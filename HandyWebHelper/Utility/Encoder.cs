using System.Text;
using System.Web;

namespace HandyWebHelper.Utility
{
    public class Encoder
    {
        public static string UrlEncode(string input)
        {
            return HttpUtility.UrlEncode(input);
        }

        public static string Base64Encode(string input)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string HtmlEncode(string input)
        {
            return HttpUtility.HtmlEncode(input);
        }
    }
}
