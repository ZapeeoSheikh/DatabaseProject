namespace MyWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class atest : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enrollments", "JoinOndate", c => c.DateTime(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Enrollments", "JoinOndate", c => c.String());
        }
    }
}
