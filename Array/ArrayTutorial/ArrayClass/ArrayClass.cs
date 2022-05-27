namespace ArrayTutorial.ArrayClass
{
    /// <summary>
    /// تمام مواردی که تا به اینجا گفته شد  میاد در پشت صحنه از امکانات کلاس ارری استقاده میشه
    /// کلاسی که توی دات نت دولوپ شده بیس کلاس همه ی آرایه هاست و خیلی از امکاناتی که استفاده کردیم بخاطر وجود همین کلاس است
    /// مثلا تونستیم طول آرایه رو بگیریم  میتونستیم آرایه رو پیمایش بکنیم بخاطر گت اینامریتوری که داشت یا بحث رنک آرایه
    /// یک ارری کلاسی وجود داره که ابسترکت هستش و مامیتونیم ازش استفاده بکنیم که اینستنس آیایه هامون رو ایجاد بکنیم
    /// نکته مهم اینکه شما میتونید تایپش رو بهش پاس بدید،
    /// </summary>
    public class ArrayClass
    {
        #region ArrayClassSample 
        public void ArrayClassSample()
        {
            // مهمترین آورلودش اونیه که میتونید
            // lowerBunde رو تعیین بکنید که ایندکسش دیگه از صفر شروع نشه
            // خودتون تعیین بکنید که بگید هر بعدتون ایندکس شروعش از چه عدد باشه
            // CreateInstanceنمونه سازی با 
            var myArray = Array.CreateInstance(typeof(int), 3);

            // Set Value
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray.SetValue(i, i);
            }

            // Get Value
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray.GetValue(i));
            }
        }
        #endregion

        #region CopyArray
        public void CopyArray()
        {
            var myArray = Array.CreateInstance(typeof(int), 10);
            // شلو کپی اتفاق میوفته،یعنی اگر رفرنس تایپی داشته باشید مقدار آدرسش کپی میشه و با تغییر آرایه قبلی
            // آرایه جدید هم تغییر میکنه
            var myArrayCopy = myArray.Clone();

            int[] arr = new int[5];

            Array.Copy(myArray, arr, 10);
        }
        #endregion

        #region SortArray
        public void SortSample()
        {
            int[] myArray = new int[] { 10, 5, 2, 8, 9 };
            Array.Sort(myArray);
            foreach (var item in myArray)
            {
                Console.WriteLine(myArray);
            }
        }
        #endregion

        #region IComparable
        /// <summary>
        /// شما اگه بخواید آرایه ای داشته باشید که نوع دلخواه خودتون داره پیاده میکنه و بخواید از سورت کردنش استفاده بکنید
        /// کلاستون باید 
        /// IComparable
        /// رو پیاده سازی بکنه
        /// یا صفر برمیگردونه یا یک یا کوچیکتر از صفر
        /// اگر صفر برگردونه یعنی دوتاشون مساوی هستن،
        /// </summary>
        public class Person : IComparable<Person>
        {
            public int Id { get; set; }
            public int Age { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int CompareTo(Person? other)
            {
                if (this.Age > other.Age)
                    return 1;
                else if (this.Age < other.Age)
                    return -1;
                else
                    return 0;
            }
        }
        #endregion

        #region IComparer
        /// <summary>
        /// شما اگه از 
        /// Comparable
        /// استفاده بکنید همیشه با همون قاعده ای که بالا نوشتیم مقایسه انجام میشه ولی یه زمانهایی هست که شما میخواید طبق قواعد متفاوتی بتونید مرتب
        /// سازیتون رو انجام بدید تو این شرایط برای هر قاعده مرتب سازی که دارید میاید یک کلاس کامپرر ایجاد میکنید
        /// </summary>
        public class PersonComparerFirstName : IComparer<Person>
        {
            public int Compare(Person? x, Person? y)
            {
                throw new NotImplementedException();
            }
        }

        public class PersonComparerLastName : IComparer<Person>
        {
            public int Compare(Person? x, Person? y)
            {
                throw new NotImplementedException();
            }
        } 
        #endregion
    }
}
