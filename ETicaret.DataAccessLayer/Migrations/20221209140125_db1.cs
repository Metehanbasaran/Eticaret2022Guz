using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.DataAccessLayer.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commeties",
                columns: table => new
                {
                    CommetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commentingperson = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CommetSurName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CommetStatu = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommetText = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commeties", x => x.CommetId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SubCategoryStatu = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SortKey = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                });

            migrationBuilder.InsertData(
                table: "Commeties",
                columns: new[] { "CommetId", "datetime", "CommetStatu", "CommetSurName", "CommetText", "commentingperson" },
                values: new object[] { 1, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Kalmış", "Güzelllmişşş", "Ahmet" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "CategoryId", "SortKey", "SubCategoryName", "SubCategoryStatu" },
                values: new object[] { 1, 0, (short)1, "Bilgisayar", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commeties");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
