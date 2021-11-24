using System;
using System.Linq;
using System.Collections.Generic;

//namespace Array_intialization
//{
//class Program
//{
//static void Main()
//{
//    int[] arr = { 1, 2, 3, 4, 5, 6 };
//foreach(int x in arr)
//{
//    if (x % 2 == 0)
//        Console.WriteLine($"{x}");
//}
//       IEnumerable<int> odds=arr.Where(x => x % 2 != 0);
//        foreach (int x in odds)
//            Console.WriteLine($"{x}");
//    }
//} 

// }

//var x = 100;
//var n = new int[] { 10, 20, 30 };
//var obj = new Employee { Name = "Lakshmi" };
//class Employee
//{
//    public string Name { get; set; }
//}
//}
var x=GenerateNumbers(10)
.Where(n => n % 2 != 0)
.Select(n => n * 2);

foreach(int n in x)
    Console.WriteLine($"{n}");

   


    IEnumerable<int> GenerateNumbers(int max)
    {
        for (int i = 1; i < max; ++i)
            yield return i;
    }
