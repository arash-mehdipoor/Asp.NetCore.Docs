namespace GenericsSample.Generics
{
    #region Description
    /// <summary>
    /// متغیر استاتیک بعد از اینکه تایپ کلاسمون تعیین شد مقداردهی می شود
    /// به این صورت هر تایپی برای خودش مقدار خاص خودشو داره
    /// </summary>
    /// <typeparam name="T"></typeparam> 
    #endregion
    public class StaticMember<T>
    {
        public static int Counter;
    }
}
