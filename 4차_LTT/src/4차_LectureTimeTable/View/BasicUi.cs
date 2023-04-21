using _4차_LectureTimeTable.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.View
{
    public class BasicUi
    {
        public void MainUi()
        {

            Console.WriteLine("\n\n\n");
            Console.WriteLine("                             ==============================================");
            Console.WriteLine("                               ##     ##    ##     ##   ##  #           #  ");
            Console.WriteLine("                               ##     ##    ##     ##       ##         ##  ");
            Console.WriteLine("                               ##     ##    ####   ##   ##   ##       ##   ");
            Console.WriteLine("                               ##     ##    ## ##  ##   ##    ##     ##    ");
            Console.WriteLine("                               ##     ##    ##  ## ##   ##     ##   ##     ");
            Console.WriteLine("                               ##     ##    ##   ####   ##      ## ##      ");
            Console.WriteLine("                                #######     ##     ##   ##       ###       ");
            Console.WriteLine("                             ==============================================");
            Console.WriteLine("                             □       세종대학교 수강신청 프로그램       □");
            Console.WriteLine("                             ==============================================");

        }

        public void LoginUi()
        {
            Console.WriteLine("                         ┌───────────────────────────────────────────────────┐");
            Console.WriteLine("                         │                      로그인                       │");
            Console.WriteLine("                         │                                                   │");
            Console.WriteLine("                         │ 아이디   :                                        │");
            Console.WriteLine("                         │ 패스워드 :                                        │");
            Console.WriteLine("                         │                                                   │");
            Console.WriteLine("                         └───────────────────────────────────────────────────┘");
        }

        public void MenuUi(string userName)
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

        public void MenuList(string[] menuList ,int menuNumber)
        {
            for(int i=0; i< menuList.Length; i++)
            {
                if( i == menuNumber)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine(menuList[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(menuList[i]);
                }
            }

        }
    }
}
