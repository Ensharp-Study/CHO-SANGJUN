using System;
using System.Runtime.InteropServices;

namespace Game
{
    public class TicTacToe {
        public static void Main(string[] args)
        {          
            Ui menu_ui = new Ui();
            menu_ui.PrintMenuUi();
            SelectMenu selectmenu = new SelectMenu();
            selectmenu.Method();
            

        } 
    }
}
