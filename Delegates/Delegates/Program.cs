

using Delegates.Delegate;

#region Delegate
PersonPrinter personPrinter = new();
Person person = new() { FirstName = "Arash", LastName = "Mehdipour" };

personPrinter.Print(PersonFullName.GetPersonFullName, person); // Arash - Mehdipour
personPrinter.Print(PersonFullNameReverce.GetPersonFullName, person);  // Mehdipour - Arash 
#endregion

#region Variable
/// <summary>
/// حواستون باشه ناید پرانتر باز و بسته بزارید چون نمیخویم اگزکیوت بشه فقط متغیرش رو ایحاد میکنیم بعدش با ساتفاده از کلمه کلیدی 
/// Invoke صداش میزنیم
/// </summary>
PersonTostring myDelegate = PersonFullName.GetPersonFullName;
var result = myDelegate.Invoke(person);
Console.WriteLine(result);
#endregion

#region Func
PersonPrinter personPrinter02 = new();
personPrinter02.PrintForFunc(PersonFullName.GetPersonFullName, person); 
#endregion

Console.WriteLine("Hello, World!");
