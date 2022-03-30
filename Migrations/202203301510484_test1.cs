namespace MyWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genders", "Genderr", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genders", "Genderr");
        }
    }
}
