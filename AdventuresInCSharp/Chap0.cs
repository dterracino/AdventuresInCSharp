namespace AdventuresInCSharp {
    using Properties;

    public class Chap0 : IChapter {
        private readonly IPrinter printer;

        public Chap0(IPrinter printer) {
            this.printer = printer;
        }

        public void Show() {
            foreach (string s in Resources.Chapter0a.Split('\n')) {
                printer.WriteLineByCharacter(s, TextAlign.Center);
            }
            printer.WaitForUser();
            printer.Clear();

            printer.SetBackgroundWhite();
            printer.Clear();
            printer.PlaySoundBeep();
            printer.SetBackgroundBlack();
            printer.Clear();

            foreach(string text in Resources.Chapter0b.Split('\n')) {
                printer.WriteLineByCharacter(text, TextAlign.Center);
            }
            printer.WaitForUser();
            printer.Clear();
        }
    }
}
