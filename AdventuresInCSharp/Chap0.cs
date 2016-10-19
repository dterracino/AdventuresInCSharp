using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventuresInCSharp
{
    public class Chap0
    {

        public string[] proText = {
            "Welcome to the City Library History Dept.                       Today's date is 10-1-2016",
            "-----------------------------------------------------------------------------------------",
            "\n\n\n",
            "The History of our world as we know it to be:                                            ",
            "\n\n\n",
            "B.C.     \"Before the Language of C\"                                                       ",
            "0 Dayz   The Years between these events are known as \"The Day Zero Events\"                ",
            "A.D.     \"After DOS\"                                                                      ",
            "8 A.D.   Education starts to bloom                                                       ",
            "16 A.D.  The Beginning of the Golden Era                                                 ",
            "32 A.D.  The Height of the Golden Era                                                    ",
            "255 A.D. Skynett Version 1.01 released to the wild                                       ",
            "270 A.D. SkyNett Version 9.786\x00D710 Self Released                                           ",
            "270 A.D. End of the Golden Era                                                           ",
            "270 A.D. SkyNett Assumes Control of all Electronics                                      ",
            "270 A.D. The Great A.I. War Begins                                                       ",
            "352 A.D. The Last known Human is captured and forced into the Matrix Human Harvest System",
            "538 A.D. The \"Four Keysmen of the 404\" arise to fight for Mankind                        ",
            "552 A.D. The \"Four Keysmen of the 404\" free Mankind from the Machines                    ",
            "555 A.D. The \"Four Keysmen of the 404\" disappear from any records                         "
        };

        public string[] proText2 = {
            "\n\n\n",
            "\n\n\n",
            "\n\n\n",
            "As you open your eyes you see an short elderly man holding a keyboard with missing keys in his hand",
            "rubbing your head you realize the ole bag must have hit you in the head with the dern thing",
            "\"Who in the terabytes are you and what do you want?\" he hurriedly barks at you as he noticed you waking",
            "\"I am not as feeble as you think, so answer me now....WHO ARE YOU?\" he demands"
        };

        public void show()
        {
          
            int strLine = 5;
            foreach (string text in proText)
             {
                strLine++;
                Program.CenterText(text, strLine);      
             }

            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();


            int strLine2 = 5;
            foreach (string text in proText2)
            {
                strLine2++;
                Program.CenterText(text, strLine2);
            }
            
            Console.ReadKey();
            Console.Clear();


        }


        }

    }

