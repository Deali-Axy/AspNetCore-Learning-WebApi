using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Api.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("0a6aaa2f-e826-4da2-8c20-d44e509766d4"), new DateTimeOffset(new DateTime(1960, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "中国香港", "author1@deali.cn", "Author 1" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BirthPlace", "Email", "Name" },
                values: new object[] { new Guid("971b4133-798d-48b7-a81e-9ef0255f05e5"), new DateTimeOffset(new DateTime(1970, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 0, 0, 0)), "London, England", "author2@deali.cn", "Author 2" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("4a29ae9a-550b-4640-9db8-ed12d2610ed7"), new Guid("0a6aaa2f-e826-4da2-8c20-d44e509766d4"), "Description of Book 1", 281, "Book 1" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("0e602ccd-2bf2-44de-a345-3e6eb21dd1c5"), new Guid("0a6aaa2f-e826-4da2-8c20-d44e509766d4"), "Description of Book 3", 404, "Book 3" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("b0e5cb7b-bbd5-4b09-9054-5425bcc3e0d3"), new Guid("0a6aaa2f-e826-4da2-8c20-d44e509766d4"), "Description of Book 5", 320, "Book 5" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("c432b62b-93e5-4e61-8864-505f215ba355"), new Guid("971b4133-798d-48b7-a81e-9ef0255f05e5"), "Description of Book 2", 382, "Book 2" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Pages", "Title" },
                values: new object[] { new Guid("9f19cad3-81cc-4688-a5f6-8ff1a53ef298"), new Guid("971b4133-798d-48b7-a81e-9ef0255f05e5"), "Description of Book 4", 501, "Book 4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e602ccd-2bf2-44de-a345-3e6eb21dd1c5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4a29ae9a-550b-4640-9db8-ed12d2610ed7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9f19cad3-81cc-4688-a5f6-8ff1a53ef298"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b0e5cb7b-bbd5-4b09-9054-5425bcc3e0d3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c432b62b-93e5-4e61-8864-505f215ba355"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a6aaa2f-e826-4da2-8c20-d44e509766d4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("971b4133-798d-48b7-a81e-9ef0255f05e5"));
        }
    }
}
