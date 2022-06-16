using Attributes.CustomAttributes;
using System.Diagnostics;

namespace Attribute.Domain.Models
{
    [DebuggerDisplay("Person Name is : {FirstName}")]
    [DebuggerTypeProxy(typeof(PersonProxyAttribute))]
    [CodeChangeHistory("Arash Mehdipour", true, Description = "Add New Property whit Name...")]
    [CodeChangeHistory("Arash Mehdipour", false, Description = "Fix the bug...")]
    public class Person
    {
        [CodeChangeHistory("Arash Mehdipour", false, Description = "Use attribute in code for property...")]  
        public string FirstName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
