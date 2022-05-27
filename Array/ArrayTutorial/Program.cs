



using ArrayTutorial.ArrayClass;
using static ArrayTutorial.ArrayClass.ArrayClass;

#region Comparable

Person person1 = new Person { FirstName = "John", LastName = "Smith", Age = 21 };
Person person2 = new Person { FirstName = "Mark", LastName = "Logan", Age = 19 };
Person person3 = new Person { FirstName = "Luke", LastName = "Adams", Age = 20 };

Person youngest = GetYoungest(person1, person2, person3);
Person oldest = GetOldest(person1, person2, person3);

Console.WriteLine("The youngest person is {0} {1}.",
    youngest.FirstName, youngest.LastName);
Console.WriteLine("The oldest person is {0} {1}.",
    oldest.FirstName, oldest.LastName);
Console.ReadKey();



static Person GetYoungest(Person person1, Person person2, Person person3)
{
    Person youngest = person1;

    if (person2.CompareTo(youngest) == -1)
        youngest = person2;

    if (person3.CompareTo(youngest) == -1)
        youngest = person3;

    return youngest;
}

static Person GetOldest(Person person1, Person person2, Person person3)
{
    Person oldest = person1;

    if (person2.CompareTo(oldest) == 1)
        oldest = person2;

    if (person3.CompareTo(oldest) == 1)
        oldest = person3;

    return oldest;
}

#endregion

#region HatvsRange
ArrayClass arrayClass = new ArrayClass();
arrayClass.Hat();
arrayClass.Range();
arrayClass.HatAndRange();
#endregion

Console.WriteLine("Hello, World!");
