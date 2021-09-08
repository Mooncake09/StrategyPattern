using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    class Player
    {
        public string Name { get; set; }
        public IWeapon Weapon { get; set; }
        public int Points { get; }
        public Player(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void Shoot()
        {
            Weapon.Shoot();
            Weapon.GiveStat();
        }
    }
}
