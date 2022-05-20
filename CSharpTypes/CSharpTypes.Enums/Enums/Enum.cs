namespace CSharpTypes.Enums.Enums
{
    #region Enums
    /// <summary>
    /// بصورت دیفال مقادیرش int است
    /// اگر میخوایم جای کمتری اشغال بکنه میتونیم به بایت تبدیلش بکنیم
    /// مقادیرش از صفر شروع میشه
    /// ولی میتونیم با گذاشتن علامت تساوی مقدارشون رو تغییر بدیم
    /// مثل این میمونه که ما مجموعه ای از کانستنت ها داشته باشیم
    /// </summary>
    public enum Enum01
    {
        Shanbe,
        YekShanbe,
        DoShanbe,
        SeShanbe,
        ChaharShanbe,
        PanjShanbe,
        jome,
    }
    public enum Enum02 : byte
    {
        PaymentStatus = 1,
        OrderStatus = 2
    } 
    #endregion
}
