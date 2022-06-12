﻿

using Collections.Lists;
using Collections.Queue;

#region List

ListSample list = new ListSample();

list.PrintCapacity(); // 0
list.PrintCount(); // 0

list.AddMember("1");
list.PrintCapacity(); // 4
list.PrintCount(); // 1

list.AddMember("2");
list.PrintCapacity(); // 4
list.PrintCount(); // 2

list.AddMember("3");
list.PrintCapacity(); // 4
list.PrintCount(); // 3

list.AddMember("4");
list.PrintCapacity(); // 4
list.PrintCount(); // 4


list.AddMember("5");
list.PrintCapacity(); // 8
list.PrintCount(); // 5

list.AddMember("6");
list.PrintCapacity(); // 8
list.PrintCount(); // 6

#endregion

#region Queue
QueueSample queue = new QueueSample();
queue.Enquue("2"); 
queue.Enquue("1");
queue.Enquue("3");

Console.WriteLine("_".PadLeft(20,'_'));
queue.Count(); // 3
Console.WriteLine("_".PadLeft(20, '_'));

queue.Peek(); // 2
queue.Peek(); // 2
queue.Peek(); // 2
Console.WriteLine("_".PadLeft(20, '_'));

queue.Dequeue(); // 2
queue.Dequeue(); // 1
queue.Dequeue(); // 3

Console.WriteLine("_".PadLeft(20, '_'));
queue.Count(); // 0
Console.WriteLine("_".PadLeft(20, '_'));

queue.PriorityQueue();
#endregion

Console.ReadKey();
Console.WriteLine("Hello, World!");
