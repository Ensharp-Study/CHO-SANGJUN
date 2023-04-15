using System;

 public class MainMenuUi
{
    public void ViewMainMenu()
    {

        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("           ####       ####    #########      ########             ###       ########      ####     ####");
        Console.WriteLine("            ##         ##      ##      ##     ##     ##           ###        ##     ##     ##       ##");
        Console.WriteLine("            ##         ##      ##     ###     ##      ##         ## ##       ##      ##     ##     ##");
        Console.WriteLine("            ##         ##      ##  ##         ##     ##         ##   ##      ##     ##       ##  ##");
        Console.WriteLine("            ##         ##      ##  ##         ##  ###          #########     ##   ###          ###");
        Console.WriteLine("            ##         ##      ##    ###      ####   ##       ##       ##    ####    ##        ##");
        Console.WriteLine("            ##         ##      ##     ###     ##       ##    ##         ##   ##       ##       ##");
        Console.WriteLine("           #########  ####    #########      ####       ### ##           ## ####       ###    ####");
        Console.WriteLine("\n\n\n\n");
        Console.WriteLine("               ENTER : 선택                                                           ESC : 나가기");
        Console.WriteLine("\n");
    }

    public void ViewMenuSquare()
    {
        Console.WriteLine("                        _______________________________________________________________                        ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       -----------------------------------------------------------------                       ");
    }

    public int PrintSelectMenu()
    {
        ConsoleKeyInfo inputKey;
        bool isCheckedEnter = false;
        int selectedMenuNum = -1;

        Console.SetCursorPosition(50, 23);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("○ 유저모드");
        Console.SetCursorPosition(50, 24);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("○ 관리자 모드");
        selectedMenuNum = Constants.USER_MODE;

        while (isCheckedEnter == false)
        {
            inputKey = Console.ReadKey(); //입력받는거 모델에 있으면 안됨 - 모델은 데이터겟 셋만 뷰는 화면 뿌려주는것만 
            if (inputKey.Key == ConsoleKey.UpArrow)
            {
                Console.SetCursorPosition(50, 23);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("○ 유저모드");
                Console.SetCursorPosition(50, 24);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("○ 관리자 모드");
                selectedMenuNum = Constants.USER_MODE;
            }
            else if (inputKey.Key == ConsoleKey.DownArrow)
            {
                Console.SetCursorPosition(50, 23);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("○ 유저모드");
                Console.SetCursorPosition(50, 24);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("○ 관리자 모드");
                Console.ResetColor();
                selectedMenuNum = Constants.ADMIN_MODE;
            }
            else if (inputKey.Key == ConsoleKey.Enter)
            {
                isCheckedEnter = true;
            }
        }
        if (selectedMenuNum == Constants.USER_MODE)
        {
            return Constants.USER_MODE;
        }
        else if (selectedMenuNum == Constants.USER_MODE)
        {
            return Constants.USER_MODE;
        }

        return -1;
    }
}

