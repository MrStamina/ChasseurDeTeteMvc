namespace HeadHunterProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDiploma : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into dbo.diplomes (Id, Libelle, NiveauId) values(1,'Concepteur developpeur informatique',2)");
            Sql("Insert into dbo.diplomes (Id, Libelle, NiveauId) values(2,'Developpeur logiciel',3)");
            Sql("Insert into dbo.diplomes (Id, Libelle, NiveauId) values(3,'DUT informatique',3)");
            Sql("Insert into dbo.diplomes (Id, Libelle, NiveauId) values(4,'BTS informatique',3)");
            Sql("Insert into dbo.diplomes (Id, Libelle, NiveauId) values(5,'Master1 informatique',2)");
            Sql("Insert into dbo.diplomes (Id, Libelle, NiveauId) values(6,'Ingénieur',1)");
        }
        
        public override void Down()
        {
        }
    }
}
