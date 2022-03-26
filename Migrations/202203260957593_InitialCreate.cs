namespace MyWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CnicDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CnicNumber = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CoiurseId = c.Int(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        JoinOndate = c.String(),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.CnicDetails", "StudentId", "dbo.Students");
            DropIndex("dbo.Enrollments", new[] { "Course_Id" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropIndex("dbo.CnicDetails", new[] { "StudentId" });
            DropTable("dbo.Genders");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Courses");
            DropTable("dbo.Students");
            DropTable("dbo.CnicDetails");
        }
    }
}
