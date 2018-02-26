namespace XLWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        Sex = c.String(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        Address = c.String(maxLength: 500),
                        Phone = c.String(maxLength: 50),
                        QQ = c.String(maxLength: 50),
                        Remark = c.String(maxLength: 500),
                        CreateUser = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        ModifyUser = c.String(),
                        ModifyTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
