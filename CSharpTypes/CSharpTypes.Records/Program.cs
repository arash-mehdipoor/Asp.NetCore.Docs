

using CSharpTypes.Classes.Records;

#region Records
PersonRecord personRecord01 = new()
{
    Id = 1,
    FirstName = "Arash",
    LastName = "Mehdipour"
};
PersonRecord personRecord02 = new()
{
    Id = 1,
    FirstName = "Arash",
    LastName = "Mehdipour"
};


PersonClass personClass01 = new()
{
    Id = 1,
    FirstName = "Arash",
    LastName = "Mehdipour"
};

PersonClass personClass02 = new()
{
    Id = 1,
    FirstName = "Arash",
    LastName = "Mehdipour"
};


Console.WriteLine($"{personRecord01}"); // PersonRecord { Id = 1, FirstName = Arash, LastName = Mehdipour }
Console.WriteLine($"{personClass01}"); // CSharpTypes.Classes.Records.PersonClass

Console.WriteLine($"{object.ReferenceEquals(personRecord01, personRecord02)}"); // False
Console.WriteLine($"{object.ReferenceEquals(personClass01, personClass02)}"); // False

/// <summary>
/// در رابطه با رکورد میره دونه دونه پراپرتی هاش رو چک میکنه
/// </summary>
Console.WriteLine($"{personRecord01 == personRecord02}"); // True

/// <summary>
/// در رابطه با کلاس میره رفرنس هاش رو چک میکنه
/// </summary>
Console.WriteLine($"{personClass01 == personClass02}"); // False 

/// <summary>
/// with
/// مقدار پرسن قبلی را کپی میکند و تنها آی دی را تغییر می دهد
/// </summary>
PersonRecordPrimary personRecordPrimary = new PersonRecordPrimary(1,"Arash","Mehdipour");
PersonRecordPrimary PersonRecordPrimary02 = personRecordPrimary with { Id = 2 };
#endregion


Console.WriteLine("Hello, World!");
Console.ReadKey();