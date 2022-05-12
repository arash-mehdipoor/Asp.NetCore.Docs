namespace CSharpTypes.Classes.Methods
{

    public class Method
    {
        #region Property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion 
        #region FunctionMember
        /// <summary>
        /// ممبر هایی که فقط دیتا نگه می دارند بهشون میگیم 
        /// Data Member
        /// اما ممبر هایی که علاوه بر نگهداری دیتا عملیاتی نیز بروی آنها انجام می دهند 
        /// Function Member 
        /// میگیم
        /// </summary>
        public string GetFullName()
        {
            return $"{FirstName} - {LastName}";
        }
        #endregion 
        #region ExpressionBodiedFunction
        /// <summary>
        /// Expression Bodied Function
        /// </summary>
        /// <returns></returns>
        public string GetFullNameEx() => $"{FirstName} - {LastName}";

        #endregion
        #region syntax
        /// <summary>
        /// بهتر است حرف اول پارامتر ها کوچک باشد،
        /// و حرف اول نام متد با حروف بزرگ نوشته شود
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        #endregion 
        #region  StaticMembers
        /// <summary>
        /// ممبر هایی که از نوع
        /// static
        /// هستند به خود کلاس میچسبند و نیازی به نمونه سازی از روی کلاس ندارند و به آنها 
        /// Static Members می گوبند
        /// و اگر ممبر هایی باشند که بعد از نمونه سازی از روی کلاس قابل استفاده هستند به آنها 
        /// Instance Members گوبند
        /// </summary>
        public static int Count() => 100;

        #endregion
        #region MethodOverLoading
        /// <summary>
        /// Method OverLoading
        /// اگر تعداد پارامتر ها متفاوت یا نوع پارامتر ها متفاوت باشد
        /// متد اورلودینگ انجام داده اید
        /// اما نمیتواند  
        /// return type
        /// متفاوتی داشته باشید
        /// و باید 
        /// signature 
        /// متد تفاوت داشته باشد
        /// مثلا در متد اورلودینگ نمیتونیم دوتا متد داشته باشیم که هر دوتا یک پرامتر ورودی داشته باشد
        /// </summary>
        public string Print(string param1)
        {
            return param1;
        }
        public string Print(string param1, string param2)
        {
            return $"{param1} - {param2}";
        }
        public string Print(int param3, int param4)
        {
            return $"{param3} - {param4}";
        }
        #endregion
        #region NamedArgument 
        /// <summary>
        /// Named Argument
        /// method.NamedArgument(width:10,height:100);
        /// در اینصورت دیگه ترتیب و توالی داشتن معنایی ندارد
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void NamedArgument(int width, int height)
        {
            Console.WriteLine($"{width}{height}");
        }
        #endregion 
        #region OptionalParameters
        /// <summary>
        /// وقتی پارامتری را 
        /// optional
        /// تعریف میکنیم باید به عنوان آخرین پارامتر باشه،
        /// و اگر ابتدای پارامتر ها قرار بگیره باید بعد اون
        /// همشون مقدار پیشفرض بگیرن
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void OptionalParameters(int a, int b, int c = 3)
        {

        }
        #endregion 
        #region Params
        /// <summary>
        /// اگر بیش از یک ورودی داریم میتوانیم از 
        /// Params
        /// استفاده کنیم نکات : در هر متد فقط یک پارام میتوانیم داشته باشیم و حتما باید 
        /// به عنوان آخرین پارامتر تعریف شود 
        /// </summary>
        /// <param name="numbers"></param>
        public void ParamsMethod(params int[] numbers) { }
        public void ParamsMethod(int age, params int[] numbers) { }
        /// <summary>
        /// Error
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="age"></param>
        //public void ParamsMethod(params int[] numbers, int age) { }

        /// <summary>
        /// درصورتی که 
        /// overload 
        /// های مختلفی وجود داشته باشد کامپایلر تشخیص میدهد که مثلا در این مثال 
        /// اگر هنگام صدا زدن متد، 2 پارامتر وارد شود متد دارای دوپارامتر را صدا میزند اگر 3 پارامتر
        /// وارد کنید متد دارای 3 پارامتر را صدا زده و
        /// بیش از 3 پارامتر  میرود سراغ متد زیر :
        /// public void ParamsMethod(int age, params int[] numbers) { }
        /// </summary>
        /// <param name="age"></param>
        /// <param name="number1"></param>
        public void ParamsMethod(int age, int number1) { }
        public void ParamsMethod(int age, int number1, int number2) { }
        #endregion

    }
}
