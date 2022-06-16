using Attributes.CustomAttributes;
using System.Diagnostics;

namespace Attribute.Domain.Models;

//میتونیم موقع استفاد کلمه اتریبیوت رو پاک کنیم
// چون موقع تعریفش گفتیم در سطح اسملی پس اینجا ارور میده و باید در سطح اسمبلی فقط استفاده بشه
//[AutoScanForDependencyAttribute()]
//[AutoScanForDependency]
 public class PersonPrinter
{
    private readonly Person _person;

    public PersonPrinter(Person person)
    {
        _person = person;
    }

    public void Print()
    {
        ShowDebugData();
        PrintAge();
        PerintFullName();
    }

    #region Description
    /// <summary>
    /// فقط در حال دیباگ اجرا می شود،به حروف بزرگ هم حساسه،
    /// کاری که خود کامپایلر انجام میده اینه که،ببینید ممکنه جاهای مختلفی این کد نوشته شده باشه،و حالاکه ما بصورت
    /// کاندیشنالی حذف کردیمش، اونجاهارو هم پیدا میکنه و حذف میکنه،
    /// پس هم محل هایی که استفاده شده و هم خود تابع رو برای ما حرف میکنه،
    /// تنظیماتشم میتونید انجام بدید و یه مد دیگه ای براش بنویسید
    /// مسیر : Properies => Build => General => Conditinal compilation symbols
    /// </summary> 
    #endregion
    //[Conditional("DEBUG")]
    [Conditional("Arash")] // مسیر تنظیماتش هم توی دیسکریپشن بالا نوشته شده
    private void ShowDebugData()
    {
        Console.WriteLine("This application compile in debug mode");
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
    //[Obsolete("message: Depricated Attribute")]
    //[Obsolete("message for depricate",error:true)]
    private void PrintAge()
    {
        Console.WriteLine($"Age: {_person.Age}");
    }
}

