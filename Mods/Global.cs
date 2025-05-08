using GunLib;
using StupidTemplate.Menu;
using UnityEngine.InputSystem;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Mods
{
    internal class Global
    {
        public static void ReturnHome()
        {
            buttonsType = 0;

        }

        public static void NP() 
        {
            Main.Toggle("NextPage");
        }
        public static void PP() 
        {
            Main.Toggle("PreviousPage");
        }

        //how to use gunlib
        public static void Gun1()
        {
            //no need to hold any button because gun always shows on vr, hold rmb to show gun on pc
            GunTemplate.StartBothGuns(() =>
            {


            }, true);
        }

        public static void Gun2()
        {
            if (!ControllerInputPoller.instance.rightGrab && !Mouse.current.rightButton.isPressed) return; //requires rg or rmb to be pressed to show gun

            GunTemplate.StartBothGuns(() =>
            {

            }, true);
        }
    }
}
