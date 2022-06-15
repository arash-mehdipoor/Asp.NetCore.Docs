




using Attribute.Domain.Models;

Person person = new Person()
{
    FirstName = "Arash",
    LastName = "Mehdipour",
    Age = 29
};

PersonPrinter printer = new PersonPrinter(person);
printer.Print();


Console.ReadKey();