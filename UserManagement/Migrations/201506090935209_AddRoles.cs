namespace UserManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("Users", "Roles", c => c.Int());
        }
        
        public override void Down()
        {
        }
    }
}
