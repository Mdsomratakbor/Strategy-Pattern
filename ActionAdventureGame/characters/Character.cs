using ActionAdventureGame.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAdventureGame.characters
{
   public abstract class Character
    {
         IWeaponBehavior weapon;
        public void SetWeapon(IWeaponBehavior _weapon)
        {
            this.weapon = _weapon;
        }
        public void UsedWeapon()
        {
            this.weapon.UseWeapon();
        }
        public abstract void Fight();
    }
}
