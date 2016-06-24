namespace HeadHunterProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDiplomeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diplomes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Libelle = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Candidats", "DiplomeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Candidats", "DiplomeId");
            AddForeignKey("dbo.Candidats", "DiplomeId", "dbo.Diplomes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidats", "DiplomeId", "dbo.Diplomes");
            DropIndex("dbo.Candidats", new[] { "DiplomeId" });
            DropColumn("dbo.Candidats", "DiplomeId");
            DropTable("dbo.Diplomes");
        }
    }
}
