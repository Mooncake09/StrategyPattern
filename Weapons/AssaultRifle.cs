using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    class AssaultRifle : IWeapon
    {
        public int ClipSize { get; set; }
        public int BulletsCountInClip{ get; set; }
        public int Burst { get; set; }
        public float Accuracy { get; set; }
        public AssaultRifle(int clipSize, int burst)
        {
            if (clipSize > 0 && clipSize < 100)
            {
                ClipSize = clipSize;
                BulletsCountInClip = ClipSize;
                ComputeAccuracy();
            }
            if (burst <= clipSize) Burst = burst;
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
            if (BulletsCountInClip != 0 )
            {
                Console.WriteLine("Full auto fire");
                BulletsCountInClip -= Burst;
            }
        }
        private void ComputeAccuracy()
        {
            Accuracy = (100f - ClipSize) / 100f;
            if (Accuracy < 0.1f) Accuracy = 0.1f;
        }
    }
}
