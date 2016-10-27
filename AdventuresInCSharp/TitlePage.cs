namespace AdventuresInCSharp {
    public class TitlePage : IChapter {
        private readonly IPrinter printer;

        public TitlePage(IPrinter printer) {
            this.printer = printer;
        }

        public void Show() {
            printer.WriteLineByCharacter("Welcome to the Adventure of a Type Time!", TextAlign.Center);
            printer.WriteLineByCharacter("Adventures in C#", TextAlign.Center);
            printer.WriteLineByCharacter("Press any key to begin!", TextAlign.Center);
            printer.WaitForUser();
            printer.Clear();
        }
    }
}
