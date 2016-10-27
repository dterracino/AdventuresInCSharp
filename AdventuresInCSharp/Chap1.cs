namespace AdventuresInCSharp {
    public class Chap1 : IChapter {
        private readonly Player player;
        private readonly IPrinter printer;

        public Chap1(IPrinter printer, Player player) {
            this.printer = printer;
            this.player = player;
        }

        public void Show() {
            foreach(string text in GetText(player)) {
                printer.WriteLineByCharacter(text, TextAlign.Center);
            }
        }

        private static string[] GetText(Player player) {
            return new[] {
                "\n\n\n",
                "\n\n\n",
                "\n\n\n",
                "\"I will not ask you this again\" he threatens",
                "you respond \"Console.WriteLine(\"My Name is " + player.Name + " \");\"",
                "",
                ""
            };
        }
    }
}
