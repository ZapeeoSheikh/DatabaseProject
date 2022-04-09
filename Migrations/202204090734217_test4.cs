namespace MyWebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Logins", "RoleId", "dbo.Roles");
            DropIndex("dbo.Logins", new[] { "RoleId" });
            DropTable("dbo.Logins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        Password = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Logins", "RoleId");
            AddForeignKey("dbo.Logins", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
        }
    }
}
