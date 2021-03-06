﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CarsBackend.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make2')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make3')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelA', (SELECT Id FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelB', (SELECT Id FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelC', (SELECT Id FROM Makes WHERE Name = 'Make1'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelA', (SELECT Id FROM Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelB', (SELECT Id FROM Makes WHERE Name = 'Make2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelC', (SELECT Id FROM Makes WHERE Name = 'Make2'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make3-ModelA', (SELECT Id FROM Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make3-ModelB', (SELECT Id FROM Makes WHERE Name = 'Make3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make3-ModelC', (SELECT Id FROM Makes WHERE Name = 'Make3'))");

            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature 1')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature 2')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature 3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name In ('Make1', 'Make2', 'Make3')");
            migrationBuilder.Sql("DELETE FROM Features");
        }
    }
}
