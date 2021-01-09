using System;
using System.Collections.Generic;
using System.Text;

namespace CS_GO_Console
{
    class Cheat
    {
        public static void CheatingCommands(string cmd)
        {
            if (cmd == "sv_cheats 1")
            {
                Console.WriteLine("allows using cheat commands.");
            }
            else if (cmd == "sv_infinite_ammo 1")
            {
                Console.WriteLine("all players get infinite ammo. With the value 1, the characters must reload their weapons. With the value 2, they can shoot constantly.");
            }
            else if (cmd == "sv_showbullethits 1")
            {
                Console.WriteLine("shows where bullets hit characters.");
            }
            else if (cmd == "sv_showimpacts 1")
            {
                Console.WriteLine("shows where bullets hit virtual objects.");
            }
            else if (cmd == "sv_showimpacts_time [value]")
            {
                Console.WriteLine("time in seconds for showing the impacts of your bullets.");
            }
            else if (cmd == "sv_grenade_trajectory 1")
            {
                Console.WriteLine("shows how grenades fly. You’ll see all the hit spots.");
            }
            else if (cmd == "sv_grenade_trajectory_time [value]")
            {
                Console.WriteLine("time in seconds for showing the grenades’ trajectory.");
            }
            else if (cmd == "god")
            {
                Console.WriteLine("makes your character invulnerable. Use the command gods to share the effect with everyone in the match.");
            }
            else if (cmd == "sv_specspeed 1.5")
            {
                Console.WriteLine("the speed of the game character in spectator mode.");
            }
            else if (cmd == "cl_disable_ragdolls 1")
            {
                Console.WriteLine("removes the Ragdoll physics and the smoke on the virtual map.");
            }
        }
    }
}
