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
            "Oh, I get it. That was like a joke, except not funny.",
            "You will never rise from the ashes of your shame and humiliation!",
            "Isn't it rather dangerous to use ones entire vocabulary in a single sentence?",
            "Let me guess, you have a great personality.",
            "Say that to my face, you limp noodle!",
            "May all your bacon burn!",
            "You really are the worst.... EVER!",
            "You're tacky, and I hate you.",
            "You have a very cruel sense of humor.",
            "No offence, but I don't really care.",
            "You smell funny.",
            "OOH, BURN!",
            "How do I say, 'You're the grossest thing ever' without offending you?",
            "I hope the devil uses your backbone as a ladder to pick apple's in the garden of hell.",
            "You're horrible, and you need to go down.",
            "I do not consider you a vulture, I consider you something a vulture would eat."
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