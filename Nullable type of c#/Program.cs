using System;
class Program
{
    static void Main()
    {
        //bool? areyouamajor = true;
        //if (areyouamajor == true)
        //{
        //    Console.WriteLine("The user is Major");
        //}
        //else if (areyouamajor == false)
        //{
        //    Console.WriteLine("The user is not Major");
        //}
        //else {

        //    Console.WriteLine("User don't select any item");

        //}

        int? ticketsonsale = 1200;
        //int ticketavailable;

        //if (ticketsonsale == null)
        //{
        //    ticketavailable = 0;
        //}
        //else
        //{
        //    ticketavailable = ticketsonsale.Value;
        //}instead of this code we can use it in a single line

        int ticketsAvailable = ticketsonsale ?? 0;



        Console.WriteLine("ticketavailable= {0}", ticketsAvailable);
    }
}