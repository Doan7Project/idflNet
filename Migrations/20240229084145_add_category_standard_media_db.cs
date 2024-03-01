using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflNet.Migrations
{
    /// <inheritdoc />
    public partial class add_category_standard_media_db : Migration
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
                    { new Guid("153019a7-b1da-4e82-8d09-2e7732996fac"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7768), null, null, "/images/default/banner_1.jpg" },
                    { new Guid("5b57b3d8-8f70-4dbe-9d17-b2854ecfbab2"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7780), null, null, "/images/default/banner_2.jpg" },
                    { new Guid("ca99628f-674c-4e93-ad8b-fc84a2a09dd1"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7782), null, null, "/images/default/banner_3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "dblanguage",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), "vi", new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7690), null, true, "Tiếng việt", null },
                    { new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), "en", new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7709), null, true, "English", null }
                });

            migrationBuilder.InsertData(
                table: "dbmedia",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { new Guid("33c6f5a3-5008-41e9-8e65-ee26d276d01d"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7859), null, null, "/images/default/icon_4.png" },
                    { new Guid("352baa1c-3631-44da-834e-98892a85156f"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7856), null, null, "/images/default/icon_2.png" },
                    { new Guid("3d671336-2e4a-4262-812b-add51e38fcb6"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7863), null, null, "/images/default/icon_6.png" },
                    { new Guid("76274a0a-590d-4e10-99db-dde8c7e94e85"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7857), null, null, "/images/default/icon_3.png" },
                    { new Guid("b182db0b-3e14-4851-adfb-411e879abc9b"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7864), null, null, "/images/default/icon_7.png" },
                    { new Guid("cbd1dbca-9de3-44d2-88db-0e80844b3ae2"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7853), null, null, "/images/default/icon_1.png" },
                    { new Guid("d45b816f-ec3c-434c-90f8-8176674d6b21"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7861), null, null, "/images/default/icon_5.png" }
                });

            migrationBuilder.InsertData(
                table: "dbcategory",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "LanguageId", "Name", "Thumbnail", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11894bcd-fd13-4ce6-b053-f766479dbef5"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7806), null, "", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), "TIÊU CHUẨN DỆT HỮU CƠ TOÀN CẦU", "/images/default/category_2.jpg", null },
                    { new Guid("76150aee-a938-4172-b213-0304b9f95c39"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7803), null, "", true, new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), "GLOBAL RECYLED STANDARD", "/images/default/category_1.jpg", null },
                    { new Guid("88cac7c0-9fb3-4b3e-8d6f-bfa579907779"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7808), null, "", true, new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), "GLOBAL ORGANIC TEXTILE STANDARD", "/images/default/category_2.png", null },
                    { new Guid("8a91040f-020b-4e1f-a972-06c4cb33c240"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7800), null, "", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), "TIÊU CHUẨN TÁI CHẾ TOÀN CẦU", "/images/default/category_1.jpg", null },
                    { new Guid("945276ee-ca0c-40d1-b386-63c5eebe2bb2"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7811), null, "", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), "TIÊU CHUẨN LEN CÓ TRÁCH NHIỆM", "/images/default/category_3.jpg", null },
                    { new Guid("b4cf7466-4f50-4678-a545-12149297b8cd"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7834), null, "", true, new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), "RESPONSIBLE WOOL STANDARD", "/images/default/category_3.png", null }
                });

            migrationBuilder.InsertData(
                table: "dbpagemetadata",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Field", "Key", "LanguageId", "Session", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("60d549cb-d3d4-4b08-b3cd-01eedbbcf03e"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7738), null, "header", "home", new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), "sessionService", null, "CHÚNG TÔI ĐẢM BẢO CHẤT LƯỢNG" },
                    { new Guid("72f8cd97-4260-4497-ae45-3b7c9ab8b5bb"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7746), null, "subHeader", "home", new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), "sessionService", null, "DFL conducts on-site audits, and documentation reviews to verify supplier traceability and social, chemical, environmental and animal welfare. Click below to learn details about each of the audit certifications offered by IDFL." },
                    { new Guid("9956785d-3be1-4701-9990-5936265a29f3"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7744), null, "subHeader", "home", new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), "sessionService", null, "DFL tiến hành kiểm tra tại chỗ và xem xét tài liệu để xác minh khả năng truy xuất nguồn gốc của nhà cung cấp và các yếu tố xã hội, hóa học, môi trường và phúc lợi động vật. Nhấp vào bên dưới để tìm hiểu chi tiết về từng chứng nhận kiểm toán do IDFL cung cấp." },
                    { new Guid("a5cde2c5-08ed-4adb-b070-32ad43636cf2"), new DateTime(2024, 2, 29, 15, 41, 45, 713, DateTimeKind.Local).AddTicks(7741), null, "header", "home", new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), "sessionService", null, "WE GUARANTEE QUALITY" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedAt", "Description", "IsActive", "LanguageId", "MediaId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("16dccc90-3a21-4204-8251-6d663531030c"), new Guid("8a91040f-020b-4e1f-a972-06c4cb33c240"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), new Guid("352baa1c-3631-44da-834e-98892a85156f"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("1c28fe96-fb04-4457-8592-ba2edb390182"), new Guid("88cac7c0-9fb3-4b3e-8d6f-bfa579907779"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), new Guid("76274a0a-590d-4e10-99db-dde8c7e94e85"), "Global Recycled Standard (GRS)", null },
                    { new Guid("30a126ea-62d9-4449-b020-44a937dc81b7"), new Guid("b4cf7466-4f50-4678-a545-12149297b8cd"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), new Guid("3d671336-2e4a-4262-812b-add51e38fcb6"), "Global Recycled Standard (GRS)", null },
                    { new Guid("3e96232f-d321-4dd3-821b-f59f1ee32cf1"), new Guid("11894bcd-fd13-4ce6-b053-f766479dbef5"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), new Guid("33c6f5a3-5008-41e9-8e65-ee26d276d01d"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("427dcb7f-7a23-4b28-9219-4dec5f452f8c"), new Guid("b4cf7466-4f50-4678-a545-12149297b8cd"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), new Guid("d45b816f-ec3c-434c-90f8-8176674d6b21"), "Global Recycled Standard (GRS)", null },
                    { new Guid("48fe24be-895d-4d16-b4b8-bbe4b6607895"), new Guid("945276ee-ca0c-40d1-b386-63c5eebe2bb2"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), new Guid("b182db0b-3e14-4851-adfb-411e879abc9b"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("57210705-662e-47c1-b983-efd47181a1f1"), new Guid("b4cf7466-4f50-4678-a545-12149297b8cd"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), new Guid("b182db0b-3e14-4851-adfb-411e879abc9b"), "Global Recycled Standard (GRS)", null },
                    { new Guid("7b9c836f-1791-4381-acfd-8b7f7fa2054a"), new Guid("76150aee-a938-4172-b213-0304b9f95c39"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), new Guid("cbd1dbca-9de3-44d2-88db-0e80844b3ae2"), "Global Recycled Standard (GRS)", null },
                    { new Guid("7faf4fa4-7bf1-4aa2-a966-edcb758d70eb"), new Guid("8a91040f-020b-4e1f-a972-06c4cb33c240"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), new Guid("cbd1dbca-9de3-44d2-88db-0e80844b3ae2"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("a6827887-8853-4971-ba68-e82c1cbe2772"), new Guid("945276ee-ca0c-40d1-b386-63c5eebe2bb2"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), new Guid("d45b816f-ec3c-434c-90f8-8176674d6b21"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("bb0e61a1-a9f3-4ca3-add9-6b368f95d7e0"), new Guid("76150aee-a938-4172-b213-0304b9f95c39"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), new Guid("352baa1c-3631-44da-834e-98892a85156f"), "Global Recycled Standard (GRS)", null },
                    { new Guid("d12630fb-c5e3-4844-ada2-87b7be54cbf2"), new Guid("88cac7c0-9fb3-4b3e-8d6f-bfa579907779"), null, null, "<h3><strong>Aims</strong></h3>\n                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>\n                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>\n                <h3><strong>Scope</strong></h3>\n                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>\n                <h3><strong>Requirements</strong></h3>\n                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>\n                <ul>\n                    <li>Recycling</li>\n                    <li>Supply Chain</li>\n                    <li>Social</li>\n                    <li>Environmental</li>\n                    <li>Chemical</li>\n                </ul>", true, new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"), new Guid("33c6f5a3-5008-41e9-8e65-ee26d276d01d"), "Global Recycled Standard (GRS)", null },
                    { new Guid("e663aa1a-9113-4c5c-bf85-3e30b7987c9d"), new Guid("11894bcd-fd13-4ce6-b053-f766479dbef5"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), new Guid("76274a0a-590d-4e10-99db-dde8c7e94e85"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null },
                    { new Guid("f7058002-f332-4ed7-a6ed-d35baeb76fcb"), new Guid("945276ee-ca0c-40d1-b386-63c5eebe2bb2"), null, null, "<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>\n                <p><strong>Phạm vi</strong><br />\n                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>\n                <p><strong>Y&ecirc;u cầu</strong><br />\n                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />\n                T&aacute;i chế<br />\n                Chuỗi cung ứng<br />\n                X&atilde; hội<br />\n                Thuộc về m&ocirc;i trường<br />\n                H&oacute;a chất</p>", true, new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"), new Guid("3d671336-2e4a-4262-812b-add51e38fcb6"), "Tiêu chuẩn tái chế toàn cầu (GRS)", null }
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
                keyValue: new Guid("153019a7-b1da-4e82-8d09-2e7732996fac"));

            migrationBuilder.DeleteData(
                table: "dbbannerhomepage",
                keyColumn: "Id",
                keyValue: new Guid("5b57b3d8-8f70-4dbe-9d17-b2854ecfbab2"));

            migrationBuilder.DeleteData(
                table: "dbbannerhomepage",
                keyColumn: "Id",
                keyValue: new Guid("ca99628f-674c-4e93-ad8b-fc84a2a09dd1"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("60d549cb-d3d4-4b08-b3cd-01eedbbcf03e"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("72f8cd97-4260-4497-ae45-3b7c9ab8b5bb"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("9956785d-3be1-4701-9990-5936265a29f3"));

            migrationBuilder.DeleteData(
                table: "dbpagemetadata",
                keyColumn: "Id",
                keyValue: new Guid("a5cde2c5-08ed-4adb-b070-32ad43636cf2"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("61694b70-b096-44e2-8d8a-4e5a81e9af1f"));

            migrationBuilder.DeleteData(
                table: "dblanguage",
                keyColumn: "Id",
                keyValue: new Guid("9d8ec89e-1cc1-46eb-88e0-1d303f7a8a74"));

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
