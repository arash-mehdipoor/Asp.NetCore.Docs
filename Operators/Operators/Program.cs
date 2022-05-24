



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

Money money03 = money01 + money02;

Console.WriteLine(money03.Value);
Console.ReadKey();
#endregion

Console.WriteLine("Hello, World!");
