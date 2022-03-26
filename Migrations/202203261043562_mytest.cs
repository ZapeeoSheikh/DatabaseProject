namespace MyWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mytest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "Course_Id" });
            RenameColumn(table: "dbo.Enrollments", name: "Course_Id", newName: "CourseId");
            AlterColumn("dbo.Enrollments", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enrollments", "CourseId");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            DropColumn("dbo.Enrollments", "CoiurseId");
            DropColumn("dbo.Enrollments", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrollments", "MyProperty", c => c.Int(nullable: false));
            AddColumn("dbo.Enrollments", "CoiurseId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            AlterColumn("dbo.Enrollments", "CourseId", c => c.Int());
            RenameColumn(table: "dbo.Enrollments", name: "CourseId", newName: "Course_Id");
            CreateIndex("dbo.Enrollments", "Course_Id");
            AddForeignKey("dbo.Enrollments", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
