namespace LTWeb15CTH12Advanced.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'Development')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'Bussiness')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'Internet Marketing')");
        }

        public override void Down()
        {
        }
    }
}
