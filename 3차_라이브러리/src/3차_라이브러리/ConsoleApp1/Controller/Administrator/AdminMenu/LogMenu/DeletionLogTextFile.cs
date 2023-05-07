using ConsoleApp1.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller.Administrator.AdminMenu.LogMenu
{
    public class DeletionLogTextFile
    {
        AdministratorModeUi administratorModeUi;
        public DeletionLogTextFile()
        {
            this.administratorModeUi = AdministratorModeUi.GetInstance();
        }

        public void DeleteTextFile()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //바탕화면 경로 설정
            string filePath = Path.Combine(desktopPath, "로그정보.txt");

            administratorModeUi.PrintDeleteLogTextMenu(); //삭제의사 물어보기
            if (!(GoBackMenu.GetInstance().GoBackToBeforeFunction())) return;//ESC눌러서 뒤로가기 기능 구현

            File.Delete(filePath); //파일 삭제

            Console.Clear();
            administratorModeUi.PrintDeleteLogTextSuccess(); //삭제 성공 메세지
            GoBackMenu.GetInstance().ensureUiVisibility();


        }
    }
}
