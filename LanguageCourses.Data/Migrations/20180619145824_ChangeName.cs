using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageCourses.Data.Migrations
{
    public partial class ChangeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseUserMarks");

            migrationBuilder.AddColumn<decimal>(
                name: "AverageDecimal",
                table: "CourseUsers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CourseUserId = table.Column<Guid>(nullable: false),
                    UserMark = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_CourseUsers_CourseUserId",
                        column: x => x.CourseUserId,
                        principalTable: "CourseUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marks_CourseUserId",
                table: "Marks",
                column: "CourseUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropColumn(
                name: "AverageDecimal",
                table: "CourseUsers");

            migrationBuilder.CreateTable(
                name: "CourseUserMarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CourseUserId = table.Column<Guid>(nullable: true),
                    Mark = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUserMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseUserMarks_CourseUsers_CourseUserId",
                        column: x => x.CourseUserId,
                        principalTable: "CourseUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseUserMarks_CourseUserId",
                table: "CourseUserMarks",
                column: "CourseUserId");
        }
    }
}
