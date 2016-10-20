using System;

namespace AdventuresInCSharp
{
    public class TitlePage
    {
        public static void show()
        {
            Program.CenterText("Welcome to the Adventure of a Type Time!", 12);
            Program.CenterText("Adventures in C#", 16);
            Program.CenterText("Press any key to begin!", 30);

            Console.ReadKey();
            Console.Clear();
        }
    }
}