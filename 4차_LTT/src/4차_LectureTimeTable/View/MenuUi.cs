using System;
using System.Collections.Generic;
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

        public void PrintSearchLectureGuideUi()
        {
            Console.WriteLine("┏───────────────강의 검색 가이드───────────────┓");
            Console.WriteLine("┃                                                                            ┃");
            Console.WriteLine("┃  ◎                                                                        ┃");
            Console.WriteLine("┃                                                                            ┃");
            Console.WriteLine("┃                                                                            ┃");
            Console.WriteLine("┃                                                                            ┃");
            Console.WriteLine("┃                                                                            ┃");
            Console.WriteLine("┃                                                                            ┃");
            Console.WriteLine("┗──────────────────────────────────────┛");
        }

       
    }
}
