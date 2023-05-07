using ConsoleApp1.Controller.Administrator.AdminMenu.LogMenu;
using ConsoleApp1.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller.Administrator.AdminMenu
{
    public class LogManagerMenu
    {
        DataLogging dataLogging;
        MainMenuUi mainMenuUi;
        CommonFunctionUi commonFunctionUi;
        MenuSelectController menuSelectController;

        LogEdition logEdition;

        public LogManagerMenu()
        {
            this.dataLogging = DataLogging.GetInstance();
            this.mainMenuUi = MainMenuUi.GetInstance();
            this.commonFunctionUi = CommonFunctionUi.GetInstance();
            this.menuSelectController = MenuSelectController.GetInstance();

            this.logEdition = new LogEdition();
        }

        public void LogManagerSelectMenu()
        {
            int menuNumber;
            string[] logMenuList = { "○ 로그 수정", "○ 로그 TEXT 파일저장", "○ 로그 삭제", "○ 로그 리셋" };

            while (true)
            {
                mainMenuUi.ViewMainMenu();
                commonFunctionUi.ViewMenu();

                menuNumber = menuSelectController.SelectMenuWithUpAndDown(logMenuList, 4, 49, 26);
                Console.Clear();

                switch (menuNumber)
                {
                    case (int)(LogManagerMenuNumber.LOG_EDIT):
                        logEdition.DeleteLog();
                        break;
                    case (int)(LogManagerMenuNumber.LOG_SAVE_TEXT_FILE):
                        break;
                    case (int)(LogManagerMenuNumber.LOG_DELETE_TEXT_FILE):
                        break;
                    case (int)(LogManagerMenuNumber.LOG_RESET):
                        break;
                }


            }

        }
    }
}
