namespace Attribute.Domain.Models
{
    public class PersonProxyAttribute 
    {
        private readonly Person person;

        public PersonProxyAttribute(Person person)
        {
            this.person = person;
        }

        public string FullName => $"{person.FirstName}, {person.LastName}";
        public int Age => person.Age;
    }
}