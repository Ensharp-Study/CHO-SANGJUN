using System;

public class UserModeUi
{
    //싱글턴 디자인 패턴
    private static UserModeUi instance;
    private UserModeUi() { }
    public static UserModeUi GetInstance()
    {
        if (instance == null)
        {
            instance = new UserModeUi();
        }
        return instance;
    }

    public int PrintSelectUserMenu()
    {
        ConsoleKeyInfo inputKey;
        bool isCheckedEnter = false;
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

        while (isCheckedEnter == false) // view 여기에 로직이 있는게 이상
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
            else if (inputKey.Key == ConsoleKey.Escape)
            {
                menuIndex = 10;
                isCheckedEnter = true;
            }

        } //두 와일 지양, 너무 길다


        return menuIndex;
    }

    public void PrintBorrowingBookMenu()
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
    public void PrintNotCorrectBook()
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("해당 책이 없습니다. 다시 입력해 주세요");
        Console.ResetColor();
    }

    public void PrintBorrowingList()
    {
        Console.WriteLine("============================================================");
        Console.WriteLine("                  현재 대여 중인 도서 목록                  ");
        Console.WriteLine("============================================================");
    }

    public void PrintUserBorrowingList(BookInformation book)
    {
        Console.WriteLine(" 책 아이디 : " + book.BookId);
        Console.WriteLine(" 책 이름   : " + book.BookName);
        Console.WriteLine(" 작가      : " + book.BookAuthor);
        Console.WriteLine(" 출판사    : " + book.BookPublisher);
        Console.WriteLine(" 책 수량   : " + book.BookQuantity);
        Console.WriteLine(" 책 가격   : " + book.BookPrice);
        Console.WriteLine(" 대여 일시 : " + book.BookPublicationDate);
        Console.WriteLine(" ISBN      : " + book.Isbn);
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
    public void PrintReturningMenuList()
    {
        Console.WriteLine("============================================================");
        Console.WriteLine("                    현재 반납한 도서 목록                   ");
        Console.WriteLine("============================================================");
    }
    public void PrintShouldReturningList(BookInformation book)
    {

        Console.WriteLine(" 책 이름 : " + book.BookName);
        Console.WriteLine("============================================================");
    }

    public void PrintBeforeUserInformation(UserInformation user)
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
        Console.WriteLine("                 USER ID (8~15글자 영어, 숫자포함) : " + user.Id);
        Console.WriteLine("                 USER PW (8~15글자 영어, 숫자포함) : " + user.Password);
        Console.WriteLine("                 USER Name (한글,영어 포함 2글자 이상) : " + user.UserName);
        Console.WriteLine("                 USER Age (    자연수 0~200세    ) : " + user.UserAge);
        Console.WriteLine("                 USER PhoneNumber (  01x-xxxx-xxxx  ) : " + user.UserPhoneNumber);
        Console.WriteLine("                 USER Address (       한글 주소       ) : " + user.UserAddress);
    }
    public void PrintAfterUserInformation(UserInformation user)
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

    public void confirmAccountDeletion()
    {
        Console.WriteLine("                        _______________________________________________________________                        ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                     정말 삭제하시겠습니까?                    |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       -----------------------------------------------------------------                       ");

    }

    public void PrintAccountDeletionSentence()
    {
        Console.WriteLine("                        _______________________________________________________________                        ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                   회원 탈퇴가 완료 되었습니다.                |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       -----------------------------------------------------------------                       ");

    }

    public void PrintMaintainingAccountSentence()
    {
        Console.WriteLine("                        _______________________________________________________________                        ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                   회원 탈퇴가 거절 되었습니다.                |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       -----------------------------------------------------------------                       ");

    }
}