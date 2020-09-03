using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine();
            Console.WriteLine($"Please enter a number {Name}:");
            bool response = int.TryParse(Console.ReadLine(), out int input);
            while (!response)
            {
                Console.WriteLine($"Please enter a number {Name}:");
                response = int.TryParse(Console.ReadLine(), out input);
            }
            Console.WriteLine("-------------------");
            return input;
        }
    }
}