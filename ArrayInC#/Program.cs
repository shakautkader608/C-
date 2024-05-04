using System;
class Program
{
    static void Main()
    {
        //int[] num = new int[4];
        Console.WriteLine("Please Enter a number");
        string input=(Console.ReadLine()); //Readline return a number as a string formate so we have to convert it to integer//
        //Console.WriteLine(number);
        int number;

        if (int.TryParse(input, out number))
        {
             Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Please enter a  Integer ");
        }
        
    }
}