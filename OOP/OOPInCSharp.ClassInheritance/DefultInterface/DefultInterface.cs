namespace OOPInCSharp.ClassInheritance.DefultInterface
{
    #region Description
    /// <summary>
    /// در سی شارپ 8 میتونیم پیاده سازی برای قرارداد هامون داشته باشیم
    /// قبل از این مورد اگر امضای جدیدی اضافه میکردیم تمام کلاس هایی که این اینترفیس رو پیاده سازی کرده
    /// بودند باید این متد جدید رو برای خودشون پیاده میکردند اگر اینکارو انجام نمیدادند به ارور میخوردند
    /// اما در سی شارپ 8 میتونیم یک پیاده سازی پیفرض داشته باشیم که دچار ارور نشویم و هرکسی که 
    /// از متدمون استفاده کنه و براش پیاده سازی نداشته باشه به ارور میخوره
    /// </summary> 
    #endregion

    #region DefultInterface
    public interface ILog
    {
        void Test();
        public void Log(string message) => throw new NotImplementedException();
    }

    public class DefultInterface : ILog
    {
        public void Test()
        {
            throw new NotImplementedException();
        }
    } 
    #endregion
}
