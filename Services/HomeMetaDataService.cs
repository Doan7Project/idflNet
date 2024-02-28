using Core.Models;
using idflNet.Constants;
using idflNet.Core.Models.BaseModel;
using idflNet.Core.Resutls;
using idflNet.Data;

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
                SessionServices = ServiceItems(queryParams)
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
    }
}