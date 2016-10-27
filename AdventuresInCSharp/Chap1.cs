namespace AdventuresInCSharp
{
    public static class Chap1
    {
        public static string[] ch1txt = {
            "\n\n\n",
            "\n\n\n",
            "\n\n\n",
            "\"I will not ask you this again\" he threatens",
            "you respond \"Console.WriteLine(\"My Name is " + Player.Name + " \");\"",
            "",
            ""
        };

        public static void show()
        {
            int strLine = 5;
            foreach (string text in ch1txt)
            {
                strLine++;
                Program.CenterText(text, strLine);
            }
        }
    }
}