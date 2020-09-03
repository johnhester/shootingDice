using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts = new List<string>
        {
            "Ugh, you've got little ass teeth... like dolphin teeth!",
            "I hope all the bad things in life happen to you and nobody else but you.",
            "Y'all a bunch of markass marks, trickass marks, punk bitches, skip skaps, skinks, and scallywags!",
            "I was a millionaire, but I bought my momma a car and spent the rest on PCP.",
            "Y'know if you shoot someone below the knee it doesn't count as attempted murder.",
            "Real hatin man, that's like a artform man. It's like. You like born a hater man like myself. Lotta cats think they hate, but I'm mad at everything man. Brother got a nice car man, why you got a car man? I only got one car man. Why you got three cars or a wife or all that, man that's played out man. I'll hate on a player till they're broke or aint got nothin' like me. That's what real hatin' is all about man."
        };

        public override int Roll()
        {
            Random rnd = new Random();
            // write a random taunt when you roll
            int tauntIndex = rnd.Next(0, Taunts.Count);
            Console.WriteLine();
            Console.WriteLine($"{Name} shouts: '{Taunts[tauntIndex]}'");
            Console.WriteLine();
            // Return a random number between 1 and DiceSize
            return rnd.Next(DiceSize) + 1;

        }

    }
}