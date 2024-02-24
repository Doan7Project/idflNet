using idflNet.Constants;
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

        public HomeMetaDataResult HomeMetaResult()
        {
            return new HomeMetaDataResult
            {
                SessionServiceResult = ServiceItems()
            };
        }
        public SessionServiceResult ServiceItems()
        {
            var data = _context.PageMetaData
            .Where(
            w=>w.Key.Equals(HomePageMetaDataKey.Home) 
            && w.Session.Equals(HomePageMetaDataSession.SessionService)
            && w.LanguageModel.Code == "en")
            .ToList();
            string header = data.FirstOrDefault(s=>s.Field.Equals(HomePageMetaDataField.Header)).Value;
            string subHeader = data.FirstOrDefault(s => s.Field.Equals(HomePageMetaDataField.SubHeader)).Value;
            return new SessionServiceResult{
                Header = header,
                SubHeader = subHeader
            };
        }
    }
}