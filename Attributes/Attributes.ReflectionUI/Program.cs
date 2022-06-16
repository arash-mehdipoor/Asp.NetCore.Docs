

using Attribute.Domain.Models;

#region GetType
Person person = new Person();


Type type01 = person.GetType();
bool d = type01.IsAbstract;
Console.WriteLine(type01.FullName);

Type type02 = typeof(Person);
Console.WriteLine(type02.FullName);

#region Description
/// <summary>
/// اگر مقدار throwOnError
/// برابر با ترو قرار بدیم اگر چیزی پیدا نکنه ارور میده ولی اگر فالس بدیم چیزی پیدا نکنه نال برمیگردونه
/// </summary> 
#endregion
Type type03 = Type.GetType("Attributes.ReflectionUI.Models.Teacher", throwOnError: true, ignoreCase: true);
Console.WriteLine(type03.FullName);


#region Description
/// <summary>
/// اگر به همین صورت کلاس پرسن رو بخوایم داشته باشیم ارور میده چون کلاس پرسن توی یک پروژه ی دیگه ایی هستش باید حتما 
/// AssemblyQualifiedName
/// رو هم بهش بدیم
/// </summary> 
#endregion
//Type type04 = Type.GetType("Attribute.Domain.Models.Person", throwOnError: true, ignoreCase: true);
Type type04 = Type.GetType("Attribute.Domain.Models.Person,Attributes.Domain", throwOnError: true, ignoreCase: true);
Console.WriteLine(type04.FullName);

#endregion

Console.WriteLine("Hello, World!");
