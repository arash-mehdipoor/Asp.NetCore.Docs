namespace GenericsSample.Generics
{
    #region Description
    /// <summary>
    /// میتونیم کلاسی داشته باشیم که جنریک نباشه ولی متدی داشته باشه که جنریک هستش و تمام
    /// مواردی که برای کلاس جنریک گفتیم برای این متد هم صدق میکنه
    /// </summary> 
    #endregion

    #region GenericMethod
    public class GenericMethod
    {
        public string Print<TInput>(TInput input)
        {
            return input.ToString();
        }
    } 
    #endregion
}
