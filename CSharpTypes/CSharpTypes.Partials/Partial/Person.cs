﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypes.Partials.Partial
{
    #region Description
    /// <summary>
    ///  یک شرایطی ممکنه توی سیستم شما ایجاد بشه که حجم کلاستون حجم اینترفیستون خیلی بزرگ بشه
    ///  یا به یک دلیلی بخواهید کلاستون رو توی دوتا فایل مختلف قرار بدید مثلا یکی از این دلایل
    ///  فرض کنید یک کد جنریتوری دارید که کد شمارو با یک شرایطی جنریت میکنه
    ///  و شما میخواید این رو بهینش بکنید حالا هروقت که شما کد جنریتورتون رو ران بکنید 
    ///  و این کدی که شما نوشتید پاک میشه و کدی که کدجنریتورتون نوشته جایگزین میشه
    ///  در این صورت شما میتونید کدتون رو بصورت پارشیال دولوپ بکنید
    ///  و در نهایت وقتی که کامپایل میکنید با توجه به این که اینها پارشیال تایپ هستن سیستم نمیاد ببینه اینها توی دوتا محل متفاوت هستن یا نام فایلهاشون
    ///  متفاوت هستش بلکه در نهایت میاد اینهارو یکی در نظر میگیره 
    /// </summary> 
    #endregion
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
