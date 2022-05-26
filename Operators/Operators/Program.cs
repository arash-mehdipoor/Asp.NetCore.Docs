



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

#region OperatorOverloading
Money money01 = new Money(100000);
Money money02 = new Money(200000); 
Money money04 = money01 + money02; 
Console.WriteLine(money04.Value);

// User Defined Conversion
Money money03 = 200000;
int a = new Money(1);

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
