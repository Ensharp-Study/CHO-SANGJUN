using System;

public class Ui {

	public void ViewMainMenu()
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
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("○ 유저모드");
        Console.SetCursorPosition(50, 24);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("○ 관리자 모드");
       
        while (isCheckedEnter == false)
        {
            inputKey = Console.ReadKey();
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

    public void ViewUserMenu()
    {
        Console.SetCursorPosition(0, 21);
        Console.WriteLine("                       _________________________________________________________________                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                          메 뉴 선 택                          |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       -----------------------------------------------------------------                       ");
    }


    public int PrintSelectUserMenu(MagicNumber magicNumber)
    {
        ConsoleKeyInfo inputKey;
        bool isCheckedEnter = false;
        int selectedMenuNum = -1;
        int menuIndex = 0;
        int i;
        string[] menuArr = { "○ 책 정보 검색", "○ 책 대여하기", "○ 대여 목록 확인", "○ 책 반납하기", "○ 반납 목록 확인", "○ 회원정보 수정", "○ 회원탈퇴"}; 

        Console.SetCursorPosition(49, 26);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(menuArr[0]);
        Console.ResetColor();
        for(i=1; i<7; i++)
        {
            Console.SetCursorPosition(49, 26+i);
            Console.WriteLine(menuArr[i]);
        }

        while (isCheckedEnter == false)
        {
            do
            {
                inputKey = Console.ReadKey();
                if (inputKey.Key == ConsoleKey.UpArrow)
                {
                    if (menuIndex > 0) menuIndex--;
                    
                    for (i = 0; i < 7; i++)
                    {
                        Console.SetCursorPosition(49, 26 + i);
                        if (i == menuIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(menuArr[i]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(menuArr[i]);
                        }
                    }
                }

                else if (inputKey.Key == ConsoleKey.DownArrow)
                {
                    if (menuIndex < 6) menuIndex++;
                    
                    for (i = 0; i < 7; i++)
                    {
                        Console.SetCursorPosition(49, 26 + i);
                        if (i == menuIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(menuArr[i]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(menuArr[i]);
                        }
                    }
                }

                else if (inputKey.Key == ConsoleKey.Enter)
                {
                    isCheckedEnter = true;
                }

            } while (inputKey.Key != ConsoleKey.Enter);
           
        }
        return menuIndex;
    }

    public void PrintBookListMenu()
    {
        Console.WriteLine("============================================================");
        Console.WriteLine(" 제목으로 찾기:");
        Console.WriteLine(" 작가명으로 찾기:");
        Console.WriteLine(" 출판사로 찾기:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ESC  :  뒤로가기");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ENTER  :  입력하기");
        Console.ResetColor();
        Console.WriteLine("건너뛰고자 하는 항목은 ENTER을 눌러주세요");
        Console.WriteLine("============================================================");
    }
    public void PrintBookList(Data data)
    {
        int i;
        for (i = 0; i < data.bookList.Count; i++)
        {
            Console.WriteLine("책아이디  :  {0}", data.bookList[i].bookId);
            Console.WriteLine("책 제목   :  "+ data.bookList[i].bookName);
            Console.WriteLine("작가      :  " + data.bookList[i].bookAuthor);
            Console.WriteLine("출판사    :  " + data.bookList[i].bookPublisher);
            Console.WriteLine("수량      :  {0}", data.bookList[i].bookQuantity);
            Console.WriteLine("가격      :  {0}", data.bookList[i].bookPrice);
            Console.WriteLine("출시일    :  " + data.bookList[i].bookPublicationDate);
            Console.WriteLine("ISBN      :  " + data.bookList[i].isbn);
            Console.WriteLine("책 정보   :  " + data.bookList[i].bookInf);
            Console.WriteLine("============================================================");

        }
    }


}
