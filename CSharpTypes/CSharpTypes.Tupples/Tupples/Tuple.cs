namespace CSharpTypes.Tupples.Tupples
{
    #region Description
    /// <summary>
    /// تاپل ها این امکان رو به ما میدن که در لحظه یک تایپی رو ایجاد بکنیم با یک تعداد پراپرتی از استفاده بکنیم
    /// و بعد از اینکه کارمون تموم شد از بین بره و تایپ جدیدی ایجاد نکرده باشیم 
    /// </summary> 
    #endregion
    public class Tuple
    {
        #region Tuple
        public void TupleSample()
        {
            (int Id, string FirstName, string LastName) person = (1, "Arash", "Mehdipour");

            Console.WriteLine(person.Id);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }


        public (int Id, string FirstName, string LastName) ReturnTuple()
        {
            return (1, "Arash", "Mehdipour");
        }

        public void CallerReturnTuple()
        {
            var result = ReturnTuple();

            Console.WriteLine(result.Id);
            Console.WriteLine(result.FirstName);
            Console.WriteLine(result.LastName);
        }
        /// <summary>
        /// Tuple Deconstruction
        /// </summary>
        public void CallerReturnTupleDeconstruction()
        {
            (int Id, string FirstName, string LastName) = ReturnTuple();

            Console.WriteLine(Id);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);

        } 
        #endregion
    }
}
