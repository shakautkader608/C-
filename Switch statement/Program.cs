using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a numbr");
        int input=int.Parse(Console.ReadLine());
        

        //if (input == 10)
        //{
        //    Console.WriteLine("The number is 10");
        //}
        //else if (input == 20)
        //{
        //    Console.WriteLine("The number is 10");
        //}
        //else if (input == 30)
        //{
        //    Console.WriteLine("The number is 10");
        //} 
        // else if (input == 40)
        //{
        //    Console.WriteLine("The number is 10");
        //}
        //else
        //{
        //    Console.WriteLine("The number is not 10,20,30,40");
        //} We can use a different code using SWITCH which is more easier

        switch (input)
        {
            case 10:
                Console.WriteLine("This numner is 10");
                break;

            case 20:
                {
                    Console.WriteLine("This number is 20");
                    break;
                }
            case 30:
                {
                    Console.WriteLine("This number is 30");
                    break;
                }
            case 40:
                {
                    Console.WriteLine("This number is 40");
                    break;
                }
            default:
                {
                    Console.WriteLine("This are not 10,20,30,40");
                }
                break;
        }

        //More easier code is
        Console.WriteLine("Please enter a another numbr");
        int input2 = int.Parse(Console.ReadLine());
        switch (input2)
        {
            case 10:
            case 20:
            case 30:
                {
                    Console.WriteLine("The number is {0}", input2);
                }
                break;
            default:
                {
                    Console.WriteLine("These are not 10,20,30,40");
                }
                break;

        }
    }
}