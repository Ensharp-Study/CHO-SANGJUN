using _4차_LectureTimeTable.View;
using System;

namespace _4차_LectureTimeTable.Controller
{
    public class CourseOfInterestAdder
    {
        MenuUi menuUi;
        public string[] menuList = { "개설학과 전공", "이수구분", "교과목 명", "교수명", "학년", "학수번호", "<검색하기>" };
        public string[] menuMajorOptionList = { "전체", "컴퓨터공학과", "소프트웨어공학과", "지능기전공학부", "기계항공우주공학부" };
        public string[] menuCreditClassificationList = { "전체", "교양필수", "전공필수", "전공선택" };
        public int selectedMenu;

        public CourseOfInterestAdder(MenuUi menuUi)
        {
            this.menuUi = menuUi;
        }

        public void SearchTheLecture()
        {
            Console.Clear();
            menuUi.PrintSearchLectureGuideUi();
            SelectUpAndDownMenu(6,44,11);
        }

        public void SelectUpAndDownMenu(int menuNumber, int cursorPositionX, int cursorPositionY) //위 아래 키 입력 받고 처리하는 함수
        {
            ConsoleKeyInfo inputKey;
            bool isEnter = false;

            Console.CursorVisible = false;
            SetAndPrintColorUpAndDownMenuSentence(cursorPositionX, cursorPositionY);

            selectedMenu = 0;
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

                SetAndPrintColorUpAndDownMenuSentence(cursorPositionX, cursorPositionY);
            }
        }

        public void SelectRightAndLeftMenu(int menuNumber, int cursorPositionX, int cursorPositionY)
        {
            ConsoleKeyInfo inputKey;
            bool isEnter = false;

            Console.CursorVisible = false;
            SetAndPrintColorUpAndDownMenuSentence(cursorPositionX, cursorPositionY);

            selectedMenu = 0;
            while (!isEnter)
            {
                inputKey = Console.ReadKey();
                if ((inputKey.Key == ConsoleKey.LeftArrow) && (selectedMenu > 0))
                {
                    selectedMenu--;
                }
                else if ((inputKey.Key == ConsoleKey.RightArrow) && (selectedMenu < (menuNumber-1)))
                {
                    selectedMenu++;
                }
                else if ((inputKey.Key == ConsoleKey.Enter))
                {
                    isEnter = true;
                }

                SetAndPrintColorLeftAndRightMenuSentence(cursorPositionX, cursorPositionY);
            }
        }

        public void SetAndPrintColorUpAndDownMenuSentence(int cursorPositionX, int cursorPositionY) //해당 메뉴 위치 보여주는 함수
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

        public void SetAndPrintColorLeftAndRightMenuSentence(int cursorPositionX, int cursorPositionY) //해당 메뉴 위치 보여주는 함수
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

                Console.Write("     "); //옆으로 나열하기 위한
            }
        }

        public void SelectDetailOption()
        {
            while (true)
            {
                
            }
        }
        
    }
}
