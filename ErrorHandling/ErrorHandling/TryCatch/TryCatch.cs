namespace ErrorHandling.TryCatch
{
    #region Description
    /// <summary>
    /// فرایندی که باعث میشه ما یک خطایی رو به درستی کشف بکنیم ارسالش بکنیم و برای اون خطای ارسال شده  کدهایی بنویسیم که
    /// بتونن اون خطا رو به درستی مدیریت بکنن اصطلاحا ما  میگیم اکسپشن هندلینگ
    /// روال مدیریت خطا توی دات نت به کمک ترای کش اتفاق میوفته،قطعه کدی که احتمال خطا داره توی ترای میزاریم و اگر خطا اتفاق بیوفته
    /// بخش کچ رخ میده
    /// </summary> 
    #endregion
    #region TryCatch
    public class TryCatch
    {
        public void Add(int number01, int number02)
        {
            if (number01 < 1)
                throw new ArgumentException();
            if (number02 < 1)
                throw new InvalidOperationException();

            int result = number01 + number02;
            Console.WriteLine(result);
        }
    } 
    #endregion
}
