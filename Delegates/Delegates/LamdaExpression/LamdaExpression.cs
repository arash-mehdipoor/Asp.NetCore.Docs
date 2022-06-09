namespace Delegates.LamdaExpression
{
    #region LamdaExpression
    public class LamdaExpression
    {

        #region Description
        /// <summary>
        /// انونیموس متد فرمتش چاق بود یعنی یک عالمه پرانتز و آکولاد بازو بسته و فلان،برای حل این مشکل مایکروسافت لامبدا اکسپرژن رو معرفی کرد که فرمت خلاصه تری هستش
        /// </summary> 
        #endregion
        public void LamdaExpressionTest()
        {
            Func<int, string> func1 = x => $"{x}";

            Func<int, int, string> func2 = (x, y) => $"{x}, {y}";

            Func<int, int, string> func3 = (x, y) =>
            {
                if (x == y)
                {
                    return $" x == y";
                }
                else
                {
                    return "x";
                }
            };

            Func<string> func4 = () => "Test";



            var result1 = func1.Invoke(1);
            var result2 = func2.Invoke(1, 2);
            var result3 = func3.Invoke(1, 2);
            var result4 = func4.Invoke();

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    } 
    #endregion
}
