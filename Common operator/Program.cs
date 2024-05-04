//using System;
//class Program
//{
//    static void Main()
//    {
//        int a = 10;
//        int b = 10;


//        int result = a / b;
//        Console.WriteLine("Result = {0}", result);

//        if (a == b)
//        {
//            Console.WriteLine("Number Are Same");
//        }



//    }
//}

using System;
class Program
{
    static void Main()
    {
        int number = 15;
        //bool Isnumber10;

        //if (number == 10)
        //{
        //    Isnumber10 = true;
        //}
        //else
        //{
        //    Isnumber10 = false;
        //}instead of so many line we can just use ternanry operator like this
        bool isnumber10 = number == 15 ? true : false;
        Console.WriteLine("Number==15 is {0}", isnumber10);
    }
   
} 