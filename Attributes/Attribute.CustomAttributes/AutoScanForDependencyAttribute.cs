namespace Attributes.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public class AutoScanForDependencyAttribute:Attribute
    {

    }

    #region Description
    /// <summary>
    /// Inherited : یعنی وقتی کلاسی از یک کلاس دیگه ارث بری بکنه بتونه اتریبیوت رو هم به ارث بره یا نه،که در این مثال جواب نه هستش
    /// </summary> 
    #endregion
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Class,AllowMultiple =true,Inherited = false)]
    public class CodeChangeHistoryAttribute : Attribute
    {
        private readonly string author;
 
        public string Description{ get; set; }
        public DateTime ChangeDateTime { get; set; }
        public bool IsBug { get; set; }

        public CodeChangeHistoryAttribute(string author,bool isBug= false)
        {
            this.author = author;
            this.IsBug = isBug;
        }
    }
}