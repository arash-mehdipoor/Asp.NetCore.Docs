namespace ArrayTutorial.MultiDimensionalArray
{
    #region MultiDimensionalArray
    #region Description
    /// <summary>
    /// خیلی تفوتی با آرایه های عادی نداره یعنی کماکان ما یه مجموعه ای از اشیاء همشکل و همجنس داریم که داخل خودش نگهداری میکنه
    /// ولی فقط بجای اینکه یک بعد داخلش باشه چند بعد مختلف میتونه داشته باشه و در ابعاد مختلف دوباره مجموعه ای از اشیاء رو نگهداری میکنه مرسوم
    /// ترین حالتش آرایه دو بعدی هستش که ما بهش ماتریس هم میگیم ولی میتونیم سه یا چهار، هرچندتا که میخوایم داشته باشیم
    /// همه ی ویژگی هاش شبیه آرایه عادیه فقط وقتی تعریفش میکنیم برای هر بعدی که میخوایم اضافه بکنیم یک علامت ویرگول اضافه میکنیم برای اینکه بتونیم کارمون
    /// رو به درستی پیش ببریم
    /// </summary> 
    #endregion
    public class MultiDimensionalArray
    {
        public void Dimensional()
        {
            #region Sample01

            int[,] a = new int[2, 2];

            a[0, 0] = 1;
            a[0, 1] = 2;
            a[1, 0] = 3;
            a[1, 1] = 4;

            Console.WriteLine(a[0, 0]);
            Console.WriteLine(a[0, 1]);
            #endregion
             
            #region Sample02
            int[,] intArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            // Or
            // int[,] intArray = { { 1, 1 }, { 1, 2 }, { 1, 3 } };

            Console.WriteLine(intArray[0, 0]); //Output: 1
            Console.WriteLine(intArray[0, 1]); // 2
            Console.WriteLine(intArray[1, 0]); // 3
            Console.WriteLine(intArray[1, 1]); // 4
            Console.WriteLine(intArray[2, 0]); // 5
            Console.WriteLine(intArray[2, 1]); // 6  
            #endregion

            #region Rank
            // تعداد بعدهایی که یک آرایه داره رو بهمون میده
            int[,,] c = new int[10, 10, 10]; 
            Console.WriteLine(c.Rank);
            Console.WriteLine(a.Rank);
            Console.WriteLine(intArray.Rank);
            #endregion

        }
    } 
    #endregion
}
