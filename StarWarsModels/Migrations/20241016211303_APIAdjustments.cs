using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarWarsModels.Migrations
{
    /// <inheritdoc />
    public partial class APIAdjustments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "url",
                table: "Starship",
                newName: "URL");

            migrationBuilder.RenameColumn(
                name: "pilots",
                table: "Starship",
                newName: "Pilots");

            migrationBuilder.RenameColumn(
                name: "passengers",
                table: "Starship",
                newName: "Passengers");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Starship",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "Starship",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "manufacturer",
                table: "Starship",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "length",
                table: "Starship",
                newName: "Length");

            migrationBuilder.RenameColumn(
                name: "films",
                table: "Starship",
                newName: "Films");

            migrationBuilder.RenameColumn(
                name: "edited",
                table: "Starship",
                newName: "Edited");

            migrationBuilder.RenameColumn(
                name: "crew",
                table: "Starship",
                newName: "Crew");

            migrationBuilder.RenameColumn(
                name: "created",
                table: "Starship",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "consumables",
                table: "Starship",
                newName: "Consumables");

            migrationBuilder.RenameColumn(
                name: "starship_class",
                table: "Starship",
                newName: "StarshipClass");

            migrationBuilder.RenameColumn(
                name: "max_atmosphering_speed",
                table: "Starship",
                newName: "MaxAtomspheringSpeed");

            migrationBuilder.RenameColumn(
                name: "hyperdrive_rating",
                table: "Starship",
                newName: "HyperDriveRating");

            migrationBuilder.RenameColumn(
                name: "cost_in_credits",
                table: "Starship",
                newName: "CostInCredits");

            migrationBuilder.RenameColumn(
                name: "cargo_capacity",
                table: "Starship",
                newName: "CargoCapacity");

            migrationBuilder.AlterColumn<string>(
                name: "Crew",
                table: "Starship",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "URL",
                table: "Starship",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Pilots",
                table: "Starship",
                newName: "pilots");

            migrationBuilder.RenameColumn(
                name: "Passengers",
                table: "Starship",
                newName: "passengers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Starship",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Starship",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Starship",
                newName: "manufacturer");

            migrationBuilder.RenameColumn(
                name: "Length",
                table: "Starship",
                newName: "length");

            migrationBuilder.RenameColumn(
                name: "Films",
                table: "Starship",
                newName: "films");

            migrationBuilder.RenameColumn(
                name: "Edited",
                table: "Starship",
                newName: "edited");

            migrationBuilder.RenameColumn(
                name: "Crew",
                table: "Starship",
                newName: "crew");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Starship",
                newName: "created");

            migrationBuilder.RenameColumn(
                name: "Consumables",
                table: "Starship",
                newName: "consumables");

            migrationBuilder.RenameColumn(
                name: "StarshipClass",
                table: "Starship",
                newName: "starship_class");

            migrationBuilder.RenameColumn(
                name: "MaxAtomspheringSpeed",
                table: "Starship",
                newName: "max_atmosphering_speed");

            migrationBuilder.RenameColumn(
                name: "HyperDriveRating",
                table: "Starship",
                newName: "hyperdrive_rating");

            migrationBuilder.RenameColumn(
                name: "CostInCredits",
                table: "Starship",
                newName: "cost_in_credits");

            migrationBuilder.RenameColumn(
                name: "CargoCapacity",
                table: "Starship",
                newName: "cargo_capacity");

            migrationBuilder.AlterColumn<int>(
                name: "crew",
                table: "Starship",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
