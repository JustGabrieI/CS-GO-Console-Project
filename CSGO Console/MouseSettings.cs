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
            else if (cmd == "m_customaccel_scale 0.04")
            {
                Console.WriteLine("this command sets the mouse boost");
            }
            else if (cmd == "m_customaccel_exponent [value]")
            {
                Console.WriteLine("sets the index of the mouse boost");
            }
            else if (cmd == "m_customaccel_max [value]")
            {
                Console.WriteLine("the max possible index of the mouse boost");
            }
            else if (cmd == "m_mouseaccel1 1")
            {
                Console.WriteLine("activates the 2x mouse boost");
            }
            else if (cmd == "m_mouseaccel2 1")
            {
                Console.WriteLine("activates the 4x mouse boost");
            }
            else if (cmd == "m_mousespeed 1")
            {
                Console.WriteLine("the boost of the mouse will be managed by the Windows tools");
            }
            else if (cmd == "m_forward 1")
            {
                Console.WriteLine("the mouse sensitivity in moving forward");
            }
            else if (cmd == "m_side 0.8")
            {
                Console.WriteLine("the mouse sensitivity in moving sideways");
            }
            else if (cmd == "m_yaw 0.022")
            {
                Console.WriteLine("the mouse sensitivity in moving horizontally");
            }
            else if (cmd == "m_pich 0.022")
            {
                Console.WriteLine("the mouse sensitivity in moving vertically");
            }
            else if (cmd == "m_pitch 0.022")
            {
                Console.WriteLine("the command for inverting the mouse");
            }
        }

    }
}
