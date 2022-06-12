namespace Collections.Queue
{
    #region Description
    /// <summary>
    /// مجموعه ای از عناصر هستن که ترتیب توالیشون توی مجموعه و ترتیب توالی خوندنشون توی مجموعه یکسانه
    /// یعنی اولین عنصری که توی مجموعه قرار میگیره اولین عنصری هستنش که از مجموعه خونده میشه، یعنی با هر ترتیبی که عناصر وارد مجموعه ی ما بشن با همون ترتیب خارج میشن
    /// فرایند اضافه کردن یک عنصر به صف رو ما بهش میگیم Enqueue
    /// و فرایند خوندن یک عنصر از ابتدای صف رو بهش میگیم Dequeue
    /// وقتی enqueue میکنیم یک عنصر اضافه میشه
    /// و dequeue میکنیم خوندن و حذف همزمان انجام میشه
    /// 
    /// </summary>
    #endregion
    public class QueueSample
    { 
        #region Count
        Queue<string> queue = new Queue<string>(); 
        public void Count()
        {
            Console.WriteLine(queue.Count);
        }
        #endregion

        #region Enquue
        public void Enquue(string input)
        {
            queue.Enqueue(input);
        }
        #endregion

        #region Dequeue
        public void Dequeue()
        {
            Console.WriteLine(queue.Dequeue());
        }
        #endregion

        #region Peek
        /// <summary>
        /// وقتی از پیک استفاده میکنید آخرین خونه رو میخونه ولی چیزی حذف نمیکنه در نتیجه اون اشاره گری که انتهای صف رو داره نشون میده جابجا نمیشه پس ده بار هم اگه پیک بکنم یک مقدار برام نشون میده
        /// </summary>
        public void Peek()
        {
            Console.WriteLine(queue.Peek());
        }
        #endregion

        #region PriorityQueue
        public void PriorityQueue()
        {
            PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();

            /// <summary>
            /// هر چی که عدد کمتر زمان خوندن بالاتر
            /// اگه عدد مساوی بود اونی که اول نوشته شده بالاتر خونده میشه
            /// </summary>
            priorityQueue.Enqueue("1", 3);
            priorityQueue.Enqueue("2", 10);
            priorityQueue.Enqueue("3", 5);
            priorityQueue.Enqueue("4", 1);

            Console.WriteLine(priorityQueue.Dequeue()); // 4
            Console.WriteLine(priorityQueue.Dequeue()); // 1
            Console.WriteLine(priorityQueue.Dequeue()); // 3
            Console.WriteLine(priorityQueue.Dequeue()); // 2
        } 
        #endregion
    }
}
