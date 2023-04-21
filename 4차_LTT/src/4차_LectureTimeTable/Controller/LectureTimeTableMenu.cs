using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.Utility;
using _4차_LectureTimeTable.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.Controller
{
    public class LectureTimeTableMenu
    {
        BasicUi basicUi;
        DataStorage dataStorage;

        public LectureTimeTableMenu(BasicUi basicUi, DataStorage dataStorage) //생성자 
        { 
           this.basicUi = basicUi;
           this.dataStorage = dataStorage;  
        }

        string[] menuList = { "○ 강의 시간표 조회", "○ 관심과목 담기", "○ 수강 신청", "○ 수강 신청 내역 조회" };
        int selectedMenu = 0;

        public void ControllLectureTimeTableMenu(UserDTO userInformation) //로그인한 유저의 정보 인자로 받아오기
        {
            basicUi.MenuUi(userInformation.UserName);
            SelectMenu();

            switch (selectedMenu)
            {
                case (int)MenuList.COURSE_FINDER:


                case (int)MenuList.COURSE_OF_INTEREST_ADDER:

                case (int)MenuList.COURSE_REGISTRATION:

                case (int)MenuList.COURSE_REGISTRATION_CHECKER:
                    break;
                
            }
           

        }

        public void SelectMenu()
        {
            ConsoleKeyInfo inputKey;
            bool isEnter = false;

            Console.CursorVisible = false;
            SetAndPrintColorMenuSentence(42,11);

            while (!isEnter)
            {
                inputKey = Console.ReadKey();
                if ((inputKey.Key == ConsoleKey.UpArrow) && (selectedMenu > 0))
                {
                    selectedMenu--;
                }
                else if ((inputKey.Key == ConsoleKey.DownArrow) && (selectedMenu < 3))
                {
                    selectedMenu++;
                }
                else if ((inputKey.Key == ConsoleKey.Enter))
                {
                    isEnter = true;
                }

                SetAndPrintColorMenuSentence(42, 11);
            }
        }

        public void SetAndPrintColorMenuSentence(int cursorPositionX,int CursorPositionY)
        {
            for (int i = 0; i < menuList.Length; i++)
            {
                if (i == selectedMenu)
                {
                    Console.SetCursorPosition(cursorPositionX,CursorPositionY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(menuList[i]);
                    Console.ResetColor();
                }

                else
                {
                    Console.SetCursorPosition(cursorPositionX, CursorPositionY);
                    Console.WriteLine(menuList[i]);
                }

                CursorPositionY += 1;
            }
        }

    }
}
