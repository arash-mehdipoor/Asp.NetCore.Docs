namespace ErrorHandling.UserDefinedException
{
    #region Description
    /// <summary>
    /// خطای سفارشی سازی شده :
    /// یه زمانی ممکنه من به عنوان توسعه دهنده بخوام خطایی داشته باشم که خودم ایجادشکردم و یکسری اطلاعات اضافه بهش بچسبونم
    /// و نمیخوام از خطای پیشفرض استفاده بکنم تو این شرایط میرم سراع 
    /// CustomException
    /// </summary> 
    #endregion
    public class UserDefinedException : Exception
    {
        public DateOnly DateOnly { get; set; }
        public TimeOnly MyTime { get; set; }
    }
}
