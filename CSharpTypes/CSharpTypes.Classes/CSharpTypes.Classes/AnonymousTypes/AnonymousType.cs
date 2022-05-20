namespace CSharpTypes.Classes.AnonymousTypes
{
    public class AnonymousType
    {
        #region AnonymousType
        /// <summary>
        /// گاهی اوقات نیازه من یک تایپی داشته باشم برای یک زمان کوتاه،و نمیخوام درگیر ایجاد 
        /// Dto بشم
        /// نکته اینکه 
        /// AnonymousType ها
        /// readonly
        /// هستند ینی فقط موقع اینیشیال کردن آبجکت مقداردهی می شوند و تمام
        /// درسته که بدون اینکه کلاسی وجود داشته باشه ساخته میشوند ولی واقعا یک کلاسی ساخته میشود
        /// براشون و این کلاس بی نام هستشو ارث بری از آبجکت اتفاق میوفته
        /// اگر آبجکتهای انونیموس تایپ مقادیرشون یکسان باشه پشت صحنه براشون یک کلاس بی نام ایجاد میشه
        /// نکته ی بعدی برای پر کردن پراپرتی های انونیموس تایپهامون میتونیم از یک کلاس دیگه ای هم استفاده کنیم
        /// </summary>
        public void AnonymousTypeMethod()
        {
            var teacher = new Teacher()
            {
                FirtsName = "ahmad",
                LastName = "mohamadi"
            };

            // استفاده از پراپرتی های teacher
            var teacherTow = new
            {
                teacher.FirtsName,
                teacher.LastName
            };

            // شیوه ایجاد انونیموس تایپها
            var student = new
            {
                FirstName = "Arash",
                LastName = "Memdipour"
            };
        } 
        #endregion
    }
}
