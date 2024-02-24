using idflNet.Constants;
namespace Utils
{
    public class CheckExistFileUtils
    {
        internal static string CheckExistFile(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                string file = value.Replace(StaticPathFile.staticMetaPath, string.Empty);
                string pathFile = Path.Combine(StaticPathFile.staticPath, file);
                if (System.IO.File.Exists(pathFile))
                {
                    return value;
                }
            }
            // throw new ArgumentException(value + "was not exist");
            return "";
        }
    }
}