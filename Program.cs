using dieclass;
using System.Security.Cryptography.X509Certificates;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userDecision;
            double betType, timesPlayed;
            double userBalance, userBet, userGuess, dieTotal, userWinnings;
            userBalance = 100;
            timesPlayed = 0;
            Console.WriteLine("Welcome to the dice roller game");
            while (userBalance > 0)
            {
                Console.WriteLine($"You have a balance of {userBalance.ToString("C")}");
                Console.WriteLine("Click enter to continue. If you would like to exit press 1");
                userDecision = Console.ReadLine();
                if (userDecision == "1")
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
                    Console.WriteLine("Here are the options:");
                    Thread.Sleep(500);
                    Console.WriteLine("1: Double (A win is a 2x bet amount + bet).");
                    Console.WriteLine("2: Even Sum (A win is a 1x bet amount + bet).");
                    Console.WriteLine("3: Odd Sum (A win is a 1x bet amount + bet).");
                    Console.WriteLine("4: Not Double (A win is 0.5x bet amount + bet");
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

                    if ((die1.Roll == die2.Roll) && userGuess == 1)
                    {
                        userWinnings = (userBet * 3);
                        Console.WriteLine("You guessed right");
                        Console.WriteLine($"You win {userWinnings}");
                        userBalance = userBalance + userWinnings;
                        timesPlayed++;
                        Thread.Sleep(2000);
                    }
                    else if ((dieTotal == 2 || dieTotal == 4 || dieTotal == 6 || dieTotal == 8 || dieTotal == 10 || dieTotal == 12) && userGuess == 2)
                    {
                        userWinnings = (userBet * 2);
                        Console.WriteLine("You guessed right");
                        Console.WriteLine($"You win {userWinnings}");
                        userBalance = userBalance + userWinnings;
                        timesPlayed++;
                        Thread.Sleep(2000);

                    }
                    else if ((dieTotal == 1 || dieTotal == 3 || dieTotal == 5 || dieTotal == 7 || dieTotal == 9 || dieTotal == 11) && userGuess == 3)
                    {
                        userWinnings = (userBet * 2);
                        Console.WriteLine("You guessed right");
                        Console.WriteLine($"You win {userWinnings.ToString("C")}");
                        userBalance = userBalance + userWinnings;
                        timesPlayed++;
                        Thread.Sleep(2000);

                    }
                    else if ((die1.Roll != die2.Roll) && userGuess == 4)
                    {
                        userWinnings = (userBet * 1.5);
                        Console.WriteLine("You guessed right");
                        Console.WriteLine($"You win {userWinnings.ToString("C")}");
                        userBalance = userBalance + userWinnings;
                        timesPlayed++;
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("You did not guess right");
                        timesPlayed++;
                        Thread.Sleep(2000);
                    }

                }

            }
        }
    }
}