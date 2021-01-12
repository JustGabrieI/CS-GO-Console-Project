using System;
using System.Collections.Generic;
using System.Text;

namespace CS_GO_Console
{
    class Launch
    {
        public static void LaunchCommands(string cmd)
        {
            if (cmd == "-console")
            {
                Console.WriteLine("Opens the console right after the match start.");
            }
            else if (cmd == "-novid")
            {
                Console.WriteLine("Turns off video intros.");
            }
            else if (cmd == "-high")
            {
                Console.WriteLine("Makes the computer to give  the game high priority, so the CPU will largely ignore all background processes. A similar effect can be achieved by closing all other windows before launching the game.");
            }
            else if (cmd == "-threads [value]")
            {
                Console.WriteLine("Makes the computer use the specified number of CPU cores. Try to use all the cores of your PC and check the result.");
            }
            else if (cmd == "-tickrate [value]")
            {
                Console.WriteLine("The number of information updates on the server per second (for your server, of course). Most of the matchmaking servers use the value 64. Some people recommend trying 128.");
            }
            else if (cmd == "-language English")
            {
                Console.WriteLine("Sets the language for the game if you want to use a different one than on the Steam app.");
            }
            else if (cmd == "-fullscreen")
            {
                Console.WriteLine("The game opens in the full screen; it’s easier to use relevant settings in the game menu.");
            }
            else if (cmd == "-windowed")
            {
                Console.WriteLine("To play CS:GO in the usual window; the command has additional parameters: -w [value] for width, -h [value] for height, -x [value] for x-axis, -y [value] for y-axis.");
            }
            else if (cmd == "-noborder")
            {
                Console.WriteLine("Use this command to remove borders around the CS:GO window.");
            }
        }
    }
}
