namespace TheBillboard.MVC.Models
{
    public class Message
    {
        public int Id { get; init; }
        

        public string Title { get; init; }
        public string Body { get; init; }

        public Author Author { get; init;}


        public Message(int id,string title, string body, Author author)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
        }
    }


}
