using GenericsSample.Models;

namespace GenericsSample.Generics
{
    #region Description
    /// <summary>
    /// ممکنه زمانی پیش بیاد شما بخواید یک کار رو برای یک تایپ خاصی یا یک گروه خاصی انجام بدید
    /// واگر تایپ دیگه ای پاس بدید سورس کدتون دچار مشکل میشه
    /// تو این شرایط ما از کانسترینت ها استفاده میکنیم برای اینکه بتونیم یکسری محدودیت ایجاد بکنیم
    /// محدودیت برای دیتا تایپهایی که امکان ارسال برای جنریکمون دارن و اگه ارسال بشن باعث بوجود اومدن خطا
    /// میشیم
    /// </summary>
    /// <typeparam name="TInput"></typeparam>

    #endregion

    #region Class
    public class GenericConstraint1<TInput> where TInput : class
    {
    } 
    #endregion

    #region PersonType
    public class GenericConstraint2<TInput> where TInput : Person
    {
        public string GetString(TInput input)
        {
            return $"{input.FirstName} - {input.LastName}";
        }
    } 
    #endregion

    #region Struct
    public class GenericConstraint3<TInput> where TInput : struct
    {
    } 
    #endregion

    #region New
    #region Description
    /// <summary>
    /// وقتی از new 
    /// استفاده میکنیم یعنی حتما باید تایپون یک کانستراکتور پیشفرض داشته باشه
    /// برای زمانی که میخوایم از تایپمون یک شی بسازیم
    /// </summary>
    /// <typeparam name="TInput"></typeparam> 
    #endregion
    public class GenericConstraint4<TInput> where TInput : class, new()
    {
        TInput input = new TInput();
    }
    #endregion

    #region ITestInterFace  
    public class GenericConstraint5<TInput> where TInput : ITestInterFace
    {
        
    }
    #endregion

    #region TInput1:TInput2  
    public class GenericConstraint5<TInput1,TInput2> where TInput1:TInput2
    {

    }
    #endregion

}
