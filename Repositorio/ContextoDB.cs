using System.Data.Entity;
using Modelo;

namespace Repositorio
{
    public class ContextoDB: DbContext
    {
        public DbSet<CentroCusto> CentroCustos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }
        public DbSet<CotacaoFornecedor> CotacaoFornecedores { get; set; }
        public DbSet<CotacaoProduto> CotacaoProdutos { get; set; }
        public DbSet<CotacaoValor> CotacaoValores { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<DespesaDetalhes> DespesasDetalhe { get; set; }
        public DbSet<DespesaTipo> DespesasTipo { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<EstoqueMovimento> EstoqueMovimentos { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<FilialAtua> FiliaisAtua { get; set; }
        public DbSet<FilialCentroCusto> FilialCentroCustos { get; set; }
        public DbSet<FinanceiroPendencia> FinPendencias { get; set; }
        public DbSet<FinanceiroTitulo> Titulos { get; set; }
        public DbSet<FormaPagamento> FinanceiroFormaPagamento { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Malote> Malotes { get; set; }
        public DbSet<MaloteDetalhe> MaloteDetalhes { get; set; }
        public DbSet<MaterialSaida> MateriaisSaida { get; set; }
        public DbSet<MaterialSaidaProdutos> MateriaisSaidaProdutos { get; set; }
        public DbSet<MaterialSolicitacao> MateriaisSolicitacao { get; set; }
        public DbSet<NotaEntrada> NotasEntrada { get; set; }
        public DbSet<NotaEntradaItens> NotaEntradaItens { get; set; }
        public DbSet<OrdemCompra> OrdensCompra { get; set; }
        public DbSet<OrdemCompraDetalhes> OrdensCompraDetalhes { get; set; }
        public DbSet<Patrimonio> Patrimonios { get; set; }
        public DbSet<PatrimonioGrupo> PatrimonioGrupos { get; set; }
        public DbSet<PatrimonioHistorico> PatrimonioHistoricos { get; set; }
        public DbSet<ProdutoGrupoUsuario> ProdutosGrupoUsuario { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoGrupo> ProdutoGrupos { get; set; }
        public DbSet<ProdutoTipo> ProdutoTipos { get; set; }
        public DbSet<TelefoneCobranca> TelefoneCobrancas { get; set; }
        public DbSet<TelefoneLinha> TelefoneLinhas { get; set; }
        public DbSet<TonerManutencao> TonersManutencao { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioFilial> UsuariosFilial { get; set; }
    }
}
