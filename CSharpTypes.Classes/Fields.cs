namespace CSharpTypes.Classes
{
    public class Fields
    {
        /// <summary>
        ///  فیلدها در کانستراکتور و یا همانجایی که تعریف می شوند مقداردهی می شوند 
        /// </summary>
        //private readonly int _age = 100;
        private readonly int _age;
        public Fields(int age)
        {
            _age = age;
        }
        /// <summary>
        /// اگر در جای غیر از موارد بالا مقدار دهی شوند باعث ایجاد خطا می شویم
        /// </summary>
        public void ChangeAge()
        { 
            //_age = _age + 1;
            Console.WriteLine(_age);
        }
    }
}
