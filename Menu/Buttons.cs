using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Button", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button", isTogglable = true},
                new ButtonInfo { buttonText = "Button 2", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button 2", isTogglable = true},
                new ButtonInfo { buttonText = "Button 3", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button 3", isTogglable = true},
                new ButtonInfo { buttonText = "Button 4", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button 4", isTogglable = true},
                new ButtonInfo { buttonText = "--Page-2-->", method =() => Global.NP(), isTogglable = false},
                new ButtonInfo { buttonText = "YOU'RE ON PAGE " + (Main.pageNumber + 1).ToString(), isTogglable = false},


                new ButtonInfo { buttonText = "Button 5", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button 5", isTogglable = true},
                new ButtonInfo { buttonText = "Button 6", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button 6", isTogglable = true},
                new ButtonInfo { buttonText = "Button 7", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button 7", isTogglable = true},
                new ButtonInfo { buttonText = "Button 8", isTogglable = false},
                new ButtonInfo { buttonText = "<--Page-1--", method =() => Global.PP(), isTogglable = false},
                new ButtonInfo { buttonText = "--Page-3-->", method =() => Global.NP(), isTogglable = false},
                new ButtonInfo { buttonText = "YOU'RE ON PAGE 2", isTogglable = false},

                new ButtonInfo { buttonText = "Toggle Button 8", isTogglable = true},
                new ButtonInfo { buttonText = "Button 9", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button 9", isTogglable = true},
                new ButtonInfo { buttonText = "Button 10", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button 10", isTogglable = true},
                new ButtonInfo { buttonText = "Button 11", isTogglable = false},
                new ButtonInfo { buttonText = "Toggle Button 11", isTogglable = true},
                new ButtonInfo { buttonText = "Button 12", isTogglable = false},
                new ButtonInfo { buttonText = "<--Page-2--", method =() => Global.PP(), isTogglable = false},
                new ButtonInfo { buttonText = "YOU'RE ON PAGE 3", isTogglable = false},

            },

            new ButtonInfo[] { // Settings

                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                //new ButtonInfo { buttonText = "asdasd", method =() => Global.Page(), isTogglable = true, enabled = true ,toolTip = "Opens the main settings page for the menu."},

                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
