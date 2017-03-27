using System;
using System.Linq;
using Repositorio;
using Modelo;
using System.Collections.Generic;
using System.Data.Entity;


namespace Aplicacao
{
    public class MaterialSaidaApp : App<MaterialSaida>
    {
        public ContextoDB Banco { get; set; }

        public MaterialSaidaApp()
        {
            Banco = new ContextoDB();
        }

        public void Adicionar(MaterialSaida obj)
        {
            if (ValidarCampos(obj))
            {
                obj.FilialSaida = Banco.Filiais.Find(obj.FilialSaida.Id);
                obj.FilialEntrada = Banco.Filiais.Find(obj.FilialEntrada.Id);
                if (obj.ResponsavelRecebimento != null)
                {
                    obj.ResponsavelRecebimento = Banco.Funcionarios.Find(obj.ResponsavelRecebimento.Id);
                }
                if(obj.Solicitacao != null)
                {
                    obj.Solicitacao = Banco.MateriaisSolicitacao.Find(obj.Solicitacao.Id);
                }
                

                IEnumerable<MaterialSaidaProdutos> lista = obj.MaterialSaidaProdutos;
                obj.MaterialSaidaProdutos = null;
                Banco.MateriaisSaida.Add(obj);
                foreach (var item in lista)
                {
                    item.MaterialSaida = obj;
                    item.CentroCusto = Banco.CentroCustos.Find(item.CentroCusto.Id);
                    item.Produto = Banco.Produtos.Find(item.Produto.Id);
                    Banco.MateriaisSaidaProdutos.Add(item);
                    AtualizarEstoque(item, EstoqueAcao.INSERT);
                }
                SalvarTodos();
            }
        }

