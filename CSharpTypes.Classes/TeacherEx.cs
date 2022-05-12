using CSharpTypes.Classes.ExtentionsMethod;

namespace CSharpTypes.Classes
{ 
    public static class TeacherEx
    {
        #region ExtentionMethod
        /// <summary>
        /// اکستنشن متد حتما باید در یک کلاس استاتیک و متد استاتیک باشد
        /// و اگر یک متد همنام اکستنشن متد در داخل کلاس مورد نظر باشد 
        /// متدی که در کلاس وجود دارد اولویت دارد
        /// اکستنشن متدها با namespace
        /// خود قابل شناسایی هستند
        /// </summary>
        public static string GetFullName(this Teacher teacher)
        {
            return $"{teacher.FirstName} - {teacher.LastName}";
        } 
        #endregion
    }
}
