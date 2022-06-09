using Delegates.Delegate;

namespace Delegates.AnonymousMethod
{
    #region AnonymousMethod
    #region Description
    /// <summary>
    /// گاهی اوقات ممکنه ما دلیگیتهایی داشته باشیم که تنها توی کل پروژه یکبار قابل استفاده باشه اما مجبورم تمام ساختار و روندشو طی بکنم
    /// برای اینکه این مشکل حل بشه مایکروسافت اومد گفت من انونیموس متد دارم،متدهای ناشناس دارم که در لحظه شما میتونید تعریفشون بکنید،
    /// البته این روزها با معرفی شدن لامبدا اکسپرژن ها استفاده از این نوع دلیگیتها محدود شده
    /// </summary> 
    #endregion
    public class AnonymousMethod
    {
        public void AnonymousMethodSample01()
        {
            Person person1 = new Person() { FirstName = "Arash", LastName = "Mehdipour" };

            PersonTostring personTostring = delegate (Person person)
            {
                return $"{person.FirstName} - {person.LastName}";
            };

            personTostring.Invoke(person1);
        }

        /// <summary>
        /// انونیموس متد فرمتش چاق بود یعنی یک عالمه پرانتز و آکولاد بازو بسته و فلان،برای حل این مشکل مایکروسافت لامبدا اکسپرژن رو معرفی کرد که فرمت خلاصه تری هستش
        /// </summary>
        public void AnonymousMethodSample02()
        {
            Func<int, string> func = x => $"{x}";
            var result = func.Invoke(1);

            Console.WriteLine(result);
        }
    } 
    #endregion
}
