// Ryan Gross
using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables and sets them = 0
            char ch;
            int number1 = 0;
            int number2 = 0;
            int userAnswer = 0;
            int ExpressionsCounter = 0;
            int score = 0;

            // takes in user input from menu and performs the switch
            do
            {
                // menu method displays options and converts user input form string to char
                menu();
                ch = Convert.ToChar(Console.ReadLine());

                // switch statment runs method depending on user input
                switch (ch)
                {
                case 'a':
                    // get the userAnswer by performing the ReadExpression method which passes numbers 1 & 2, ExpressionsCounter and returns userAnswer to main
                    userAnswer = ReadExpession(out number1, out number2, ref ExpressionsCounter);
                    break;
                case 'b':
                    // passes numbers 1 & 2, userAnswer and ExpressionsCounter into CheckAnswer method. Score is passed into main
                    CheckAnswer(number1 , number2, userAnswer, ExpressionsCounter, ref score);
                    break;
                case 'c':
                    // passes score and ExpressionsCounter into DisplayScore
                    DisplayScore(score, ExpressionsCounter);
                    break;
                }
              // Exits the switch statement  
            } while (ch != 'd');
        }

        // Menu method lists out options for user
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
            // reads users input
            string Expression = Console.ReadLine();
            // splits users input into number1, number2 and userAnswer
            string[] ExpressionComponents = Expression.Split('*', '=');
            // converts string to int and places it in the ExpressionComponents array
            number1 = Convert.ToInt32(ExpressionComponents[0]);
            number2 = Convert.ToInt32(ExpressionComponents[1]);
            int userAnswer = Convert.ToInt32(ExpressionComponents[2]);
            // counter adds 1 each time an expression is entered
            ExpressionsCounter ++;
            // sends userAnser value back to main
            return userAnswer;
        }


        public static int CheckAnswer(int number1, int number2, int userAnswer, int ExpressionsCounter, ref int score)
        {
            // declares correctAnswer variable by passing in number1 and number2 from main and multiplying them
            int correctAnswer = number1 * number2;

            if(ExpressionsCounter == 0)
            {
                // Tells user to enter an expression before they can check for the answer if no expression has been entered
                Console.WriteLine("Enter an expression by selecting option 'a' in the menu.");
            }
            else if(userAnswer == correctAnswer)
            {
                // Tells user it is correct and shows the correct answer if the users answer and the correct answer match
                Console.WriteLine("Correct. The right answer is {0}*{1}={2}.", number1, number2, correctAnswer);
                //counter adds 1 each time the user enters the correct answer
                score ++;
            }
            else
            {
                // Tells user it is incorrect and shows the correct answer if the users answer and the correct answer do not match
                Console.WriteLine("Incorrect. The right answer is {0}*{1}={2}.", number1, number2, correctAnswer);
            }
            // sends score value back to main
            return score;
        }

        static void DisplayScore(int score, int ExpressionsCounter)
        {
            // Displays score to user by passing in score and ExpressionsCounter from main
            Console.WriteLine("Your score is {0}/{1} expressions.", score, ExpressionsCounter);
        }
    }
}
