using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflNet.Migrations
{
    /// <inheritdoc />
    public partial class add_language_pagemetadata_data_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbpagemetadata",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Key = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Session = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Field = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LanguageId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbpagemetadata", x => x.Id);
                    table.ForeignKey(
                        name: "fk_language_pagemetadata",
                        column: x => x.LanguageId,
                        principalTable: "dblanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_dbpagemetadata_LanguageId",
                table: "dbpagemetadata",
                column: "LanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbpagemetadata");

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("434d7f1c-532b-4e28-9007-61a10098562d"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("f8d5b292-35e8-4ebc-8e94-cc10bbbad127"));
        }
    }
}
