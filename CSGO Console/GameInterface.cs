using System;
using System.Collections.Generic;
using System.Text;

namespace CS_GO_Console
{
    class GameInterface
    {

        public static void GameInterfaceCommands(string cmd)
        {
            if (cmd == "cl_hud_playercount_pos 1")
            {
                Console.WriteLine("Moves the list of players to the lower part of the screen. The value 0 returns the standard upper position.");
            }
            else if (cmd == "cl_hud_playercount_showcount 1")
            {
                Console.WriteLine("Turns pics of players into numbers of living characters. It is convenient when you aren’t interested in detailed information about opponents and teammates.");
            }
            else if (cmd == "cl_showloadout 1")
            {
                Console.WriteLine("This command shows items from the inventory in the right lower corner.");
            }
            else if (cmd == "cl_radar_always_centered 1")
            {
                Console.WriteLine("Changes the radar mode, putting your character in its center.");
            }
            else if (cmd == "cl_radar_rotate 1")
            {
                Console.WriteLine("Makes the radar rotate. This may help to navigate the CSGO map.");
            }
            else if (cmd == "cl_radar_square_with_scoreboard 1")
            {
                Console.WriteLine("The radar becomes square, and the match score is shown there.");
            }
            else if (cmd == "hideradar")
            {
                Console.WriteLine("Removes the radar. The command drawradar returns it.");
            }
            else if (cmd == "cl_radar_scale 0.3")
            {
                Console.WriteLine("The scale of the radar.");
            }
            else if (cmd == "cl_radar_icon_scale_min 0.7")
            {
                Console.WriteLine("The scale of the game characters on the radar.");
            }
            else if (cmd == "cl_hud_radar_scale 1.15")
            {
                Console.WriteLine("Changes the size of the radar and the other interface elements.");
            }
            else if (cmd == "hud_scaling [value]")
            {
                Console.WriteLine("The scale of all the interface elements.");
            }
            else if (cmd == "hud_showtargetid 0")
            {
                Console.WriteLine("Hides names of players while hovering over their characters.");
            }
            else if (cmd == "cl_hud_background_alpha [value]")
            {
                Console.WriteLine("The level of opacity for the interface elements. The value 0.1 is popular.");
            }
            else if (cmd == "cl_hud_background_alpha 1")
            {
                Console.WriteLine("He indicator of you having the bomb is displayed under the radar. It returns to the inventory with the value 0.");
            }
            else if (cmd == "cl_hud_color [value]")
            {
                Console.WriteLine("Hanges the color of the interface elements. Try values from 0 to 10.");
            }
            else if (cmd == "cl_draw_only_deathnotices 1")
            {
                Console.WriteLine("Only death notifications will appear in the game interface; all the other elements will be hidden.");
            }
            else if (cmd == "cl_drawhud 0")
            {
                Console.WriteLine("Removes all the interface elements from the game screen.");
            }

        }

    }
}
