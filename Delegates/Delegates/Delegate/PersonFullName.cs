namespace Delegates.Delegate
{
    public class PersonFullName
    {
        public static string GetPersonFullName(Person person) =>
            $"{person.FirstName} - {person.LastName}";
    }
}
