namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Noticia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 30, unicode: false),
                        Conteudo = c.String(nullable: false, maxLength: 200, unicode: false),
                        Imagem = c.String(maxLength: 8000, unicode: false),
                        DataPublicacao = c.DateTime(nullable: false),
                        PalavraChave = c.String(maxLength: 8000, unicode: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Noticia", "Usuario_Id", "dbo.Usuario");
            DropIndex("dbo.Noticia", new[] { "Usuario_Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Noticia");
        }
    }
}
