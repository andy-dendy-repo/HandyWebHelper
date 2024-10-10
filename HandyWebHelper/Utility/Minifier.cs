using Newtonsoft.Json;
using NUglify;
using System.Xml;

namespace HandyWebHelper.Utility
{
    public class Minifier
    {
        public static string MinifyJson(string json)
        {
            var parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.None);
        }

        public static string MinifyXml(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter) { Formatting = System.Xml.Formatting.None };
            doc.WriteTo(xmlTextWriter);
            return stringWriter.ToString();
        }

        public static string MinifyHtml(string html)
        {
            UglifyResult result = Uglify.Html(html);
            return result.Code;
        }

        public static string MinifyCss(string css)
        {
            UglifyResult result = Uglify.Css(css);
            return result.Code;
        }
    }
}
