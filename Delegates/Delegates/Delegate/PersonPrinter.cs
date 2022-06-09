namespace Delegates.Delegate
{
    public class PersonPrinter
    {
        public void Print(PersonTostring personTostring, Person person)
        {
            string text = personTostring.Invoke(person);
            Console.WriteLine(text);
        }

        public void PrintForFunc(Func<Person,string> personTostring, Person person)
        {
            string text = personTostring.Invoke(person);
            Console.WriteLine(text);
        }
    }
}
