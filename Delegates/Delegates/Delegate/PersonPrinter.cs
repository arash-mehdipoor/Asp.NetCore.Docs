namespace Delegates.Delegate
{
    public class PersonPrinter
    {
        public void Print(PersonTostring personTostring, Person person)
        {
            string text = personTostring.Invoke(person);
            Console.WriteLine(text);
        }
    }
}
