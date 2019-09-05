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
                menu();
                ch = Convert.ToChar(Console.ReadLine());

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

        public static void menu()
        {
            Console.WriteLine("Choose an option by entering a,b,c or d.");
            Console.WriteLine("a. Enter expression");
            Console.WriteLine("b. Check the answer");
            Console.WriteLine("c. Display score");
            Console.WriteLine("d. Exit");
        }

        public static int ReadExpession(out int number1, out int number2)
        {
            int ExpressionsCounter = 0;

            Console.WriteLine("Enter an expression with two numbers separated by a * and the answer separted by an = : ");
            string Expression = Console.ReadLine();
            string[] ExpressionComponents = Expression.Split('*', '=');
            int number1 = Convert.ToInt32(ExpressionComponents[0]);
            int number2 = Convert.ToInt32(ExpressionComponents[1]);
            int userAnswer = Convert.ToInt32(ExpressionComponents[2]);
            ExpressionsCounter ++;

            
        }


        public static void CheckAnswer()
        {
            int correctAnswer = number1 * number2;

            if(ExpressionsCounter == 0)
            {
                Console.WriteLine("Enter an expression by selecting option a in the menu.");
            }
            else if(userAnswer == correctAnswer)
            {
                Console.WriteLine("Correct. The right answer is {0}*{1}={2}.", number1, number2, correctAnswer);
                score ++;
            }
            else
            {
                Console.WriteLine("Incorrect. The right answer is {0}*{1}={2}.", number1, number2, correctAnswer);
            }
        }

        static void DisplayScore()
        {
            int score = 0;

            Console.WriteLine("Your score is {0}/{1} expressions.", score, ExpressionsCounter);
        }
    }
}
