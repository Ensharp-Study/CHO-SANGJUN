using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.View
{
    public class MenuUi
    {
        public void PrintMenuUi(string userName)
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("                             ==============================================");
            Console.WriteLine("                                             학사 정보 시스템              ");
            Console.WriteLine("                             ==============================================");
            Console.Write("                             회원 :");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(userName);
            Console.ResetColor();
            Console.Write(" 님");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                 ESC : 로그아웃");
            Console.ResetColor();
            Console.WriteLine("                             ==============================================");
            Console.WriteLine("                             □                  메뉴선택                □");
            Console.WriteLine("                             ==============================================");
        }

        public void PrintColorSentence(int cursorPositionX, int cursorPositionY, string menuIndexLine) //초록색 줄 처리 함수
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(menuIndexLine);
            Console.ResetColor();
        }

        public void PrintNotColorSentence(int cursorPositionX, int cursorPositionY, string menuIndexLine) //기존 리셋값 흰색 줄 처리 함수
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.Write(menuIndexLine);
        }

        public void PrintCourseFinderMenu()
        {
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("                                 23학년도 1학기 강의 검색         ");
            Console.WriteLine("==========================================================================================");

        }

        public void PrintSearchLectureGuideUi()
        {
            Console.WriteLine("┏────────────────────────────────────강의 검색 가이드────────────────────────────────────┓");
            Console.WriteLine("┃                                                                                        ┃");
            Console.WriteLine("┃  ◎  방향키를 이용하여 옵션을 이동 후 ENTER를 누르면 선택 또는 입력 가능 합니다.       ┃");
            Console.WriteLine("┃  ◎  검색 도중 ESC를 누르면 다시 입력 할 수 있습니다.                                  ┃");
            Console.WriteLine("┃  ◎  모든 입력을 완료하면 <검색하기>를 눌러 주세요.                                    ┃");
            Console.WriteLine("┃                                                                                        ┃");
            Console.WriteLine("┗────────────────────────────────────────────────────────────────────────────────────────┛");
        }
        public void PrintLectureDetailInformationInputMenu(int cursorPositionX, int cursorPositionY)
        {
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine(" > 교과목명 : ");
            cursorPositionY++;
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine(" > 교수명   : ");
            cursorPositionY++;
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine(" > 학년     : ");
            cursorPositionY++;
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine(" > 학수번호 : ");
            cursorPositionY++;
            Console.SetCursorPosition(cursorPositionX, cursorPositionY);
            Console.WriteLine(" > 분반     : ");
        }

        public void PrintExistLectureInformation(string lectureData, int emptyCount)
        {

            lectureData = lectureData.PadRight(emptyCount);
            Console.Write(lectureData);
            Console.Write("  ");

        }

        public void PrintStatusOfInterestedLecture(int availableCreditsForRegistration, int earnedCredits)
        {
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("등록가능 학점 : {0}    담은학점 : {1}     담을과목 (NO) : ", availableCreditsForRegistration, earnedCredits);
        }
    }
}
