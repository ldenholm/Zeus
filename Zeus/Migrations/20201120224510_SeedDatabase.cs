using Microsoft.EntityFrameworkCore.Migrations;

namespace Zeus.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Makes] (Name) VALUES ('Honda')");
            migrationBuilder.Sql("INSERT INTO [Makes] (Name) VALUES ('Volkswagon')");
            migrationBuilder.Sql("INSERT INTO [Makes] (Name) VALUES ('Mazda')");

            migrationBuilder.Sql("INSERT INTO [Models] (Name, MakeID) VALUES ('Golf', (SELECT ID FROM [Makes] WHERE [Name] = 'Volkswagon'))");
            migrationBuilder.Sql("INSERT INTO [Models] (Name, MakeID) VALUES ('Polo', (SELECT ID FROM [Makes] WHERE [Name] = 'Volkswagon'))");
            migrationBuilder.Sql("INSERT INTO [Models] (Name, MakeID) VALUES ('Passat', (SELECT ID FROM [Makes] WHERE [Name] = 'Volkswagon'))");

            migrationBuilder.Sql("INSERT INTO [Models] (Name, MakeID) VALUES ('Accord', (SELECT ID FROM [Makes] WHERE [Name] = 'Honda'))");
            migrationBuilder.Sql("INSERT INTO [Models] (Name, MakeID) VALUES ('City', (SELECT ID FROM [Makes] WHERE [Name] = 'Honda'))");
            migrationBuilder.Sql("INSERT INTO [Models] (Name, MakeID) VALUES ('Civic', (SELECT ID FROM [Makes] WHERE [Name] = 'Honda'))");

            migrationBuilder.Sql("INSERT INTO [Models] (Name, MakeID) VALUES ('Mazda3', (SELECT ID FROM [Makes] WHERE [Name] = 'Mazda'))");
            migrationBuilder.Sql("INSERT INTO [Models] (Name, MakeID) VALUES ('MX-5', (SELECT ID FROM [Makes] WHERE [Name] = 'Mazda'))");
            migrationBuilder.Sql("INSERT INTO [Models] (Name, MakeID) VALUES ('CX-30', (SELECT ID FROM [Makes] WHERE [Name] = 'Mazda'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MAKES");
        }
    }
}
