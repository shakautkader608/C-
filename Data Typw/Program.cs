//using System;
//class Program
//{
//    static void Main()
//    {
//        int i = 0;
//        int a = int.MinValue;
//        int b = int.MaxValue;
//        Console.WriteLine("Min Value={0}",a);
//        Console.WriteLine("Max Value={0}", b);
//    }
//}

using System;
class Program
{
    static void Main()
    {
        string name = "\"Shakaut\"";
        string number = "one\ntwo\nthree";
        string number2= "one\\two\\hree";
        Console.WriteLine(name);
        Console.WriteLine(number);
        Console.WriteLine(number2);
    }
}