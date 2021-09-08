using System;

namespace StrategyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player(new ScoutRifle(20));
            player.Shoot();
        }
    }
}
