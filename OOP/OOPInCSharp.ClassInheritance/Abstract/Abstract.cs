namespace OOPInCSharp.ClassInheritance.Abstract
{
    #region Description
    /// <summary>
    /// زمانی که ما نیاز داریم کلاس یا متدهایی داشته باشیم 
    /// که ساختار برای ما تعیین بکنند ولی خودشون قابل اینستنس سازی نباشد یا خودشون  پیشفرض پیاده سازی
    /// نداشته باشند،  و بقیه و مجبور میکنه که براش پیاده سازی داشته باشند
    /// تو این شرایط از 
    /// Abstract ها استفاده میکنیم
    /// </summary>
    #endregion
    public class Abstract
    {
        #region Abstract
        /// <summary>
        /// کلاس آبسترکت میتونه شامل متدهای عادی یا متدهای آبسترکت باشه
        /// و ساب کلاس ها حتما باید متد آبسترکت رو پیاده سازی بکنند
        /// از یک کلاس آبسترکت دیگه نمیتونیم نمونه سازی بکنیم، ولی میتونید به عنوان نوع متغیر در نظر بگیرید
        /// وهرنوعی که ازش ارث بری کرده داخلش بریزید
        /// </summary>
        public abstract class Animal
        {
            public virtual string Voice() => "voice in Animal";
            /// <summary>
            /// متدی که بصورت آبسترکت تعریف میشه دیگه نمیتونه پیاده سازی در جایی که تعریف شده داشته باشه،
            /// و همچنین در کلاس آبسترکت هم باید باشه
            /// </summary>
            public abstract void Feed();
        }

        public class Dog : Animal
        {
            public override void Feed()
            {
                throw new NotImplementedException();
            }

            public override string Voice() => "Hup";
        }

        public class Cat : Animal
        {
            public override void Feed()
            {
                throw new NotImplementedException();
            }

            public override string Voice()
            {
                base.Voice();
                return "Mio";
            }
        }

        public class Cow : Animal
        {
            public override void Feed()
            {
                throw new NotImplementedException();
            }
        } 
        #endregion
    }
}
