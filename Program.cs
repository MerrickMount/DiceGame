using dieclass;
using System.Security.Cryptography.X509Certificates;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double betType, userDecision, timesPlayed;
            double userBalance, userBet, userGuess, dieTotal, userWinnings;
            userBalance = 100;
            timesPlayed = 0;
            Console.WriteLine("Welcome to the dice roller game");
            while (userBalance > 0)
            {
                Console.WriteLine($"You have a balance of {userBalance.ToString("C")}");
                Console.WriteLine("if you want to exit type 1 if you would like to continue type 2");
                userDecision = double.Parse(Console.ReadLine());
                if (userDecision == 1)
                {
                    double userProfit;
                    userProfit = userBalance - 100;
                    Console.WriteLine($"your Balance is {userBalance.ToString("C")}, You ended with {userProfit.ToString("C")} Profit in {timesPlayed} rounds of play");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please Insert your bet amount");
                    userBet = double.Parse(Console.ReadLine());
                    userBalance = userBalance - userBet;
                    Console.WriteLine("What bet type would you like to do?");
                    Thread.Sleep(1000);
                    Console.WriteLine("Here are the options: Double (A win is a 2x bet amount + bet).");
                    Console.WriteLine("Even (A win is a 1x bet amount + bet).");
                    Console.WriteLine("Half (A win is a 0.5x bet amount + bet).");
                    Console.WriteLine(" To select Double enter 1, to select Even enter 2, to select Half enter 3");
                    betType = double.Parse(Console.ReadLine());
                    if (betType == 1)
                    {
                        userWinnings = (userBet * 3);
                    }
                    if (betType == 2)
                    {
                        userWinnings = (userBet * 2);
                    }
                    if (betType == 3)
                    {
                        userWinnings = (userBet * 1.5);
                    }
                    Console.WriteLine("What number are you betting on?");
                    userGuess = double.Parse(Console.ReadLine());
                    die die1 = new die();
                    die die2 = new die();
                    Console.WriteLine("Rolling");
                    Thread.Sleep(500);
                    die1.RollDie();
                    Console.WriteLine($"Die 1 = {die1}");
                    Console.WriteLine("Rolling");
                    Thread.Sleep(500);
                    die1.DrawRoll();
                    Console.WriteLine($"Die 2 = {die2}");
                    die2.DrawRoll();
                    dieTotal = die1.Roll + die2.Roll;
                    Console.WriteLine($"The Total is {dieTotal}");

                    if (userGuess == dieTotal)
                    {
                        if (betType == 1)
                        {
                            userWinnings = (userBet * 3);
                            Console.WriteLine("You guessed right");
                            Console.WriteLine($"You win {userWinnings}");
                            timesPlayed++;
                        }
                        if (betType == 2)
                        {
                            userWinnings = (userBet * 2);
                            Console.WriteLine("You guessed right");
                            Console.WriteLine($"You win {userWinnings}");
                            timesPlayed++;
                        }
                        if (betType == 3)
                        {
                            
                            userWinnings = (userBet * 1.5);
                            Console.WriteLine("You guessed right");
                            Console.WriteLine($"You win {userWinnings.ToString("C")}");
                            userBalance = userBalance + userWinnings;
                            timesPlayed++;
                        }

                    }
                    else
                    {
                        Console.WriteLine("You did not guess the right number. Try again");
                        Thread.Sleep(1000);
                        timesPlayed++;
                    }
                }

            }
        }
    }
}