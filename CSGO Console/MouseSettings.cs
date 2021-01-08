using System;
using System.Collections.Generic;
using System.Text;

namespace CS_GO_Console
{
    class MouseSettings
    {

        public static void MouseSettingsCommands(string cmd)
        {
            if (cmd == "sensitivity 2.5")
            {
                Console.WriteLine("sensitivity of the mouse; the value 2.5 is popular among pro-players.");
            }
            else if (cmd == "m_rawinput 1")
            {
                Console.WriteLine("with this command, the game will set the mouse directly, bypassing the operating system.");
            }
            else if (cmd == "m_customaccel 1")
            {
                Console.WriteLine("activates the mouse boost.");
            }
        }

    }
}
