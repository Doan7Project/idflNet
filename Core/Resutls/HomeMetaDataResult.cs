namespace idflNet.Core.Resutls
{
    public class HomeMetaDataResult
    {
        public List<SessionBannerResult> SessionBanners { get; set; }
        public SessionServiceResult SessionServices { get; set; }
    }
    public class SessionBannerResult{
        public string? Url { get; set; }
    }
    public class SessionServiceResult
    {
        public string? Header { get; set; }
        public string? SubHeader { get; set; }
    }
}