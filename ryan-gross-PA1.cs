// Ryan Gross
using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char ch;
            do
            {
                ch = menu();
                switch (ch)
                {
                case 'a':
                    ReadExpession();
                    //put a flag
                    break;
                case 'b':
                    CheckAnswer();
                    //put a flag
                    break;
                case 'c':
                    DisplayScore();
                    break;
                }
            } while (ch != 'd');
        }

        public static char menu()
        {
            Console.WriteLine("Choose an option by entering a,b,c or d.");
            Console.WriteLine("a. Enter expression");
            Console.WriteLine("b. Check the answer");
            Console.WriteLine("c. Display score");
            Console.WriteLine("d. Exit");
            return ch;
        }

        static void ReadExpession()
        {

            Console.WriteLine("Enter an expression with two numbers separated by a * and the answer by an =: ");
            string Expression = Console.ReadLine();
            string[] ExpressionComponents = Expression.Split('*', '=');
            int Number1 = Convert.ToInt32(ExpressionComponents[0]);
            int Number2 = Convert.ToInt32(ExpressionComponents[1]);
            int Answer = Convert.ToInt32(ExpressionComponents[2]);
        }


        static void CheckAnswer()
        {

        }

        static void DisplayScore()
        {

        }
    }
}
