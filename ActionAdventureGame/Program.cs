using ActionAdventureGame.characters;
using ActionAdventureGame.weapons;
using System;

namespace ActionAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor
          = ConsoleColor.Blue;
           
            Console.WriteLine("*****^^^^^^^^^^^^ Game Start *****^^^^^^^^^^^^");
            Console.WriteLine("\n");

            Console.ForegroundColor
         = ConsoleColor.White;
            Character queen = new Queen();
            queen.Fight();
            queen.SetWeapon(new AxeBehavior());
            queen.UsedWeapon();
          

            Console.WriteLine();
            Console.ForegroundColor
        = ConsoleColor.Red;

            Character king = new King();
            king.Fight();
            king.SetWeapon(new KnifeBehavior());
            king.UsedWeapon();
   


            Console.WriteLine();
            Console.ForegroundColor
        = ConsoleColor.Yellow;
            Character knight = new Knight();
            knight.Fight();
            knight.SetWeapon(new SwordBehavior());
            knight.UsedWeapon();
       

            Console.WriteLine();
            Console.ForegroundColor
        = ConsoleColor.Cyan;
            Character troll = new Troll();
            troll.Fight();
            troll.SetWeapon(new BowAndArrowBehavior());
            troll.UsedWeapon();
       
        }
    }
}
