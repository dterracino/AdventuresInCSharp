namespace AdventuresInCSharp {
    using System.Linq;

    public class CharCreator : IChapter {
        private readonly Player player;
        private readonly IPrinter printer;

        public CharCreator(IPrinter printer, Player player) {
            this.printer = printer;
            this.player = player;
        }

        public void Show() {
            bool nameOk = false;
            while(!nameOk) {
                printer.WriteLineByCharacter("What name will you give the old man?", TextAlign.Center);
                printer.CursorVisible = true;
                printer.AlignCursorUnderPrevious();

                player.Name = printer.GetUserInput();

                printer.CursorVisible = false;
                printer.Clear();
                printer.WriteLineByCharacter("Are you sure you want to be called " + player.Name + " ?", TextAlign.Center);
                printer.WriteLineByCharacter("press Y for yes or N for no", TextAlign.Center);
                printer.AlignCursorCenter();
                string answer = printer.GetUserInput();

                printer.Clear();
                if (answer.ToLower().First() == 'y') {
                    nameOk = true;
                } else if (answer.ToLower().First() != 'n') {
                    printer.WriteLineByCharacter("You did not give a correct response... to try again press any key", TextAlign.Center);
                    printer.WaitForUser();
                    printer.Clear();
                }
            }
        }
    }
}
