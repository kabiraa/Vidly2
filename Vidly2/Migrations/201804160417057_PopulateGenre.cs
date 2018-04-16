namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES(Name) VALUES ('Action')");
            Sql("INSERT INTO GENRES(Name) VALUES ('Comedy')");
            Sql("INSERT INTO GENRES(Name) VALUES ('Romantic')");
            Sql("INSERT INTO GENRES(Name) VALUES ('Family Saga')");
        }
        
        public override void Down()
        {
        }
    }
}
