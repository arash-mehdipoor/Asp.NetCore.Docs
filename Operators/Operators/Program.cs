



using Operators;
using Operators.Models;
using static Operators.OperatorsExample;

OperatorsExample operators = new();

#region CheckedAnaUnchecked
operators.CheckedAnaUnchecked();
#endregion

#region IsAndAs
var strudent = new Student()
{
    FirstName = "Arash",
    LastName = "Mehdipour",
    StudentName = "s1"
};

var teacher = new Teacher()
{
    TeacherName = "Teacher1"
};


operators.CheckIs(strudent);
operators.CheckIs(teacher);

operators.CheckAs(strudent);
operators.CheckAs(teacher);
#endregion

#region TypeOf
operators.TypeOf();
#endregion

#region NameOf
operators.NameOf();
#endregion

#region OperatorOverloadingAndMultipleCast
Money money01 = new Money(100000);
Money money02 = new Money(200000); 
Money money04 = money01 + money02; 
Console.WriteLine(money04.Value);

// User Defined Conversion
Money money03 = 200000;


#region MultipleCast
/// <summary>
/// الان کامپایلر میدونه که میتونه مانی رو تبدیل بکنه به بایت
/// اما تایپ کستینگی برای اینکه مانی رو تبدیل بکنی به این ندارن(کامنت کردم)
/// اما بستر اجرایی من میدونه که بدون هیچ مشکلی میتونه بایت رو تبدیل بکنه به اینتیجر 
/// بنابراین خطا نمیده بلکه توی آی ال کدی که تولید میکنه اول مانی رو تبدیل میکنه به بایت
/// از بایت تبدیل میکنه به اینتیجر
/// و اینجاست که مالتی پل کست اتفاق افتاده
/// پس این اتفاق که مجموعه ای از کستینگ ها باهم جمع میشوند تا یک تایپی رو تبدیل بکنند به یک تایپ دیگه بدون اینکه کستینگی
/// بطور مستقیم ازش وجود داشته باشه اصطلاحا بهش میگیم مالتی پل کست
/// </summary>
int a = new Money(1);

byte b = new Money(2); 
#endregion

Console.ReadKey();
#endregion 

#region Indexer

Wallet wallet = new Wallet();

wallet[0] = new Money(1000);
wallet[1] = new Money(2000);
wallet[10] = new Money(2000);

Console.WriteLine(wallet[0]);
Console.WriteLine(wallet[1]);

#endregion

Console.WriteLine("Hello, World!");
