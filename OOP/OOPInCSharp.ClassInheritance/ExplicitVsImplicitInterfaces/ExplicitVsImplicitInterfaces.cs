namespace OOPInCSharp.ClassInheritance.ExplicitVsImplicitInterfaces
{
    #region Description
    /// <summary>
    /// یک اینترنفیس رو میتونیم به دو روش مختلف پیاده سازی بکنیم  
    /// Explicit یا Implicit
    /// Implicit :  بصورت معمول
    /// یعنی یک اینترفیس رو اسمشو مینویسیم و پیاده سازیش رو انجام میدیم و متدهایی که پیاده سازی میکنیم ازش پابلیک هستن
    /// Explicit :
    /// یعنی موقع پیاده سازی سطح دسترسیش رو برمیداریم برای اینکه 
    /// Explicit
    /// پیاده سازی بشه اسم اینترفیس رو قبل از متدم قرار میدم مثل :
    /// interface.MethodName() {}
    /// ویژگی هاش :
    /// 
    /// </summary> 
    #endregion

    #region Implicit
    public interface ImplicitInterface
    {
        void Test();
        void Temp();
    }
    public class ImplicitInterfaceClass : ImplicitInterface
    {
        public void Temp()
        {
            Console.WriteLine("Temp");
        }

        public void Test()
        {
            Console.WriteLine("Test");
        }
    } 
    #endregion

    #region Explicit
    public interface ExplicitInterface
    {
        void Test();
        void Temp();
    }
    public class ExplicitInterfaceClass : ExplicitInterface
    {
        void ExplicitInterface.Temp()
        {
            Console.WriteLine("Temp");
        }

        void ExplicitInterface.Test()
        {
            Console.WriteLine("Test");
        }
    } 
    #endregion
}
