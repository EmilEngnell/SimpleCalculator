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
            switch (action) {
                case 1: {
                    result = Addition(input_1, input_2);
                    break;
                } 
                case 2: {
                    result = Substraction(input_1, input_2);
                    break;
                }
                case 3: {
                    result = Multiplication(input_1, input_2);
                    break;
                }
                case 4: {
                    result = Division(input_1, input_2);
                    break;
                }
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
            Console.WriteLine(" = {0}",result);
            Console.ReadKey();

        }
        //Addition
        public static int Addition(int input_1, int input_2) {
            int result = input_1 + input_2;
            return result;
        }
        //Substraction
        public static int Substraction(int input_1, int input_2) {
            int result = input_1 + input_2;
            return result;
        }
        //Multiplication
        public static int Multiplication(int input_1, int input_2) {
            int result = input_1 + input_2;
            return result;
        }
        //Division
        public static int Division(int input_1, int input_2) {
            int result = input_1 + input_2;
            return result;
        }
    }
}