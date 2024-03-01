using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflNet.Migrations
{
    /// <inheritdoc />
    public partial class add_bannerpagemodel_to_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "dbbannerhomepage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Url = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbbannerhomepage", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "dbbannerhomepage",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { new Guid("4127f7c0-59fc-47e6-ab19-9f2a23a02028"), new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(8282), null, null, "/images/default/banner_2.jpg" },
                    { new Guid("89bce33a-279a-4a36-b3ab-74e9b083facb"), new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(8228), null, null, "/images/default/banner_1.jpg" },
                    { new Guid("c2949f3d-d948-408e-910d-dcc50614e0a3"), new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(8318), null, null, "/images/default/banner_3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "dblanguage",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("128d7a45-4291-48a9-904e-0f9321465cbb"), "en", new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7802), null, true, "English", null },
                    { new Guid("5ef7e651-70f7-4c5a-89c8-8fc6fcc35dbd"), "vi", new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7787), null, true, "Tiếng việt", null }
                });

            migrationBuilder.InsertData(
                table: "dbpagemetadata",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Field", "Key", "LanguageId", "Session", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("4e2fdcd1-f2d4-45f3-8931-e024ba5f4c7a"), new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7831), null, "header", "home", new Guid("128d7a45-4291-48a9-904e-0f9321465cbb"), "sessionService", null, "WE GUARANTEE QUALITY" },
                    { new Guid("5f19bfc7-3b73-4578-9707-742f26014722"), new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7833), null, "subHeader", "home", new Guid("5ef7e651-70f7-4c5a-89c8-8fc6fcc35dbd"), "sessionService", null, "DFL tiến hành kiểm tra tại chỗ và xem xét tài liệu để xác minh khả năng truy xuất nguồn gốc của nhà cung cấp và các yếu tố xã hội, hóa học, môi trường và phúc lợi động vật. Nhấp vào bên dưới để tìm hiểu chi tiết về từng chứng nhận kiểm toán do IDFL cung cấp." },
                    { new Guid("9efa048d-512a-4ad1-befd-80b548571eee"), new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7828), null, "header", "home", new Guid("5ef7e651-70f7-4c5a-89c8-8fc6fcc35dbd"), "sessionService", null, "CHÚNG TÔI ĐẢM BẢO CHẤT LƯỢNG" },
                    { new Guid("b3bf0338-e5e1-4193-bdeb-7a1dcafd9f9b"), new DateTime(2024, 2, 28, 16, 55, 20, 124, DateTimeKind.Local).AddTicks(7835), null, "subHeader", "home", new Guid("128d7a45-4291-48a9-904e-0f9321465cbb"), "sessionService", null, "DFL conducts on-site audits, and documentation reviews to verify supplier traceability and social, chemical, environmental and animal welfare. Click below to learn details about each of the audit certifications offered by IDFL." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbbannerhomepage");

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("4e2fdcd1-f2d4-45f3-8931-e024ba5f4c7a"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("5f19bfc7-3b73-4578-9707-742f26014722"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("9efa048d-512a-4ad1-befd-80b548571eee"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("b3bf0338-e5e1-4193-bdeb-7a1dcafd9f9b"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("128d7a45-4291-48a9-904e-0f9321465cbb"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("5ef7e651-70f7-4c5a-89c8-8fc6fcc35dbd"));

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
    }
}
