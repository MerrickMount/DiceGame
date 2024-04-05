using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dieclass
{
    public class die
    {
        private Random _generator;
        private int _roll;

        public die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }

        public die(int roll)
        {
            _generator = new Random();
            if (roll < 1)
                _roll = 1;
            else if (roll > 6)
                _roll = 6;
            else
                _roll = roll;
        }

        public int Roll { get { return _roll; } }

        public void RollDie()
        {
            _roll = _generator.Next(1, 7);

        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void DrawRoll()
        {
             
            switch (_roll)
            {
                case 1:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|   |");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|   |");
                    Console.WriteLine(" ---");
                    break;
                case 2:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o  |");
                    Console.WriteLine("|   |");
                    Console.WriteLine("|  o|");
                    Console.WriteLine(" ---");
                    break;
                case 3:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o  |");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|  o|");
                    Console.WriteLine(" ---");
                    break;
                case 4:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o o|");
                    Console.WriteLine("|   |");
                    Console.WriteLine("|o o|");
                    Console.WriteLine(" ---");
                    break;
                case 5:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o o|");
                    Console.WriteLine("| o |");
                    Console.WriteLine("|o o|");
                    Console.WriteLine(" ---");
                    break;
                    break;
                case 6:
                    Console.WriteLine(" ---");
                    Console.WriteLine("|o o|");
                    Console.WriteLine("|o o|");
                    Console.WriteLine("|o o|");
                    Console.WriteLine(" ---");
                    break;
            }
        }
    }
}
