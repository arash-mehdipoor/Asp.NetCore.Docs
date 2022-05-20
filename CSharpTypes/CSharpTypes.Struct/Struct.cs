
#region Description
/// <summary>
/// استراکچر ها دیتاتایپهایی هستن که وقتی ازشون متغیر تعریف میکنیم توی 
/// stack نگهداری میشوند
/// وقتی توی استک نگهداری میشوند ینی سربار خیلی کمتری دارند با حافظه 
/// و مثل رفرنس تایپها اول نمیرن تو استک بعدش برن تو هیپ
/// سربار کمتری داره و ما میتونیم پرفورمنس  بهتری بگیریم ازش
/// نکته : حافظه استک نسبت به حافظه هیپ محدودیت داره و کمه و اگر استارکتمون بزرگ باشه حافظه به سرعت پر میشه
/// زمانهایی که اندازه آبجکت ها کوچیکه ،مقدارشون برامون مهمه و تعداد خیلی بالایی قرار نیست ازشون ایجاد بکنیم
/// میریم سراغ استراکتها
/// محدویت ها :
/// ما برای استراکت ها نمیتوانیم کانستراکتور پیشفرض تعریف کنیم البته قبل از سی شارپ ده
/// در سی شارپ ده میتونیم دیفالت کانستراکتور داشته باشیم اما تمام پراپرتی هارو باید مقدار دهی اولیه بکنیم
/// محدودیت بعدی نمیتونید ارث بری داشته باشید
/// نه ارث میبره نه میشه ازش ارث برد
/// استراکت ها finalizer هم نمیتونن داشته باشند
/// </summary>

#endregion

namespace CSharpTypes.Struct
{
    #region ForceReadonly
    /// <summary>
    /// اگر بخواهیم استراکت مارو فورس بکنه به اینکه اعضا رو بصورت 
    /// readonly تعریف بکنیم
    /// قبل کلمه کلیدی استراکت کلمه کلیدی readonly
    /// رو اضافه میکنیم
    /// </summary> 
    public readonly struct Struct01
    {
        public readonly int age;
        public int Id { get; }
        public string FirstName { get; init; }
        public string LastName { get; }
    } 
    #endregion
    #region ReadonlyMember
    /// <summary>
    /// امکانی که تو سی شارپ هشت اضافه شد اینه که 
    /// میتونیم اعضایی  رو تعریف کنیم که readonly هستن
    /// و داخلشون اجازه نداریم فیلدی یا پراپرتی رو تغییر بدیم
    /// </summary>
    public struct Struct02
    {
        public int age;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public readonly string GetFullName()
        {
            // error
            //Id++;
            return FirstName + " " + LastName;
        }
    } 
    #endregion
    #region StructRecord
    /// <summary>
    /// در سی شارپ ده این امکان ایجاد شد که استراکتهایی از نوع رکورد ایجاد کنید
    /// و در اینصورت استراکت ما باز ولیو تایپ است
    /// </summary>
    /// <param name="id"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    public record struct StructRecord(int Id, string FirstName, string LastName); 
    #endregion
}
