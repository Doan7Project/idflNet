using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflNet.Migrations
{
    /// <inheritdoc />
    public partial class add_category_standard_media_data_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dbbannerhomepage",
                keyColumn: "Id",
                keyValue: new Guid("4127f7c0-59fc-47e6-ab19-9f2a23a02028"));

            migrationBuilder.DeleteData(
                table: "dbbannerhomepage",
                keyColumn: "Id",
                keyValue: new Guid("89bce33a-279a-4a36-b3ab-74e9b083facb"));

            migrationBuilder.DeleteData(
                table: "dbbannerhomepage",
                keyColumn: "Id",
                keyValue: new Guid("c2949f3d-d948-408e-910d-dcc50614e0a3"));

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

            migrationBuilder.CreateTable(
                name: "dbcategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Thumbnail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LanguageId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbcategory", x => x.Id);
                    table.ForeignKey(
                        name: "fk_language_category",
                        column: x => x.LanguageId,
                        principalTable: "dblanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbmedia",
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
                    table.PrimaryKey("PK_dbmedia", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbstandard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CategoryId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LanguageId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MediaId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbstandard", x => x.Id);
                    table.ForeignKey(
                        name: "fk_category_standard",
                        column: x => x.CategoryId,
                        principalTable: "dbcategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_language_standard",
                        column: x => x.LanguageId,
                        principalTable: "dblanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_media_product",
                        column: x => x.MediaId,
                        principalTable: "dbmedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "dbbannerhomepage",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { new Guid("15f479bf-a4a7-48cd-85c6-7517912531ec"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(5588), null, null, "" },
                    { new Guid("4532a5ab-7c56-42a5-9e39-2bc4f05ca59c"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(5673), null, null, "" },
                    { new Guid("dab1928f-3bf4-4a85-b3f4-0d37dbbf907b"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(5723), null, null, "" }
                });

            migrationBuilder.InsertData(
                table: "dblanguage",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), "en", new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(4631), null, true, "English", null },
                    { new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), "vi", new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(4610), null, true, "Tiếng việt", null }
                });

            migrationBuilder.InsertData(
                table: "dbmedia",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { new Guid("02b44015-0e08-48b6-960c-74d6514f61d2"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(6273), null, null, "" },
                    { new Guid("1630c65e-8e63-48dc-8229-b6501399f4c9"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(6155), null, null, "" },
                    { new Guid("327e708a-d2d7-4dc9-aadb-acaa569800ae"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(6193), null, null, "" },
                    { new Guid("333c35fc-8f84-4fcc-9907-d8c563a8ef59"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(6447), null, null, "" },
                    { new Guid("415f020d-3168-427c-a6f4-7d04745828ee"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(6350), null, null, "" },
                    { new Guid("9b20c7ee-45e2-409f-b0a6-8c8b879e7b5d"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(6233), null, null, "" },
                    { new Guid("ac4019d7-e899-46c7-ae3f-b2079d032fe2"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(6410), null, null, "" }
                });

            migrationBuilder.InsertData(
                table: "dbcategory",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "LanguageId", "Name", "Thumbnail", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("21ccff1c-48fc-419c-a8b2-9d3df4b748b4"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(5867), null, "", true, new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), "GLOBAL RECYLED STANDARD", "", null },
                    { new Guid("2a36bad6-9ace-463a-ba5c-e64c521875c8"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(6039), null, "", true, new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), "RESPONSIBLE WOOL STANDARD", "", null },
                    { new Guid("44be8122-6b69-4826-822d-4fa867ff4f7e"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(5831), null, "", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), "TIÊU CHUẨN TÁI CHẾ TOÀN CẦU", "", null },
                    { new Guid("7a2c8b69-926e-45a5-8308-eb65da7f7f0c"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(5959), null, "", true, new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), "GLOBAL ORGANIC TEXTILE STANDARD", "", null },
                    { new Guid("a49ff7f6-0c47-4a13-83c2-8d8e2a4cf905"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(5921), null, "", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), "TIÊU CHUẨN DỆT HỮU CƠ TOÀN CẦU", "", null },
                    { new Guid("c49e4206-663f-4726-8b4c-5d5db64391dc"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(5993), null, "", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), "TIÊU CHUẨN LEN CÓ TRÁCH NHIỆM", "", null }
                });

            migrationBuilder.InsertData(
                table: "dbpagemetadata",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Field", "Key", "LanguageId", "Session", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("28aa00a8-046c-4d39-a5e3-e3c61a372db9"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(4693), null, "subHeader", "home", new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), "sessionService", null, "DFL tiến hành kiểm tra tại chỗ và xem xét tài liệu để xác minh khả năng truy xuất nguồn gốc của nhà cung cấp và các yếu tố xã hội, hóa học, môi trường và phúc lợi động vật. Nhấp vào bên dưới để tìm hiểu chi tiết về từng chứng nhận kiểm toán do IDFL cung cấp." },
                    { new Guid("6a4e07a4-5c1e-4682-8b65-c335d0aa8277"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(4691), null, "header", "home", new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), "sessionService", null, "WE GUARANTEE QUALITY" },
                    { new Guid("7fc54a62-aa8c-4344-aa01-f3ce9b1cf956"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(4688), null, "header", "home", new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), "sessionService", null, "CHÚNG TÔI ĐẢM BẢO CHẤT LƯỢNG" },
                    { new Guid("84168072-1e98-4baf-959c-5328c0ca43d7"), new DateTime(2024, 2, 29, 14, 44, 27, 73, DateTimeKind.Local).AddTicks(4695), null, "subHeader", "home", new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), "sessionService", null, "DFL conducts on-site audits, and documentation reviews to verify supplier traceability and social, chemical, environmental and animal welfare. Click below to learn details about each of the audit certifications offered by IDFL." }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "Description", "IsActive", "LanguageId", "MediaId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0615851b-582c-450a-91e2-c79a1e320cdf"), new Guid("c49e4206-663f-4726-8b4c-5d5db64391dc"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), new Guid("ac4019d7-e899-46c7-ae3f-b2079d032fe2"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("153ad832-c576-4dbc-aea3-da2181ea3c61"), new Guid("7a2c8b69-926e-45a5-8308-eb65da7f7f0c"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), new Guid("9b20c7ee-45e2-409f-b0a6-8c8b879e7b5d"), "Global Recycled Standard (GRS)", null },
                    { new Guid("39c55cc1-589c-4347-82d6-664b355b4cdc"), new Guid("a49ff7f6-0c47-4a13-83c2-8d8e2a4cf905"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), new Guid("02b44015-0e08-48b6-960c-74d6514f61d2"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("4da04cb1-e39f-445b-b2c6-0ad074919366"), new Guid("21ccff1c-48fc-419c-a8b2-9d3df4b748b4"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), new Guid("1630c65e-8e63-48dc-8229-b6501399f4c9"), "Global Recycled Standard (GRS)", null },
                    { new Guid("5ff8d2d3-4eca-481d-b111-e9c0175639dd"), new Guid("2a36bad6-9ace-463a-ba5c-e64c521875c8"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), new Guid("415f020d-3168-427c-a6f4-7d04745828ee"), "Global Recycled Standard (GRS)", null },
                    { new Guid("68619e6c-77ee-42fe-aecc-e3cee77ae83c"), new Guid("2a36bad6-9ace-463a-ba5c-e64c521875c8"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), new Guid("ac4019d7-e899-46c7-ae3f-b2079d032fe2"), "Global Recycled Standard (GRS)", null },
                    { new Guid("6a76d0ae-340e-46cc-8075-c464221a62c8"), new Guid("a49ff7f6-0c47-4a13-83c2-8d8e2a4cf905"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), new Guid("9b20c7ee-45e2-409f-b0a6-8c8b879e7b5d"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("6f9cc6e6-7d3c-434b-8944-f2dbb34f46a4"), new Guid("7a2c8b69-926e-45a5-8308-eb65da7f7f0c"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), new Guid("02b44015-0e08-48b6-960c-74d6514f61d2"), "Global Recycled Standard (GRS)", null },
                    { new Guid("72f40d80-7f1c-4979-af04-a545ea943a08"), new Guid("44be8122-6b69-4826-822d-4fa867ff4f7e"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), new Guid("1630c65e-8e63-48dc-8229-b6501399f4c9"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("97c2b96c-06c8-4eaa-8075-066c2d9e6990"), new Guid("2a36bad6-9ace-463a-ba5c-e64c521875c8"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"), new Guid("333c35fc-8f84-4fcc-9907-d8c563a8ef59"), "Global Recycled Standard (GRS)", null },
                    { new Guid("990f5512-b757-4b56-9825-abb614ff5d58"), new Guid("44be8122-6b69-4826-822d-4fa867ff4f7e"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), new Guid("327e708a-d2d7-4dc9-aadb-acaa569800ae"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("c9b5a135-6976-4c17-ab48-df68575a8803"), new Guid("c49e4206-663f-4726-8b4c-5d5db64391dc"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), new Guid("415f020d-3168-427c-a6f4-7d04745828ee"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("dc342bbc-3cff-4a72-902a-d20bcdf6cd8c"), new Guid("21ccff1c-48fc-419c-a8b2-9d3df4b748b4"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), new Guid("327e708a-d2d7-4dc9-aadb-acaa569800ae"), "Global Recycled Standard (GRS)", null },
                    { new Guid("e4103b89-1fbc-4697-bc94-782feac48d93"), new Guid("c49e4206-663f-4726-8b4c-5d5db64391dc"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"), new Guid("333c35fc-8f84-4fcc-9907-d8c563a8ef59"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbcategory_LanguageId",
                table: "dbcategory",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_dbstandard_CategoryId",
                table: "dbstandard",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_dbstandard_LanguageId",
                table: "dbstandard",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_dbstandard_MediaId",
                table: "dbstandard",
                column: "MediaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbstandard");

            migrationBuilder.DropTable(
                name: "dbcategory");

            migrationBuilder.DropTable(
                name: "dbmedia");

            migrationBuilder.DeleteData(
                table: "dbbannerhomepage",
                keyColumn: "Id",
                keyValue: new Guid("15f479bf-a4a7-48cd-85c6-7517912531ec"));

            migrationBuilder.DeleteData(
                table: "dbbannerhomepage",
                keyColumn: "Id",
                keyValue: new Guid("4532a5ab-7c56-42a5-9e39-2bc4f05ca59c"));

            migrationBuilder.DeleteData(
                table: "dbbannerhomepage",
                keyColumn: "Id",
                keyValue: new Guid("dab1928f-3bf4-4a85-b3f4-0d37dbbf907b"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("28aa00a8-046c-4d39-a5e3-e3c61a372db9"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("6a4e07a4-5c1e-4682-8b65-c335d0aa8277"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("7fc54a62-aa8c-4344-aa01-f3ce9b1cf956"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("84168072-1e98-4baf-959c-5328c0ca43d7"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("07cc6b31-f1cc-4e6c-9ed8-5ffa389d3fe7"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("aff66bad-a320-4ce5-8215-1ae09adb4f5e"));

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
    }
}
