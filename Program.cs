using dieclass;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userBalance, userBet, userGuess, dieTotal;
            userBalance = 100;
            Console.WriteLine("Welcome to the dice roller game");
            Console.WriteLine($"You have a balance of {userBalance.ToString("C")}");
            Console.WriteLine("Please Insert your bet amount");
            userBet = double.Parse( Console.ReadLine() );
            Console.WriteLine("What number are you betting on?");
            userGuess = double.Parse( Console.ReadLine() );
            die die1 = new die();
            die die2 = new die(4);
            Console.WriteLine("Rolling");
            Thread.Sleep(500);
            die1.RollDie();
            Console.WriteLine($"Die 1 = {die1}");
            Console.WriteLine("Rolling");
            Thread.Sleep(500);
            die1.DrawRoll();
            Console.WriteLine($"Die 2 = {die2}");
            die2.DrawRoll();
            Console.WriteLine($"The Total is {die1}");
        }
    }
}