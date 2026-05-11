using System.Text.RegularExpressions;
using Task__1___Searchable.Interfaces;

namespace Task__1___Searchable.Models
{
    public class WebPage : ISearchable
    {
        public string Url { get; set; }
        public string Html { get; set; }

        public WebPage(string url, string html)
        {
            Url = url;
            Html = html;
        }

        public bool Search(string word)
        {
            string cleanText = Regex.Replace(Html, "<.*?>", " ");

            string[] words = cleanText.ToLower().Split(' ');
            return words.Contains(word.ToLower());

        }

    }
}
