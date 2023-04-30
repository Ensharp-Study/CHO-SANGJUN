using System;
using System.Runtime.CompilerServices;

public class AdministratorModeUi{

    //싱글턴 디자인 패턴
    private static AdministratorModeUi instance;
    private AdministratorModeUi() { }
    public static AdministratorModeUi GetInstance()
    {
        if (instance == null)
        {
            instance = new AdministratorModeUi();
        }
        return instance;
    }

    public int PrintSelectAdministratorMenu()
    {

        ConsoleKeyInfo inputKey;
        bool isCheckedEnter = false;
        int selectedMenuNum = -1;
        int menuIndex = 0;
        int i;
        string[] menuArr = { "○ 책 정보 검색", "○ 책 추가하기", "○ 책 삭제하기", "○ 책 정보 수정하기", "○ 회원관리", "○ 도서 대여 현황" };

        Console.SetCursorPosition(49, 26);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(menuArr[0]);
        Console.ResetColor();
        for (i = 1; i < 6; i++)
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

                for (i = 0; i < 6; i++)
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
                if (menuIndex < 5) menuIndex++;

                for (i = 0; i < 6; i++)
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

            //두 와일 지양, 너무 길다

        }
        return menuIndex;
    }

    public void PrintAddingBookMenu()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                                    도서추가\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                 ENTER : 확인                     ESC : 뒤로가기\n\n");
        Console.WriteLine("                 ------------------------------------------------------------------------------\n");
        Console.WriteLine("                 책 제목  :  ");
        Console.WriteLine("                 작가     :  ");
        Console.WriteLine("                 출판사   :  ");
        Console.WriteLine("                 수량     :  ");
        Console.WriteLine("                 가격     :  ");
        Console.WriteLine("                 출시일   :  ");
        Console.WriteLine("                 ISBN     :  ");
        Console.WriteLine("                 정보     :  \n");
        Console.WriteLine("                 -------------------------------------------------------------------------------\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                            책 제목 - 영어, 한글, 숫자,?!+= 1개 이상");
        Console.WriteLine("                          : 작가    - 영어, 한글 1글자 이상");
        Console.WriteLine("                          : 출판사  - 영어, 한글, 숫자 중 1개 이상");
        Console.WriteLine("                          : 수량    - 1~999 사이의 자연수");
        Console.WriteLine("                          : 가격    - 1~9999999 사이의 자연수");
        Console.WriteLine("                          : 출시일  - 19xx or 20xx-xx-xx");
        Console.WriteLine("                          : ISBN    - 국제표준 xxx-xx-xxxxxx-x-x ");
        Console.WriteLine("                          : 정보    - 최소1개의 문자(공백포함)\n");
        Console.ResetColor();
        Console.WriteLine("                 -------------------------------------------------------------------------------\n");
    }

    public void PrintAddingBookSuccessSentence()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                                    추가 완료\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                ENTER : 다시추가                     ESC : 뒤로가기\n\n");
        Console.WriteLine("                 -------------------------------------------------------------------------------\n\n\n");
        Console.WriteLine("                                                   ★추가 성공★\n\n\n");
    }

    public void PrintDeletingBookMenu()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                                  삭제할 책 ID : \n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                ENTER : 확인                       ESC : 뒤로가기\n\n");
    }
    public void PrintDeletingBookSuccessSentence()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                                    책 삭제 완료!\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 다시삭제                  ESC : 뒤로가기\n\n");
    }

    public void PrintEditingBookAskingMenu()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                                  수정할 책 ID : \n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                ENTER : 확인                       ESC : 뒤로가기\n\n");
    }
    public void PrintEditingBookMenu()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                                     책  수정  \n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                ENTER : 확인                       ESC : 뒤로가기\n\n");
    }
    public void PrintEditingBookSuccessSentence()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                                   책  수정 완료! \n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 다시하기                    ESC : 뒤로가기\n\n");
    }
    public void PrintCurrentSavedBookInformation(BookInformation bookInformation)
    {
        Console.WriteLine("                                                       ◈현재 등록되어 있는 정보◈         \n\n");
        Console.WriteLine("                        책제목(영어,한글,숫자,?!+= 1개 이상): " + bookInformation.BookName);
        Console.WriteLine("                        작가 (  영어,한글 1글자 이상  )     : " + bookInformation.BookAuthor);
        Console.WriteLine("                        출판사 (영어,한글,숫자 1개 이상)    : " + bookInformation.BookPublisher);
        Console.WriteLine("                        수량 (    1~999 사이의 자연수    )  : " + bookInformation.BookQuantity);
        Console.WriteLine("                        가격 (  1~9999999 사이의 자연수  )  : " + bookInformation.BookPrice);
        Console.WriteLine("                        출시일 (  19xx or 20xx-xx-xx   )    : " + bookInformation.BookPublicationDate);
        Console.WriteLine("\n\n");
    }
    public void PrintEditingBookInformation()
    {
        Console.WriteLine("                                                       ◈새로 정보등록 하기◈         \n\n");
        Console.WriteLine("                        책제목(영어,한글,숫자,?!+= 1개 이상): ");
        Console.WriteLine("                        작가 (  영어,한글 1글자 이상  )     : ");
        Console.WriteLine("                        출판사 (영어,한글,숫자 1개 이상)    : ");
        Console.WriteLine("                        수량 (    0~999 사이의 정수    )  : ");
        Console.WriteLine("                        가격 (  1~9999999 사이의 자연수  )  : ");
        Console.WriteLine("                        출시일 (  19xx or 20xx-xx-xx   )    : ");
    }

    public void PrintMemberManagerMenu()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                             삭제할 유저 Number 입력 :\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 확인                     ESC : 뒤로가기\n\n");
    }

    public void PrintMemberList(UserInformation userInformation)
    {
        Console.WriteLine("===========================================================================================================\n");
        Console.WriteLine("유저 Number :{0}", userInformation.UserNumber);
        Console.WriteLine("유저 ID     :" + userInformation.Id);
        Console.WriteLine("유저 이름   :" + userInformation.UserName);
        Console.WriteLine("유저 나이   :{0}", userInformation.UserAge);
        Console.WriteLine("유저 번호   :" + userInformation.UserPhoneNumber);
        Console.WriteLine("유저 주소   :" + userInformation.UserAddress);
        Console.WriteLine("\n\n");
    }
    public void PrintDeletingUserSuccessSentence()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                                 유저 삭제 성공 \n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 다시하기                 ESC : 뒤로가기\n\n");
    }

    public void PrintBookBorrowedMenu()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                                 전체회원 대여상황 \n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 확인                     ESC : 뒤로가기\n\n");
    }

    public void PrintUserName(string userName)
    {
        Console.WriteLine("========================================================================================================================\n");
        Console.WriteLine("User Name  :" + userName);
        Console.WriteLine("========================================================================================================================");
    }
    public void PrintUserBorrowedBookList(BookInformation bookInformation)
    {
        Console.WriteLine("책아이디  :  {0}", bookInformation.BookId);
        Console.WriteLine("책 제목   :  " + bookInformation.BookName);
        Console.WriteLine("작가      :  " + bookInformation.BookAuthor);
        Console.WriteLine("출판사    :  " + bookInformation.BookPublisher);
        Console.WriteLine("수량      :  {0}", bookInformation.BookQuantity);
        Console.WriteLine("가격      :  {0}", bookInformation.BookPrice);
        Console.WriteLine("출시일    :  " + bookInformation.BookPublicationDate);
        Console.WriteLine("ISBN      :  " + bookInformation.Isbn);
        Console.WriteLine("빌린 시간 :  " + bookInformation.BorrowTime);
        Console.WriteLine("반납 시간 :  " + bookInformation.ReturnTime);
        Console.WriteLine("============================================================");
    }
}
