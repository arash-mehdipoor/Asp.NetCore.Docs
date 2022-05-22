﻿namespace CSharpTypes.RefInOut
{
    #region Description
    /// <summary>
    /// زمانی که ما یک متد رو کال میکنیم و به عنوان آرگومان ها یکی دوتا  متغیر رو ارسال میکنیم
    /// در حقیقت مقادیر داخل اون متغیر ها کپی میشن توی یک متغیر جدیدی و در اختیار متد ما قرار میگیرند
    /// ولی یه زمانایی هست که مانمیخوایم این مقادیر کپی بشن بلکه میخوایم رفرنسش ارسال بشه
    /// در واقع نمیخوایم یک متغیر جدید در حافظه ایجاد بکنیم بلکه میخوایم یک الیاس بگیریم از اون متغیر
    /// تو این شرایط میتونید از 
    /// Ref In Out 
    /// استفاده بکنیم
    /// </summary> 
    #endregion
    public class RefInOut
    {
        #region Ref
        /// <summary>
        /// Ref
        /// وقتی از رف استفاده میکنید حتما باید  متغیرتون رو قبل از ارسال مقداردهی بکنید
        /// و بعد از این که متغیر رو پاس بدید میتونه تغییرش بدید یا ندید، توی تابع جدید
        /// و اگر تغییر بکنه مقدار متغیر قبلی هم آپدیت میشه
        /// بخاطر اینکه مقدار تغییر کرده رو برمیگردونه
        /// چون هردوتاشون به یک خونه از حافظه اشاره میکنند
        /// </summary>
        public void Caller01()
        {
            //  اینجا یک خونه از حافظه گرفته شده توی استک ومقدار ده داخل ریخته شده
            int value = 10;

            Console.WriteLine(value);
            // وقتی اینجا مقدار رو ارسال میکنیم به تابع خودمون یه خونه دیگه از حافظه اشغال میشه و مقدار 10 داخلش ریخته میشه
            // اما ما نمیخوایم این اتفاق بیوفته و میخواهیم کماکان دسترسی داشته باشیم به خونه یک از حافظه
            // یکی از راهکار ها استفاده از کلمه کلیدی Ref هستش
            Callee01(ref value);
            Console.WriteLine(value);
        }

        public void Callee01(ref int input)
        {
            input++;
        }
        #endregion
        #region Out
        /// <summary>
        /// در اوت دیگه مجبور نیستیم متغیرمون رو مقداردهی اولیه بکنیم
        /// توی اوت عملا میخواهیم دوتا خروجی داشته باشیم
        /// میخوام مجبور بکنم کسی که پارامتر من رو دریافت کرده حتما مقدار این پارامتر رو عوض بکنه
        /// برای همین مجبور نیستم اینیشالایزش بکنم ولی وقتی میاد تو متد باید مقدارش رو تغییر بدیم
        /// </summary>
        public void Caller02()
        {
            //  اینجا یک خونه از حافظه گرفته شده توی استک ومقدار ده داخل ریخته شده
            int value = 10;

            Console.WriteLine(value);

            Callee02(out value);
            Console.WriteLine(value);
        }

        public void Callee02(out int input)
        {
            input = 3;
        }
        #endregion
        #region In
        /// <summary>
        /// کماکان داره رفرنس میبره با این تفاوت که دیگه اجازه تغییر دادن به ما نمیده
        /// </summary>
        public void Caller03()
        {
            //  اینجا یک خونه از حافظه گرفته شده توی استک ومقدار ده داخل ریخته شده
            int value = 10;

            Console.WriteLine(value);

            Callee03(in value);
            Console.WriteLine(value);
        }

        public void Callee03(in int input)
        {
            //input = 3;
        } 
        #endregion
    }
}