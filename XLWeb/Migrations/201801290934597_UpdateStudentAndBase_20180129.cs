namespace XLWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudentAndBase_20180129 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "CreateUser", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "ModifyUser", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "ModifyUser", c => c.String());
            AlterColumn("dbo.Students", "CreateUser", c => c.String());
        }
    }
}
