using System.Dynamic;
using System.Runtime.CompilerServices;
using Practice.models;

internal class Program
{
    
    private static void Main(string[] args)
    {
        var person = new { Name = "Alice", Age = 30 };
        var job = new { Role = "Developer", Salary = 50000 };
        var merged = MergeObjects(person, job);
        Console.WriteLine($"{merged.Name}, {merged.Age}, {merged.Role}, {merged.Salary}");
    }
    public static dynamic MergeObjects<T, U>(T obj1, U obj2)
    {
        var expando = new ExpandoObject() as IDictionary<string , object>;
        foreach (var prop in obj1.GetType().GetProperties())
        {
            expando[prop.Name] = prop.GetValue(obj1);
        }
        foreach (var prop in obj2.GetType().GetProperties())
        {
            expando[prop.Name] = prop.GetValue(obj2);
        }

        return expando;
    }
}