




using GenericsSample.Generics;

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


Console.WriteLine("Hello, World!");
