namespace HeadHunterProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNiveau : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.Niveaux (Id, Libelle) Values (1,'Niveau 1')");
            Sql("Insert into dbo.Niveaux (Id, Libelle) Values (2,'Niveau 2')");
            Sql("Insert into dbo.Niveaux (Id, Libelle) Values (3,'Niveau 3')");
            Sql("Insert into dbo.Niveaux (Id, Libelle) Values (4,'Niveau 4')");
            Sql("Insert into dbo.Niveaux (Id, Libelle) Values (5,'Niveau 5')");
        }
        
        public override void Down()
        {
        }
    }
}
