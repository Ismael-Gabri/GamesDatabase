using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamesDatabase.Domain.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(60)", maxLength: 60, nullable: false),
                    Genre = table.Column<string>(type: "NVARCHAR(30)", maxLength: 30, nullable: false),
                    InitialPrice = table.Column<decimal>(type: "DECIMAL(18,0)", nullable: false),
                    DiscountPercentage = table.Column<decimal>(name: "Discount_Percentage", type: "DECIMAL(18,0)", nullable: false),
                    FinalPrice = table.Column<decimal>(type: "DECIMAL(18,0)", nullable: false),
                    ScreenshotPath = table.Column<string>(type: "NVARCHAR(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
