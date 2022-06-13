namespace Collections.LinkedList
{
    #region Description
    /// <summary>
    /// یک ساختار داده ای است که داخل اجزاش صرفا تایپی که ما تعیین میکنیم نگهداری نمیشه  مثلا ما  یک لیست جنریک از جنس استرینگ نگهداری میکردیم
    /// داخل خونه های  حافظمون استرینگ نگهداری میشد اما توی لینک لیست اینطوری نیست 
    /// خودش یک ساختار دادست که هر نودش برای خودش یک معنای خاص داره و داخل لینک لیست اجزایی که نگهداری میشن از جنس لینک لیست نود هستن
    /// که عنصر قبلی و بعدی خودشون رو تعیین میکنند در نتیجه دیگه ما  مجبور نیستیم یک تعدادی خونه توی حافظه پشت سر هم بگیریم
    /// هرجایی میتونن این خونها باشن و هر نودی،نود قبلی و بعدی خودش رو تعیین میکنه
    /// </summary> 
    #endregion
    #region LinkedList
    public class LinkedListSample
    {
        LinkedList<string> list = new LinkedList<string>();

        public void Add(string input)
        {
            list.AddLast(input);

            // میاد پشت صحنه یک لین لیست نود میسازه از جنس استرینگ و ولیو رو با ولیویی که دادیم ست میکنه هر نود عنصر بعدی و قبلی خودش رو تعیین میکنه 
            LinkedListNode<string> node = new LinkedListNode<string>(input);

        }

        /// <summary>
        /// توی سرعت ثبت خیلی بهره ور میگیرید ولی توی جستجو ممکنه دچار دردسر بشید
        /// </summary>
        /// <param name="input"></param>
        public void AddSecondNode(string input)
        {
            var first = list.First;
            list.AddAfter(first, input);
        }
    } 
    #endregion
}
