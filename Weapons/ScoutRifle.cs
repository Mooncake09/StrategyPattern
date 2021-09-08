using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    class ScoutRifle : IWeapon
    {
        public int ClipSize { get; set; }
        public int BulletsCountInClip { get; set; }
        public float Accuracy { get; set; }
        public ScoutRifle(int clipSize = 10)
        {
            if (clipSize > 0 && clipSize <= 25) 
            {
                ClipSize = clipSize;
            }
            else
            {
                ClipSize = 10;
            }
            BulletsCountInClip = clipSize;
            ComputeAccuracy();
        }

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
            if (BulletsCountInClip != 0)
            {
                Console.WriteLine("SingleShot");
                BulletsCountInClip -= 1;
            }
        }
        private void ComputeAccuracy()
        {
            Accuracy = (90f - ClipSize) / 100f;
        }
    }
}
