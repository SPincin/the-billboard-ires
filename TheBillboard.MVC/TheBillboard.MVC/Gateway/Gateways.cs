using TheBillboard.MVC.Models;

namespace TheBillboard.MVC.Gateway
{
    public class Gateways
    {
        private readonly IEnumerable<Message> _message = new List<Message>()
        { 
            new (1,"Title Message","Body del messaggio", new(1,"Given name","Family name")),
            new (2,"Title Message2","Body del messaggio2", new(2,"Given name2","Family name2")),
        };

        public IEnumerable<Message> GetData()
        {
            return _message;
        }

        public Message? GetById(int id)
        {
           return _message.SingleOrDefault(x => x.Id == id);
        }
    }
}
