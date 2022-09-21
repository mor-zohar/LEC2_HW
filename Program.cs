using System;

namespace Lec2_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            // EX_01
            Console.WriteLine("----------------- EX_1 -----------------\n");
            Console.WriteLine("Enter First Number:");
            int a1 = Convert.ToInt32(Console.ReadLine() + "\n");
            Console.WriteLine("Enter Second Number:");
            int a2 = Convert.ToInt32(Console.ReadLine() + "\n");
            Console.WriteLine("a1 = {0}", a1);
            Console.WriteLine("a2 = {0}\n", a2);

            Console.WriteLine("--------------------------------------------------------------------");

            // EX_2
            Console.WriteLine("----------------- EX_2 -----------------\n");
            Console.WriteLine("Enter Your Birth Year:");
            int bYear = Convert.ToInt32(Console.ReadLine() + "\n");
            Console.WriteLine("Your Birth Year Is: {0}", bYear);

            Console.WriteLine("--------------------------------------------------------------------");

            // EX_3
            Console.WriteLine("----------------- EX_3 -----------------\n");
            Console.WriteLine("Enter Your First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name:");
            string lName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Hello " + fName + " " + lName);

            Console.WriteLine("--------------------------------------------------------------------");

            // EX_4
            Console.WriteLine("----------------- EX_4 -----------------\n");
            Console.WriteLine("# HackerU Shop #\n" + "Please Enter Your Choice,Which Product You Like To Buy?\n" + "- Milk\n" + "- Chocolate\n" + "- Apple\n");
            string choice = Console.ReadLine();
            Console.WriteLine("Thank You For Buying {0}", choice);

            Console.WriteLine("--------------------------------------------------------------------");


            // EX_5
            Console.WriteLine("----------------- EX_5 -----------------\n");
            Console.WriteLine("Enter A Year");
            string year = Console.ReadLine();
            Console.WriteLine("Enter A Month");
            string month = Console.ReadLine();
            Console.WriteLine("Enter A Day");
            string day = Console.ReadLine();

            Console.WriteLine(day + "." + month + "." + year);
            Console.WriteLine(day + "-" + month + "-" + year);
            Console.WriteLine(day + @"\" + month + @"\" + year);

            Console.WriteLine("--------------------------------------------------------------------");


            // EX_6
            Console.WriteLine("----------------- EX_6 -----------------\n");
            Console.WriteLine("Enter A Year");
            int year1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Month");
            string month1 = Console.ReadLine();
            Console.WriteLine("Enter A Day");
            string day1 = Console.ReadLine();

            Console.WriteLine(day1 + "." + month1 + "." + year1);
            Console.WriteLine(day1 + "-" + month1 + "-" + year1);
            Console.WriteLine(day1 + @"\" + month1 + @"\" + year1);

            Console.WriteLine("--------------------------------------------------------------------");

        }
    }
}