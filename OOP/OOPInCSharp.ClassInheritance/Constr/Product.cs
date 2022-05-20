namespace OOPInCSharp.ClassInheritance.Constr
{
    #region Description
    /// <summary>
    /// وقتی کلاس پرنتمون کانستراکتور پیشفرض نداشته باشه هنگام ارث بری ازش حتما باید 
    /// پارامتر ورودی کانستراکتور پرنت رو پاس بدیم،
    /// چوت توی چایلد میخواد از پرنت آبجکت بسازه میبینه یه ورودی میخواد و باید با کلمه کلیدی 
    /// base حتما ورودی و بهش پاس بدیم
    /// </summary> 
    #endregion

    #region Constructor
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Constr Defult");
        }
    
        public Product(string productName)
        {
            Console.WriteLine($"Product Name : {productName}");
        }
    }

    public class Mobile : Product
    {
        public Mobile()
        {

        }
        public Mobile(string productName) : base(productName)
        {
        }
    } 
    #endregion
}
