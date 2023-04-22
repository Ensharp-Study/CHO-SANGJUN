using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.ExceptionHandling;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.Utility;
using _4차_LectureTimeTable.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.Controller
{
    public class LectureTimeTableMenu
    {
        MenuUi menuUi= new MenuUi();
        LectureException lectureException= new LectureException();

        DataStorage dataStorage;

        public LectureTimeTableMenu(DataStorage dataStorage) //생성자 
        { 
           this.dataStorage = dataStorage;  
        }


        string[] menuList = { "○ 강의 시간표 조회", "○ 관심과목 담기", "○ 수강 신청", "○ 수강 신청 내역 조회" };
        int selectedMenu = 0;

        public void ControllLectureTimeTableMenu(UserDTO userInformation) //로그인한 유저의 정보 인자로 받아오기
        {
            CourseFinder courseFinder = new CourseFinder(dataStorage, lectureException);
            CourseOfInterestAdder courseOfInterestAdder = new CourseOfInterestAdder(menuUi);

            menuUi.PrintMenuUi(userInformation.UserName);
            SelectMenu(4);

            switch (selectedMenu)
            {
                case (int)MenuList.COURSE_FINDER:

                case (int)MenuList.COURSE_OF_INTEREST_ADDER:
                    Console.SetWindowSize(150, 30);
                    courseOfInterestAdder.SearchTheLecture();
                    break;

                case (int)MenuList.COURSE_REGISTRATION:

                case (int)MenuList.COURSE_REGISTRATION_CHECKER:
                    break;
                
            }
           

        }

        public void SelectMenu(int menuNumber) //위아래 키 입력 받고 처리하는 함수
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
                else if ((inputKey.Key == ConsoleKey.DownArrow) && (selectedMenu < (menuNumber-1)))
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

        public void SetAndPrintColorMenuSentence(int cursorPositionX, int cursorPositionY) //해당 메뉴 위치 보여주는 함수
        {
            for (int i = 0; i < menuList.Length; i++)
            {
                if (i == selectedMenu)
                {
                    menuUi.PrintColorSentence(cursorPositionX, cursorPositionY, menuList[i]);
                }

                else
                {
                    menuUi.PrintNotColorSentence(cursorPositionX, cursorPositionY, menuList[i]);
                }

                cursorPositionY += 1; //다음줄로 넘기기 위한 Y좌표 증가
            }
        }
    }
}
