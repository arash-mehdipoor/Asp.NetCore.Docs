



using Operators;
using Operators.Models;

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

Console.WriteLine("Hello, World!");
