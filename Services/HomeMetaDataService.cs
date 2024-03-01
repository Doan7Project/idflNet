using idflNet.Constants;
using idflNet.Core.Models.Interfaces;
using idflNet.Core.Resutls;
using idflNet.Data;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class HomeMetaDataService
    {
        private readonly ApplicationDbContext _context;
        public HomeMetaDataService(ApplicationDbContext context)
        {
            _context = context;
        }

        public HomeMetaDataResult HomeMetaResult(IParams queryParams)
        {
            return new HomeMetaDataResult
            {
                SessionBanners = SessionBannerItems(queryParams),
                SessionServices = ServiceItems(queryParams),
                SessionServiceStandard = SessionServiceStandardItems(queryParams)
            };
        }
        public SessionServiceResult ServiceItems(IParams queryParams)
        {
            var data = _context.PageMetaData
            .Where(
            w => w.Key.Equals(HomePageMetaDataKey.Home)
            && w.Session.Equals(HomePageMetaDataSession.SessionService)
            && w.LanguageModel.Code == (queryParams.Language != null ? queryParams.Language : LanguageConstant.LangValue.vi.ToString())).ToList();
            string header = data.FirstOrDefault(s => s.Field.Equals(HomePageMetaDataField.Header)).Value;
            string subHeader = data.FirstOrDefault(s => s.Field.Equals(HomePageMetaDataField.SubHeader)).Value;
            return new SessionServiceResult
            {
                Header = header,
                SubHeader = subHeader
            };
        }
        public List<SessionBannerResult> SessionBannerItems(IParams queryParams){
            var data = _context.BannerHomePage.Select(s=> new SessionBannerResult{
                Url = s.Url
            }).ToList();
            return data; 
        }
        public List<SessionServiceStandardResult> SessionServiceStandardItems(IParams queryParams){
            var data = _context.Category.Include(c=>c.StandardModels)
            .Where(s=>s.LanguageModel.Code.Equals(queryParams.Language))
            .Select(s=> new SessionServiceStandardResult{
                Id = s.Id,
                Url = s.Thumbnail,
                Name = s.Name,
                Icons = s.StandardModels.Select(s=>s.MediaModel.Url).ToList()
            }).ToList();
            return data;
        }
    }
}