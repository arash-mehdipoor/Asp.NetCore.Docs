﻿namespace Attributes.UI.Description
{
    #region Description
    /// <summary>
    /// سریالایز کردن جز مواردی هستش که هر برنامه نویس ممکنه بارها و بارها انجام بده، و بهینه کردن این فرایند سریالایز و دیسریالایز کردم این موارد
    /// از اون کارهایی هستش که برنامه نویس هاباهاش سروکار دارن،توی دات نت به کمک اتریبیوت ها میتونید این فرایندها رو تحت تاثیر قرار بدیم
    ///  یعنی میتونیم توی یک تایپی از اتریبیوت سریالایزبل استفاده بکنیم که بگیم این تایپ قابل سریالایز هست
    /// [Serializable]
    /// </summary> 
    #endregion
    [Serializable]
    public class SerializationAttributes
    {
        //با این اتریبیوت میگیم نمیخوایم این مورد سریالایز بشه
        [NonSerialized]
        private int _age;
    }
}
