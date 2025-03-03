using System.Runtime.CompilerServices;
using Practice.models;

internal class Program
{
    
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //var strLength = GetLength(new StringWrapper("Hello")); // Works
        //var arrLength = GetLength(new ArrayWrapper<int>(new int[] { 1, 2, 3 })); // Works

        //Console.WriteLine(strLength); // Output: 5
        //Console.WriteLine(arrLength); // Output: 3

        //var queue = new MyQueue<int>();
        //queue.Enqueue(10);
        //queue.Enqueue(20);
        //Console.WriteLine(queue.Deque()); // 10
        //Console.WriteLine(queue.Size); // 1
        List<IKeyValue<string , int>> pairs = new List<IKeyValue<string, int>>();
        pairs.Add(new KeyValue<string, int>("One", 1));
        pairs.Add(new KeyValue<string, int>("Two", 2));
        pairs.Add(new KeyValue<string, int>("Three", 3));
        pairs.Add(new KeyValue<string, int>("Four", 4));

        foreach (var pair in pairs)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }


    }
}