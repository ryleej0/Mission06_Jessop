using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Jessop.Migrations
{
    /// <inheritdoc />
    public partial class AddCopiedToPlex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add CopiedToPlex column (required for Mission 7)
            migrationBuilder.AddColumn<bool>(
                name: "CopiedToPlex",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            // Make Category, Director, Rating nullable for database flexibility per assignment
            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopiedToPlex",
                table: "Movies");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
