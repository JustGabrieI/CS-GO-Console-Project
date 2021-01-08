using System;

namespace CS_GO_Console
{
    class Program
    {

        /*public static void StartCommands()
        {
            Console.WriteLine("Parent cvar in client.dll not allowed (weapon_max_before_cleanup) \n" + 
"Parent cvar in client.dll not allowed(weapon_auto_cleanup_time) \n" + 
"Parent cvar in client.dll not allowed(sv_bumpmine_detonate_delay) \n" +
Parent cvar in client.dll not allowed(sv_bumpmine_arm_delay)
Parent cvar in client.dll not allowed(sv_breachcharge_arm_delay)
Parent cvar in client.dll not allowed(sv_breachcharge_fuse_max)
Parent cvar in client.dll not allowed(sv_breachcharge_fuse_min)
Parent cvar in client.dll not allowed(sv_breachcharge_delay_max)
Parent cvar in client.dll not allowed(sv_breachcharge_delay_min)
Parent cvar in client.dll not allowed(sv_breachcharge_distance_max)
Parent cvar in client.dll not allowed(sv_breachcharge_distance_min)
Parent cvar in client.dll not allowed(cl_grenadepreview)
Parent cvar in client.dll not allowed(snd_max_pitch_shift_inaccuracy)
Parent cvar in client.dll not allowed(steam_controller_haptics)
Parent cvar in client.dll not allowed(mp_endmatch_votenextleveltime)
Parent cvar in client.dll not allowed(mp_verbose_changelevel_spew)
Parent cvar in client.dll not allowed(cl_remove_old_ugc_downloads)
maxplayers set to 64
V8 Version: 5.8.283
FcConfigAppFontAddDir c:\program files(x86)\steam\steamapps\common\counter - strike global offensive\csgo\panorama\fonts\ took 61.844 ms.
CUiComponent_OptionsMenu::CUiComponent_OptionsMenu
Loading Game State Integration: gamestate_integration_logitech.cfg
Loading Game State Integration: gamestate_integration_overwolf.cfg
Loading Game State Integration: gamestate_integration_overwolf2.cfg
Steam config directory: C:\Program Files(x86)\Steam\steamapps\common\Counter - Strike Global Offensive\platform\config
ChangeGameUIState: CSGO_GAME_UI_STATE_INVALID->CSGO_GAME_UI_STATE_INTROMOVIE
-- - Missing Vgui material vgui / store / store_item_bg
-- - Missing Vgui material vgui / store / store_item_bg_highlight
-- - Missing Vgui material vgui / store / store_item_sel_bg
-- - Missing Vgui material vgui / store / store_item_pickup_bg
-- - Missing Vgui material vgui / store / store_preview_bg
-- - Missing Vgui material vgui / store / store_bottom_bar_button_bg
-- - Missing Vgui material vgui / store / store_bottom_bar_button_highlight_bg
-- - Missing Vgui material vgui / store / store_default_dialog
-- - Missing Vgui material vgui / store / store_backpack_bg
-- - Missing Vgui material vgui / store / store_backpack_bg_highlight
-- - Missing Vgui material vgui / store / store_backpack_bg_highlight
-- - Missing Vgui material vgui / store / store_discount_corner
-- - Missing Vgui material vgui / store / store_preview_bg
-- - Missing Vgui material vgui / store / store_tooltip_bg
-- - Missing Vgui material vgui / store / store_tab_selected
-- - Missing Vgui material vgui / store / store_tab_unselected
-- - Missing Vgui material vgui / btn_econ_blue
-- - Missing Vgui material vgui / store / button_econ_blue_over
-- - Missing Vgui material vgui / store / store_backpack_bg
-- - Missing Vgui material vgui / store / store_backpack_bg_highlight
-- - Missing Vgui material vgui / store / store_backpack_bg_highlight
vgui / store / store_backpack_bg_highlight
Unknown command "cl_thirdperson"
Unknown command "tr_best_course_time"
Unknown command "tr_completed_training"
Unknown command "weapon_accuracy_logging"
Elapsed time: 0.00 seconds
 Unable to localize '#matchdraft_phase_action_wait' on panel 'id-map-draft-phase-wait'
 Unable to localize '#DemoPlayback_Restart' on panel descendant of 'HudDemoPlayback'
 Unable to localize '#DemoPlayback_Back' on panel descendant of 'HudDemoPlayback'
 Unable to localize '#DemoPlayback_Pause' on panel descendant of 'HudDemoPlayback'
 Unable to localize '#DemoPlayback_Slow' on panel descendant of 'HudDemoPlayback'
 Unable to localize '#DemoPlayback_Play' on panel descendant of 'HudDemoPlayback'
 Unable to localize '#DemoPlayback_Fast' on panel descendant of 'HudDemoPlayback'
 Unable to localize '#DemoPlayback_Next' on panel descendant of 'HudDemoPlayback'
Unknown command "cl_teamid_min"
Unknown command "cl_teamid_max"
Unknown command "cl_teamid_overhead"
Can't use cheat cvar cl_teamid_overhead_maxdist in multiplayer, unless the server has sv_cheats set to 1.
NET_CloseAllSockets
Got SDR network config.Loaded revision 289 OK
Performing ping measurement
RelayNetWorkStatus: avail = Attempting  config = OK  anyrelay = Attempting(Performing ping measurement)
AuthStatus(steamid: 76561198380293591):  OK(OK)
Unknown command "cl_thirdperson"
Unknown command "tr_best_course_time"
Unknown command "tr_completed_training"
Unknown command "weapon_accuracy_logging"
Telling Steam it is safe to update the app
Host_WriteConfiguration: Wrote cfg / config.cfg
ChangeGameUIState: CSGO_GAME_UI_STATE_INTROMOVIE->CSGO_GAME_UI_STATE_MAINMENU
 Unable to localize '#GameUI_Stationary' on panel 'MoveSpeedLabel'
 Unable to localize '#GameUI_Fire' on panel descendant of 'TestSpread'
Host_WriteConfiguration: Wrote cfg / config.cfg
Host_WriteConfiguration: Wrote cfg / config.cfg
Host_WriteConfiguration: Wrote cfg / config.cfg
Host_WriteConfiguration: Wrote cfg / config.cfg
Host_WriteConfiguration: Wrote cfg / config.cfg
Host_WriteConfiguration: Wrote cfg / config.cfg
Ping measurement completed
Ping location: vie = 19 + 1, waw = 55 + 5 / 30 + 1, fra = 37 + 3 / 31 + 1, lux = 32 + 3, par = 36 + 3, ams = 36 + 3 / 38 + 1, lhr = 41 + 4 / 41 + 3, sto = 46 + 4, sto2 = 48 + 4 / 47 + 4, iad = 114 + 11 / 113 + 3, sgp = 189 + 18 / 190 + 18, gru = 231 + 23
RelayNetWorkStatus: avail = OK  config = OK  anyrelay = OK(OK)
Host_WriteConfiguration: Wrote cfg / config.cfg
Ping measurement completed
Ping location: vie = 19 + 1, waw = 55 + 5 / 30 + 1, fra = 37 + 3 / 31 + 1, lux = 32 + 3, par = 36 + 3, ams = 36 + 3 / 38 + 1, lhr = 41 + 4 / 41 + 3, sto = 46 + 4, sto2 = 48 + 4 / 47 + 4, iad = 114 + 11 / 113 + 3, sgp = 189 + 18 / 190 + 18, gru = 231 + 23
RelayNetWorkStatus: avail = OK  config = OK  anyrelay = OK(OK)
Host_WriteConfiguration: Wrote cfg / config.cfg");
        }
        */

        public static void EnterNickname()
        {
            string name;
            Console.WriteLine("Enter your steam name: ");
            name = Console.ReadLine();
            for (int i = 0; i < 8 + name.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine($"Welcome {name}");
            for (int i = 0; i < 8 + name.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            EnterNickname();

            string cmd = Console.ReadLine();
            GameInterface.GameInterfaceCommands(cmd);
            GameView.GameViewCommands(cmd);
            MouseSettings.MouseSettingsCommands(cmd);
        }
    }
}
