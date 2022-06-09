namespace Delegates.Delegate
{
    #region Description
    /// <summary>
    /// دیلیگیتهای قراردادهایی هستن که  ما برای عملکرد متدهامون مینویسیم،جاهای مختلفی هم توی دات نت کاربرد دارن،توی ایونت کاررد دارن،توی لینک کاربرد دارند توی تسک بیس پروگرمینگ کاربرد دارد
    /// </summary> 
    #endregion
    #region Delegate
    public delegate string PersonTostring(Person person);

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    } 
    #endregion
}
