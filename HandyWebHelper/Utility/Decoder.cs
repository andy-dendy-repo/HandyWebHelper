using System.Text;
using System.Web;

namespace HandyWebHelper.Utility
{
    public class Decoder
    {
        public static string UrlDecode(string input)
        {
            return HttpUtility.UrlDecode(input);
        }

        public static string Base64Decode(string input)
        {
            var base64EncodedBytes = Convert.FromBase64String(input);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string HtmlDecode(string input)
        {
            return HttpUtility.HtmlDecode(input);
        }
    }
}
