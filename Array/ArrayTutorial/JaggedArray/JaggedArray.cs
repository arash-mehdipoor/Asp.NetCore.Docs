namespace ArrayTutorial.JaggedArray
{
    #region JaggedArray
    public class JaggedArray
    {
        #region Description
        /// <summary>
        /// جگد ارری یا آرایه های دندونه دار:
        /// یه زمانی ممکنه به دلایل متلف مثلا یک الگوریتم خاصی دارم یک سناریوی خاصی دارم میخوام توی بعد دوم طول آرایهامون
        /// با هم متفاوت باشه تو این شرایط میریم سراغ جگد ارری ها
        /// یک آرایه جگد به جای اینکه مقادیری را در خود ذخیره کند آرایه ها را در خود ذخیره میکند. یک آرایه جگد با استفاده از دو براکت
        ///  [][] مقدار دهی اولیه می شود.
        ///  در براکت اول اندازه خود آرایه مشخص میشود و در براکت دوم ابعاد آرایه هایی که قرار است در آن ذخیره سازی شوند تعیین می شود
        /// </summary> 
        #endregion
        public void JaggedArraySample()
        {
            // فقط تعداد سطرهارو بهش اشاره میکنه در مثال زیر مقدار سطرهام 2 هستش
            int[][] intJaggedArray = new int[2][];

            intJaggedArray[0] = new int[3] { 1, 2, 3 };

            intJaggedArray[1] = new int[2] { 4, 5 };

            Console.WriteLine(intJaggedArray[0][0]); // 1

            Console.WriteLine(intJaggedArray[0][2]); // 3

            Console.WriteLine(intJaggedArray[1][1]); // 5

            for (int i = 0; i < intJaggedArray.Length; i++)
            {
                for (int j = 0; j < intJaggedArray[i].Length; j++)
                {
                    Console.WriteLine($"{i}-{j} : {intJaggedArray[i][j]}");
                }
            }
        }
    } 
    #endregion
}
