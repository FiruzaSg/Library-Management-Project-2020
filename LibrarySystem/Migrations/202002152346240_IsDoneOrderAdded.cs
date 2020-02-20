﻿namespace LibrarySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDoneOrderAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsDone", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "IsDone");
        }
    }
}
