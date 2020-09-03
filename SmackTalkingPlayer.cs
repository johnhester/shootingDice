using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {

        public string Taunt = "Git gud scrub!";

        public override int Roll()
        {
            Random rnd = new Random();
            // write a random taunt when you roll
            Console.WriteLine();
            Console.WriteLine($"{Name} shouts: '{Taunt}'");
            Console.WriteLine();
            // Return a random number between 1 and DiceSize
            return rnd.Next(DiceSize) + 1;

        }
    }
}