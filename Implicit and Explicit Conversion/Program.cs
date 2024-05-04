using System;
class Program
{
    static void Main()
    {
        int i = 100;
        float f = i;
        Console.WriteLine(i.GetType());
        Console.WriteLine(f);

        float ff = 125.34f;
        int ii = Convert.ToInt32(ff);
        Console.WriteLine(ii);
        Console.WriteLine(ff.GetType());

        string s = "100";
        int a = int.Parse(s);
        Console.WriteLine(a);
        string s2 = "100";
        string s3 = "100GT";
        int result = 0;
        int result2 = 0;
        bool isthisAnumner = int.TryParse(s2, out result); //Hrere Tryparse method convert the string to intiger and store it in result.Hrere "out" is output parameter.Intryparse method we have make sure 
        bool isthisAnumner12 = int.TryParse(s3, out result2); //Hrere Tryparse method convert the string to intiger and store it in result.Hrere "out" is output parameter.Intryparse method we have make sure 
        //we have to make sure that is this number can be covert intiger or not so that we have to check it using tryparse and for make sure we use boolian data type
        if (isthisAnumner)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please enter valid number ");
        }if (isthisAnumner12)
        {
            Console.WriteLine(result2);
        }
        else
        {
            Console.WriteLine("Please enter valid number ");
        }

    }
}