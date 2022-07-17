﻿using ActionAdventureGame.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAdventureGame.weapons
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("%%%%%%%%%% swinging a sword %%%%%%%%%%");
        }
    }
}
