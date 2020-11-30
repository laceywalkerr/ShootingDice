using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            if (myRoll < otherRoll)
            {
                throw new RageQuitException();
            }

            DecalreWinner(this, myRoll, other, otherRoll);
        }
    }
}