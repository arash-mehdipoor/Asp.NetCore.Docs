﻿namespace Asp.NetCore.Description
{
    #region Description
    /// <summary>
    /// HttpResponse:
    /// در نتیجه درخواست کاربر ساخته میشه،باز دوباره توی این کلاس یکسری اطلاعات بصورت ثابت وجود داره
    /// ContentLenght: طول کانتنتی که دارم برمیگردونم  چقدره، ،چه حجمی از بایتها رو باید دریافت بکنه
    /// ContentType: json,Xml,Text,exel,video
    /// Cookies:کوکی هایی که میخوام بنویسم توی ریسپانس مینویسم
    /// HasStarted:
    /// ببینید ریکوئست که به دست ما میرسه ما به ازاش یک ریسپانسی باید برگرده به کلاینت تا زمانی که شروع  نشده این ریسپانس برگرده این مورد فالس هستش،وقتی فالسه میتونیم 
    /// استتوس کد عوض بکنیم میتونیم هدرهارو تغییر بدیم،یا هرکار دیگه ای،اما اگه ترو شد دیگه نمیتونم استتوس کد رو تغییر بدم،دیگه ریسپانس رو شروع کردم برگردوندن برای کاربر
    /// Headers:
    /// خب ریسپانس هم مث ریکوئست دو قسمتی هستش هدر داره و بادی، که توی هدرش دومرتبه یک عالمه متا دیتا نگهداری میشه مث تایتلی که توی صفحاتمون میبینیم
    /// StatusCode:
    /// استتوس کدها پنج تا خانواده دارن :
    /// خانواده ی یک رزرو شدست
    /// 200: کار به درستی انجام شده حالا 200 هستش 201 یا 204
    /// 300: خانواده ی این نوع استتوس کدها میگه،ریدایرکشن باید اتفاق بیوفته، یعنی وقتی میره ریسپانس ما روی دستگاه کاربر،دوباره باید یه درخواستی ما به ازاش ارسال بشه
    /// که برای یک وب سرور دیگه ای که ریدایرکت بشه
    /// 400: میگه یه خطایی از طرف کاربر اتفاق افتاده
    /// 500: میگه یه خطای روی سرور اتفاق افتاده
    /// WriteAsync:به ما امکان این رو میده که ما توی ریسپان متنی رو بنویسیم
    /// Redirect: اگر بخوایم بجای اینکه رو سایت ما بمونه بفرستیمش به یک سایت دیگه میتونیم از امکان ریدایرکت استفاده کنیم
    /// </summary> 
    #endregion
    public class HttpResponse
    {

    }

}
