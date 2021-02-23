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
            bool alive = true;

            while (alive)
            {


                Console.WriteLine("Welcome to the Basic Calculator\nWhat action would you like to perform?\n");//Just text,this will not b treated as code - notes for coder
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Substraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Exit");
                double action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please, enter you first number:");
                double input_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please, enter your seccond number:");
                double input_2 = Convert.ToInt32(Console.ReadLine());
                double result = 0;
                switch (action)
                {
                    case 1:
                        {
                            result = Addition(input_1, input_2);
                            break;
                        }
                    case 2:
                        {
                            result = Substraction(input_1, input_2);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(input_1, input_2);
                            break;
                        }
                    case 4:
                        {
                            result = Division(input_1, input_2);
                            break;
                        }
                    case 5:
                        alive = false;
                        break;
                       

                    default:
                        Console.WriteLine("I beg your pardon?");
                        break;
                }
                Console.WriteLine(" = {0}", result);
                Console.ReadKey();
            }
        }
        //Addition
        public static double Addition(double input_1, double input_2)
        {
            double result = input_1 + input_2;
            return result;
        }
        //Substraction
        public static double Substraction(double input_1, double input_2)
        {
            double result = input_1 - input_2;
            return result;
        }
        //Multiplication
        public static double Multiplication(double input_1, double input_2)
        {
            double result = input_1 * input_2;
            return result;
        }
        //Division
        public static double Division(double input_1, double input_2)
        {

            {
                double result = input_1 / input_2;
                if (input_1 != 0)
                {

                }
                else if (input_2 != 0)
                {
                    Console.WriteLine("Error! Infinity Guantlet required to divide by 0. Thanos is not amused!");
                }
                return result;
            }

        }
            
    } 
}