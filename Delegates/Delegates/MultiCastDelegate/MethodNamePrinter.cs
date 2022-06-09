namespace Delegates.MultiCastDelegate
{
    public delegate void MethodNamePrinterHolder();
    public class MethodNamePrinter
    {
        public void Method01()
        {
            Console.WriteLine(nameof(Method01));
        }
        public void Method02()
        {
            Console.WriteLine(nameof(Method02));
        }
        public void Method03()
        {
            throw new Exception();
            Console.WriteLine(nameof(Method03));
        }
        public void Method04()
        {
            Console.WriteLine(nameof(Method04));
        } 
    }
}
