using System;

public class Ui
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
        selectedMenuNum = magicNumber.USERMODE;

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
    public int PrintLoginOrSignUpMenu(MagicNumber magicNumber)
    {
        ConsoleKeyInfo inputKey;
        bool isCheckedEnter = false;
        int selectedMenuNum = -1;

        Console.SetCursorPosition(50, 23);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("○ 로그인                         ");
        Console.SetCursorPosition(50, 24);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("○ 회원가입                       ");
        selectedMenuNum = magicNumber.USERMODE;

        while (isCheckedEnter == false)
        {
            inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.UpArrow)
            {
                Console.SetCursorPosition(50, 23);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("○ 로그인                  ");
                Console.SetCursorPosition(50, 24);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("○ 회원가입                ");
                selectedMenuNum = magicNumber.LOGIN;
            }
            else if (inputKey.Key == ConsoleKey.DownArrow)
            {
                Console.SetCursorPosition(50, 23);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("○ 로그인                  ");
                Console.SetCursorPosition(50, 24);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("○ 회원가입                ");
                Console.ResetColor();
                selectedMenuNum = magicNumber.SIGNUP;
            }
            else if (inputKey.Key == ConsoleKey.Enter)
            {
                isCheckedEnter = true;
            }
        }
        if (selectedMenuNum == magicNumber.LOGIN)
        {
            return magicNumber.LOGIN;
        }
        else if (selectedMenuNum == magicNumber.SIGNUP)
        {
            return magicNumber.SIGNUP;
        }

        return -1;


    }
    public void PrintSignUpMenu()
    {
        Console.SetCursorPosition(50, 22);
        Console.WriteLine("                                              ");
        Console.SetCursorPosition(50, 23);
        Console.WriteLine("회 원 가 입");
        Console.SetCursorPosition(34, 25);
        Console.WriteLine("ESC : 뒤로가기              ENTER : 입력하기  ");
    }
    public void PrintSignUpInputMenu()
    {
        Console.WriteLine("\n");
        Console.WriteLine("                       User ID (8~15글자 영어 ,숫자 포함) : ");
        Console.WriteLine("                       User PW (8~15글자 영어 ,숫자 포함) : ");
        Console.WriteLine("                       User PW (      PASSWORD 확인     ) : ");
        Console.WriteLine("                       User Name (한글,영어 포함 1글자 이상) : ");
        Console.WriteLine("                       User Age ( 0,자연수 0세 ~ 200세 ) : ");
        Console.WriteLine("                       User PhoneNumber (  01x-xxxx-xxxx  ) : ");
        Console.WriteLine("                       User Address (  도로명 주소 - 00시 00구  ) : ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("                       ex) 경기도 수원시 영통구 영통로 124");
        Console.WriteLine("                       ex) 서울특별시 강남구 남부순환로 지하 2744");
        Console.WriteLine("                       ex) 서울특별시 마포구 큰우물로 28");
        Console.ResetColor();
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
        string[] menuArr = { "○ 책 정보 검색", "○ 책 대여하기", "○ 대여 목록 확인", "○ 책 반납하기", "○ 반납 목록 확인", "○ 회원정보 수정", "○ 회원탈퇴" };

        Console.SetCursorPosition(49, 26);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(menuArr[0]);
        Console.ResetColor();
        for (i = 1; i < 7; i++)
        {
            Console.SetCursorPosition(49, 26 + i);
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
    public void PrintBookList(Data data, int indexI)
    {
        Console.WriteLine("책아이디  :  {0}", data.bookList[indexI].bookId);
        Console.WriteLine("책 제목   :  " + data.bookList[indexI].bookName);
        Console.WriteLine("작가      :  " + data.bookList[indexI].bookAuthor);
        Console.WriteLine("출판사    :  " + data.bookList[indexI].bookPublisher);
        Console.WriteLine("수량      :  {0}", data.bookList[indexI].bookQuantity);
        Console.WriteLine("가격      :  {0}", data.bookList[indexI].bookPrice);
        Console.WriteLine("출시일    :  " + data.bookList[indexI].bookPublicationDate);
        Console.WriteLine("ISBN      :  " + data.bookList[indexI].isbn);
        Console.WriteLine("책 정보   :  " + data.bookList[indexI].bookInf);
        Console.WriteLine("============================================================");
    }

    public void PrintBorrowingBook()
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("     빌릴 책의 ID를 입력해 주세요 : ");
        Console.WriteLine("     값의 범위 : 0~999");
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ESC  :  뒤로가기");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ENTER  :  입력하기\n\n\n\n");
        Console.ResetColor();
        Console.WriteLine("============================================================");


    }

    public void PrintBorrowingBook(Data data, int indexI)
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("   빌릴 책의 ID를 입력해 주세요 : ");
        Console.WriteLine("   값의 범위 : 0~999");
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ESC  :  뒤로가기");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ENTER  :  입력하기\n\n");
        Console.ResetColor();
        Console.WriteLine("============================================================");
    }

    public void PrintBorrowingList()
    {
        Console.WriteLine("============================================================");
        Console.WriteLine("                  현재 대여 중인 도서 목록                  ");
        Console.WriteLine("============================================================");
    }

    public void PrintUserBorrowingList(string bookName)
    {
        Console.WriteLine(" 책 이름 : " + bookName);
        Console.WriteLine("============================================================");
    }
    public void PrintReturningBook()
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("   반납할 책의 ID를 입력해 주세요 : ");
        Console.WriteLine("   값의 범위 : 0~999");
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ESC  :  뒤로가기");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ENTER  :  입력하기\n\n");
        Console.ResetColor();
        Console.WriteLine("============================================================");
    }
    public void PrintReturningList()
    {
        Console.WriteLine("============================================================");
        Console.WriteLine("                    현재 반납한 도서 목록                   ");
        Console.WriteLine("============================================================");
    }

    public void PrintBeforeUserInf(UserInf user)
    {
        Console.WriteLine("                        _______________________________________________________________                        ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                        개인 정보 바꾸기                       |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |             ESC : 뒤로가기          ENTER : 선택하기          |                       ");
        Console.WriteLine("                       -----------------------------------------------------------------                       ");
        Console.WriteLine("                                                                                                               ");
        Console.WriteLine("                                          ★ 현재 등록되어 있는 정보 ★                                        ");
        Console.WriteLine("                                                                                                               ");
        Console.WriteLine("                                                                                                               ");
        Console.WriteLine("                 USER ID (8~15글자 영어, 숫자포함) : " + user.id);
        Console.WriteLine("                 USER PW (8~15글자 영어, 숫자포함) : " + user.password);
        Console.WriteLine("                 USER Name (한글,영어 포함 2글자 이상) : " + user.userName);
        Console.WriteLine("                 USER Age (    자연수 0~200세    ) : " + user.userAge);
        Console.WriteLine("                 USER PhoneNumber (  01x-xxxx-xxxx  ) : " + user.userPhoneNumber);
        Console.WriteLine("                 USER Address (       한글 주소       ) : " + user.userAddress);
    }
    public void PrintAfterUserInf(UserInf user)
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("                                          ★     변경 할 정보 입력    ★                                        ");
        Console.WriteLine("                                                                                                               ");
        Console.WriteLine("                                                                                                               ");
        Console.WriteLine("                 USER ID (8~15글자 영어, 숫자포함) : ");
        Console.WriteLine("                 USER PW (8~15글자 영어, 숫자포함) : ");
        Console.WriteLine("                 USER Name (한글,영어 포함 2글자 이상) : ");
        Console.WriteLine("                 USER Age (    자연수 0~200세    ) : ");
        Console.WriteLine("                 USER PhoneNumber (  01x-xxxx-xxxx  ) : ");
        Console.WriteLine("                 USER Address (       한글 주소       ) : ");
    }
}