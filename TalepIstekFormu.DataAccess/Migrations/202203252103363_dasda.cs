namespace TalepIstekFormu.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dasda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "IsDeleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.Departments", "IsDelete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "IsDelete", c => c.Boolean(nullable: false));
            DropColumn("dbo.Departments", "IsDeleted");
        }
    }
}
