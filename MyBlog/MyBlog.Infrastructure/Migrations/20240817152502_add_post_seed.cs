using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyBlog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_post_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "Created", "IsActive", "ProfileId", "Title", "Updated" },
                values: new object[,]
                {
                    { -2, "This is my second seed post", new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(318), true, -1, "My Second Post", new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(319) },
                    { -1, "This is my first seed post", new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(314), true, -1, "My First Post", new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(314) }
                });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(306), new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 8, 17, 22, 25, 2, 420, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ProfileId",
                table: "Posts",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Profiles_ProfileId",
                table: "Posts",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Profiles_ProfileId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ProfileId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 7, 12, 358, DateTimeKind.Local).AddTicks(9988), new DateTime(2024, 8, 17, 22, 7, 12, 359, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 7, 12, 359, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 8, 17, 22, 7, 12, 359, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 7, 12, 359, DateTimeKind.Local).AddTicks(14), new DateTime(2024, 8, 17, 22, 7, 12, 359, DateTimeKind.Local).AddTicks(14) });
        }
    }
}
