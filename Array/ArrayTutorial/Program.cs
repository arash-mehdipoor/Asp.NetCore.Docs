using ArrayTutorial.BitArraySample;

#region comparable

person person1 = new person { firstname = "john", lastname = "smith", age = 21 };
person person2 = new person { firstname = "mark", lastname = "logan", age = 19 };
person person3 = new person { firstname = "luke", lastname = "adams", age = 20 };

person youngest = getyoungest(person1, person2, person3);
person oldest = getoldest(person1, person2, person3);

console.writeline("the youngest person is {0} {1}.",
    youngest.firstname, youngest.lastname);
console.writeline("the oldest person is {0} {1}.",
    oldest.firstname, oldest.lastname);
console.readkey();



static person getyoungest(person person1, person person2, person person3)
{
    person youngest = person1;

    if (person2.compareto(youngest) == -1)
        youngest = person2;

    if (person3.compareto(youngest) == -1)
        youngest = person3;

    return youngest;
}

static person getoldest(person person1, person person2, person person3)
{
    person oldest = person1;

    if (person2.compareto(oldest) == 1)
        oldest = person2;

    if (person3.compareto(oldest) == 1)
        oldest = person3;

    return oldest;
}

#endregion

#region hatvsrange
arrayclass arrayclass = new arrayclass();
arrayclass.hat();
arrayclass.range();
arrayclass.hatandrange();
#endregion

#region BitArray 
BitArrayExample bitArray = new();
bitArray.BitArrayMethod(); 
#endregion

Console.ReadKey();
