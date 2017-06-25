namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnFirstName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "LastName", newName: "Apelido");
            RenameColumn(table: "dbo.Student", name: "FirstMidName", newName: "Nome");
            RenameColumn(table: "dbo.Student", name: "EnrollmentDate", newName: "Matricula");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Student", name: "Matricula", newName: "EnrollmentDate");
            RenameColumn(table: "dbo.Student", name: "Nome", newName: "FirstMidName");
            RenameColumn(table: "dbo.Student", name: "Apelido", newName: "LastName");
        }
    }
}
