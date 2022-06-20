
using System.Reflection;

#region LateBinding
var assembly = Assembly.LoadFrom(@"C:\Users\Arash\source\repos\arash-mehdipoor\Asp.NetCore.Docs\Attributes\Attribute.Domain\bin\Debug\net6.0\Attributes.Domain.dll");


var personType = assembly.GetType("Attribute.Domain.Models.Person");

/// <summary>
/// اصلی ترین متدی که توی لیت بایندیگ مورد استفاده قرار میگیره همین کلاس اکتیویتور هستش،برای نمونه سازی از تایپهای تو برنامم
/// </summary>
var person = Activator.CreateInstance(personType);

// بخشی از کد رو صدا میزنیم اینجا
var personMethod = personType.GetMethod("Print");

var prsonMethods = personType.GetMethods();

//foreach (var item in prsonMethods) { 
//    Console.WriteLine(item.Name);
//}
/// <summary>
/// برای بار اولی که متد پرینت رو به کلاس پرس اضافه میکنید و پروژه ی (در اینجا پروژه ی دامین) رو بیلد نمیکنید و بلافاصله هنگامی که بصورت لیت بایندیگ ازش استفاده میکنید 
/// با خطا روبه رو میشوید پس حواستون به این موضوع باشه که حتما پروژه رو بیلد کنید
/// </summary>
personMethod.Invoke(person, null); // Arash - Mehdipour



var inputPrinterMethod = personType.GetMethod("InputPrinter");
inputPrinterMethod.Invoke(person, new object[] { "This is input parameter" }); // my name is : This is input parameter 
#endregion

Console.WriteLine("Hello, World!");
