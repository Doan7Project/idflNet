using Core.Models;
using idflNet.Constants;
using idflNet.Core.Models;
using Microsoft.EntityFrameworkCore;
using Utils;

namespace idflNet.Data
{
    public class DataGenerator
    {
        public static void Run(ModelBuilder modelBuilder)
        {
            var LanguageVi = new LanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "Tiếng việt",
                Code = "vi",
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            var LanguageEn = new LanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "English",
                Code = "en",
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            modelBuilder
            .Entity<LanguageModel>()
            .HasData(new List<LanguageModel> { LanguageVi, LanguageEn });
            var HomeMetaSessionServiceHeaderVi = new PageMetaDataModel
            {
                Id = Guid.NewGuid(),
                Key = HomePageMetaDataKey.Home,
                Session = HomePageMetaDataSession.SessionService,
                Field = HomePageMetaDataField.Header,
                Value = "CHÚNG TÔI ĐẢM BẢO CHẤT LƯỢNG",
                LanguageId = LanguageVi.Id,
                CreatedAt = DateTime.Now
            };
            var HomeMetaSessionServiceHeaderEn = new PageMetaDataModel
            {
                Id = Guid.NewGuid(),
                Key = HomePageMetaDataKey.Home,
                Session = HomePageMetaDataSession.SessionService,
                Field = HomePageMetaDataField.Header,
                Value = "WE GUARANTEE QUALITY",
                LanguageId = LanguageEn.Id,
                CreatedAt = DateTime.Now
            };
            var HomeMetaSessionServiceSubHeaderVi = new PageMetaDataModel
            {
                Id = Guid.NewGuid(),
                Key = HomePageMetaDataKey.Home,
                Session = HomePageMetaDataSession.SessionService,
                Field = HomePageMetaDataField.SubHeader,
                Value = "DFL tiến hành kiểm tra tại chỗ và xem xét tài liệu để xác minh khả năng truy xuất nguồn gốc của nhà cung cấp và các yếu tố xã hội, hóa học, môi trường và phúc lợi động vật. Nhấp vào bên dưới để tìm hiểu chi tiết về từng chứng nhận kiểm toán do IDFL cung cấp.",
                LanguageId = LanguageVi.Id,
                CreatedAt = DateTime.Now
            };
            var HomeMetaSessionServiceSubHeaderEn = new PageMetaDataModel
            {
                Id = Guid.NewGuid(),
                Key = HomePageMetaDataKey.Home,
                Session = HomePageMetaDataSession.SessionService,
                Field = HomePageMetaDataField.SubHeader,
                Value = "DFL conducts on-site audits, and documentation reviews to verify supplier traceability and social, chemical, environmental and animal welfare. Click below to learn details about each of the audit certifications offered by IDFL.",
                LanguageId = LanguageEn.Id,
                CreatedAt = DateTime.Now
            };
            modelBuilder
            .Entity<PageMetaDataModel>()
            .HasData(new List<PageMetaDataModel>
            {
                HomeMetaSessionServiceHeaderVi,
                HomeMetaSessionServiceHeaderEn,
                HomeMetaSessionServiceSubHeaderVi,
                HomeMetaSessionServiceSubHeaderEn
            });
            var banner_1 = new BannerHomePageModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/banner_1.jpg"),
                CreatedAt = DateTime.Now,
            };
            var banner_2 = new BannerHomePageModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/banner_2.jpg"),
                CreatedAt = DateTime.Now,
            };
            var banner_3 = new BannerHomePageModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/banner_3.jpg"),
                CreatedAt = DateTime.Now,
            };
            modelBuilder
            .Entity<BannerHomePageModel>()
            .HasData(new List<BannerHomePageModel>
            {
                banner_1,
                banner_2,
                banner_3
            });
            var category_1_Vi = new CategoryModel
            {
                Id = Guid.NewGuid(),
                Name = "TIÊU CHUẨN TÁI CHẾ TOÀN CẦU",
                Description = "",
                Thumbnail = CheckExistFileUtils.CheckExistFile("/uploads/default/category_1.jpg"),
                LanguageId = LanguageVi.Id,
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            var category_1_En = new CategoryModel
            {
                Id = Guid.NewGuid(),
                Name = "GLOBAL RECYLED STANDARD",
                Description = "",
                Thumbnail = CheckExistFileUtils.CheckExistFile("/uploads/default/category_1.jpg"),
                LanguageId = LanguageEn.Id,
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            var category_2_Vi = new CategoryModel
            {
                Id = Guid.NewGuid(),
                Name = "TIÊU CHUẨN DỆT HỮU CƠ TOÀN CẦU",
                Description = "",
                Thumbnail = CheckExistFileUtils.CheckExistFile("/uploads/default/category_2.jpg"),
                LanguageId = LanguageVi.Id,
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            var category_2_En = new CategoryModel
            {
                Id = Guid.NewGuid(),
                Name = "GLOBAL ORGANIC TEXTILE STANDARD",
                Description = "",
                Thumbnail = CheckExistFileUtils.CheckExistFile("/uploads/default/category_2.png"),
                LanguageId = LanguageEn.Id,
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            var category_3_Vi = new CategoryModel
            {
                Id = Guid.NewGuid(),
                Name = "TIÊU CHUẨN LEN CÓ TRÁCH NHIỆM",
                Description = "",
                Thumbnail = CheckExistFileUtils.CheckExistFile("/uploads/default/category_3.jpg"),
                LanguageId = LanguageVi.Id,
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            var category_3_En = new CategoryModel
            {
                Id = Guid.NewGuid(),
                Name = "RESPONSIBLE WOOL STANDARD",
                Description = "",
                Thumbnail = CheckExistFileUtils.CheckExistFile("/uploads/default/category_3.png"),
                LanguageId = LanguageEn.Id,
                IsActive = true,
                CreatedAt = DateTime.Now
            };
            modelBuilder
            .Entity<CategoryModel>()
            .HasData(new List<CategoryModel>
            {
                category_1_En, category_1_Vi,category_2_Vi,category_2_En,category_3_En,category_3_Vi
            });
            var icon_1 = new MediaModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/icon_1.png"),
                CreatedAt = DateTime.Now
            };
            var icon_2 = new MediaModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/icon_2.png"),
                CreatedAt = DateTime.Now
            };
            var icon_3 = new MediaModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/icon_3.png"),
                CreatedAt = DateTime.Now
            };
            var icon_4 = new MediaModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/icon_4.png"),
                CreatedAt = DateTime.Now
            };
            var icon_5 = new MediaModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/icon_5.png"),
                CreatedAt = DateTime.Now
            };
            var icon_6 = new MediaModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/icon_6.png"),
                CreatedAt = DateTime.Now
            };
            var icon_7 = new MediaModel
            {
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/uploads/default/icon_7.png"),
                CreatedAt = DateTime.Now
            };
            modelBuilder
            .Entity<MediaModel>()
            .HasData(new List<MediaModel>
            {
               icon_1, icon_2, icon_3, icon_4, icon_5, icon_6,icon_7
            });
            var standard_1_Vi = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Tiêu chuẩn tái chế toàn cầu (GRS)",
                Description = @"<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>
                <p><strong>Phạm vi</strong><br />
                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>
                <p><strong>Y&ecirc;u cầu</strong><br />
                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />
                T&aacute;i chế<br />
                Chuỗi cung ứng<br />
                X&atilde; hội<br />
                Thuộc về m&ocirc;i trường<br />
                H&oacute;a chất</p>",
                LanguageId = LanguageVi.Id,
                CategoryId = category_1_Vi.Id,
                MediaId = icon_1.Id,
                IsActive = true,

            };
            var standard_1_En = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Global Recycled Standard (GRS)",
                Description = @"<h3><strong>Aims</strong></h3>
                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>
                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>
                <h3><strong>Scope</strong></h3>
                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>
                <h3><strong>Requirements</strong></h3>
                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>
                <ul>
                    <li>Recycling</li>
                    <li>Supply Chain</li>
                    <li>Social</li>
                    <li>Environmental</li>
                    <li>Chemical</li>
                </ul>",
                LanguageId = LanguageVi.Id,
                CategoryId = category_1_En.Id,
                MediaId = icon_1.Id,
                IsActive = true,

            };
            var standard_2_Vi = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Tiêu chuẩn tái chế toàn cầu (GRS)",
                Description = @"<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>
                <p><strong>Phạm vi</strong><br />
                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>
                <p><strong>Y&ecirc;u cầu</strong><br />
                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />
                T&aacute;i chế<br />
                Chuỗi cung ứng<br />
                X&atilde; hội<br />
                Thuộc về m&ocirc;i trường<br />
                H&oacute;a chất</p>",
                LanguageId = LanguageVi.Id,
                CategoryId = category_1_Vi.Id,
                MediaId = icon_2.Id,
                IsActive = true,

            };
            var standard_2_En = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Global Recycled Standard (GRS)",
                Description = @"<h3><strong>Aims</strong></h3>
                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>
                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>
                <h3><strong>Scope</strong></h3>
                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>
                <h3><strong>Requirements</strong></h3>
                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>
                <ul>
                    <li>Recycling</li>
                    <li>Supply Chain</li>
                    <li>Social</li>
                    <li>Environmental</li>
                    <li>Chemical</li>
                </ul>",
                LanguageId = LanguageVi.Id,
                CategoryId = category_1_En.Id,
                MediaId = icon_2.Id,
                IsActive = true,

            };
            var standard_3_Vi = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Tiêu chuẩn tái chế toàn cầu (GRS)",
                Description = @"<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>
                <p><strong>Phạm vi</strong><br />
                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>
                <p><strong>Y&ecirc;u cầu</strong><br />
                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />
                T&aacute;i chế<br />
                Chuỗi cung ứng<br />
                X&atilde; hội<br />
                Thuộc về m&ocirc;i trường<br />
                H&oacute;a chất</p>",
                LanguageId = LanguageVi.Id,
                CategoryId = category_2_Vi.Id,
                MediaId = icon_3.Id,
                IsActive = true,

            };
            var standard_3_En = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Global Recycled Standard (GRS)",
                Description = @"<h3><strong>Aims</strong></h3>
                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>
                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>
                <h3><strong>Scope</strong></h3>
                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>
                <h3><strong>Requirements</strong></h3>
                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>
                <ul>
                    <li>Recycling</li>
                    <li>Supply Chain</li>
                    <li>Social</li>
                    <li>Environmental</li>
                    <li>Chemical</li>
                </ul>",
                LanguageId = LanguageEn.Id,
                CategoryId = category_2_En.Id,
                MediaId = icon_3.Id,
                IsActive = true,

            };
            var standard_4_Vi = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Tiêu chuẩn tái chế toàn cầu (GRS)",
                Description = @"<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>
                <p><strong>Phạm vi</strong><br />
                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>
                <p><strong>Y&ecirc;u cầu</strong><br />
                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />
                T&aacute;i chế<br />
                Chuỗi cung ứng<br />
                X&atilde; hội<br />
                Thuộc về m&ocirc;i trường<br />
                H&oacute;a chất</p>",
                LanguageId = LanguageVi.Id,
                CategoryId = category_2_Vi.Id,
                MediaId = icon_4.Id,
                IsActive = true,

            };
            var standard_4_En = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Global Recycled Standard (GRS)",
                Description = @"<h3><strong>Aims</strong></h3>
                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>
                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>
                <h3><strong>Scope</strong></h3>
                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>
                <h3><strong>Requirements</strong></h3>
                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>
                <ul>
                    <li>Recycling</li>
                    <li>Supply Chain</li>
                    <li>Social</li>
                    <li>Environmental</li>
                    <li>Chemical</li>
                </ul>",
                LanguageId = LanguageEn.Id,
                CategoryId = category_2_En.Id,
                MediaId = icon_4.Id,
                IsActive = true,

            };
            var standard_5_Vi = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Tiêu chuẩn tái chế toàn cầu (GRS)",
                Description = @"<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>
                <p><strong>Phạm vi</strong><br />
                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>
                <p><strong>Y&ecirc;u cầu</strong><br />
                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />
                T&aacute;i chế<br />
                Chuỗi cung ứng<br />
                X&atilde; hội<br />
                Thuộc về m&ocirc;i trường<br />
                H&oacute;a chất</p>",
                LanguageId = LanguageVi.Id,
                CategoryId = category_3_Vi.Id,
                MediaId = icon_5.Id,
                IsActive = true,

            };
            var standard_5_En = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Global Recycled Standard (GRS)",
                Description = @"<h3><strong>Aims</strong></h3>
                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>
                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>
                <h3><strong>Scope</strong></h3>
                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>
                <h3><strong>Requirements</strong></h3>
                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>
                <ul>
                    <li>Recycling</li>
                    <li>Supply Chain</li>
                    <li>Social</li>
                    <li>Environmental</li>
                    <li>Chemical</li>
                </ul>",
                LanguageId = LanguageEn.Id,
                CategoryId = category_3_En.Id,
                MediaId = icon_5.Id,
                IsActive = true,

            };
            var standard_6_Vi = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Tiêu chuẩn tái chế toàn cầu (GRS)",
                Description = @"<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>
                <p><strong>Phạm vi</strong><br />
                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>
                <p><strong>Y&ecirc;u cầu</strong><br />
                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />
                T&aacute;i chế<br />
                Chuỗi cung ứng<br />
                X&atilde; hội<br />
                Thuộc về m&ocirc;i trường<br />
                H&oacute;a chất</p>",
                LanguageId = LanguageVi.Id,
                CategoryId = category_3_Vi.Id,
                MediaId = icon_6.Id,
                IsActive = true,

            };
            var standard_6_En = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Global Recycled Standard (GRS)",
                Description = @"<h3><strong>Aims</strong></h3>
                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>
                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>
                <h3><strong>Scope</strong></h3>
                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>
                <h3><strong>Requirements</strong></h3>
                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>
                <ul>
                    <li>Recycling</li>
                    <li>Supply Chain</li>
                    <li>Social</li>
                    <li>Environmental</li>
                    <li>Chemical</li>
                </ul>",
                LanguageId = LanguageEn.Id,
                CategoryId = category_3_En.Id,
                MediaId = icon_6.Id,
                IsActive = true,

            };
            var standard_7_Vi = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Tiêu chuẩn tái chế toàn cầu (GRS)",
                Description = @"<p>Ti&ecirc;u chuẩn c&oacute; s&aacute;u mục ti&ecirc;u: (1) điều chỉnh c&aacute;c định nghĩa về &quot;t&aacute;i chế&quot; tr&ecirc;n nhiều ứng dụng, (2) theo d&otilde;i v&agrave; truy t&igrave;m nguy&ecirc;n liệu đầu v&agrave;o được t&aacute;i chế, (3) cung cấp cho kh&aacute;ch h&agrave;ng c&ocirc;ng cụ để đưa ra quyết định s&aacute;ng suốt, (4) giảm t&aacute;c động c&oacute; hại của sản xuất dựa tr&ecirc;n con người v&agrave; m&ocirc;i trường, (5) đảm bảo rằng vật liệu trong sản phẩm cuối c&ugrave;ng được t&aacute;i chế v&agrave; xử l&yacute; bền vững v&agrave; (6) th&uacute;c đẩy đổi mới trong việc giải quyết c&aacute;c vấn đề chất lượng li&ecirc;n quan đến việc sử dụng vật liệu t&aacute;i chế.</p>
                <p><strong>Phạm vi</strong><br />
                Người nộp đơn c&oacute; thể chọn loại vật liệu t&aacute;i chế m&agrave; họ muốn kiểm to&aacute;n. C&aacute;c vật liệu t&aacute;i chế phổ biến bao gồm l&ocirc;ng tơ v&agrave; l&ocirc;ng vũ, PET, d&acirc;y t&oacute;c, sợi/chỉ v&agrave; vải. C&aacute;c c&ocirc;ng ty đăng k&yacute;, chẳng hạn như c&aacute;c thương hiệu v&agrave; nh&agrave; sản xuất, c&oacute; thể chọn sản phẩm cuối c&ugrave;ng m&agrave; họ muốn đ&aacute;nh gi&aacute;. Một danh s&aacute;ch đầy đủ c&aacute;c sản phẩm v&agrave; danh mục sản phẩm c&oacute; thể được t&igrave;m thấy ở đ&acirc;y.</p>
                <p><strong>Y&ecirc;u cầu</strong><br />
                C&aacute;c vật liệu v&agrave; sản phẩm được lựa chọn sẽ được đ&aacute;nh gi&aacute; dựa tr&ecirc;n y&ecirc;u cầu trong c&aacute;c lĩnh vực sau:<br />
                T&aacute;i chế<br />
                Chuỗi cung ứng<br />
                X&atilde; hội<br />
                Thuộc về m&ocirc;i trường<br />
                H&oacute;a chất</p>",
                LanguageId = LanguageVi.Id,
                CategoryId = category_3_Vi.Id,
                MediaId = icon_7.Id,
                IsActive = true,

            };
            var standard_7_En = new StandardModel
            {
                Id = Guid.NewGuid(),
                Name = "Global Recycled Standard (GRS)",
                Description = @"<h3><strong>Aims</strong></h3>
                <p>The aim of the Global Recycled Standard (GRS) is to increase the use of recycled materials.</p>
                <p>The Standard has six objectives: (1) aligning definitions of &quot;recycled&quot; across multiple applications, (2) tracking and tracing recycled input materials, (3) providing customers with a tool to make informed decisions, (4) reducing the harmful impact of production on people and the environment, (5) providing assurance that materials in a final product are recycled and processed sustainably and (6) driving innovation in addressing quality issues related to the use of recycled materials.</p>
                <h3><strong>Scope</strong></h3>
                <p>Applicants may choose the types of recycled materials they want to have audited. Common recycled materials include down and feathers, PET, filament, yarn/thread and fabric. Applicant companies, such as brands and manufacturers, may select the final products they would like to have audited. A complete list of products and product categories can be found&nbsp;<a href='https://idfl.com/textile-exchange-te-mapping-product-categories-and-product-details/'>here</a>.</p>
                <h3><strong>Requirements</strong></h3>
                <p>The selected materials and products will be evaluated based upon requirements in the following areas:</p>
                <ul>
                    <li>Recycling</li>
                    <li>Supply Chain</li>
                    <li>Social</li>
                    <li>Environmental</li>
                    <li>Chemical</li>
                </ul>",
                LanguageId = LanguageEn.Id,
                CategoryId = category_3_En.Id,
                MediaId = icon_7.Id,
                IsActive = true,

            };
            modelBuilder
            .Entity<StandardModel>()
            .HasData(new List<StandardModel>
            {
               standard_1_Vi,standard_1_En, standard_2_Vi,standard_2_En, standard_3_Vi,standard_3_En
               ,standard_4_Vi, standard_4_En,standard_5_Vi,standard_5_En,standard_6_Vi,standard_6_En,standard_7_Vi,standard_7_En
            });
        }
    }
}