using System;
using System.Collections.Generic;
using System.Text;

namespace CS_GO_Console
{
    class GameView
    {

        public static void GameViewCommands(string cmd)
        {
            if (cmd == "sv_showbullethits 0 ")
            {
                Console.WriteLine("turns off the animation of blood in the game.");
            }
            else if (cmd == "r_cleardecals")
            {
                Console.WriteLine("wipe out all the existing blood and bullet holes in the virtual world of CS:GO.");
            }
            else if (cmd == "cam_idealdist 150")
            {
                Console.WriteLine("the position of the camera. The value 0 is the a standard one. Change it to move the camera in a circle.");
            }
            else if (cmd == "cam_idealyaw 0")
            {
                Console.WriteLine("wipe out all the existing blood and bullet holes in the virtual world of CS:GO.");
            }
            else if (cmd == "cam_command 1")
            {
                Console.WriteLine("activates the third person perspective. The command.");
            }
            else if (cmd == "cam_command 2")
            {
                Console.WriteLine(" returns the standard first person perspective.");
            }
            else if (cmd == "cl_righthand 1")
            {
                Console.WriteLine("puts the weapon in the left hand. cl_righthand 0 – returns the right-hand view.");
            }
            else if (cmd == "viewmodel_presetpos 2")
            {
                Console.WriteLine("this command changes the view of the weapon. It has different values: 2 for closed view, 3 for the classic view as in Counter-Strike 1.6, 1 for the default view.");
            }
            else if (cmd == "viewmodel_offset_x [value]")
            {
                Console.WriteLine("by entering this command, players can adjust the position of the character’s hand. It determines the x-axis. Change the letter in this command to influence the y- or z-axis.The value can be from -2 to 2.5.");
            }
            else if (cmd == "viewmodel_fov [value]")
            {
                Console.WriteLine("makes the character hold the weapon closer or farther away. The value can be from -54 to 65).");
            }
            else if (cmd == "r_dynamic 0")
            {
                Console.WriteLine("turns off the dynamic lighting.");
            }
            else if (cmd == "r_drawtracers_firstperson 0")
            {
                Console.WriteLine("you won’t see the light of fire from your weapon.");
            }
            else if (cmd == "mat_savechanges")
            {
                Console.WriteLine("use this command to save changes caused through the console for the next matches.");
            }

        }

    }
}

