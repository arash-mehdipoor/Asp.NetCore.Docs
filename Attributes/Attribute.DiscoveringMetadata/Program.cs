using Attribute.DiscoveringMetadata;
using Attribute.Domain.Models;

MetaDataPrinter printer01 = new MetaDataPrinter(typeof(int));
printer01.Print();


MetaDataPrinter printer02 = new MetaDataPrinter(typeof(Person));
printer02.Print();

Console.WriteLine("Hello, World!");
