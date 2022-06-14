


using ErrorHandling.TryCatch;
using ErrorHandling.UserDefinedException;

#region TryCatch
TryCatch exception = new TryCatch();

try
{
    exception.Add(1, 2);
    exception.Add(2, 3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    // اگه میخواید خطا رو باز ببرید لایه بالاتر باز میتونید خطا رو ترو کنید
    //throw;
}
#endregion

#region UserDefinedException

TryCatch exception2 = new TryCatch();

try
{
    exception.Add(1, 2);
    exception.Add(2, 3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    UserDefinedException userDefinedException = new UserDefinedException();
    throw userDefinedException;
}
#endregion

#region Tips
#region Description
/// <summary>
/// هر بولک ترای میتونه چندین کچ داشته باشه،و وقتی که یک کچ اجرا میشه دیگه بقیه اجرا نمیشن
/// وقتی که من خطا برام اتفاق میوفته خب کچ اتفاق میوفته و وقتی که درست کار میکنه خب ترای کار میکنه،یه زمانایی
/// ممکنه بخوام در هرصورت یه کاری حتما انچام بشه،در این حالت از finally استفاده بکنم
/// فاینالی تیکه کدی هستش که بعد از مدیریت  اکسپشن و اکسپشن هندلینگ من حتما انجام میشه
/// نکته بعدی در رابطه با مدیریت خطا توسط دات نت،دات نت خودش اکسپشن هندلینگ انجام میده،  ببینید همه ی کار هایی که ما میکنیم
/// توی دات نت توی بلاک ترای کچ قرار میگیره ،حالا اگر ما اکسپشنی تو اپ ما اتفاق بیوفته و ترای کچ نوشته باشیم و مدیریتش کرده باشیم که هیچی
/// اگر اینکارو نکرده باشیم اکسپشن میره میرسه به دات نت میرسه به اون ترایی که دات نت بیرون همه ی ترای کچ ها نوشته شده،
/// و اونه که خطا رو مدیریت میکنه
/// برای همینه که میگیم دات نت 
/// Exception ManageMent داره
/// </summary> 
#endregion
TryCatch exception3 = new TryCatch();

try
{
    exception.Add(1, 2);
    exception.Add(2, 3);
}
catch(ArgumentException ex)
{

}
catch (InvalidOperationException ex)
{

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    UserDefinedException userDefinedException = new UserDefinedException();
    throw userDefinedException;
}
finally
{

}
#endregion

Console.WriteLine("Hello, World!");
