namespace idflNet.Core.Resutls
{
    public class HomeMetaDataResult
    {
        public SessionServiceResult SessionServiceResult { get; set; }
    }
    public class SessionServiceResult
    {
        public string? Header { get; set; }
        public string? SubHeader { get; set; }
    }
}