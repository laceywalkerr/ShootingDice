using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "Smacky talky!";
        public override int Roll()
        {
            Console.WriteLine($"'{Taunt}' proclaimed {Name}.");
            return base.Roll();

        }
    }
}