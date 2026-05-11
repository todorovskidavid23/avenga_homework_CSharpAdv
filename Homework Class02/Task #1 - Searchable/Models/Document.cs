using Task__1___Searchable.Interfaces;

namespace Task__1___Searchable.Models
{
    public class Document : ISearchable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Document(string title, string content)
        {
            Title = title;
            Content = content;
        }
        public bool Search(string word)
        { 
            string[] words = Content.ToLower().Split(' ');
            return words.Contains(word.ToLower());
        }
    }
}
