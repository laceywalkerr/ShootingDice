using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> _allTaunts = new List<string>()
        {
            "Ok Boomer",
            "Go eat a Tide Pod",
            "Oh, I get it. That was like a joke, except not funny."
        };

        public override void Play(Player other)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, _allTaunts.Count);
            string randomTaunt = _allTaunts[randomIndex];

            Console.WriteLine($"Hey {other.Name}! {randomTaunt}");
            base.Play(other);
        }
    }
}