using System;
using System.Runtime.CompilerServices;

public class AdministratorModeUi{ // ui 메모리 더 쌓일 수 있다.

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
    public void PrintFailNotExistInListSentence()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                             책이 검색 목록에 없습니다!\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 다시입력                  ESC : 뒤로가기\n\n");
    }
    public void PrintDeletingBookFailAlreadyBorrowedSentence()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                        책이 대여 중이라 삭제 할 수 없습니다!\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 다시입력                  ESC : 뒤로가기\n\n");
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
    public void PrintEditingBookFailAlreadyBorrowedSentence()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                        책이 대여 중이라 수정 할 수 없습니다!\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 다시입력                  ESC : 뒤로가기\n\n");
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
    public void PrintCurrentSavedBookInformation(BookDTO bookInformation)
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

    public void PrintNotExistUser()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                             입력한 사용자가 없습니다 :\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 확인                     ESC : 뒤로가기\n\n");
    }

    public void PrintUserBorrowedSomeBook()
    {
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                    대여중인 도서가 있어 회원삭제가 불가능합니다. :\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 확인                     ESC : 뒤로가기\n\n");
    }

    public void PrintMemberList(UserDTO userInformation)
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
        Console.WriteLine("========================================================================================================================");
        Console.WriteLine("User Name  :" + userName);
        Console.WriteLine("========================================================================================================================");
    }
    public void PrintUserBorrowedBookList(BookDTO bookInformation)
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
        Console.WriteLine("반납 의무 시간 :  " + bookInformation.ReturnTime);
        Console.WriteLine("============================================================");
    }
}
