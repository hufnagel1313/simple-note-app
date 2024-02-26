using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleNotesApp.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddLabelField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Notes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Label",
                table: "Notes");
        }
    }
}
