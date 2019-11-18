using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopAPI.WEB.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Makes (Name) values ('Make1')");
            migrationBuilder.Sql("Insert into Makes (Name) values ('Make2')");
            migrationBuilder.Sql("Insert into Makes (Name) values ('Make3')");

            migrationBuilder.Sql("insert into Products (Name, MakeId) values ('Make1-ModelA', (select id from makes where Name = 'Make1'))");
            migrationBuilder.Sql("insert into Products (Name, MakeId) values ('Make1-ModelB', (select id from makes where Name = 'Make1'))");
            migrationBuilder.Sql("insert into Products (Name, MakeId) values ('Make2-ModelA', (select id from makes where Name = 'Make2'))");
            migrationBuilder.Sql("insert into Products (Name, MakeId) values ('Make2-ModelB', (select id from makes where Name = 'Make2'))");
            migrationBuilder.Sql("insert into Products (Name, MakeId) values ('Make3-ModelA', (select id from makes where Name = 'Make3'))");
            migrationBuilder.Sql("insert into Products (Name, MakeId) values ('Make3-ModelB', (select id from makes where Name = 'Make3'))");
            migrationBuilder.Sql("insert into Products (Name, MakeId) values ('Make3-ModelC', (select id from makes where Name = 'Make3'))");
            migrationBuilder.Sql("insert into Products (Name, MakeId) values ('Make1-ModelC', (select id from makes where Name = 'Make1'))");
            migrationBuilder.Sql("insert into Products (Name, MakeId) values ('Make2-ModelC', (select id from makes where Name = 'Make2'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from makes");
            migrationBuilder.Sql("delete from products");
        }
    }
}
