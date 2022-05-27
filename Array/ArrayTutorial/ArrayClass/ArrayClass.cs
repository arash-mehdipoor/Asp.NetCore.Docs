using System.Collections;

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

        #region Enumrator
        /// <summary>
        /// ما به دو روش میتونیم یک آرایه رو پیمایش کنیم یکی : فور و دیگی فورایچ،شما توی فور میدونید طول آرایه چقدره ولی توی فورایچ
        /// نمیدونید ،پس فور ایچ از کجا میدونه که باید از کجا شروع به پیمایش کنه و تا کجا ادامه بده،
        /// این کار رو با اینامریتورها انجام میده،
        /// با استفاده از  : MoveNext()
        /// که اگه ترو بده میفهمه که باید پیمایش کنه و مقدار فعلی هم داخل کارنت ریخته میشه
        /// </summary>
        public void Enumrator()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            var e = a.GetEnumerator();

            // تا زمانی که مو نکس ترو برگردونه مقدار فعلی در داخل کارنت قرار میگیره و توی کنسول چاپ میشه
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
        }
        #endregion

        #region RangeVsHat
        /// <summary>
        /// رنج و هت دوتا عملگر هستن که کمک میکنند که ما بتونیم با آرایه ها هم کار بکنیم
        /// هت : وقتی میخواهیم راجب هت بگیم باید بریم سراغ ایندکس : ایندکس برای ما چیکار میکرد؟ این امکان روفراهم میکرد که به اعضای یک آرایه به ترتیب
        /// دسترسی پیدا بکنیم از ابتدا تا انتها،هت میاد معکوسش میکنیه یعنی از انتها به ابتدا دسترسی پیدا میکنیم
        /// </summary>
        public void Hat()
        {
            int[] a = new[] { 1, 2, 3, 4 };
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[^1]);
            Console.WriteLine(a[^2]);
            Console.ReadKey();
        }

        public void Range()
        {
            int[] a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // در این مثال مقدار 0 اینکلسیو هستش یعنی مقدار ایندکس صفر هم جزش باشه ولی مقدار دوم که 4 هستش اکسکلوسیو هستش یعنی
            // چهار جزش نباشه و نمایش داده نشه
            // inclusive Vs exclusive

            var e = a[0..4]; // 1,2,3,4

            foreach (var item in e)
            {
                Console.WriteLine(item);
            }
        }

        public void HatAndRange()
        {
            int[] a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
            var e = a[^4..^1]; // 6,7,8

            foreach (var item in e)
            {
                Console.WriteLine(item);
            }
        }

        #endregion
    }
}
