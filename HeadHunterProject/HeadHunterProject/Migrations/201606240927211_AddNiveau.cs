namespace HeadHunterProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNiveau : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Niveaux",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Libelle = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Diplomes", "NiveauId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Diplomes", "NiveauId");
            AddForeignKey("dbo.Diplomes", "NiveauId", "dbo.Niveaux", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Diplomes", "NiveauId", "dbo.Niveaux");
            DropIndex("dbo.Diplomes", new[] { "NiveauId" });
            DropColumn("dbo.Diplomes", "NiveauId");
            DropTable("dbo.Niveaux");
        }
    }
}
