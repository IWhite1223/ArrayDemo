using System;
using static System.Console;

class main
{
    static void Main (string[] args)
    {
        Console.WriteLine("Hello, Please enter price of item ");
        double userinput;
        double Limit = 8000;
        userinput = Convert.ToDouble (Console.ReadLine());

        if (userinput < Limit)
        {
            Console.WriteLine("Approved!");
          
        }
        else 
         Console.WriteLine("Declined. Enter amount under the limit of 8000");














    }
       

}



