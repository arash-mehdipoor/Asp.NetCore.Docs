using System.Collections;

namespace OOPInCSharp.ClassInheritance.Interface
{ 
    #region Description
    /// <summary>
    /// اینترفیس برای ما قرارداد ایجاد میکنه پیاده سازی نیست  
    /// توی سی شارپ بصورت پیشفرض نمیتونید شما 
    /// Multi Inheritance داشته باشید یعنی
    /// یک کلاستون از چند کلاس مختلف ارث بری کنه ولی شما میخواید که یک کلاسی داشته باشید که شباهتی به عنواع  کلاس مختلف داشته باشه
    /// برای همین بجای اینکه بیاید اونواعتون رو از کلاس بسازید
    /// میتونید از اینترفیس های مختلفی بسازی قراردادهای متفاوتی ایجاد بکنید وبا استفاده از اینترفیس ها میتونید 
    /// Dependency Injection و Dependency Inversion  برسید
    /// نکته اینکه تا قبل از سی شارپ 8 قابلیت پیاده سازی توی اینترفیس ها وجود نداشت اما از 8 به بعد این امکان فراهم شد
    /// و نکته بعدی اینترفیس ها در داخلشون استید وجود نداره
    /// تو نسخه های قدیمی سی شارپ امکان تعریف سطح دسترسی وجود نداشت
    /// </summary> 
    #endregion

    #region Interface
    public interface Interface1
    {
        public void Test();
        void Temp();
    }
    #endregion

    #region IDisposable
    /// <summary>
    /// وقتی از IDisposable استفاده میکنیم
    /// یک متد به ما میده به اسم 
    /// Dispose
    /// و به ما این قابلیت رو میده که تو زمان خاصی که میدونیم کی هست بتونیم 
    /// اون ریسورس هایی که مدیریت نشده ای که در اختیارمون هست رو آزاد بکنیم
    /// این اینترفیس همراه کلمه کلیدی Using توی سی شارپ
    /// معنی پیدا میکنه وقتی یوزینگ مینویسیم و تایپی که بهش میدیم با هم اینترفیس 
    /// IDisposabe رو ایمپلیمنت کرده باشه و 
    /// پشت صحنه یوزینگ وقتی کامپایل میشه تبدیل میشه به ترای کش فاینالی
    /// به اینصورت که در قسمت ترای میاد آبجکت رو اینستنسشو میسازه و در قسمت فاینالی میاد دیسپوز رو صدا میزنه
    /// </summary> 
    public class MyDisposable : IDisposable
    {

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region IEnumerable , IEnumerator
    /// <summary>
    /// به ما کمک میکنند که ما بیایم روی مجمومعه ای از اشیا لوپ بزنیم و گردش ایجاد بکنیم
    /// این اینترفیسها هم با کلمه کلیدی 
    /// Foreach
    /// تناظر دارند و فور ایچ ما روی تایپهایی توانایی گردش داره که 
    /// IEnumerable یا IEnumerator باشند
    /// و فور ایچمون بعد از ترجمه شدن تبدیل میشه به 
    /// do while
    /// و وایل داره این فور ایچمون رو اجرا میکنه 
    /// </summary>
    public class MyEnumrable : IEnumerable<MyEnumrable>
    {
        public IEnumerator<MyEnumrable> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region IComparable
    /// <summary>
    /// این امکان رو به ما میده که دوتا آبجکت رو با هم مقایسه بکنیم یعنی یک جنریک به ما میده که بهمون میگه
    /// چه تایپی باید به چه تایپی مقایسه بشه
    /// other
    ///  کلاس ورودیمه که میخوام کلاسم رو با اون مقایسه کنم
    ///  this
    ///  هم که کلاس جاریم هستش
    /// </summary>
    public class MyComparable : IComparable<MyComparable>
    { 
        public int CompareTo(MyComparable? other)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ExampleCode
    // using(MyDisposable testClassInterface = new MyDisposable()) { }
    #endregion
}

