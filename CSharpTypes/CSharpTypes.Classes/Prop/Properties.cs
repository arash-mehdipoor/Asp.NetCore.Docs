namespace CSharpTypes.Classes.Prop
{
    public class Properties
    {
        #region ExpressionBodiedMembers
        /// <summary>
        /// سینتکس کوتاه نویسی در صورتی که فقط 
        /// get داشته باشیم
        /// Expression bodied members
        /// </summary>
        private string _city;
        public string City => _city;
        #endregion 
        #region Auto-ImplementedProperties
        /// <summary>
        /// Auto-Implemented Properties
        /// </summary>
        public string FirstName { get; set; }
        #endregion  
        #region PrivateSet 
        /// <summary>
        /// میتوانیم پراپرتی داشته باشیم که 
        /// private Set 
        /// و نکته بعدی اینکه باید حتما یکیشون سطح دسترسیش با پراپرتی برابر باشه
        /// مثلا در این مثال نمیتونه جفتشون پرایویت باشه
        /// </summary>
        public string LastName { get; private set; }
        #endregion 
        #region ReadonlyProperty
        /// <summary>
        /// اگر پراپرتی فقط 
        /// get 
        /// داشته باشه 
        /// readonly
        /// میشه
        /// </summary>
        public string FatherName { get; }
        #endregion 
        #region PublicMembers
        /// <summary>
        /// اگر سطح دسترسی برای 
        /// get و set
        /// تعریف نکنیم دسترسی خودشون رو از پراپرتی میگیرن
        /// در این مثال هر جفتشون 
        /// Public
        /// هستند
        /// </summary>
        public int Age { get; set; }
        #endregion 
        #region InitOnly
        /// <summary>
        /// اگر پراپرتی بصورت 
        /// init only
        /// تعریف شود به این معنی است که فقط در 
        /// Object Initializers یا Constructor 
        /// قایل تغییر هست و بعد اون دیگه نمیتونیم تغییری در مقدار فیلد آدرس ایجاد کنیم
        /// </summary>
        public string Address { get; init; }
        #endregion 
        #region PropFull
        /// <summary>
        /// propFull
        /// </summary>
        private string carName;
        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }
        #endregion 
        #region PropG
        /// <summary>
        /// propG
        /// </summary>
        public int Count { get; private set; }
        #endregion
    }
}
