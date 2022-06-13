namespace Collections.Sets
{
    #region Description
    /// <summary>
    /// اگر ما کالکشنی داشته باشیم که اعضایی که داره مقدار تکراری نداشته باشند اصلاحا ست هستن برای ما
    /// توی دات نت ست با دوتا کلاس مختلفن که کار ست میکنن برای ما
    /// Hashset :
    /// که ما هش تیبل داریم که اطلاعات بصورت یونیک در داخلش نگهداری میشن
    /// SortedSet :
    /// مجموعه ای هستش که یک لیستی از اعضا رو بصورت یونیک و مرتب شده در کنار هم قرار میگیرن
    /// </summary> 
    #endregion
    #region Set
    public class SetSample
    {
        HashSet<string> sets = new HashSet<string>();

        public void Add(string input)
        {
            sets.Add(input);
        }

        public void Print()
        {
            foreach (var item in sets)
            {
                Console.WriteLine(item);
            }
        }

        public void Operators()
        {
            HashSet<string> newSet = new HashSet<string>();
            newSet.Add("1");
            newSet.Add("5");

            newSet.ExceptWith(sets); // 5
            // اجتماع
            var union = newSet.Union(sets); //  1,2,3,5

            // اشتراک
            var intersect = newSet.Intersect(sets); // 1

            // زیر مجموعشه یا مجموعه بالادستیشه
            bool subse = newSet.IsSubsetOf(sets); // false
            bool super = newSet.IsSupersetOf(sets); // false


            foreach (var item in newSet)
            {
                Console.WriteLine(item);
            }


        }

    } 
    #endregion
}
