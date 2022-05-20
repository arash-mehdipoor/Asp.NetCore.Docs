namespace OOPInCSharp.ClassInheritance.Inheritance
{
    #region Description
    /// <summary>
    /// بصورت پیشفرض تمامیه کلاس ها از آبجکت ارث بری کرده اند 
    /// و متد های 
    /// GetHashCode(); Tostring(); GetType();
    /// را از آبجکت به ارث برده اند
    /// با ارث بری  
    /// Behavior پدر را ارث بری میکند
    /// </summary> 
    #endregion
    public class Child : Parent
    {
        public string GetChildName() => nameof(Child);
    }
}
