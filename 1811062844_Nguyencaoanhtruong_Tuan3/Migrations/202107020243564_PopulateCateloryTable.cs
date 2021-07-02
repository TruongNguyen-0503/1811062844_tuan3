namespace _1811062844_Nguyencaoanhtruong_Tuan3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCateloryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATELORIES(ID,NAME)) VALUES(1, 'Development')");
            Sql("INSERT INTO CATELORIES(ID,NAME)) VALUES(2, 'Business')");
            Sql("INSERT INTO CATELORIES(ID,NAME)) VALUES(3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
