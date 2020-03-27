using Microsoft.EntityFrameworkCore.Migrations;

namespace Pierre.Migrations
{
    public partial class Authorization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Treats",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Flavors",
                newName: "FlavorName");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Treats",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TreatName",
                table: "Treats",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treats_UserId",
                table: "Treats",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_Treats_UserId",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "TreatName",
                table: "Treats");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Treats",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FlavorName",
                table: "Flavors",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Treats",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
