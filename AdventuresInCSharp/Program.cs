namespace AdventuresInCSharp {
    using System;
    using System.Collections.Generic;

    internal class Program {
        private static void Main() {
            //Set Console Dimensions and Settings
            int height = 40;
            int width = 120;
            Console.SetWindowSize(width, height);
            IPrinter printer = new Printer(width) { CursorVisible = false };
            var player = new Player();

            //beginning of game
            IList<IChapter> chapters = new List<IChapter> { new TitlePage(printer), new Chap0(printer), new CharCreator(printer, player), new Chap1(printer, player) };
            foreach(IChapter chapter in chapters) {
                chapter.Show();
            }

            //Do not remove until done.
            Console.ReadKey();
        }
    }
}
