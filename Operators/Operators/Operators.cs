using Operators.Models;

namespace Operators
{
    public class OperatorsExample
    {
        #region CompoundOperators
        #region Description
        /// <summary>
        /// a++ : اول داخل عملیاتم ( چاپ توی کنسول ) شرکت میکنه بعد بهش اضافه میشه
        /// ++a : اول بهش اضافه میشه بعد داخل عملیاتم ( چاپ توی کنسول ) شرکت میکنه 
        /// </summary> 
        #endregion
        public void CompoundOperators()
        {
            int a = 0;

            Console.WriteLine(a++);

            Console.WriteLine(++a);
        }
        #endregion

        #region ConditionalExperssion
        public string ConditionalExperssion(int input)
        {
            return input == 0 ? "Zero" : "NotZero";
        }
        #endregion

        #region CheckedAnaUnchecked 
        #region Description
        /// <summary>
        /// بصورت پیشفرض توی دات نت سر ریز متغیرها چک نمیشه 
        /// مثلا بایت رو در نظر بگیرید در مسئله زیر بایت 255 تا هستش وقتی پلاس پلاسش میکنیم 255 پر میشه
        /// و میره از 1 شروع میشه سر ریز کرده،ریست میکنه  ولی من مطلع نمیشم چون چک کردن کار سنگینیه
        /// اینکه بخواد با ازای هر عملکردی که داریم چک بکنه ببینه این عملکرد  سرریزی اتفاق میوفته یا نه
        /// کار میتونه به شدت برای سیستم سخت و سنگین بکنه برای همین بصورت پیشفرض 
        /// unchecked هستش سرریز میکنه و لی
        /// من میتونم سیستم رو مجبور بکنم کار رو برای من چک بکنه
        /// و اگر سر ریز بکنه ارور System.OverflowException رو بهم میده
        /// </summary> 
        #endregion
        public void CheckedAnaUnchecked()
        {
            // کل بلاک رو چک میکنه
            checked
            {
                byte a = byte.MaxValue;
                a++;
                Console.WriteLine(a);
            }

            // فقط داخل چکد بررسی رو اناجم میده
            byte b = byte.MaxValue;
            b = checked(b++);
            Console.WriteLine(b);

            // میتونیم داخل فایل csproj مقدار :   
            //  <CheckForOverflowUnderflow>True</CheckForOverflowUnderflow>
            // قرار بدیم که باعث میشه توی کل پروژه این کار رو انجام بده که سربار بسیار بالایی داره
            // میتونیم بگیم یک قسمتی رو اصلا چک نکنه unchecked :

            byte d = byte.MaxValue;
            d = unchecked(d++);
            Console.WriteLine(d);
        }
        #endregion

        #region IsAndAs

        /// <summary>
        /// Is : 
        /// کلمه کلیدی ایز  چک میکنه ببینه متغیر ما از یک تایپی هست یا نه
        /// </summary>
        public void CheckIs(object input)
        {
            Console.WriteLine(input is Person);
        }
        /// <summary>
        /// As:
        /// میاد تلاش میکنه که تایپی که بهش دادیم رو تبدیل بکنه به یک تایپ دیگه 
        /// اگه بتونه انجام میده اگه نتونه نال برمیگردونه
        /// </summary>
        public void CheckAs(object input)
        {
            var person = input as Person;
            if (person != null)
            {
                Console.WriteLine("Is Person");
            }
            else
            {
                Console.WriteLine("Is Not Person");
            }
        }
        #endregion

        #region SizeOf
        /// <summary>
        /// بهمون میگه چند بایت حافظه رو اینها اشغال میکنند
        /// </summary>
        public void SizeOf()
        {
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(bool));
            Console.WriteLine(sizeof(long));
        }
        #endregion

        #region TypeOf
        /// <summary>
        /// یک تایپ رو از ما میگیره و متادیتاهای مخصوص به اون رو به ما میده
        /// یک تایپ دریافت میکنم عملا که یک عالمه متادیتا رو از اون نوع خاصی که بهش دادیم بهمون میده
        /// توی رفلکشن بشدت از این مورد استفاده میشه
        /// </summary>
        public void TypeOf()
        {
            var type = typeof(Person);
            Console.WriteLine(type.Assembly);
            Console.WriteLine(type.AssemblyQualifiedName);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.FullName);

            foreach (var item in type.GetProperties())
            {
                Console.WriteLine(item.Name);
            }
        }
        #endregion
    }
}
