﻿namespace GenericsSample.Generics
{
    #region Description
    /// <summary>
    /// خیلی وقتا توی روال برنامه نویسی که دارید انجام میدید یک کار ثابت رو میخواید انجام بدید روی دیتا
    /// تایپهای متفاوت فرایندتون ،چارچوبتون،فلوچارتتون یکسانه ولی با تایپهای مختلفی میخواید اینکار رو انجام
    /// بدید،مثل عملیاتهای کراد
    /// میخواد آپدیت ،اینسرت،دیلیت رو انجام بدید با یک ساختار مشخص،ولی با تایپهای متفاوت
    /// پرفورمنس ما زمانی که از جنریک ها استفاده میکنیم بسیار بیشتر از زمانی هستش که از آبجکت 
    /// استفاده میکنیم چون دقیقا دیتا تایپی که میخوایم ارسال میشه زمانی که از جنریک استفاده میکنیم :
    /// یک تایپی رو برای متدم مشخص میکنم که میگم این تایپه نا معلومه بعدا بهت پاس میدم و تو جنریک هستی
    /// هرتایپی رو میتونی دریافت بکنی تو لحظه ای که میخوام استفاده بکنم بهم میگه تایپ جنریک رو معلوم بکن
    /// حالا اتفاقی که میوفته اینه که زمان کد نویسی من یکبار کد مینویسم بعد از این هم که کامپایل میشه جنریکه
    /// ولی اون لحظه ای که جاستین تایمم میاد عمل بکنه دقیقا اون لحظه ای که قراره از سورس کدم استفاده بشه
    /// یک اتفاقی میوفته میبینه یه کلاس جنریکه که قبلا کامپایل شده و سورسش که موجوده
    /// حالا میاد یک کپی از این سورس کد میگیره وقتی میخواد تبدیلش بکنه به باینریش و یکبار کلاسم رو 
    /// واقعا با تایپ اینتیجر ایجاد میکنه مثلا، هر تایپی که بدم وقتی جاستین تایمم میاد کدم رو تبدیل بکنه به
    /// کد اجرایی واقعا کلاسهایی با تایپهایی که خواستیم ایجاد میشه
    /// اگر ده تا تایپ مختلف بهش بدید واقعا ده تا کلاس مختلف بهت میده،عوض اینکه همه ی این کلاس ها رو من ایجاد بکنم
    /// سیستم خودش این ایجاد کلاس ها رو به عهده میگیره،این باعث میشه پرفورمنس بهتری داشته باشم
    /// </summary>
    /// <typeparam name="Tinput"></typeparam> 
    #endregion

    #region Generic
    public class GenericsExample<Tinput>
    {
        public string GenericsConcat(Tinput input1, Tinput input2)
        {
            var value1 = input1.ToString();
            var value2 = input2.ToString();

            return $"{value1} - {value2}";
        }
    } 
    #endregion
}
