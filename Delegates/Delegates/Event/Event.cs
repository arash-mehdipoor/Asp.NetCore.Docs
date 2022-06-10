namespace Delegates.Event
{
    #region Description
    /// <summary>
    /// ایونت یا رخداد، ببینید من یک زمانی یک آبجکتی دارم این آبجکتم یکسری کارها انجام میده و یکسری کلاس ها و آبجکتهای  دیگه ای دارم که به کارهایی که داخل این کلاس انجام 
    /// میشه و به تغییر وضعیتی که داخل این کلاس انجام میشه علاقه مند هستن، تواین شرایط ما میایم از ایونت استفاده میکنیم،حتی اگر قرار باشه بعد تغییر دیتای تحویل بقیه بده هم
    /// اینکار رو انجام میده با ایونت،کسی که ایونت رخ میده داخلش وبقیه رو مطلع میکنه اصطلاحا بهش میگیم پابلیشر،کسی که علاقه منده به یک ایونتی و یک ایونت رو میگیره اطلاعاتشو میخونه و کار خودشو
    /// انجام میده اصطلاحا بهش میگیم هندلر دیتایی که جابجا میشه توی ایونتمون بهش میگیم ایونت آرگومان
    /// </summary> 
    #endregion 
    #region Event
    public class TeacherNameChangeArgs : EventArgs
    {
        public string OldName { get; set; }
        public string NewName { get; set; }

        public TeacherNameChangeArgs(string oldName, string newName)
        {
            OldName = oldName;
            NewName = newName;
        }
    }
    public class Teacher
    {
        public event EventHandler<TeacherNameChangeArgs> TeacherNameChanged;

        private string _name;
        private string _description;

        public Teacher(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void SetName(string newName)
        {
            var args = new TeacherNameChangeArgs(_name, newName);
            _name = newName;
            TeacherNameChanged.Invoke(this, args);
        }
    }

    public class TeacherChangeNameLogger
    {
        public void Log(object sender, TeacherNameChangeArgs args)
        {
            Console.WriteLine($"Old name is : {args.OldName} and newName is : {args.NewName}");
        }
    } 
    #endregion
}
