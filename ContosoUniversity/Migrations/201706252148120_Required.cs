namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "Apelido", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Student", "Nome", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "Nome", c => c.String(maxLength: 50));
            AlterColumn("dbo.Student", "Apelido", c => c.String(maxLength: 50));
        }
    }
}
