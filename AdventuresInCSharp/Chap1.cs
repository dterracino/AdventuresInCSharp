using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventuresInCSharp
{
    class Chap1
    {
        
        public string[] ch1txt = {
            "\n\n\n",
            "\n\n\n",
            "\n\n\n",
            "\"I will not ask you this again\" he threatens",
            "you respond \"Console.WriteLine(\"My Name is " + Player.getName() + " \");\"",
            "",
            ""
        };


        public void show()
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
