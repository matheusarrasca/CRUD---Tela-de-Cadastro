namespace TelaCadastroCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(),
                        RazaoSocial = c.String(),
                        NomeFantasia = c.String(),
                        InscricaoEstadual = c.String(),
                        Endereco = c.String(),
                        Bairro = c.String(),
                        CEP = c.String(),
                        Cidade = c.String(),
                        UF = c.String(),
                        Pais = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                        Celular = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
