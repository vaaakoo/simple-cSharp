using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userChoose;
            Console.WriteLine("Please choose a game: 1. guessing game or 2. simple math!!! ");
            userChoose = int.Parse(Console.ReadLine());

            if (userChoose == 1)
            {
                Console.WriteLine("Thanks, you choose Guessing Game! ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("This is the Our New Game Guess It...");
                Console.ResetColor();

                int userGuess;
                Random random = new Random();
                int randomNumber = random.Next(1, 101);

                Console.WriteLine("Please guess a number from 1 to 100");
                userGuess = int.Parse(Console.ReadLine());

                while (userGuess != randomNumber)
                {
                    if (userGuess > randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It is too high! Please try a lower number.");
                        Console.ResetColor();
                    }
                    else if (userGuess < randomNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It is too low! Please try a higher number.");
                        Console.ResetColor();
                    }

                    Console.WriteLine("Please guess again: ");
                    userGuess = int.Parse(Console.ReadLine());
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Congratulations, you guessed the number correctly!");
                Console.ResetColor();
            } else if (userChoose == 2)
            {
                Console.WriteLine("You choose simple Mathemathic Game!!");

                Console.WriteLine("What are your strengths in math? Are you better at 1. addition, 2. subtraction, 3. multiplication, or 4. division?");

                int userChoice;
                userChoice = int.Parse(Console.ReadLine());

                /* Simple Mathematics */
                if (userChoice == 1) //addition
                {
                    Console.WriteLine("addition a + b");
                    int a, b, answer;
                    Random random = new Random();
                    int score = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        a = random.Next(1, 101);
                        b = random.Next(1, 101);
                        answer = a + b;
                        Console.WriteLine("{0}: {1} + {2}",i+1,a,b);
                        int userAnswer = int.Parse(Console.ReadLine());
                        if (answer == userAnswer)
                        {
                            Console.WriteLine("You are Good In math!");
                            score++;
                        }else
                        {
                            Console.WriteLine("Wrong! answer is {0}", answer);
                        }
                    }
                    Console.WriteLine("Your score is {0} answer! ", score);



                }
                else if (userChoice == 2) //substract
                {
                    Console.WriteLine("substract a - b");

                    int a, b, answer;
                    Random random = new Random();
                    int score = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        a = random.Next(501, 1001);
                        b = random.Next(101, 501);
                        answer = a - b;
                        Console.WriteLine("{0}: {1} - {2}", i + 1, a, b);
                        int userAnswer = int.Parse(Console.ReadLine());
                        if (answer == userAnswer)
                        {
                            Console.WriteLine("You are Good In math!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong! answer is {0}", answer);
                        }
                    }
                    Console.WriteLine("Your score is {0} answer! ", score);

                }
                else if(userChoice == 3) //multiplication
                {
                    Console.WriteLine("multiplication a * b");

                    int a, b, answer;
                    Random random = new Random();
                    int score = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        a = random.Next(1, 101);
                        b = random.Next(1, 101);
                        answer = a * b;
                        Console.WriteLine("{0}: {1} * {2}", i + 1, a, b);
                        int userAnswer = int.Parse(Console.ReadLine());
                        if (answer == userAnswer)
                        {
                            Console.WriteLine("You are Good In math!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong! answer is {0}", answer);
                        }
                    }
                    Console.WriteLine("Your score is {0} answer! ", score);
                }
                else if (userChoice == 4) //division
                {
                    Console.WriteLine("division a / b");

                    int a, b, answer;
                    Random random = new Random();
                    int score = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        a = random.Next(51, 501);
                        b = random.Next(1, 11);
                        answer = a / b;
                        Console.WriteLine("{0}: {1} / {2}", i + 1, a, b);
                        int userAnswer = int.Parse(Console.ReadLine());
                        if (answer == userAnswer)
                        {
                            Console.WriteLine("You are Good In math!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong! answer is {0}", answer);
                        }
                    }
                    Console.WriteLine("Your score is {0} answer! ", score);
                }
            }

        }
    }
}
