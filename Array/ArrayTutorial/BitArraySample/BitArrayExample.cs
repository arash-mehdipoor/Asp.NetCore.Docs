using System.Collections;

namespace ArrayTutorial.BitArraySample
{
    public class BitArrayExample
    {
        #region Description
        /// <summary>
        ///  اگر بخواهیم آرایه ای از بیتها داشته باشیم از چه دیتا تایپی میتونیم استفاده بکنیم؟ بیت یا صفر هستش یا یک ما تنها دیتا تایپی که میتونه این حالت
        ///  رو برای ما پشتیبانی بکنه بولین هستش، که میتونیم یه آرایه از بولین ایجاد بکنیم ولی یک مشکلی هست اینجا،مشکل اینه که آرایه بولین اگه تعریف بکنم یعنی اینکه یک بایت
        ///  به ازای هر بیت که میخوام اشغال بکنم هدر میره،برای همین دات نت یه کلاسی به اسم بیت ارری به ما داده که واقعا به ازای هر یک بیت واقعا یک بیت توی حافظه برای ما اشغال میکنه
        ///  پشت صحنه آرایه ای از اینتیجر ها برای ما نگهداری میکنه به ازای هر 32 بیتی که ما میخوایم یک اینتیجر به آرایه ی خودش اضافه میکنه و بیت های اینتیجر رو کم و زیاد میکنه که در نهایت بتونه
        ///  آرایه بیتی مارو بهمون تحویل بده،کلی هم امکانات داره برای خوندن نوشتن ،اند ایکس اور
        ///   
        /// </summary> 
        #endregion
        #region BitArray
        public void BitArrayMethod()
        {
            BitArray bitAray = new(4);
            bitAray.SetAll(true);
            bitAray[0] = false;


            BitArray bitAray02 = new(4);
            bitAray02.SetAll(true);


            //bitAray.And(bitAray02);
            //bitAray.Or(bitAray02);
            bitAray.Xor(bitAray02);

            foreach (var item in bitAray)
            {
                Console.WriteLine(item);
            }
        } 
        #endregion
    }
}
