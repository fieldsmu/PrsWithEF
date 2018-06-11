namespace PrsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedvendorclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 30),
                        Name = c.String(maxLength: 30),
                        Address = c.String(maxLength: 30),
                        City = c.String(maxLength: 30),
                        State = c.String(maxLength: 2),
                        Zip = c.String(maxLength: 5),
                        Phone = c.String(maxLength: 12),
                        Email = c.String(maxLength: 255),
                        IsPreapproved = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Vendors", new[] { "Code" });
            DropTable("dbo.Vendors");
        }
    }
}
