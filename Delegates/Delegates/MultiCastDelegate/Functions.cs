using Delegates.Delegate;

namespace Delegates.MultiCastDelegate
{
    public class Functions
    {
        #region TestMultiCastDelegate
        public void TestMultiCastDelegate()
        {
            MethodNamePrinter printer = new();

            MethodNamePrinterHolder printerHolder = printer.Method01;

            printerHolder += printer.Method02;
            printerHolder += printer.Method03;
            printerHolder += printer.Method04;

            //printerHolder -= printer.Method02;

            printerHolder.Invoke();
        }

        #endregion

        #region MultiCastDelegateWithOutput
        /// <summary>
        /// وقتی که دلیگیتهامون خروجی داشته باشند فقط آخری چاپ میشه
        /// اما جفتشون اگزکیوتمیشن
        /// </summary>
        public void TestMultiCastDelegateWithOutput()
        {
            Person person = new() { FirstName = "Arash", LastName = "Mehdipour" };

            PersonTostring myDelegate = PersonFullName.GetPersonFullName;
            myDelegate += PersonFullNameReverce.GetPersonFullName;


            PersonPrinter printer = new();

            printer.Print(myDelegate, person); // Mehdipour - Arash
        }
        #endregion

        #region MultiCastDelegateExceptionHandle
        /// <summary>
        /// فقط جایی که به ارور میخوریم چاپ نمیشه
        /// </summary>
        public void TestMultiCastDelegateExeptionHandle()
        {
            MethodNamePrinter printer = new();

            MethodNamePrinterHolder printerHolder = printer.Method01;

            printerHolder += printer.Method02;
            printerHolder += printer.Method03;
            printerHolder += printer.Method04;


            var list = printerHolder.GetInvocationList();
            foreach (var item in list)
            {
                try
                {
                    item.DynamicInvoke();

                    // Output : 
                    // Method01
                    // Method02
                    // Method04
                }
                catch (Exception)
                {

                }
            }
        }
        #endregion

    }
}
