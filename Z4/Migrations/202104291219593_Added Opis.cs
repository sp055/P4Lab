namespace Z4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOpis : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Osobas", "Opis", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Osobas", "Opis");
        }
    }
}
