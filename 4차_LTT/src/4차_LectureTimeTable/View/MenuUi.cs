﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.View
{   
    public class MenuUi
    {
        public void MainMenuUi() 
        {

            Console.WriteLine("\n\n\n");
            Console.WriteLine("                             ==============================================");
            Console.WriteLine("                               ##     ##    ##     ##   ##  ##         ##  ");
            Console.WriteLine("                               ##     ##    ##     ##       ##         ##  ");
            Console.WriteLine("                               ##     ##    ####   ##   ##   ##       ##   ");
            Console.WriteLine("                               ##     ##    ## ##  ##   ##    ##     ##    ");
            Console.WriteLine("                               ##     ##    ##  ## ##   ##     ##   ##     ");
            Console.WriteLine("                               ##     ##    ##   ####   ##      ## ##      ");
            Console.WriteLine("                                #######     ##    ###   ##       ###       ");
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

    }
}
