namespace OOPInCSharp.ClassInheritance.Inheritance
{
    #region Description
    /// <summary>
    /// بصورت پیشفرض تمامیه کلاس ها از آبجکت ارٍ بری کرده اند 
    /// و متد های 
    /// GetHashCode(); Tostring(); GetType();
    /// را از آبجکت به ارث برده اند
    /// </summary> 
    #endregion
    public class Parent
    {
        public string GetParentName() => nameof(Parent);
    }
}
