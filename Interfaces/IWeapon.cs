using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    interface IWeapon : IShoot, IReload
    {
        public float Accuracy { get; set; }
        public int ClipSize { get; set; }
        public int BulletsCountInClip { get; set; }
        public void GiveStat()
        {
            Console.WriteLine($"Maximum clip size: {ClipSize}");
            Console.WriteLine($"Bullets in clip: {BulletsCountInClip}");
            Console.WriteLine($"Accuracy: {Accuracy}");
        }
    }
}
