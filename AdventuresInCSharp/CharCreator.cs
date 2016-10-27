using System;

namespace AdventuresInCSharp
{
    public class CharCreator
    {
        public static void show()
        {
            Program.CenterText("What name will you give the old man?", 12);
            Console.CursorVisible = true;
            Console.SetCursorPosition((Console.WindowWidth - 9) / 2, 13);
            //var P1 = new Player();
            var P2 = Console.ReadLine();
            Player.Name = P2;
            Console.CursorVisible = false;
            Console.Clear();
            Program.CenterText("Are you sure you want to be called " + Player.Name + " ?", 15);
            Program.CenterText("press Y for yes or N for no", 20);
            ConsoleKeyInfo answer = Console.ReadKey();

            if (answer.KeyChar == 'y' || answer.KeyChar == 'Y')
            {
                Console.Clear();
                return;
            }
            else if (answer.KeyChar == 'n' || answer.KeyChar == 'N')
            {
                Console.Clear();
                show();
            }
            else
            {
                Console.Clear();
                Program.CenterText("You did not give a correct response... to try again press any key", 12);
                Console.ReadKey();
                Console.Clear();
                show();
            }
        }
    }
}