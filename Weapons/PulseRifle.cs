using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    class PulseRifle : IWeapon
    {
        public int ClipSize { get; set; }
        public int BulletsCountInClip { get; set; }
        public int Burst { get; set; }
        public float Accuracy { get; set; }

        public void Reload()
        {
            if (BulletsCountInClip < ClipSize)
            {
                BulletsCountInClip = ClipSize;
                Console.WriteLine("Reloaded!");
            }
        }

        public void Shoot()
        {
            if (BulletsCountInClip > 0)
            {
                Console.WriteLine($"Making {Burst} shoots");
                BulletsCountInClip -= Burst;
            }
            
        }
    }
}
