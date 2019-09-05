// Ryan Gross
using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int number1 = 0;
            int number2 = 0;
            int userAnswer = 0;
            int ExpressionsCounter = 0;
            int score = 0;

            do
            {
                menu();
                ch = Convert.ToChar(Console.ReadLine());

                switch (ch)
                {
                case 'a':
                    ReadExpession(out number1, out number2, ref ExpressionsCounter);
                    //put a flag
                    break;
                case 'b':
                    CheckAnswer(number1 , number2, userAnswer, ExpressionsCounter, score);
                    //put a flag
                    break;
                case 'c':
                    DisplayScore(score, ExpressionsCounter);
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

        public static int ReadExpession(out int number1, out int number2, ref int ExpressionsCounter)
        {

            Console.WriteLine("Enter an expression with two numbers separated by a * and the answer separted by an = : ");
            string Expression = Console.ReadLine();
            string[] ExpressionComponents = Expression.Split('*', '=');
            number1 = Convert.ToInt32(ExpressionComponents[0]);
            number2 = Convert.ToInt32(ExpressionComponents[1]);
            int userAnswer = Convert.ToInt32(ExpressionComponents[2]);
            ExpressionsCounter ++;

            return userAnswer;
        }


        public static void CheckAnswer(int number1, int number2, int userAnswer, int ExpressionsCounter, int score)
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

        static void DisplayScore(int score, int ExpressionsCounter)
        {

            Console.WriteLine("Your score is {0}/{1} expressions.", score, ExpressionsCounter);
        }
    }
}
