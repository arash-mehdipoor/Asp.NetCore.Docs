

using System.Reflection;


#region AssemblyLoading
var assembly = Assembly.LoadFrom(@"C:\Users\Arash\source\repos\arash-mehdipoor\Asp.NetCore.Docs\Attributes\Attribute.Domain\bin\Debug\net6.0\Attributes.Domain.dll");

var types = assembly.GetTypes();
Console.WriteLine($"*********************{assembly.FullName}*********************");
foreach (var item in types)
{
    Console.WriteLine(item.Name);
    //EmbeddedAttribute
    //NullableAttribute
    //NullableContextAttribute
    //InternalPrinter
    //Person
    //PersonPrinter
    //PersonProxyAttribute

} 
#endregion

Console.WriteLine("Hello, World!");
