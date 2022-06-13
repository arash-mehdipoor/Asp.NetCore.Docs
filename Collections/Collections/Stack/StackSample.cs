namespace Collections.Stack
{
    #region Description
    /// <summary>
    /// پشته یک ساختمان داده هستش که ترتیب ورود و خروج مثل صف اهمیت پیدا میکنه با این تفاوت که برعکس صف هستش
    /// یعنی اولین کسی که وارد میشه آخرین خونه ای از حافظه هستش که خارج میشه و خونده میشه و اطلاعاتش بدستمون میرسه 
    /// </summary> 
    #endregion
    #region Stack
    public class StackSample
    {
        Stack<string> stack = new Stack<string>();

        public void Push(string input)
        {
            stack.Push(input);
        }

        /// <summary>
        /// First in LastOut
        /// </summary>
        public void Pop()
        {
            Console.WriteLine(stack.Pop());
        }
    } 
    #endregion
}
