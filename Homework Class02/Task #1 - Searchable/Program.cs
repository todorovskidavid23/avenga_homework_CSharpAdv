using Task__1___Searchable.Models;

Document document = new Document("My first console app", "Welcome to my first console app");
Console.WriteLine(document.Search("welcome"));

WebPage web = new WebPage("https://avenga.com", "<h1>Welcome</h1><p>This webpage is Avenga Academy.</p>");
Console.WriteLine(web.Search("avenga"));