namespace MvcOnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mesajlars", "Icerik", c => c.String(maxLength: 2000, unicode: false));
            DropColumn("dbo.Mesajlars", "İcerik");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mesajlars", "İcerik", c => c.String(maxLength: 2000, unicode: false));
            DropColumn("dbo.Mesajlars", "Icerik");
        }
    }
}
