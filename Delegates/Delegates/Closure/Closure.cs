﻿namespace Delegates.Closure
{
    #region Closure
    #region Description
    /// <summary>
    /// وقتی راجب به لامبدا اکسپرژنها و موارد اینچنینی صحبت میکنیم Cloure
    /// یک مفهومی هستش که باید حتما باهاش آشنایی داشته باشیم،وقتی شما یک لامبدا اکسپرژن تعریف میکنید یک  پرامتر ورودی میتونه داشته باشه و یک بادی میتونه داشته باشه
    /// اما لامبدا اکسپرژنتون همیشه توی یک متدی تعریف میشه در نتیجه به متغیر های داخل اون متدتون هم دسترسی داره و وقتی که دسترسی پیدا میکنه به این متغیر های سطح متدتون، با مفهوم کلوژر ما باید آشنا باشیم
    /// ببینید من یک متغیر رو دریافت میکنم از سطح متدم و کارم رو باهاش جلو میبرم اگر همون لحظه ای که متغیر رو بهش دسترسی پیدا کردم توی اکسپرژن متد بعدش دلیگیتم رو اجرا بکنم
    /// شاید هیچوقت متوجه تغییرات و اتفاقات نشم ولی چه مشکلی ممکنه اتفاق بیوفته، ممکنه من متغیرم رو تعریف بکنم بعد بیام لامبدا اکسپرژنم رو تعریف بکنم توش دسترسی به متغیر داشته باشم بعد چند خط کد وجود داشته باشه که مقدار متغیری که تو سطح
    /// متد هست و من داخل لامبدا بهش دسترسی پیدا کردم تغییر بکنه و بعد تازه من دلیگیتم رو اجرا بکنم حالا مقداری که داخل دلیگیتم بهش دسترسی پیدا میکنم چیه؟ قبل تغییر هستش یا بعد تغییر؟
    /// دقیقا مقداری که داخلش هست مقدار بعد تغییر هستش،چرا این اتفاق میوفته؟ چون تو پشت صحنه وقتی شما میاد یک لامبدایی مینویسید و دسترسی پیدا میکنید به یک متغیری تو سطح متد
    /// یک انونیموس کلاس درست میکنه دات نت و توی کانستراکتور این انونیموس کلاسی که درست میکنه به عنوان پرامتر ورودی مقدار مگیرهريا،مقدار متغیری که شما تو سطح متدتون داشتید حالا این ساختار کلاسمون
    /// کی اینتسنس میسازه از کلاس زمانی که شما میخواید اکزکیوتش بکنید یعنی کلاس رو میسازه  اونجا که اینتنس میسازه تازه میره سراغ کانستراکتورش و در اون لحظه هستش که مقدار اون متغیری
    /// که تو سطح متدتون تعریف کردید پاس داده میشه به  کانستراکتور اون کلاس،
    /// </summary> 
    #endregion
    public class Closure
    {

        public void ClosureMethod()
        {
            var localVariable = 1;

            Func<int, int> func = x =>
             {
                 return x + localVariable;
             };

            localVariable = 100;

            var result = func.Invoke(1);

            Console.WriteLine(result);
        }
    } 
    #endregion
}
