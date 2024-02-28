using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflNet.Migrations
{
    /// <inheritdoc />
    public partial class add_role_to_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("1f4fda1a-89c1-4f19-bc96-e95efc7de576"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("20908e5d-ad36-4030-a2ea-1c07f0e243c7"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("543e4f85-cdab-4b45-81ba-3c94405cd25b"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("f58e1736-b012-4cb7-a98c-658b72107e29"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("434d7f1c-532b-4e28-9007-61a10098562d"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("f8d5b292-35e8-4ebc-8e94-cc10bbbad127"));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "dbuser",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Roles",
                table: "dbuser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "dblanguage",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("bd10c1af-77cc-441c-aadd-300e77a4f8d3"), "vi", new DateTime(2024, 2, 28, 16, 30, 59, 548, DateTimeKind.Local).AddTicks(7255), null, true, "Tiếng việt", null },
                    { new Guid("e8110edb-af7e-4dc5-a3a0-1866b582bb42"), "en", new DateTime(2024, 2, 28, 16, 30, 59, 548, DateTimeKind.Local).AddTicks(7270), null, true, "English", null }
                });

            migrationBuilder.InsertData(
                table: "dbpagemetadata",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Field", "Key", "LanguageId", "Session", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("19c8c1af-a1c0-44cd-8f39-2dd78cee24a3"), new DateTime(2024, 2, 28, 16, 30, 59, 548, DateTimeKind.Local).AddTicks(7295), null, "header", "home", new Guid("e8110edb-af7e-4dc5-a3a0-1866b582bb42"), "sessionService", null, "WE GUARANTEE QUALITY" },
                    { new Guid("1da0fa6a-e658-4cec-91ed-72d531305b92"), new DateTime(2024, 2, 28, 16, 30, 59, 548, DateTimeKind.Local).AddTicks(7297), null, "subHeader", "home", new Guid("bd10c1af-77cc-441c-aadd-300e77a4f8d3"), "sessionService", null, "DFL tiến hành kiểm tra tại chỗ và xem xét tài liệu để xác minh khả năng truy xuất nguồn gốc của nhà cung cấp và các yếu tố xã hội, hóa học, môi trường và phúc lợi động vật. Nhấp vào bên dưới để tìm hiểu chi tiết về từng chứng nhận kiểm toán do IDFL cung cấp." },
                    { new Guid("3b351781-e0ec-4d6e-a2d9-dc6a8572fc52"), new DateTime(2024, 2, 28, 16, 30, 59, 548, DateTimeKind.Local).AddTicks(7293), null, "header", "home", new Guid("bd10c1af-77cc-441c-aadd-300e77a4f8d3"), "sessionService", null, "CHÚNG TÔI ĐẢM BẢO CHẤT LƯỢNG" },
                    { new Guid("3c2a8d34-53ce-4341-bf53-50c562e03514"), new DateTime(2024, 2, 28, 16, 30, 59, 548, DateTimeKind.Local).AddTicks(7299), null, "subHeader", "home", new Guid("e8110edb-af7e-4dc5-a3a0-1866b582bb42"), "sessionService", null, "DFL conducts on-site audits, and documentation reviews to verify supplier traceability and social, chemical, environmental and animal welfare. Click below to learn details about each of the audit certifications offered by IDFL." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("19c8c1af-a1c0-44cd-8f39-2dd78cee24a3"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("1da0fa6a-e658-4cec-91ed-72d531305b92"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("3b351781-e0ec-4d6e-a2d9-dc6a8572fc52"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("3c2a8d34-53ce-4341-bf53-50c562e03514"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("bd10c1af-77cc-441c-aadd-300e77a4f8d3"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("e8110edb-af7e-4dc5-a3a0-1866b582bb42"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "dbuser");

            migrationBuilder.InsertData(
                table: "dblanguage",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("434d7f1c-532b-4e28-9007-61a10098562d"), "vi", new DateTime(2024, 2, 24, 12, 55, 19, 649, DateTimeKind.Local).AddTicks(9817), null, true, "Tiếng việt", null },
                    { new Guid("f8d5b292-35e8-4ebc-8e94-cc10bbbad127"), "en", new DateTime(2024, 2, 24, 12, 55, 19, 649, DateTimeKind.Local).AddTicks(9839), null, true, "English", null }
                });

            migrationBuilder.InsertData(
                table: "dbpagemetadata",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Field", "Key", "LanguageId", "Session", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("1f4fda1a-89c1-4f19-bc96-e95efc7de576"), new DateTime(2024, 2, 24, 12, 55, 19, 649, DateTimeKind.Local).AddTicks(9867), null, "header", "home", new Guid("f8d5b292-35e8-4ebc-8e94-cc10bbbad127"), "sessionService", null, "WE GUARANTEE QUALITY" },
                    { new Guid("20908e5d-ad36-4030-a2ea-1c07f0e243c7"), new DateTime(2024, 2, 24, 12, 55, 19, 649, DateTimeKind.Local).AddTicks(9864), null, "header", "home", new Guid("434d7f1c-532b-4e28-9007-61a10098562d"), "sessionService", null, "CHÚNG TÔI ĐẢM BẢO CHẤT LƯỢNG" },
                    { new Guid("543e4f85-cdab-4b45-81ba-3c94405cd25b"), new DateTime(2024, 2, 24, 12, 55, 19, 649, DateTimeKind.Local).AddTicks(9869), null, "subHeader", "home", new Guid("434d7f1c-532b-4e28-9007-61a10098562d"), "sessionService", null, "DFL tiến hành kiểm tra tại chỗ và xem xét tài liệu để xác minh khả năng truy xuất nguồn gốc của nhà cung cấp và các yếu tố xã hội, hóa học, môi trường và phúc lợi động vật. Nhấp vào bên dưới để tìm hiểu chi tiết về từng chứng nhận kiểm toán do IDFL cung cấp." },
                    { new Guid("f58e1736-b012-4cb7-a98c-658b72107e29"), new DateTime(2024, 2, 24, 12, 55, 19, 649, DateTimeKind.Local).AddTicks(9871), null, "subHeader", "home", new Guid("f8d5b292-35e8-4ebc-8e94-cc10bbbad127"), "sessionService", null, "DFL conducts on-site audits, and documentation reviews to verify supplier traceability and social, chemical, environmental and animal welfare. Click below to learn details about each of the audit certifications offered by IDFL." }
                });
        }
    }
}
