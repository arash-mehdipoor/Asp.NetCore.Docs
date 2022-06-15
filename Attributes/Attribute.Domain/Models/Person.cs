using System.Diagnostics;

namespace Attribute.Domain.Models
{
    [DebuggerDisplay("Person Name is : {FirstName}")]
    [DebuggerTypeProxy(typeof(PersonProxyAttribute))]
    public class Person
    {
        public string FirstName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
