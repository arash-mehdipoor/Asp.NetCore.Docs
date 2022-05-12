using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypes.Classes
{
    public class Properties
    {
        /// <summary>
        /// سینتکس کوتاه نویسی در صورتی که فقط 
        /// get داشته باشیم
        /// Expression bodied members
        /// </summary>
        private string _city;
        public string City => _city;

        /// <summary>
        /// Auto-Implemented Properties
        /// </summary>
        public string FirstName { get; set; }


        /// <summary>
        /// میتوانیم پراپرتی داشته باشیم که 
        /// private Set 
        /// و نکته بعدی اینکه باید حتما یکیشون سطح دسترسیش با پراپرتی برابر باشه
        /// مثلا در این مثال نمیتونه جفتشون پرایویت باشه
        /// </summary>
        public string LastName { get;private set; }

        /// <summary>
        /// اگر پراپرتی فقط 
        /// get 
        /// داشته باشه 
        /// readonly
        /// میشه
        /// </summary>
        public string FatherName { get; }

        /// <summary>
        /// اگر سطح دسترسی برای 
        /// get و set
        /// تعریف نکنیم دسترسی خودشون رو از پراپرتی میگیرن
        /// در این مثال هر جفتشون 
        /// Public
        /// هستند
        /// </summary>
        public int Age { get; set; }


        /// <summary>
        /// اگر پراپرتی بصورت 
        /// init only
        /// تعریف شود به این معنی است که فقط در 
        /// Object Initializers یا Constructor 
        /// قایل تغییر هست و بعد اون دیگه نمیتونیم تغییری در مقدار فیلد آدرس ایجاد کنیم
        /// </summary>
        public string Address { get; init; }


        /// <summary>
        /// propFull
        /// </summary>
        private string carName;
        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }

        /// <summary>
        /// propG
        /// </summary>
        public int Count { get; private set; }


    }
}
