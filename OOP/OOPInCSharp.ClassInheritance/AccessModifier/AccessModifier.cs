namespace OOPInCSharp.ClassInheritance.AccessModifier
{
    #region Public
    /// <summary>
    /// Public :
    /// وقتی تابع یا کلاسی این طرح دسترسی رو داشته باشه یعنی همه میتونن ببینن و ازش استفاده کنند
    /// </summary>

    public class AccessModifierPublic
    {
        public void PrivateMethod()
        {
            Console.WriteLine(nameof(AccessModifierPrivate));
        }
    }
    #endregion

    #region Private
    /// <summary>
    /// Private :
    /// فقط در داخل کلاسی که تعریف شده قابل رویت هستش
    /// </summary>

    public class AccessModifierPrivate
    {
        private void PrivateMethod()
        {
            Console.WriteLine(nameof(AccessModifierPrivate));
        }
    }
    #endregion

    #region Protected
    /// <summary>
    /// Protected :
    /// فقط کلاس هایی که ازش ارث بری کردند میتونند تابعی که این سطح دسترسی رو داره ببینند
    /// </summary>
    public class AccessModifierProtected
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine(nameof(AccessModifierProtected));
        }
    }
    #endregion

    #region Internal
    /// <summary>
    /// Internal:
    /// این سطح دسترسی به فایل فیزیکی نگاه میکنه و کلاس هایی که در اون اسمبلی وجود داشته باشند میتونند
    /// ببین این متد رو
    /// </summary>
    public class AccessModifierInternal
    {
        internal void InternalMethod()
        {
            Console.WriteLine(nameof(AccessModifierInternal));
        }
    }
    #endregion

    #region ProtectedInternal
    /// <summary>
    /// ProtectedInternal:
    /// این سطح دسترسی ترکیبی از 
    /// Protected یا Internal
    /// است،ینی یا باید ازش ارث بری کنی تا ببینیش یا در اون اسمبلی باشی تا این متد رو ببینی
    /// </summary>
    public class AccessModifierProtectedInternal
    {
        internal void ProtectedInternalMethod()
        {
            Console.WriteLine(nameof(AccessModifierProtectedInternal));
        }
    }
    #endregion

    #region PrivateInternal
    /// <summary>
    /// PrivateInternal:
    /// این سطح دسترسی ترکیبی از 
    /// Private و Internal
    /// است،ینی هم باید ازش ارث بری کنی تا ببینیش  و هم در اون اسمبلی باشی تا این متد رو ببینی
    ///  این سطح دسترسی همون ترکیب 
    ///  Protected  Internal 
    ///  هستش و با این تفاوت که 
    ///  And هستش
    ///  اما در اون 
    ///  Or بودش
    /// </summary>
    public class AccessModifierPrivateInternal
    {
        internal void PrivateInternalMethod()
        {
            Console.WriteLine(nameof(AccessModifierPrivateInternal));
        }
    }
    #endregion

    #region New

    #endregion

    #region Static

    #endregion

    #region Virtual

    #endregion

    #region Abstract

    #endregion

    #region External

    #endregion

    #region Override

    #endregion

    #region Seald

    #endregion 
}
