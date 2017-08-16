using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagemantSystem.Migrations
{
    public partial class addedReferenceKey1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreateByUserId",
                table: "Employee",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CreateByUserId",
                table: "Employee",
                column: "CreateByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_AspNetUsers_CreateByUserId",
                table: "Employee",
                column: "CreateByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_AspNetUsers_CreateByUserId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_CreateByUserId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CreateByUserId",
                table: "Employee");
        }
    }
}
