using System;
using System.Collections.Generic;
using System.Text;

namespace CS_GO_Console
{
    class Bot
    {
        public static void BotCommands(string cmd)
        {
            if (cmd == "bot_add")
            {
                Console.WriteLine("add a bot to a team with a lack of players");
            }
            else if (cmd == "bot_add_t")
            {
                Console.WriteLine("add a bot to the terrorists team");
            }
            else if (cmd == "bot_add_ct")
            {
                Console.WriteLine("add a bot to the counter-terrorists team");
            }
            else if (cmd == "bot_quota [value]")
            {
                Console.WriteLine("the number of bots in both teams");
            }
            else if (cmd == "bot_kick")
            {
                Console.WriteLine("remove all the bots in the game");
            }
            else if (cmd == "bot_kill")
            {
                Console.WriteLine("kill all the bots");
            }
            else if (cmd == "bot_stop")
            {
                Console.WriteLine("make all the bots freeze");
            }
            else if (cmd == "bot_dont_shoot")
            {
                Console.WriteLine("bots stop shooting");
            }
            else if (cmd == "bot_knives_only")
            {
                Console.WriteLine("all the bots use knives only");
            }
            else if (cmd == "bot_pistols_only")
            {
                Console.WriteLine("all the bots use pistols only");
            }
            else if (cmd == "bot_all_weapons")
            {
                Console.WriteLine("every weapon becomes available for bots");
            }
            else if (cmd == "bot_zombie 1")
            {
                Console.WriteLine("all the bots turn into “zombies,” staying indifferent to the events around them");
            }
            else if (cmd == "bot_difficulty [value]")
            {
                Console.WriteLine("changes the level of skill for the bots. The value 0 is the lowest, and the value 2 is the highest mastery");
            }
            else if (cmd == "bot_mimic 1")
            {
                Console.WriteLine("bots copy all the actions of your character");
            }
            else if (cmd == "bot_crouch 1")
            {
                Console.WriteLine("all the bots crouch");
            }
        }
    }
}
