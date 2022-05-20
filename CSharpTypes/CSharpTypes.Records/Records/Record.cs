#region Description
/// <summary>
///  در C# 9 معرفی شد
///  وقتی هدفمون بیشتر نگه داشتن دیتا هستش و نمیخوایم تغییر بکنند
///  وقتی 
///  Tostring()
///  مینویسیم اطلاعات داخل کلاس بهمون داده میشه نه اسم کلاس یا..
///  رکورد پشت صحنه همون کلاسه
///  equlity چک کردن
///  بطور پیشفرض داخل رکورد پیاده سازی شده است
///  برای تعریف رکورد دوتا سینتکس مختلف معرفی کرد مایکروسافت
///  1- Standard Propery  یا Nominal Record
///  2- Primary Construction یا  Positional Record
///  توضیح Nominal Record : 
///  دراین روش ساختار تعریف کردن رکورد دقیقا شبیه به کلاس است ولی بجای اسم کلاس
///  مینویسیم رکورد
/// </summary>

#endregion
namespace CSharpTypes.Classes.Records
{ 
    #region Record

    /// <summary>
    /// Nominal Record
    /// </summary>
    public record PersonRecord
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    /// <summary>
    /// Primary Construction
    /// به این نکته توجه کنید که بصورت 
    /// init Only
    /// تعریف میشوند
    /// در این رکورد ما از کلمه  ی کلیدی  with هم میتوانی استفاده کنیم
    /// </summary>
    public record PersonRecordPrimary(int Id, string firstName, string lastName);
    public record PersonRecordPrimary2(int Id, string firstName, string lastName)
    {
        public string GetFullName()
        {
            return $"{firstName} - {lastName}";
        }
    };

    public class PersonClass
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    } 
    #endregion
}
