using ActionAdventureGame.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAdventureGame.weapons
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("😣😣😣😣😣😣 cutting with an knife 😣😣😣😣😣😣😣😣");
        }
    }
}
