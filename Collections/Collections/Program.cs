

using Collections.ImmutableCollection;
using Collections.Lists;
using Collections.Queue;
using Collections.Sets;
using Collections.SortedList;
using Collections.Stack;

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

#region Stack
StackSample stack = new StackSample();
stack.Push("3");
stack.Push("1");
stack.Push("2");
Console.WriteLine("_".PadLeft(10, '_'));
stack.Pop();
stack.Pop();
stack.Pop();

#endregion

#region SortedList
SortedListSample SortedList = new SortedListSample();
SortedList.Add(1, "1");
SortedList.Add(2, "2");
SortedList.Add(3, "3");
SortedList.Add(4, "4");
Console.WriteLine("_".PadLeft(10, '_'));
#endregion

#region Set 
SetSample setSample = new SetSample();
setSample.Add("1");
setSample.Add("2");
setSample.Add("3");
setSample.Add("3");
setSample.Add("2");
setSample.Print();
Console.WriteLine("_".PadLeft(10), '_');
setSample.Operators();
#endregion

#region ImmutableCollection
Console.WriteLine("_".PadLeft(10), '_');
ImmutableCollection immutableCollection = new ImmutableCollection();
immutableCollection.Test(); 
#endregion

Console.ReadKey();
Console.WriteLine("Hello, World!");
