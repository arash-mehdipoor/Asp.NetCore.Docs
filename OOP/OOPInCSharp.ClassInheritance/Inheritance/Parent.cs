namespace OOPInCSharp.ClassInheritance.Inheritance
{
    #region Description
    /// <summary>
    /// بصورت پیشفرض تمامیه کلاس ها از آبجکت ارٍ بری کرده اند 
    /// و متد های 
    /// GetHashCode(); Tostring(); GetType();
    /// را از آبجکت به ارث برده اند
    /// حواستون باشه یک رکورد نمیتونه از یک کلاس به ارث ببره و بلعکس
    /// با اینکه هنگام کامپایل به هم تبدیل میشن اما امکان ارث بری از هم رو ندارند
    /// </summary> 
    #endregion
    public class Parent
    {
        public string GetParentName() => nameof(Parent);
    }
}
