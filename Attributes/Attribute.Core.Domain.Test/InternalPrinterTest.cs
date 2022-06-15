using Attribute.Domain.Models;
using Xunit; 
namespace Attribute.Core.Domain.Test
{
    public class InternalPrinterTest
    {
        /// <summary>
        /// چون از : 
        /// [assembly: InternalsVisibleTo("Attribute.Core.Domain.Test")]
        /// استفاده کردیم دیگه میتونه فایل های اینترنال رو هم ببینه
        /// </summary>
        [Fact]
        public void TestPrinter()
        { 
            InternalPrinter d = new InternalPrinter();
        }
    }
}
