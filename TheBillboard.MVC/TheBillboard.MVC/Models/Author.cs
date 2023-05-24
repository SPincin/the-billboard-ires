namespace TheBillboard.MVC.Models
{
    public class Author
    {
       
        public int Id { get;}
    
        public string GivenName { get;}
        public string FamilyName { get;}

        public Author(int id,string givenName,string familyName)
        {
            Id = id;
            GivenName = givenName;
            FamilyName = familyName;
        }
    }
}

