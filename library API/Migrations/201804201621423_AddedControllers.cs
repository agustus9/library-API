namespace library_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedControllers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CheckOutLedgers", "Books_Id", "dbo.Books");
            DropIndex("dbo.CheckOutLedgers", new[] { "Books_Id" });
            DropColumn("dbo.CheckOutLedgers", "BookID");
            RenameColumn(table: "dbo.CheckOutLedgers", name: "Books_Id", newName: "BookID");
            AlterColumn("dbo.CheckOutLedgers", "BookID", c => c.Int(nullable: false));
            CreateIndex("dbo.CheckOutLedgers", "BookID");
            AddForeignKey("dbo.CheckOutLedgers", "BookID", "dbo.Books", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckOutLedgers", "BookID", "dbo.Books");
            DropIndex("dbo.CheckOutLedgers", new[] { "BookID" });
            AlterColumn("dbo.CheckOutLedgers", "BookID", c => c.Int());
            RenameColumn(table: "dbo.CheckOutLedgers", name: "BookID", newName: "Books_Id");
            AddColumn("dbo.CheckOutLedgers", "BookID", c => c.Int(nullable: false));
            CreateIndex("dbo.CheckOutLedgers", "Books_Id");
            AddForeignKey("dbo.CheckOutLedgers", "Books_Id", "dbo.Books", "Id");
        }
    }
}
