/* Overall Goals:
 * Learn to program.
 * Learn the C# language.
 * Make a text adventure game to help to learn and teach the basics of C# programming.
 * Have FUN! If it is not fun then don't do it!
 */

/* Notes:
 * 
 * ()UI design and layout
 * ****(X)Set window size to allow for screen formatting Height = 40 Width = 120
 * ****()Health and XP layout
 * ()Health system
 * ****()Reading Books recharge health
 * ()XP sysytem
 * ()Level system
 * ()Inventory system
 * ()Create multiple choice Q and A battles
 * ****()Timed battle system
 * ****()Wrong answer removes health
 * ****()Correct answer damages enemy
 * ()Library of books
 * ()Location list
 * ()Money system
 * ()Store system
 * ()UI design and layout
 * ()List of Q and A
 * ()Quest system
 * ()Saving and Loading
 * ()Movement
 * ()Items list
 * ()Enemy List
 * ()Loot System
 * ()Achievements
 * ()Quest Rewards
 * ()Map
 * 
 * screen / scene methods and a state, player, monster class would probably be something that's easy to figure out on how to do it
 *
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventuresInCSharp
{
    class Program
    {
        static void Main()
        {
            //Set Console Dimensions and Settings
            int height = 40;
            int width = 120;
            Console.SetWindowSize(width, height);
            Console.CursorVisible = false;

            //beginning of game
            TitlePage.show();
            new Chap0().show();
           CharCreator.show();
            new Chap1().show();
 
            //Do not remove until done.
            Console.ReadKey();
        }

        public static void CenterText(string text,int line)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, line);
            Console.WriteLine(text);
        }

    }
}