        public void Atualizar(MaterialSaida obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Func<MaterialSaida, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public MaterialSaida Find(params object[] key)
        {
            return Banco.Set<MaterialSaida>().Find(key);
        }

        public IQueryable<MaterialSaida> Get(Func<MaterialSaida, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public IQueryable<MaterialSaida> GetAll()
        {
            return Banco.Set<MaterialSaida>()
                .Include(x => x.FilialSaida)
                .Include(x => x.FilialEntrada)
                .Include(x => x.ResponsavelRecebimento)
                .Include(x => x.MaterialSaidaProdutos)
                .Include(x => x.Solicitacao);
        }

        public void SalvarTodos()
        {
            Banco.SaveChanges();
        }


        public bool ValidarCampos(MaterialSaida obj)
        {
            if (obj.FilialSaida == null || obj.FilialSaida.Id == 0)
            {
                throw new Exception("Filial do estoque não informado!");
            }
            if (obj.FilialEntrada == null || obj.FilialEntrada.Id == 0)
            {
                throw new Exception("Filial de destino do item não informada");
            }
            foreach (var item in obj.MaterialSaidaProdutos)
            {
                if (item.Produto == null || item.Produto.Id == 0)
                    throw new Exception("Produto não foi informado: ");
                if (item.Quantidade <= 0)
                    throw new Exception("Quantidade inváida");
                if (item.CentroCusto == null || item.CentroCusto.Id == 0)
                    throw new Exception("Centro de custo não informado");
                if (item.CustoUnitario <= 0)
                {
                    item.CustoUnitario = Banco.Produtos.Find(item.Produto.Id).CustoMedio;
                }
            }

            return true;
        }

        private void AtualizarEstoque(MaterialSaidaProdutos item, EstoqueAcao acao)
        {
            if(acao == EstoqueAcao.UPDATE || acao == EstoqueAcao.DELETE)
            {
                List<EstoqueMovimento> lista = Banco.EstoqueMovimentos.Where(x => x.MaterialSaida.Id == item.Id).ToList();

                if (lista.Any())
                {
                    foreach (var mov in lista)
                    {
                        if (mov.TipoMovimento.Equals("S"))
                        {
                            mov.Filial = Banco.Filiais.Find(item.MaterialSaida.FilialSaida.Id);
                            mov.Produto = Banco.Produtos.Find(item.Produto.Id);
                            mov.DataMovimento = item.MaterialSaida.DataSaidaEstoque;
                            mov.QuantidadeNovo = item.Quantidade * -1;
                            mov.MaterialSaida = item;
                            mov.QuantidadeUsado = 0;
                            mov.ValorUnitario = item.CustoUnitario;
                            mov.ObservacaoHistorico = "Movimento de Saída";

                        }
                        else
                        {
                            mov.Filial = Banco.Filiais.Find(item.MaterialSaida.FilialEntrada.Id);
                            mov.Produto = Banco.Produtos.Find(item.Produto.Id);
                            mov.DataMovimento = item.MaterialSaida.DataSaidaEstoque;
                            mov.MaterialSaida = item;
                            mov.QuantidadeNovo = item.Quantidade;
                            mov.QuantidadeUsado = 0;
                            mov.ValorUnitario = item.CustoUnitario;
                            mov.ObservacaoHistorico = "Movimento de Saída";
                        }
                        AcaoMovimento(mov, acao);
                    }
                }
            }
            else
            {
                
                EstoqueMovimento saida = new EstoqueMovimento();
                if(item.MaterialSaida.FilialSaida.Id == item.MaterialSaida.Id || item.Produto.EstoqueFilial.Equals("N"))
                {
                    saida.DataMovimento = item.MaterialSaida.DataSaidaEstoque;
                    saida.MaterialSaida = item;
                    saida.TipoMovimento = "S";
                    saida.QuantidadeNovo = item.Quantidade*-1;
                    saida.QuantidadeUsado = 0;
                    saida.ValorUnitario = item.CustoUnitario;
                    saida.ObservacaoHistorico = "Movimento de Saida";
                    saida.Filial = Banco.Filiais.Find(item.MaterialSaida.FilialSaida.Id);
                    saida.Produto = Banco.Produtos.Find(item.Produto.Id);
                    AcaoMovimento(saida, acao);
                }
                else
                {
                    saida.DataMovimento = item.MaterialSaida.DataSaidaEstoque;
                    saida.MaterialSaida = item;
                    saida.TipoMovimento = "S";
                    saida.QuantidadeNovo = item.Quantidade * -1;
                    saida.QuantidadeUsado = 0;
                    saida.ValorUnitario = item.CustoUnitario;
                    saida.ObservacaoHistorico = "Movimento de Saida";
                    saida.Filial = Banco.Filiais.Find(item.MaterialSaida.FilialSaida.Id);
                    saida.Produto = Banco.Produtos.Find(item.Produto.Id);
                    AcaoMovimento(saida, acao);

                    EstoqueMovimento entrada = new EstoqueMovimento();

                    entrada.DataMovimento = item.MaterialSaida.DataSaidaEstoque;
                    saida.MaterialSaida = item;
                    entrada.TipoMovimento = "E";
                    entrada.QuantidadeNovo = item.Quantidade;
                    entrada.QuantidadeUsado = 0;
                    entrada.ValorUnitario = item.CustoUnitario;
                    entrada.ObservacaoHistorico = "Movimento de Saida";
                    entrada.Filial = Banco.Filiais.Find(item.MaterialSaida.FilialEntrada.Id);
                    entrada.Produto = Banco.Produtos.Find(item.Produto.Id);
                    AcaoMovimento(entrada, acao);
                }

            }
        }
        private void AcaoMovimento(EstoqueMovimento movimento, EstoqueAcao acao)
        {
            if (acao == EstoqueAcao.INSERT)
            {
                Banco.EstoqueMovimentos.Add(movimento);
            }
            if (acao == EstoqueAcao.UPDATE)
            {
                 Banco.Entry(movimento).State = EntityState.Modified;
             }
            if (acao == EstoqueAcao.DELETE)
            {
                Banco.EstoqueMovimentos.Remove(movimento);
            }
        }
    }    
}   
