namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.centro_de_custo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 250, storeType: "nvarchar"),
                        Situacao = c.String(maxLength: 1, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.filial",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 255, storeType: "nvarchar"),
                        Email = c.String(maxLength: 255, storeType: "nvarchar"),
                        Endereco = c.String(maxLength: 255, storeType: "nvarchar"),
                        Bairro = c.String(maxLength: 255, storeType: "nvarchar"),
                        Cep = c.String(maxLength: 10, storeType: "nvarchar"),
                        Complemento = c.String(maxLength: 255, storeType: "nvarchar"),
                        Telefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        Cidade_Id = c.Int(),
                        Empresa_Id = c.Int(),
                        CentroCusto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.cidade", t => t.Cidade_Id)
                .ForeignKey("dbo.empresa", t => t.Empresa_Id)
                .ForeignKey("dbo.centro_de_custo", t => t.CentroCusto_Id)
                .Index(t => t.Cidade_Id)
                .Index(t => t.Empresa_Id)
                .Index(t => t.CentroCusto_Id);
            
            CreateTable(
                "dbo.cidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.empresa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 250, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.filial_centro_custo",
                c => new
                    {
                        Filial_Id = c.Int(nullable: false),
                        CentroCusto_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Filial_Id, t.CentroCusto_Id })
                .ForeignKey("dbo.centro_de_custo", t => t.CentroCusto_Id, cascadeDelete: true)
                .ForeignKey("dbo.filial", t => t.Filial_Id, cascadeDelete: true)
                .Index(t => t.Filial_Id)
                .Index(t => t.CentroCusto_Id);
            
            CreateTable(
                "dbo.cotacao_fornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Vendedor = c.String(maxLength: 255, storeType: "nvarchar"),
                        EmiteNotaFiscal = c.String(maxLength: 1, storeType: "nvarchar"),
                        Cotacao_Id = c.Int(),
                        FormaPagamento_Id = c.Int(),
                        Fornecedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.cotacao", t => t.Cotacao_Id)
                .ForeignKey("dbo.forma_pagamento", t => t.FormaPagamento_Id)
                .ForeignKey("dbo.fornecedor", t => t.Fornecedor_Id)
                .Index(t => t.Cotacao_Id)
                .Index(t => t.FormaPagamento_Id)
                .Index(t => t.Fornecedor_Id);
            
            CreateTable(
                "dbo.cotacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataCotacao = c.DateTime(nullable: false, precision: 0),
                        FuncionarioSolicitante_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.funcionario", t => t.FuncionarioSolicitante_Id)
                .Index(t => t.FuncionarioSolicitante_Id);
            
            CreateTable(
                "dbo.cotacao_produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 255, storeType: "nvarchar"),
                        Quantidade = c.Double(nullable: false),
                        Cotacao_Id = c.Int(),
                        Produto_Id = c.Int(),
                        ProdutoTipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.cotacao", t => t.Cotacao_Id)
                .ForeignKey("dbo.produto", t => t.Produto_Id)
                .ForeignKey("dbo.produto_tipo", t => t.ProdutoTipo_Id)
                .Index(t => t.Cotacao_Id)
                .Index(t => t.Produto_Id)
                .Index(t => t.ProdutoTipo_Id);
            
            CreateTable(
                "dbo.produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 255, storeType: "nvarchar"),
                        CustoMedio = c.Double(nullable: false),
                        Multiplicador = c.Int(nullable: false),
                        EstoqueFilial = c.String(maxLength: 1, storeType: "nvarchar"),
                        EstoqueUsado = c.String(maxLength: 1, storeType: "nvarchar"),
                        Situacao = c.String(maxLength: 1, storeType: "nvarchar"),
                        Observacao = c.String(unicode: false),
                        UltimoValorCompra = c.Double(nullable: false),
                        UltimaDataCompra = c.DateTime(nullable: false, precision: 0),
                        UltimaNotaCompra = c.String(maxLength: 50, storeType: "nvarchar"),
                        ProdutoGrupo_Id = c.Int(),
                        UltimoFornecedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.produto_grupo", t => t.ProdutoGrupo_Id)
                .ForeignKey("dbo.fornecedor", t => t.UltimoFornecedor_Id)
                .Index(t => t.ProdutoGrupo_Id)
                .Index(t => t.UltimoFornecedor_Id);
            
            CreateTable(
                "dbo.produto_grupo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.produto_grupo_usuario",
                c => new
                    {
                        ProdutoGrupo_Id = c.Int(nullable: false),
                        Usuario_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProdutoGrupo_Id, t.Usuario_Id })
                .ForeignKey("dbo.produto_grupo", t => t.ProdutoGrupo_Id, cascadeDelete: true)
                .ForeignKey("dbo.usuario", t => t.Usuario_Id, cascadeDelete: true)
                .Index(t => t.ProdutoGrupo_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 255, storeType: "nvarchar"),
                        Senha = c.String(maxLength: 255, storeType: "nvarchar"),
                        Situacao = c.String(maxLength: 1, storeType: "nvarchar"),
                        Funcionario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.funcionario", t => t.Funcionario_Id)
                .Index(t => t.Funcionario_Id);
            
            CreateTable(
                "dbo.funcionario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CPF = c.String(maxLength: 255, storeType: "nvarchar"),
                        Nome = c.String(maxLength: 255, storeType: "nvarchar"),
                        Email = c.String(maxLength: 255, storeType: "nvarchar"),
                        Situacao = c.String(maxLength: 1, storeType: "nvarchar"),
                        Filial_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.filial", t => t.Filial_Id)
                .Index(t => t.Filial_Id);
            
            CreateTable(
                "dbo.fornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RazaoSocial = c.String(maxLength: 255, storeType: "nvarchar"),
                        NomeFantasia = c.String(maxLength: 255, storeType: "nvarchar"),
                        CnpjCpf = c.String(maxLength: 255, storeType: "nvarchar"),
                        Ie = c.String(maxLength: 20, storeType: "nvarchar"),
                        Endereco = c.String(maxLength: 255, storeType: "nvarchar"),
                        Bairro = c.String(maxLength: 255, storeType: "nvarchar"),
                        Cep = c.String(maxLength: 10, storeType: "nvarchar"),
                        Contato = c.String(maxLength: 255, storeType: "nvarchar"),
                        Telefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        Email = c.String(maxLength: 255, storeType: "nvarchar"),
                        Observacao = c.String(unicode: false),
                        Cidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.cidade", t => t.Cidade_Id)
                .Index(t => t.Cidade_Id);
            
            CreateTable(
                "dbo.produto_tipo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.cotacao_valores",
                c => new
                    {
                        Cotacao_Id = c.Int(nullable: false),
                        CotacaoFornecedor_Id = c.Int(nullable: false),
                        CotacaoProduto_Id = c.Int(nullable: false),
                        ValorUnitario = c.Double(nullable: false),
                        Situacao = c.String(maxLength: 1, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.Cotacao_Id, t.CotacaoFornecedor_Id, t.CotacaoProduto_Id })
                .ForeignKey("dbo.cotacao", t => t.Cotacao_Id, cascadeDelete: true)
                .ForeignKey("dbo.cotacao_fornecedor", t => t.CotacaoFornecedor_Id, cascadeDelete: true)
                .ForeignKey("dbo.cotacao_produto", t => t.CotacaoProduto_Id, cascadeDelete: true)
                .Index(t => t.Cotacao_Id)
                .Index(t => t.CotacaoFornecedor_Id)
                .Index(t => t.CotacaoProduto_Id);
            
            CreateTable(
                "dbo.forma_pagamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 250, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.despesa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Documento = c.String(maxLength: 255, storeType: "nvarchar"),
                        DataInicio = c.DateTime(nullable: false, precision: 0),
                        DataFim = c.DateTime(nullable: false, precision: 0),
                        DataEmissao = c.DateTime(nullable: false, precision: 0),
                        DataVencimento = c.DateTime(nullable: false, precision: 0),
                        DataReferencia = c.String(maxLength: 10, storeType: "nvarchar"),
                        ValorTitulo = c.Double(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        Fornecedor_Id = c.Int(),
                        TelefoneCobranca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.fornecedor", t => t.Fornecedor_Id)
                .ForeignKey("dbo.telefone_cobranca", t => t.TelefoneCobranca_Id)
                .Index(t => t.Fornecedor_Id)
                .Index(t => t.TelefoneCobranca_Id);
            
            CreateTable(
                "dbo.despesa_detalhe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ValorUnitario = c.Double(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        Rateio = c.String(maxLength: 1, storeType: "nvarchar"),
                        Observacao = c.String(unicode: false),
                        Despesa_Id = c.Int(),
                        DespesaTipo_Id = c.Int(),
                        Filial_Id = c.Int(),
                        Funcionario_Id = c.Int(),
                        TelefoneLinha_Linha = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.despesa", t => t.Despesa_Id)
                .ForeignKey("dbo.despesa_tipo", t => t.DespesaTipo_Id)
                .ForeignKey("dbo.filial", t => t.Filial_Id)
                .ForeignKey("dbo.funcionario", t => t.Funcionario_Id)
                .ForeignKey("dbo.telefone_linha", t => t.TelefoneLinha_Linha)
                .Index(t => t.Despesa_Id)
                .Index(t => t.DespesaTipo_Id)
                .Index(t => t.Filial_Id)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.TelefoneLinha_Linha);
            
            CreateTable(
                "dbo.despesa_tipo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descircao = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.telefone_linha",
                c => new
                    {
                        Linha = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Situacao = c.String(maxLength: 1, storeType: "nvarchar"),
                        Filial_Id = c.Int(),
                        Funcionario_Id = c.Int(),
                        TelefoneCobranca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Linha)
                .ForeignKey("dbo.filial", t => t.Filial_Id)
                .ForeignKey("dbo.funcionario", t => t.Funcionario_Id)
                .ForeignKey("dbo.telefone_cobranca", t => t.TelefoneCobranca_Id)
                .Index(t => t.Filial_Id)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.TelefoneCobranca_Id);
            
            CreateTable(
                "dbo.telefone_cobranca",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LinhaCobranca = c.String(maxLength: 255, storeType: "nvarchar"),
                        Cnpj = c.String(maxLength: 18, storeType: "nvarchar"),
                        DiaVencimento = c.Int(nullable: false),
                        Situacao = c.String(maxLength: 1, storeType: "nvarchar"),
                        FilialFatura_Id = c.Int(),
                        Fornecedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.filial", t => t.FilialFatura_Id)
                .ForeignKey("dbo.fornecedor", t => t.Fornecedor_Id)
                .Index(t => t.FilialFatura_Id)
                .Index(t => t.Fornecedor_Id);
            
            CreateTable(
                "dbo.estoque_movimento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataMovimento = c.DateTime(nullable: false, precision: 0),
                        QuantidadeNovo = c.Int(nullable: false),
                        QuantidadeUsado = c.Int(nullable: false),
                        ValorUnitario = c.Double(nullable: false),
                        TipoMovimento = c.String(maxLength: 1, storeType: "nvarchar"),
                        ObservacaoHistorico = c.String(unicode: false),
                        Documento = c.String(maxLength: 255, storeType: "nvarchar"),
                        Filial_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.filial", t => t.Filial_Id)
                .ForeignKey("dbo.produto", t => t.Produto_Id)
                .Index(t => t.Filial_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.estoque",
                c => new
                    {
                        Filial_Id = c.Int(nullable: false),
                        Produto_Id = c.Int(nullable: false),
                        QuantidadeNovo = c.Int(nullable: false),
                        QuantidadeUsado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Filial_Id, t.Produto_Id })
                .ForeignKey("dbo.filial", t => t.Filial_Id, cascadeDelete: true)
                .ForeignKey("dbo.produto", t => t.Produto_Id, cascadeDelete: true)
                .Index(t => t.Filial_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.filial_atua",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nome = c.String(unicode: false),
                        Filial_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.filial", t => t.Filial_Id)
                .Index(t => t.Filial_Id);
            
            CreateTable(
                "dbo.financeiro_pendencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataDocumento = c.DateTime(nullable: false, precision: 0),
                        Valor = c.Double(nullable: false),
                        Despesa_Id = c.Int(),
                        NotaEntrada_Id = c.Int(),
                        Titulo_Fornecedor_Id = c.Int(),
                        Titulo_Documento = c.String(maxLength: 150, storeType: "nvarchar"),
                        Titulo_Parcela = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.despesa", t => t.Despesa_Id)
                .ForeignKey("dbo.nota_entrada", t => t.NotaEntrada_Id)
                .ForeignKey("dbo.financeiro_titulo", t => new { t.Titulo_Fornecedor_Id, t.Titulo_Documento, t.Titulo_Parcela })
                .Index(t => t.Despesa_Id)
                .Index(t => t.NotaEntrada_Id)
                .Index(t => new { t.Titulo_Fornecedor_Id, t.Titulo_Documento, t.Titulo_Parcela });
            
            CreateTable(
                "dbo.nota_entrada",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Documento = c.String(maxLength: 100, storeType: "nvarchar"),
                        Serie = c.String(maxLength: 10, storeType: "nvarchar"),
                        DataEmissao = c.DateTime(nullable: false, precision: 0),
                        DataRecebimento = c.DateTime(nullable: false, precision: 0),
                        ValorDocumento = c.Double(nullable: false),
                        AcresDesc = c.Double(nullable: false),
                        ValorDocumentoTotal = c.Double(nullable: false),
                        Faturado = c.String(maxLength: 1, storeType: "nvarchar"),
                        Fornecedor_Id = c.Int(),
                        OrdemCompra_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.fornecedor", t => t.Fornecedor_Id)
                .ForeignKey("dbo.ordem_compra", t => t.OrdemCompra_Id)
                .Index(t => t.Fornecedor_Id)
                .Index(t => t.OrdemCompra_Id);
            
            CreateTable(
                "dbo.nota_entrada_itens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 255, storeType: "nvarchar"),
                        QuantidadeNota = c.Int(nullable: false),
                        Multiplicador = c.Int(nullable: false),
                        ValorUnitario = c.Double(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        QuantidadeEstoque = c.Int(nullable: false),
                        ValorUnitarioEstoque = c.Double(nullable: false),
                        EstoqueMovimento_Id = c.Int(),
                        FilialEstoque_Id = c.Int(),
                        NotaEntrada_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.estoque_movimento", t => t.EstoqueMovimento_Id)
                .ForeignKey("dbo.filial", t => t.FilialEstoque_Id)
                .ForeignKey("dbo.nota_entrada", t => t.NotaEntrada_Id)
                .ForeignKey("dbo.produto", t => t.Produto_Id)
                .Index(t => t.EstoqueMovimento_Id)
                .Index(t => t.FilialEstoque_Id)
                .Index(t => t.NotaEntrada_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.ordem_compra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataOrdem = c.DateTime(nullable: false, precision: 0),
                        Cotacao = c.Int(nullable: false),
                        FormaPagamento_Id = c.Int(),
                        Fornecedor_Id = c.Int(),
                        FuncionarioAutorizacao_Id = c.Int(),
                        FuncionarioSolicitante_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.forma_pagamento", t => t.FormaPagamento_Id)
                .ForeignKey("dbo.fornecedor", t => t.Fornecedor_Id)
                .ForeignKey("dbo.funcionario", t => t.FuncionarioAutorizacao_Id)
                .ForeignKey("dbo.funcionario", t => t.FuncionarioSolicitante_Id)
                .Index(t => t.FormaPagamento_Id)
                .Index(t => t.Fornecedor_Id)
                .Index(t => t.FuncionarioAutorizacao_Id)
                .Index(t => t.FuncionarioSolicitante_Id);
            
            CreateTable(
                "dbo.ordem_compra_detalhe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 255, storeType: "nvarchar"),
                        Quantidade = c.Double(nullable: false),
                        ValorUnitario = c.Double(nullable: false),
                        AcresDesc = c.Double(nullable: false),
                        ValorTotal = c.Double(nullable: false),
                        OrdemCompra_Id = c.Int(),
                        Produto_Id = c.Int(),
                        ProdutoTipo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ordem_compra", t => t.OrdemCompra_Id)
                .ForeignKey("dbo.produto", t => t.Produto_Id)
                .ForeignKey("dbo.produto_tipo", t => t.ProdutoTipo_Id)
                .Index(t => t.OrdemCompra_Id)
                .Index(t => t.Produto_Id)
                .Index(t => t.ProdutoTipo_Id);
            
            CreateTable(
                "dbo.financeiro_titulo",
                c => new
                    {
                        Fornecedor_Id = c.Int(nullable: false),
                        Documento = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        Parcela = c.Int(nullable: false),
                        DataEmissao = c.DateTime(nullable: false, precision: 0),
                        DataVencimento = c.DateTime(nullable: false, precision: 0),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.Fornecedor_Id, t.Documento, t.Parcela })
                .ForeignKey("dbo.fornecedor", t => t.Fornecedor_Id, cascadeDelete: true)
                .Index(t => t.Fornecedor_Id);
            
            CreateTable(
                "dbo.MaloteDetalhes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuantidadeVolume = c.Int(nullable: false),
                        Descricao = c.String(maxLength: 255, storeType: "nvarchar"),
                        MaterialSaida_Id = c.Int(),
                        Malote_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.material_saida", t => t.MaterialSaida_Id)
                .ForeignKey("dbo.malote", t => t.Malote_Id)
                .Index(t => t.MaterialSaida_Id)
                .Index(t => t.Malote_Id);
            
            CreateTable(
                "dbo.material_saida",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataSaidaEstoque = c.DateTime(nullable: false, precision: 0),
                        DataEntradaEstoque = c.DateTime(nullable: false, precision: 0),
                        Observacao = c.String(unicode: false),
                        FilialEntrada_Id = c.Int(),
                        FilialSaida_Id = c.Int(),
                        ResponsavelRecebimento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.filial", t => t.FilialEntrada_Id)
                .ForeignKey("dbo.filial", t => t.FilialSaida_Id)
                .ForeignKey("dbo.funcionario", t => t.ResponsavelRecebimento_Id)
                .Index(t => t.FilialEntrada_Id)
                .Index(t => t.FilialSaida_Id)
                .Index(t => t.ResponsavelRecebimento_Id);
            
            CreateTable(
                "dbo.material_saida_produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        CentroCusto_Id = c.Int(),
                        MaterialSaida_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.centro_de_custo", t => t.CentroCusto_Id)
                .ForeignKey("dbo.material_saida", t => t.MaterialSaida_Id)
                .ForeignKey("dbo.produto", t => t.Produto_Id)
                .Index(t => t.CentroCusto_Id)
                .Index(t => t.MaterialSaida_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.malote",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataEnvio = c.DateTime(nullable: false, precision: 0),
                        DataRecebimento = c.DateTime(nullable: false, precision: 0),
                        Observacao = c.String(unicode: false),
                        FilialDestino_Id = c.Int(),
                        FilialOrigem_Id = c.Int(),
                        Transportadora_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.filial", t => t.FilialDestino_Id)
                .ForeignKey("dbo.filial", t => t.FilialOrigem_Id)
                .ForeignKey("dbo.fornecedor", t => t.Transportadora_Id)
                .Index(t => t.FilialDestino_Id)
                .Index(t => t.FilialOrigem_Id)
                .Index(t => t.Transportadora_Id);
            
            CreateTable(
                "dbo.material_solicitacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataSolicitacao = c.DateTime(nullable: false, precision: 0),
                        Descricao = c.String(maxLength: 255, storeType: "nvarchar"),
                        Quantidade = c.String(unicode: false),
                        Situacao = c.String(maxLength: 1, storeType: "nvarchar"),
                        Filial_Id = c.Int(),
                        Funcionario_Id = c.Int(),
                        MaterialSaida_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.filial", t => t.Filial_Id)
                .ForeignKey("dbo.funcionario", t => t.Funcionario_Id)
                .ForeignKey("dbo.material_saida", t => t.MaterialSaida_Id)
                .ForeignKey("dbo.produto", t => t.Produto_Id)
                .Index(t => t.Filial_Id)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.MaterialSaida_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.patrimo_grupo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.patrimonio_historico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Historico = c.String(unicode: false),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.patrimonio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatrimonioNumero = c.String(maxLength: 50, storeType: "nvarchar"),
                        NumeroSerie = c.String(maxLength: 255, storeType: "nvarchar"),
                        DataAquisicao = c.DateTime(nullable: false, precision: 0),
                        ValorAquisicao = c.Double(nullable: false),
                        Situacao = c.String(maxLength: 1, storeType: "nvarchar"),
                        Observacao = c.String(unicode: false),
                        CentroCusto_Id = c.Int(),
                        Filial_Id = c.Int(),
                        Funcionario_Id = c.Int(),
                        PatrimonioGrupo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.centro_de_custo", t => t.CentroCusto_Id)
                .ForeignKey("dbo.filial", t => t.Filial_Id)
                .ForeignKey("dbo.funcionario", t => t.Funcionario_Id)
                .ForeignKey("dbo.patrimo_grupo", t => t.PatrimonioGrupo_Id)
                .Index(t => t.CentroCusto_Id)
                .Index(t => t.Filial_Id)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.PatrimonioGrupo_Id);
            
            CreateTable(
                "dbo.toner_manutencao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataEnvio = c.DateTime(nullable: false, precision: 0),
                        DataRetorno = c.DateTime(nullable: false, precision: 0),
                        QuantidadeEnviada = c.Int(nullable: false),
                        ValorUnitarioEnvio = c.Double(nullable: false),
                        QuantidadeRetorno = c.Int(nullable: false),
                        ValorUnitarioRetorno = c.Double(nullable: false),
                        Observacao = c.String(unicode: false),
                        Estoque_Filial_Id = c.Int(),
                        Estoque_Produto_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.estoque", t => new { t.Estoque_Filial_Id, t.Estoque_Produto_Id })
                .ForeignKey("dbo.produto", t => t.Produto_Id)
                .Index(t => new { t.Estoque_Filial_Id, t.Estoque_Produto_Id })
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.usuario_filial",
                c => new
                    {
                        Filial_Id = c.Int(nullable: false),
                        Usuario_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Filial_Id, t.Usuario_Id })
                .ForeignKey("dbo.filial", t => t.Filial_Id, cascadeDelete: true)
                .ForeignKey("dbo.usuario", t => t.Usuario_Id, cascadeDelete: true)
                .Index(t => t.Filial_Id)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.usuario_filial", "Usuario_Id", "dbo.usuario");
            DropForeignKey("dbo.usuario_filial", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.toner_manutencao", "Produto_Id", "dbo.produto");
            DropForeignKey("dbo.toner_manutencao", new[] { "Estoque_Filial_Id", "Estoque_Produto_Id" }, "dbo.estoque");
            DropForeignKey("dbo.patrimonio", "PatrimonioGrupo_Id", "dbo.patrimo_grupo");
            DropForeignKey("dbo.patrimonio", "Funcionario_Id", "dbo.funcionario");
            DropForeignKey("dbo.patrimonio", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.patrimonio", "CentroCusto_Id", "dbo.centro_de_custo");
            DropForeignKey("dbo.material_solicitacao", "Produto_Id", "dbo.produto");
            DropForeignKey("dbo.material_solicitacao", "MaterialSaida_Id", "dbo.material_saida");
            DropForeignKey("dbo.material_solicitacao", "Funcionario_Id", "dbo.funcionario");
            DropForeignKey("dbo.material_solicitacao", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.malote", "Transportadora_Id", "dbo.fornecedor");
            DropForeignKey("dbo.MaloteDetalhes", "Malote_Id", "dbo.malote");
            DropForeignKey("dbo.malote", "FilialOrigem_Id", "dbo.filial");
            DropForeignKey("dbo.malote", "FilialDestino_Id", "dbo.filial");
            DropForeignKey("dbo.MaloteDetalhes", "MaterialSaida_Id", "dbo.material_saida");
            DropForeignKey("dbo.material_saida", "ResponsavelRecebimento_Id", "dbo.funcionario");
            DropForeignKey("dbo.material_saida_produtos", "Produto_Id", "dbo.produto");
            DropForeignKey("dbo.material_saida_produtos", "MaterialSaida_Id", "dbo.material_saida");
            DropForeignKey("dbo.material_saida_produtos", "CentroCusto_Id", "dbo.centro_de_custo");
            DropForeignKey("dbo.material_saida", "FilialSaida_Id", "dbo.filial");
            DropForeignKey("dbo.material_saida", "FilialEntrada_Id", "dbo.filial");
            DropForeignKey("dbo.financeiro_pendencia", new[] { "Titulo_Fornecedor_Id", "Titulo_Documento", "Titulo_Parcela" }, "dbo.financeiro_titulo");
            DropForeignKey("dbo.financeiro_titulo", "Fornecedor_Id", "dbo.fornecedor");
            DropForeignKey("dbo.financeiro_pendencia", "NotaEntrada_Id", "dbo.nota_entrada");
            DropForeignKey("dbo.nota_entrada", "OrdemCompra_Id", "dbo.ordem_compra");
            DropForeignKey("dbo.ordem_compra_detalhe", "ProdutoTipo_Id", "dbo.produto_tipo");
            DropForeignKey("dbo.ordem_compra_detalhe", "Produto_Id", "dbo.produto");
            DropForeignKey("dbo.ordem_compra_detalhe", "OrdemCompra_Id", "dbo.ordem_compra");
            DropForeignKey("dbo.ordem_compra", "FuncionarioSolicitante_Id", "dbo.funcionario");
            DropForeignKey("dbo.ordem_compra", "FuncionarioAutorizacao_Id", "dbo.funcionario");
            DropForeignKey("dbo.ordem_compra", "Fornecedor_Id", "dbo.fornecedor");
            DropForeignKey("dbo.ordem_compra", "FormaPagamento_Id", "dbo.forma_pagamento");
            DropForeignKey("dbo.nota_entrada_itens", "Produto_Id", "dbo.produto");
            DropForeignKey("dbo.nota_entrada_itens", "NotaEntrada_Id", "dbo.nota_entrada");
            DropForeignKey("dbo.nota_entrada_itens", "FilialEstoque_Id", "dbo.filial");
            DropForeignKey("dbo.nota_entrada_itens", "EstoqueMovimento_Id", "dbo.estoque_movimento");
            DropForeignKey("dbo.nota_entrada", "Fornecedor_Id", "dbo.fornecedor");
            DropForeignKey("dbo.financeiro_pendencia", "Despesa_Id", "dbo.despesa");
            DropForeignKey("dbo.filial_atua", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.estoque", "Produto_Id", "dbo.produto");
            DropForeignKey("dbo.estoque", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.estoque_movimento", "Produto_Id", "dbo.produto");
            DropForeignKey("dbo.estoque_movimento", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.despesa", "TelefoneCobranca_Id", "dbo.telefone_cobranca");
            DropForeignKey("dbo.despesa", "Fornecedor_Id", "dbo.fornecedor");
            DropForeignKey("dbo.despesa_detalhe", "TelefoneLinha_Linha", "dbo.telefone_linha");
            DropForeignKey("dbo.telefone_linha", "TelefoneCobranca_Id", "dbo.telefone_cobranca");
            DropForeignKey("dbo.telefone_cobranca", "Fornecedor_Id", "dbo.fornecedor");
            DropForeignKey("dbo.telefone_cobranca", "FilialFatura_Id", "dbo.filial");
            DropForeignKey("dbo.telefone_linha", "Funcionario_Id", "dbo.funcionario");
            DropForeignKey("dbo.telefone_linha", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.despesa_detalhe", "Funcionario_Id", "dbo.funcionario");
            DropForeignKey("dbo.despesa_detalhe", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.despesa_detalhe", "DespesaTipo_Id", "dbo.despesa_tipo");
            DropForeignKey("dbo.despesa_detalhe", "Despesa_Id", "dbo.despesa");
            DropForeignKey("dbo.cotacao_fornecedor", "Fornecedor_Id", "dbo.fornecedor");
            DropForeignKey("dbo.cotacao_fornecedor", "FormaPagamento_Id", "dbo.forma_pagamento");
            DropForeignKey("dbo.cotacao", "FuncionarioSolicitante_Id", "dbo.funcionario");
            DropForeignKey("dbo.cotacao_valores", "CotacaoProduto_Id", "dbo.cotacao_produto");
            DropForeignKey("dbo.cotacao_valores", "CotacaoFornecedor_Id", "dbo.cotacao_fornecedor");
            DropForeignKey("dbo.cotacao_valores", "Cotacao_Id", "dbo.cotacao");
            DropForeignKey("dbo.cotacao_produto", "ProdutoTipo_Id", "dbo.produto_tipo");
            DropForeignKey("dbo.cotacao_produto", "Produto_Id", "dbo.produto");
            DropForeignKey("dbo.produto", "UltimoFornecedor_Id", "dbo.fornecedor");
            DropForeignKey("dbo.fornecedor", "Cidade_Id", "dbo.cidade");
            DropForeignKey("dbo.produto", "ProdutoGrupo_Id", "dbo.produto_grupo");
            DropForeignKey("dbo.produto_grupo_usuario", "Usuario_Id", "dbo.usuario");
            DropForeignKey("dbo.usuario", "Funcionario_Id", "dbo.funcionario");
            DropForeignKey("dbo.funcionario", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.produto_grupo_usuario", "ProdutoGrupo_Id", "dbo.produto_grupo");
            DropForeignKey("dbo.cotacao_produto", "Cotacao_Id", "dbo.cotacao");
            DropForeignKey("dbo.cotacao_fornecedor", "Cotacao_Id", "dbo.cotacao");
            DropForeignKey("dbo.filial", "CentroCusto_Id", "dbo.centro_de_custo");
            DropForeignKey("dbo.filial_centro_custo", "Filial_Id", "dbo.filial");
            DropForeignKey("dbo.filial_centro_custo", "CentroCusto_Id", "dbo.centro_de_custo");
            DropForeignKey("dbo.filial", "Empresa_Id", "dbo.empresa");
            DropForeignKey("dbo.filial", "Cidade_Id", "dbo.cidade");
            DropIndex("dbo.usuario_filial", new[] { "Usuario_Id" });
            DropIndex("dbo.usuario_filial", new[] { "Filial_Id" });
            DropIndex("dbo.toner_manutencao", new[] { "Produto_Id" });
            DropIndex("dbo.toner_manutencao", new[] { "Estoque_Filial_Id", "Estoque_Produto_Id" });
            DropIndex("dbo.patrimonio", new[] { "PatrimonioGrupo_Id" });
            DropIndex("dbo.patrimonio", new[] { "Funcionario_Id" });
            DropIndex("dbo.patrimonio", new[] { "Filial_Id" });
            DropIndex("dbo.patrimonio", new[] { "CentroCusto_Id" });
            DropIndex("dbo.material_solicitacao", new[] { "Produto_Id" });
            DropIndex("dbo.material_solicitacao", new[] { "MaterialSaida_Id" });
            DropIndex("dbo.material_solicitacao", new[] { "Funcionario_Id" });
            DropIndex("dbo.material_solicitacao", new[] { "Filial_Id" });
            DropIndex("dbo.malote", new[] { "Transportadora_Id" });
            DropIndex("dbo.malote", new[] { "FilialOrigem_Id" });
            DropIndex("dbo.malote", new[] { "FilialDestino_Id" });
            DropIndex("dbo.material_saida_produtos", new[] { "Produto_Id" });
            DropIndex("dbo.material_saida_produtos", new[] { "MaterialSaida_Id" });
            DropIndex("dbo.material_saida_produtos", new[] { "CentroCusto_Id" });
            DropIndex("dbo.material_saida", new[] { "ResponsavelRecebimento_Id" });
            DropIndex("dbo.material_saida", new[] { "FilialSaida_Id" });
            DropIndex("dbo.material_saida", new[] { "FilialEntrada_Id" });
            DropIndex("dbo.MaloteDetalhes", new[] { "Malote_Id" });
            DropIndex("dbo.MaloteDetalhes", new[] { "MaterialSaida_Id" });
            DropIndex("dbo.financeiro_titulo", new[] { "Fornecedor_Id" });
            DropIndex("dbo.ordem_compra_detalhe", new[] { "ProdutoTipo_Id" });
            DropIndex("dbo.ordem_compra_detalhe", new[] { "Produto_Id" });
            DropIndex("dbo.ordem_compra_detalhe", new[] { "OrdemCompra_Id" });
            DropIndex("dbo.ordem_compra", new[] { "FuncionarioSolicitante_Id" });
            DropIndex("dbo.ordem_compra", new[] { "FuncionarioAutorizacao_Id" });
            DropIndex("dbo.ordem_compra", new[] { "Fornecedor_Id" });
            DropIndex("dbo.ordem_compra", new[] { "FormaPagamento_Id" });
            DropIndex("dbo.nota_entrada_itens", new[] { "Produto_Id" });
            DropIndex("dbo.nota_entrada_itens", new[] { "NotaEntrada_Id" });
            DropIndex("dbo.nota_entrada_itens", new[] { "FilialEstoque_Id" });
            DropIndex("dbo.nota_entrada_itens", new[] { "EstoqueMovimento_Id" });
            DropIndex("dbo.nota_entrada", new[] { "OrdemCompra_Id" });
            DropIndex("dbo.nota_entrada", new[] { "Fornecedor_Id" });
            DropIndex("dbo.financeiro_pendencia", new[] { "Titulo_Fornecedor_Id", "Titulo_Documento", "Titulo_Parcela" });
            DropIndex("dbo.financeiro_pendencia", new[] { "NotaEntrada_Id" });
            DropIndex("dbo.financeiro_pendencia", new[] { "Despesa_Id" });
            DropIndex("dbo.filial_atua", new[] { "Filial_Id" });
            DropIndex("dbo.estoque", new[] { "Produto_Id" });
            DropIndex("dbo.estoque", new[] { "Filial_Id" });
            DropIndex("dbo.estoque_movimento", new[] { "Produto_Id" });
            DropIndex("dbo.estoque_movimento", new[] { "Filial_Id" });
            DropIndex("dbo.telefone_cobranca", new[] { "Fornecedor_Id" });
            DropIndex("dbo.telefone_cobranca", new[] { "FilialFatura_Id" });
            DropIndex("dbo.telefone_linha", new[] { "TelefoneCobranca_Id" });
            DropIndex("dbo.telefone_linha", new[] { "Funcionario_Id" });
            DropIndex("dbo.telefone_linha", new[] { "Filial_Id" });
            DropIndex("dbo.despesa_detalhe", new[] { "TelefoneLinha_Linha" });
            DropIndex("dbo.despesa_detalhe", new[] { "Funcionario_Id" });
            DropIndex("dbo.despesa_detalhe", new[] { "Filial_Id" });
            DropIndex("dbo.despesa_detalhe", new[] { "DespesaTipo_Id" });
            DropIndex("dbo.despesa_detalhe", new[] { "Despesa_Id" });
            DropIndex("dbo.despesa", new[] { "TelefoneCobranca_Id" });
            DropIndex("dbo.despesa", new[] { "Fornecedor_Id" });
            DropIndex("dbo.cotacao_valores", new[] { "CotacaoProduto_Id" });
            DropIndex("dbo.cotacao_valores", new[] { "CotacaoFornecedor_Id" });
            DropIndex("dbo.cotacao_valores", new[] { "Cotacao_Id" });
            DropIndex("dbo.fornecedor", new[] { "Cidade_Id" });
            DropIndex("dbo.funcionario", new[] { "Filial_Id" });
            DropIndex("dbo.usuario", new[] { "Funcionario_Id" });
            DropIndex("dbo.produto_grupo_usuario", new[] { "Usuario_Id" });
            DropIndex("dbo.produto_grupo_usuario", new[] { "ProdutoGrupo_Id" });
            DropIndex("dbo.produto", new[] { "UltimoFornecedor_Id" });
            DropIndex("dbo.produto", new[] { "ProdutoGrupo_Id" });
            DropIndex("dbo.cotacao_produto", new[] { "ProdutoTipo_Id" });
            DropIndex("dbo.cotacao_produto", new[] { "Produto_Id" });
            DropIndex("dbo.cotacao_produto", new[] { "Cotacao_Id" });
            DropIndex("dbo.cotacao", new[] { "FuncionarioSolicitante_Id" });
            DropIndex("dbo.cotacao_fornecedor", new[] { "Fornecedor_Id" });
            DropIndex("dbo.cotacao_fornecedor", new[] { "FormaPagamento_Id" });
            DropIndex("dbo.cotacao_fornecedor", new[] { "Cotacao_Id" });
            DropIndex("dbo.filial_centro_custo", new[] { "CentroCusto_Id" });
            DropIndex("dbo.filial_centro_custo", new[] { "Filial_Id" });
            DropIndex("dbo.filial", new[] { "CentroCusto_Id" });
            DropIndex("dbo.filial", new[] { "Empresa_Id" });
            DropIndex("dbo.filial", new[] { "Cidade_Id" });
            DropTable("dbo.usuario_filial");
            DropTable("dbo.toner_manutencao");
            DropTable("dbo.patrimonio");
            DropTable("dbo.patrimonio_historico");
            DropTable("dbo.patrimo_grupo");
            DropTable("dbo.material_solicitacao");
            DropTable("dbo.malote");
            DropTable("dbo.material_saida_produtos");
            DropTable("dbo.material_saida");
            DropTable("dbo.MaloteDetalhes");
            DropTable("dbo.financeiro_titulo");
            DropTable("dbo.ordem_compra_detalhe");
            DropTable("dbo.ordem_compra");
            DropTable("dbo.nota_entrada_itens");
            DropTable("dbo.nota_entrada");
            DropTable("dbo.financeiro_pendencia");
            DropTable("dbo.filial_atua");
            DropTable("dbo.estoque");
            DropTable("dbo.estoque_movimento");
            DropTable("dbo.telefone_cobranca");
            DropTable("dbo.telefone_linha");
            DropTable("dbo.despesa_tipo");
            DropTable("dbo.despesa_detalhe");
            DropTable("dbo.despesa");
            DropTable("dbo.forma_pagamento");
            DropTable("dbo.cotacao_valores");
            DropTable("dbo.produto_tipo");
            DropTable("dbo.fornecedor");
            DropTable("dbo.funcionario");
            DropTable("dbo.usuario");
            DropTable("dbo.produto_grupo_usuario");
            DropTable("dbo.produto_grupo");
            DropTable("dbo.produto");
            DropTable("dbo.cotacao_produto");
            DropTable("dbo.cotacao");
            DropTable("dbo.cotacao_fornecedor");
            DropTable("dbo.filial_centro_custo");
            DropTable("dbo.empresa");
            DropTable("dbo.cidade");
            DropTable("dbo.filial");
            DropTable("dbo.centro_de_custo");
        }
    }
}
