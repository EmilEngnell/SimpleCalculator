using System;

namespace Calculator
{
    /*
    * Block comment
    * many lines
    */
    class Program
    {
        //Here is where the program starts
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Calculator");//Just text,this will not b treated as code - notes for coder
            Console.WriteLine(" ");
            Console.WriteLine("What action would you like to perform?");
            Console.WriteLine(" ");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Substraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Exit");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter you first number:");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter your seccond number:");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;

        }
    }
}