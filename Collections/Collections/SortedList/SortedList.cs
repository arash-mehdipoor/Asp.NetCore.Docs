namespace Collections.SortedList
{
    #region Desscription
    /// <summary>
    /// ممکنه شرایطی پیش بیاد که ما بخوایم عناصرمون مرتب پشت هم قرار بگیرند  یک راه اینه که بریم یک لیست ایجاد بکنیم و بعد مرتبش کنیم
    /// راه دیگش اینه که مستقیم بریم سراغ لیستهای مرتب شده،سورتت لیست ترکیب کی و ولیو میگیره،مقدار و کلید رو دریافت میکنه از ما،و عناصر رو به ترتیب کلیدی که از ما دریافت میکنه
    /// مرتب میکنه،و کلیدمون حتما باید یکتا باشه،یعنی نمیتونیم برای یک کلید مقدارهای مختلفی قرار بدیم
    /// کلیدمون از هر نوعی میتونه باشه ولی باید قابلیت مرتب سازی داشته باشه،مثلا 
    /// IComparable, IComparer 
    /// در نهایت وقتی برامون ترتیب قرارگیری عناصر اهمیت داشته باشه و مرتب باشه از لینک لیست استفاده میکنیم
    /// </summary> 
    #endregion
    #region SortedList
    public class SortedListSample
    {
        SortedList<int, string> list = new SortedList<int, string>();

        public void Add(int key, string value)
        {
            list.Add(key, value);
        }
    } 
    #endregion
}
