namespace HeadHunterProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSituFamAndSecteur : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into dbo.PoleEmbauches (Id, Libelle) VALUES (1,'Aix-Marseille')");
            Sql("INSERT into dbo.PoleEmbauches (Id, Libelle) VALUES (2,'Toulon')");
            Sql("INSERT into dbo.PoleEmbauches (Id, Libelle) VALUES (3,'Nice')");
            Sql("INSERT into dbo.PoleEmbauches (Id, Libelle) VALUES (4,'Grenoble')");
            Sql("INSERT into dbo.PoleEmbauches (Id, Libelle) VALUES (5,'Lyon')");
            Sql("INSERT into dbo.PoleEmbauches (Id, Libelle) VALUES (6,'Paris')");
            Sql("INSERT into dbo.SituationFamiliales (Id, Libelle) VALUES (1,'Mari�')");
            Sql("INSERT into dbo.SituationFamiliales (Id, Libelle) VALUES (2,'Pacs�')");
            Sql("INSERT into dbo.SituationFamiliales (Id, Libelle) VALUES (3,'Divorc�')");
            Sql("INSERT into dbo.SituationFamiliales (Id, Libelle) VALUES (4,'C�libataire')");
            Sql("INSERT into dbo.SituationFamiliales (Id, Libelle) VALUES (5,'Veuf')");
        }
        
        public override void Down()
        {
        }
    }
}
