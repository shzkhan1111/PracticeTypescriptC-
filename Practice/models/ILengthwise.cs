using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region commented
//namespace Practice.models
//{
//    public interface ILengthwise
//    {
//        int Length { get; }
//    }
//    public class StringWrapper : ILengthwise
//    {
//        public string Value { get;}
//        public StringWrapper(string value)
//        {
//            Value = value;
//        }

//        public int Length => Value.Length;
//    }
//    public class ArrayWrapper<t> : ILengthwise
//    {
//        public t[] items { get; }
//        public ArrayWrapper(t[] itsd)
//        {
//            items = itsd;
//        }

//        public int Length => items.Length;
//    }


//}
//namespace Practice.models
//{
//    internal class Box<T>
//    {
//        private T data;
//        public Box(T val)
//        {
//            data = val;
//        }
//        public T Data
//        {
//            get
//            {

//                if (data is string str)
//                {
//                    Console.WriteLine($"{str.Length}");
//                    return data;

//                }
//                Console.WriteLine($"Data is not string");
//                return data;
//            }
//            set => data = value;
//        }


//    }
//}
//namespace Practice.models 
//{
//    public class MyQueue<T> 
//    {
//        private readonly List<T> items = new List<T>();
//        public MyQueue()
//        {
//            items = new List<T>();
//        }
//        public void Enqueue(T item)
//        {
//            items.Add(item);
//        }
//        public T Deque() 
//        { 
//            if(items.Count > 0)
//            {
//                T item = items[0];
//                items.RemoveAt(0);
//                return item;
//            }
//            return default(T);
//        }
//        public int Size => items.Count;
//    }
//}
#endregion


namespace Practice.models
{
    public interface IKeyValue<K, V>
    {
        K Key { get; set; }
        V Value { get; set; }
    }

    public class KeyValue<K, V> : IKeyValue<K, V>
    {
       

        public KeyValue(K v1, V v2)
        {
            this.Key = v1;
            this.Value = v2;
        }

        public K Key { get; set; }
        public V Value { get; set; }
    }

}
