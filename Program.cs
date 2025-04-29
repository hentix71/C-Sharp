// Leared new loop

using System;

class ForMain
{
    static void Main()
    {
        UsingList.method1(Storage.names);
        UsingArray.method2(Storage.names);
    }
}
public class Storage
{
    public static string [] names = {"Ayush", "Anish", "Apple", "Ball"};
}

class UsingList
{
    public static void method1(string [] names)
    {
       // Loop 1: Converting to List
        names.ToList().ForEach((i) =>
        {
            Console.WriteLine("Method 1: "+ i);
        });
    }
}
class UsingArray
{
    public static void method2(string [] names)
    {
       // Loop 2: Using Array 
        Array.ForEach(names, e => {
            Console.WriteLine("Method 2:" + e);
        });
    }
}