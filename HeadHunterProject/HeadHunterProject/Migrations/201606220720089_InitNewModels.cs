namespace HeadHunterProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitNewModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 40),
                        Prenom = c.String(nullable: false, maxLength: 50),
                        DateNaissance = c.DateTime(nullable: false),
                        Telephone = c.String(nullable: false, maxLength: 12),
                        AdresseMail = c.String(nullable: false, maxLength: 30),
                        SituationPro = c.Boolean(nullable: false),
                        Mobilite = c.Boolean(nullable: false),
                        SituationFamilialeId = c.Byte(nullable: false),
                        PoleEmbaucheId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PoleEmbauches", t => t.PoleEmbaucheId, cascadeDelete: true)
                .ForeignKey("dbo.SituationFamiliales", t => t.SituationFamilialeId, cascadeDelete: true)
                .Index(t => t.SituationFamilialeId)
                .Index(t => t.PoleEmbaucheId);
            
            CreateTable(
                "dbo.PoleEmbauches",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Libelle = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SituationFamiliales",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Libelle = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidats", "SituationFamilialeId", "dbo.SituationFamiliales");
            DropForeignKey("dbo.Candidats", "PoleEmbaucheId", "dbo.PoleEmbauches");
            DropIndex("dbo.Candidats", new[] { "PoleEmbaucheId" });
            DropIndex("dbo.Candidats", new[] { "SituationFamilialeId" });
            DropTable("dbo.SituationFamiliales");
            DropTable("dbo.PoleEmbauches");
            DropTable("dbo.Candidats");
        }
    }
}
