using ActionAdventureGame.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAdventureGame.weapons
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("%%%%%%%%%% fight with an bow and arrow %%%%%%%%%%");
        }
    }
}
