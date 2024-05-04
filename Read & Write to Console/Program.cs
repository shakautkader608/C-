Read & write


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter First Name");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Please Enter Last Name");
        string LastName = Console.ReadLine();
        //Console.WriteLine("Hello "  + UserName);
        Console.WriteLine("Hello {0} {1}", FirstName, LastName);
    }
}



