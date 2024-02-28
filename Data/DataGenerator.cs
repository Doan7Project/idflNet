using Core.Models;
using idflNet.Constants;
using idflNet.Core.Models.BaseModel;
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
            var banner_1 = new BannerHomePageModel{
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/images/default/banner_1.jpg"),
                CreatedAt = DateTime.Now,
            };
            var banner_2 = new BannerHomePageModel{
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/images/default/banner_2.jpg"),
                CreatedAt = DateTime.Now,
            };
            var banner_3 = new BannerHomePageModel{
                Id = Guid.NewGuid(),
                Url = CheckExistFileUtils.CheckExistFile("/images/default/banner_3.jpg"),
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
        }
    }
}