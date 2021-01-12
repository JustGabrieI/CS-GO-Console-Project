using System;
using System.Collections.Generic;
using System.Text;

namespace CS_GO_Console
{
    class Graphics
    {
        public static void GraphicsCommands(string cmd)
        {
            if (cmd == "mat_monitorgamma [value]")
            {
                Console.WriteLine("Sets brightness in the game. The common values are from 1.6 to 2.1. The same option is available through the settings menu.");
            }
            else if (cmd == "mat_queue_mode -1")
            {
                Console.WriteLine("Activates multi - core rendering.");
            }
            else if (cmd == "volume [value]")
            {
                Console.WriteLine("The sound volume.");
            }
            else if (cmd == "snd_musicvolume [value]")
            {
                Console.WriteLine("The volume of music in the game.");
            }
            else if (cmd == "snd_headphone_pan_exponent [value]")
            {
                Console.WriteLine("The volume of distant sounds.");
            }
            else if (cmd == "voice_scale [value]")
            {
                Console.WriteLine("The volume for the voices of your teammates.");
            }
            else if (cmd == "voice_enable 0")
            {
                Console.WriteLine("You won’t hear your teammates. voice_enable “1” activates the normal settings. These commands may also be useful to enter on the console for a particular match. In this case, remove the quote marks.");
            }
            else if (cmd == "windows_speaker_config [value]")
            {
                Console.WriteLine("Use this command to tell the computer which audio device you are using. The values are: 1 for auto-pick, 2 for a headset, 3 for four speakers, 4 for two speakers, and 5 for 5.1 surround.");
            }
            else if (cmd == "snd_mixahead [value]")
            {
                Console.WriteLine("The delay in processing in-game sounds. The default value is 0.1. Some players prefer 0.05, but this may load the computer too much.");
            }
            else if (cmd == "developer 1")
            {
                Console.WriteLine("Enables the special developer mode of the console. With it, you’ll see more information about the commands. This info may be excessive.");
            }
            else if (cmd == "cl_autohelp 0")
            {
                Console.WriteLine("Cancels help messages from the game. For the ultimate result, enter two more commands: cl_showhelp “0” and player_nevershow_communityservermessage “1”.");
            }
            else if (cmd == "cl_disablehtmlmotd 1")
            {
                Console.WriteLine("This command blocks messages from the server.");
            }
            else if (cmd == "cl_autowepswitch 0")
            {
                Console.WriteLine("A game character will not change weapon automatically when they stand near it. May be useful in many situations. For example, you will want this feature when your character steps on a weapon during shooting.");
            }
            else if (cmd == "closeonbuy 1")
            {
                Console.WriteLine("Closes the buying menu after making one purchase.");
            }
            else if (cmd == "hud_takesshots 1")
            {
                Console.WriteLine("Automatically makes screenshots of the scoreboard at the end of matches.");
            }
            else if (cmd == "cl_forcepreload 1")
            {
                Console.WriteLine("Loads objects onto maps immediately after your connection. This may increase loading time.");
            }
            else if (cmd == "cl_disablefreezecam 1")
            {
                Console.WriteLine("Disables the camera freeze  after death.");
            }
            else if (cmd == "echo [text]")
            {
                Console.WriteLine("Write any text and you will see it on the console after starting a match. This helps to check if the autoexec file is running properly.");
            }
        }
    }
}
