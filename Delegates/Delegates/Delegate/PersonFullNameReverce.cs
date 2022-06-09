namespace Delegates.Delegate
{
    public class PersonFullNameReverce
    {
        public static string GetPersonFullName(Person person) =>
            $"{person.LastName} - {person.FirstName}";
    }

    public class ForFunc
    {
        public static bool IsPersonFullName(int a) => true;
    }
}
