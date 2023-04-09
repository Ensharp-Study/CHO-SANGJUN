using System;

public class Ui {

	public void MainMenuView()
	{
        int i;
        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("           ####       ####    #########      ########             ###       ########      ####     ####");
        Console.WriteLine("            ##         ##      ##      ##     ##     ##           ###        ##     ##     ##       ##" );
        Console.WriteLine("            ##         ##      ##     ###     ##      ##         ## ##       ##      ##     ##     ##");
        Console.WriteLine("            ##         ##      ##  ##         ##     ##         ##   ##      ##     ##       ##  ##");
        Console.WriteLine("            ##         ##      ##  ##         ##  ###          #########     ##   ###          ###");
        Console.WriteLine("            ##         ##      ##    ###      ####   ##       ##       ##    ####    ##        ##");
        Console.WriteLine("            ##         ##      ##     ###     ##       ##    ##         ##   ##       ##       ##");
        Console.WriteLine("           #########  ####    #########      ####       ### ##           ## ####       ###    ####");
        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("               ENTER : 선택                                                           ESC : 나가기");
        Console.WriteLine("\n");
        Console.WriteLine("                        _______________________________________________________________                        ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       -----------------------------------------------------------------                       ");

    }

    public int PrintSelectMenu(MagicNumber magicNumber)
    {
        ConsoleKeyInfo inputKey;
        bool isCheckedEnter = false;
        int selectedMenuNum = -1;
        
       


        Console.SetCursorPosition(50, 23);
        Console.WriteLine("○ 유저모드");
        Console.SetCursorPosition(50, 24);
        Console.WriteLine("○ 관리자 모드");
        inputKey = Console.ReadKey();

        while (isCheckedEnter == false)
        {
            if (inputKey.Key == ConsoleKey.UpArrow)
            {
                Console.SetCursorPosition(50, 23);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("○ 유저모드");
                Console.SetCursorPosition(50, 24);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("○ 관리자 모드");
                selectedMenuNum = magicNumber.USERMODE;
            }
            else if (inputKey.Key == ConsoleKey.DownArrow)
            {
                Console.SetCursorPosition(50, 23);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("○ 유저모드");
                Console.SetCursorPosition(50, 24);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("○ 관리자 모드");
                selectedMenuNum = magicNumber.ADMINMODE;
            }
            else if (inputKey.Key == ConsoleKey.Enter)
            {
                isCheckedEnter = true;
            }
            inputKey = Console.ReadKey();
        }
        if (selectedMenuNum == magicNumber.USERMODE)
        {
            return magicNumber.USERMODE;
        }
        else if (selectedMenuNum == magicNumber.ADMINMODE)
        {
            return magicNumber.ADMINMODE;
        }

        return -1;
    }

    public void PrintLoginMenu()
    {
        Console.SetCursorPosition(50, 22);
        Console.WriteLine("                                              ");
        Console.SetCursorPosition(50, 22);
        Console.WriteLine("로그인");
        Console.SetCursorPosition(40, 23);
        Console.WriteLine("                                              ");
        Console.SetCursorPosition(40, 23);
        Console.WriteLine("아이디(ID) : ");
        Console.SetCursorPosition(40, 24);
        Console.WriteLine("                                              ");
        Console.SetCursorPosition(40, 24);
        Console.WriteLine("패스워드(PASSWORD) : ");

    }

    public void PrintUserMenu()
    {
        Console.SetCursorPosition(0, 21);
        Console.WriteLine("                        _______________________________________________________________                        ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                           도서 업무                           |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                         책 정보 검색                          |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                         책 대여하기                           |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                          대여목록 확인                        |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                         책 반납하기                           |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                           반납목록 확인                       |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                          회원정보 수정                        |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                          회원 탈퇴                            |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       -----------------------------------------------------------------                       ");

    }
}
