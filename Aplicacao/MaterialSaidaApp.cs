using System;
using System.Linq;
using Repositorio;
using Modelo;
using System.Collections.Generic;

namespace Aplicacao
{
    public class MaterialSaidaApp : App<MaterialSaida>
    {
        public ContextoDB Banco { get; set; }

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
                    
                    if (item.Produto != null)
                    {
                        item.Produto = Banco.Produtos.Find(item.Produto.Id);
                        AtualizarEstoque(item, EstoqueAcao.INSERT);
                    }
                    Banco.MateriaisSaidaProdutos.Add(item);
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
            throw new NotImplementedException();
        }

        public IQueryable<MaterialSaida> Get(Func<MaterialSaida, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<MaterialSaida> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SalvarTodos()
        {
            throw new NotImplementedException();
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

        private EstoqueMovimento AtualizarEstoque(NotaEntradaItens item, EstoqueAcao acao)
        {
            EstoqueMovimento movimento = 
                
                new EstoqueMovimento();

            if (item.EstoqueMovimento != null)
            {
                movimento = Banco.EstoqueMovimentos.Find(item.EstoqueMovimento.Id);
            }


            movimento.Filial = Banco.Filiais.Find(item.Filial.Id);
            movimento.Produto = Banco.Produtos.Find(item.Produto.Id);
            movimento.DataMovimento = item.NotaEntrada.DataRecebimento;
            movimento.QuantidadeNovo = item.QuantidadeEstoque;
            movimento.QuantidadeUsado = 0;
            movimento.ValorUnitario = item.ValorUnitarioEstoque;
            movimento.TipoMovimento = "E";
            movimento.ObservacaoHistorico = "Nota de Entrada";


            if (acao == EstoqueAcao.INSERT)
            {
                Banco.EstoqueMovimentos.Add(movimento);
            }
            if (acao == EstoqueAcao.UPDATE)
            {
                if (item.Produto == null)
                {
                    Banco.EstoqueMovimentos.Remove(movimento);
                    movimento = null;
                }
                else
                {
                    Banco.Entry(movimento).State = EntityState.Modified;
                }
            }
            if (acao == EstoqueAcao.DELETE)
            {
                Banco.EstoqueMovimentos.Remove(movimento);
                movimento = null;
            }

            return movimento;
        }
    }    
}   
