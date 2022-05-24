namespace TypeCasting
{
    public class BoxingVsUnboxing
    {
        #region Boxing
        /// <summary>
        /// به فرایند تبدیل ولیو تایپ به رفرنس تایپ عملیات باکسینگ گفته میشود
        /// </summary>
        public void Boxing()
        {
            // وقتی شما میزنید یک دات تو استرینگ عمل باکسینگ انجام میشه یعنی یک متغیر از جنس آبجکت توی هیپ تعریف میشه
            // یک داخلش قرار میگیره و دات تو استرینگ داخل اون انجام میشه
            1.ToString(); 
            object a = 1;

            // Boxing
            int num = 23; 
            object Obj = num; 

        }
        #endregion

        #region UnBoxing
        public void Unboxing()
        {
            int num = 23;        
            object Obj = num;    // Boxing
            int i = (int)Obj;    // Unboxing
        }
        #endregion
    }
}
