﻿namespace ArrayTutorial
{
    #region Description
    /// <summary>
    /// آرایه های ساده یا یک بعدی ساده ترین نوع آرایه هایی هستند که ما میتونیم تعریف بکنیم وتوی سی شارپ ازشون استفاده بکنیم
    /// نکات :
    /// ایندکسر توی آرایه ها فقط و فقط اینتیجر هستش تایپ دیگه ای نمیپذیره،
    /// نکته بعدی وقتی که رفرنس تایپ تعریف میکنیم متغیر آرایمون توی استک نگهداری میشه و یک اشاره گر ایجاد میکنه به هیپ
    /// و توی هیپ باز دومرتبه چیزی که تعریف میشه داخل آرایه باز آدرس خود کلاس قرار میگیره یعنی خود کلاس داخل آرایه نمیاد داخلش آدرسی ایجاد میشه که 
    /// خودش اشاره میکنه به اونجایی که کلاسمون قرار داره 
    /// پس روی استک من آرایمو تعریف میکنم روی هیپ وقتی به آرایم مقداردهی میکنم روی هیپ رفرنسی به یک جای دیگه ای ایجاد میشه که اون جایی دیگه تازه  خود
    /// متغیرم رو نگهداری میکنه
    /// پس یادتون باشه اگه میخواید با یک خونه از آرایتون کار کنید که داخلش قراره رفرنس تایپ نگهداری کنید حتما باید مقدار اون خونه رو نیو 
    /// کرده باشید و یک مقداری داخلش ریخته باشید که نال نباشه
    /// </summary> 
    #endregion

    #region ArraySimple
    public class ArraySimple
    {
        // یک متغیر از جنس آرایه ایجاد شده که میتونه داخل خودش 10 تا اینتیجر نگهداری کنه
        int[] a = new int[5];

        // این آرایه طولش 5 تایی هستش و کلا توی آرایه طول تغییر نمیکنه اما اگر میخواهید مجموعه ایی داشته باشید که طولش تغییر بکنه
        // باید برید سراغ کالکشنها
        // طول این آرایه رو از روی تعدادی که نوشتم استنتاج میکنه
        int[] b = new int[] { 1, 2, 3, 4, 5 };

        int[] c = { 1, 2, 3, 4, 5 };

        /// <summary>
        /// به کمک ایندکسر میتونیم به اعضای یک آرایه دسترسی داشته باشیم،نکته مهم اینکه ایندکس آرایه ها از صفر شروع میشوند
        /// </summary>
        public void AccessArray()
        {
            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
            Console.WriteLine(b[0]);

            // با توجه به بیس کلاسی که گفتیم و با 
            // enumrator , enumrable
            // که داره این پیمایش رو انجام میده
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }
    } 
    #endregion
}