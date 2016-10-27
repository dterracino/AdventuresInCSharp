namespace AdventuresInCSharp {
    using System;
    using System.Threading;

    public class Printer : IPrinter {
        private readonly int delayMs;
        private readonly int textBoxWidth;
        private Bounded<int> previousOffset; 

        public Printer(int textBoxWidth) : this(textBoxWidth, 20) {}

        public Printer(int textBoxWidth, int delayMs) {
            this.textBoxWidth = textBoxWidth;
            this.delayMs = delayMs;
            this.previousOffset = Bounded<int>.OfRangeStartingAtMin(0, textBoxWidth);
        }

        public bool CursorVisible {
            get { return Console.CursorVisible; }
            set { Console.CursorVisible = value; }
        }

        public void WriteLine(string s) {
            WriteLine(s, TextAlign.Left);
        }

        public void WriteLine(string s, TextAlign align) {
            WriteLineImpl(s, align, false);
        }

        public void WriteLineByCharacter(string s, TextAlign align) {
            WriteLineImpl(s, align, true);
        }

        public void AlignCursorUnderPrevious() {
            Console.Write(new string(' ', previousOffset.Current));
        }

        public void AlignCursorCenter() {
            Console.Write(new string(' ', textBoxWidth / 2));
        }

        public void WaitForUser() {
            Console.ReadKey();
        }

        public string GetUserInput() {
            return Console.ReadLine();
        }

        public void Clear() {
            Console.Clear();
        }

        public void PlaySoundBeep() {
            Console.Beep();
        }

        public void SetBackgroundWhite() {
            Console.BackgroundColor = ConsoleColor.White;
        }

        public void SetBackgroundBlack() {
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void WriteLineImpl(string s, TextAlign align, bool delay) {
            Action<string> print;
            if(delay) {
                print = WriteLineByCharacters;
            } else {
                print = Console.WriteLine;
            }

            if(align == TextAlign.Right) {
                previousOffset.Current = (textBoxWidth - s.Length);
                AlignCursorUnderPrevious();
                print(s);
            } else if(align == TextAlign.Center) {
                previousOffset.Current = (textBoxWidth - s.Length) / 2;
                AlignCursorUnderPrevious();
                print(s);
            } else if(align == TextAlign.WithPrevious) {
                AlignCursorUnderPrevious();
                print(s);
            } else { // TextAlign.Left is default
                previousOffset.Current = 0;
                print(s);
            }
        }

        private void WriteLineByCharacters(string s) {
            foreach(char c in s) {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.Write('\n');
        }
    }
}
