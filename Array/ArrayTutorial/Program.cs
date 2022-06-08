using ArrayTutorial.ArrayClass;
using ArrayTutorial.BitArraySample;
using static ArrayTutorial.ArrayClass.ArrayClass;

#region comparable

Person person1 = new Person { FirstName  = "john", LastName = "smith", Age = 21 };
Person person2 = new Person { FirstName  = "mark", LastName = "logan", Age = 19 };
Person person3 = new Person { FirstName  = "luke", LastName = "adams", Age = 20 };

Person youngest = getyoungest(person1, person2, person3);
Person oldest = getoldest(person1, person2, person3);

Console.WriteLine("the youngest person is {0} {1}.",
    youngest.FirstName, youngest.LastName);
Console.WriteLine("the oldest person is {0} {1}.",
    oldest.FirstName, oldest.LastName);
Console.ReadKey();



static Person getyoungest(Person person1, Person person2, Person person3)
{
    Person youngest = person1;

    if (person2.CompareTo(youngest) == -1)
        youngest = person2;

    if (person3.CompareTo(youngest) == -1)
        youngest = person3;

    return youngest;
}

static Person getoldest(Person person1, Person person2, Person person3)
{
    Person oldest = person1;

    if (person2.CompareTo(oldest) == 1)
        oldest = person2;

    if (person3.CompareTo(oldest) == 1)
        oldest = person3;

    return oldest;
}

#endregion

#region hatvsrange
ArrayClass arrayclass = new ArrayClass();
arrayclass.Hat();
arrayclass.Range();
arrayclass.HatAndRange();
#endregion

#region BitArray 
BitArrayExample bitArray = new();
bitArray.BitArrayMethod(); 
#endregion

Console.ReadKey();
