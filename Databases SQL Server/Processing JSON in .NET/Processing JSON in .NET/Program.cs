
namespace Processing_JSON_in.NET
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml;

    public class Program
    {
        static void Main(string[] args)
        {
            var webClient = new WebClient();
            var data = webClient.DownloadData("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw");
            var xml = Encoding.UTF8.GetString(data);

            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
            var jsonObj = JObject.Parse(json);
            var titles = GetVideosTitles(jsonObj);
            PrintTitles(titles);

            var videos = GetVideos(jsonObj);
            var html = GetHtmlString(videos);
            SaveHtml(html, "index.html");
        }

        public static IEnumerable<JToken> GetVideosTitles(JObject jsonObj)
        {
           var titles = jsonObj["feed"]["entry"]
                .Select(entry => entry["title"]);
            return titles;
        }

        public static void PrintTitles(IEnumerable<JToken> titles)
        {
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }

        public static IEnumerable<Video> GetVideos(JObject json)
        {
            var videos = json["feed"]["entry"]
                .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));

            return videos;
        }

        public static string GetHtmlString(IEnumerable<Video> videos)
        {
            StringBuilder html = new StringBuilder();

            html.Append("<!DOCTYPE html><html><body>");
            foreach (var video in videos)
            {
                html.AppendFormat("<div style=\"float:left; width: 420px; height: 450px; padding:10px; " +
                                  "margin:5px; background-color:green;\">" +
                                  "<iframe width=\"420\" height=\"345\" " +
                                  "src=\"http://www.youtube.com/embed/{1}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  "<h3>{2}</h3><a href=\"{0}\">Go to YouTube</a></div>",
                                  video.Link.Href, video.Id, video.Title);
            }
            html.Append("</body></html>");

            return html.ToString();
        }

        public static void SaveHtml(string html, string htmlName)
        {
            using (StreamWriter writer = new StreamWriter("../../" + htmlName, false, Encoding.UTF8))
            {
                writer.Write(html);
            }

            var currentDir = Directory.GetCurrentDirectory();
            var htmlDir = currentDir.Substring(0, currentDir.IndexOf("bin\\Debug")) + htmlName;

            Console.WriteLine("Html dir: {0}", htmlDir);
        }
    }
}
