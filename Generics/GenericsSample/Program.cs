




using GenericsSample.Generics;
using GenericsSample.Models;

#region GenericsSample
GenericsExample<int> genericsInt = new();
Console.WriteLine(genericsInt.GenericsConcat(1, 2));


GenericsExample<string> genericsString = new();
Console.WriteLine(genericsString.GenericsConcat("Arash", "Mehadipour"));

GenericsExample<Person> genericsperson = new();

Console.WriteLine(genericsperson.GenericsConcat(
    new Person() { FirstName = "PersonName1", LastName = "PersonLastName1" },
    new Person() { FirstName = "PersonName2", LastName = "PersonLastName2" }
    ));

#endregion

#region StaticMember
StaticMember<int>.Counter = 10;
StaticMember<string>.Counter = 12;
StaticMember<bool>.Counter = 15;

Console.WriteLine(StaticMember<int>.Counter); // 10
Console.WriteLine(StaticMember<string>.Counter); // 12
Console.WriteLine(StaticMember<bool>.Counter); // 15
#endregion

Console.WriteLine("Hello, World!");
