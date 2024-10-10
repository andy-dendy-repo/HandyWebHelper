using HtmlAgilityPack;
using Newtonsoft.Json;
using NUglify;
using NUglify.Css;
using System.Xml;

namespace HandyWebHelper.Utility
{
    public class Formatter
    {
        public static string FormatJson(string json)
        {
            var parsedJson = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.Indented);
        }

        public static string FormatXml(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter) { Formatting = System.Xml.Formatting.Indented };
            doc.WriteTo(xmlTextWriter);
            return stringWriter.ToString();
        }

        public static string FormatHtml(string html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            StringWriter writer = new StringWriter();
            doc.OptionWriteEmptyNodes = true;
            doc.Save(writer);
            return writer.ToString();
        }

        public static string FormatCss(string css)
        {
            // NUglify doesn't have a direct format method, but we can minify the CSS 
            // with readability flags turned off to produce a formatted output
            UglifyResult result = Uglify.Css(css, new CssSettings { OutputMode = OutputMode.MultipleLines });
            return result.Code;
        }
    }
}
