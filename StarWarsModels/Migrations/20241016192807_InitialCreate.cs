using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StarWarsModels.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Starship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MGLT = table.Column<string>(type: "text", nullable: false),
                    cargo_capacity = table.Column<string>(type: "text", nullable: false),
                    consumables = table.Column<string>(type: "text", nullable: false),
                    cost_in_credits = table.Column<string>(type: "text", nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    crew = table.Column<int>(type: "integer", nullable: false),
                    edited = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    hyperdrive_rating = table.Column<double>(type: "double precision", nullable: false),
                    length = table.Column<double>(type: "double precision", nullable: false),
                    manufacturer = table.Column<string>(type: "text", nullable: false),
                    max_atmosphering_speed = table.Column<string>(type: "text", nullable: false),
                    model = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    passengers = table.Column<int>(type: "integer", nullable: false),
                    films = table.Column<string[]>(type: "text[]", nullable: false),
                    pilots = table.Column<string[]>(type: "text[]", nullable: false),
                    starship_class = table.Column<string>(type: "text", nullable: false),
                    url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starship", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Starship");
        }
    }
}
