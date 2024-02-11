namespace SEO14.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Family = c.String(nullable: false, maxLength: 50),
                        Ncode = c.String(nullable: false, maxLength: 10),
                        Birthdate = c.DateTime(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 30),
                        IsActive = c.Boolean(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        age = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.T_Student");
        }
    }
}
