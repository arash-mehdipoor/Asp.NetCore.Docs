namespace OOPInCSharp.ClassInheritance.Seald
{
    #region Description
    /// <summary>
    /// ما به کمک سیلد میتونیم کلاس های مهر و موم شده ایجاد بکنیم یعنی  کلاس هایی ایجاد بکنیم 
    /// که دیگه قابلیت ارث بری نداشته باشند کسی نتونه ازشون ارث ببره 
    /// سیلد رو فقط برای کلاس بکار نمیبریم بلکه تو سلسله مراتب متدهامون وقتی داریم ارث بری میکنیم 
    /// یک متدی ویرچوال وجود داره وقتی اوراید میشه 
    /// از یجایی به بعد دیگه نمیخوایم اگه یک کلاسی از کلاس ما ارث بری کرد
    /// نمیخوایم دیگه بتتونه اوراید بکنه تو اون سطحی که دیگه نمیخوایم اوراید بشه میایم 
    /// متد خودمون رو سیلدش میکنیم،در نتیجه اون قضیه 
    /// VTable
    /// هم اتفاق نمیوفته و پرفورمنس بهتری میگیرم
    /// </summary> 
    #endregion
    #region Seald
    public abstract class Person
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int LastName { get; set; }
    }

    public sealed class Teacher : Person
    {

    }

    public class Student : Teacher
    {

    } 
    #endregion
}
