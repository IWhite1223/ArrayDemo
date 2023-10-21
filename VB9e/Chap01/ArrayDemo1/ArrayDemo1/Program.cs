using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int option = 1;
            int position;

            while (option != 4)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("(1) To view the List in order from the first to last position");
                Console.WriteLine("(2) To view the list in order from");
                Console.WriteLine("(3) Choose a specific position to view");
                Console.WriteLine("(4) Quit the application");
                Console.Write("Enter number from the above options: ");

                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                   case 1:

                        for (int i = 0; i < 20; i++)
                            Console.WriteLine("{0} ", number[i]);
                        Console.WriteLine();
                        break;
                    
                    case 2:

                        for (int i = 20 ; i <= 0; i--)
                            Console.WriteLine("{0} ", number[i]);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Enter position (1..10): ");
                        position = Convert.ToInt32(Console.ReadLine());
                        Console.Write("{0} ", number[position - 1]);
                        Console.WriteLine();
                        break;

                    default:
                        if (option != 4) Console.WriteLine("Invalid option number");
                        break;


                }





            }
        }
    }
}
