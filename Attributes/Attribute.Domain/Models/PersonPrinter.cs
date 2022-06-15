namespace Attribute.Domain.Models; 

public class PersonPrinter
{
    private readonly Person _person;

    public PersonPrinter(Person person)
    {
        _person = person;
    }

    public void Print()
    {
        PrintAge();
        PerintFullName();
    }

    private void PerintFullName()
    {
        Console.WriteLine($"FullName: {_person.FirstName}, {_person.LastName}");
    }

    #region DepricatedAttribute
    /// <summary>
    /// علامت گذاری میکنیم برای اینکه بگیم قراره بعدا پاک بشه،و جاهایی که ازش استفاده کردیم پیغام میده که داره از رده خارج میشه
    /// و توی وانینگها هم نشون میده،
    /// میتونیم پیام هم بنویسیم توش، و حتی متونیم خطا هم ترو بکنیم که هر کسی که اون بازه ی زمانی گفته شده از سمت ما 
    /// کد رو درست نکرد خطا ببینه
    /// </summary> 
    #endregion
    [Obsolete("message: Depricated Attribute")]
    //[Obsolete("message for depricate",error:true)]
    private void PrintAge()
    {
        Console.WriteLine($"Age: {_person.Age}");
    }
}

