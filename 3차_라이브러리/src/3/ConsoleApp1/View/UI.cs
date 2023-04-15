using System;

public class Ui //좀 더 쪼개기
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
    public int PrintLoginOrSignUpMenu()
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
        selectedMenuNum = Constants.USER_MODE;

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
                selectedMenuNum = Constants.LOGIN;
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
                selectedMenuNum = Constants.SIGN_UP;
            }
            else if (inputKey.Key == ConsoleKey.Enter)
            {
                isCheckedEnter = true;
            }
        }
        if (selectedMenuNum == Constants.LOGIN)
        {
            return Constants.LOGIN;
        }
        else if (selectedMenuNum == Constants.SIGN_UP)
        {
            return Constants.SIGN_UP;
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

    public void ViewMenu()
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


    public int PrintSelectUserMenu()
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

    public int PrintSelectAdministratorMenu()
    {
        ConsoleKeyInfo inputKey;
        bool isCheckedEnter = false;
        int selectedMenuNum = -1;
        int menuIndex = 0;
        int i;
        string[] menuArr = { "○ 책 정보 검색", "○ 책 추가하기", "○ 책 삭제하기", "○ 책 정보 수정하기", "○ 회원관리", "○ 도서 대여 현황"};

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

                else if(inputKey.Key == ConsoleKey.Escape)
                {
                    menuIndex = 10;
                    isCheckedEnter = true;
                }

             //두 와일 지양, 너무 길다

        }
        return menuIndex;
    }

    public void PrintBookFinderMenu()
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
    public void PrintBookList(DataStorage dataStorage, int indexI)
    {
        Console.WriteLine("책아이디  :  {0}", dataStorage.bookList[indexI].bookId);
        Console.WriteLine("책 제목   :  " + dataStorage.bookList[indexI].bookName);
        Console.WriteLine("작가      :  " + dataStorage.bookList[indexI].bookAuthor);
        Console.WriteLine("출판사    :  " + dataStorage.bookList[indexI].bookPublisher);
        Console.WriteLine("수량      :  {0}", dataStorage.bookList[indexI].bookQuantity);
        Console.WriteLine("가격      :  {0}", dataStorage.bookList[indexI].bookPrice);
        Console.WriteLine("출시일    :  " + dataStorage.bookList[indexI].bookPublicationDate);
        Console.WriteLine("ISBN      :  " + dataStorage.bookList[indexI].isbn);
        Console.WriteLine("책 정보   :  " + dataStorage.bookList[indexI].bookInf);
        Console.WriteLine("============================================================");
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

    public void PrintBorrowingList()
    {
        Console.WriteLine("============================================================");
        Console.WriteLine("                  현재 대여 중인 도서 목록                  ");
        Console.WriteLine("============================================================");
    }

    public void PrintUserBorrowingList(BookInf book)
    {
        Console.WriteLine(" 책 아이디 : " + book.bookId);
        Console.WriteLine(" 책 이름   : " + book.bookName);
        Console.WriteLine(" 작가      : " + book.bookAuthor);
        Console.WriteLine(" 출판사    : " + book.bookPublisher);
        Console.WriteLine(" 책 수량   : " + book.bookQuantity);
        Console.WriteLine(" 책 가격   : " + book.bookPrice);
        Console.WriteLine(" 대여 일시 : " + book.bookPublicationDate);
        Console.WriteLine(" ISBN      : " + book.bookPublicationDate);
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
    public void PrintShouldReturningList(BookInf book) {

        Console.WriteLine(" 책 이름 : " + book.bookName);
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
    public void SelectEndorReturnInTheProgram()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("다시 검색하려면 ENTER, 메뉴선택으로 돌아가려면 ESC를 눌러주세요.");
        Console.ResetColor();
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
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine("                            책 제목 - 영어, 한글, 숫자,?!+= 1개 이상");
        Console.WriteLine("                          : 작가    - 영어, 한글 1글자 이상");
        Console.WriteLine("                          : 출판사  - 영어, 한글, 숫자 중 1개 이상");
        Console.WriteLine("                          : 수량    - 1~999 사이의 자연수");
        Console.WriteLine("                          : 가격    - 1~9999999 사이의 자연수");
        Console.WriteLine("                          : 출시일  - 19xx or 20xx-xx-xx");
        Console.WriteLine("                          : ISBN    - 정수9개 + 영어1개 + 공백 + 정수 13개");
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
    public void PrintCurrentSavedBookInformation(DataStorage dataStorage, int bookIndex)
    {
        Console.WriteLine("                                                       ◈현재 등록되어 있는 정보◈         \n\n");
        Console.WriteLine("                        책제목(영어,한글,숫자,?!+= 1개 이상): " + dataStorage.bookList[bookIndex].bookName);
        Console.WriteLine("                        작가 (  영어,한글 1글자 이상  )     : " + dataStorage.bookList[bookIndex].bookAuthor);
        Console.WriteLine("                        출판사 (영어,한글,숫자 1개 이상)    : " + dataStorage.bookList[bookIndex].bookPublisher);
        Console.WriteLine("                        수량 (    1~999 사이의 자연수    )  : " + dataStorage.bookList[bookIndex].bookQuantity);
        Console.WriteLine("                        가격 (  1~9999999 사이의 자연수  )  : " + dataStorage.bookList[bookIndex].bookPrice);
        Console.WriteLine("                        출시일 (  19xx or 20xx-xx-xx   )    : " + dataStorage.bookList[bookIndex].bookPublicationDate);
        Console.WriteLine("\n\n");
    }
    public void PrintEditingBookInformation()
    {
        Console.WriteLine("                                                       ◈새로 정보등록 하기◈         \n\n");
        Console.WriteLine("                        책제목(영어,한글,숫자,?!+= 1개 이상): ");
        Console.WriteLine("                        작가 (  영어,한글 1글자 이상  )     : ");
        Console.WriteLine("                        출판사 (영어,한글,숫자 1개 이상)    : ");
        Console.WriteLine("                        수량 (    1~999 사이의 자연수    )  : ");
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

    public void PrintMemberList(DataStorage dataStorage, int index) 
    {
        Console.WriteLine("===========================================================================================================\n");
        Console.WriteLine("유저 Number :{0}", dataStorage.userList[index].userNumber);
        Console.WriteLine("유저 ID     :" + dataStorage.userList[index].id);
        Console.WriteLine("유저 이름   :" + dataStorage.userList[index].userName);
        Console.WriteLine("유저 나이   :{0}", dataStorage.userList[index].userAge);
        Console.WriteLine("유저 번호   :" + dataStorage.userList[index].userPhoneNumber);
        Console.WriteLine("유저 주소   :" + dataStorage.userList[index].userAddress);
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
        Console.WriteLine("                                                전체회원 대여상황 :\n");
        Console.WriteLine("                        ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n");
        Console.WriteLine("                                  ENTER : 확인                     ESC : 뒤로가기\n\n");
    }

    public void PrintUserName(string userName)
    {
        Console.WriteLine("========================================================================================================================\n");
        Console.WriteLine("User Name  :" + userName);
        Console.WriteLine("========================================================================================================================");
    }
    public void PrintUserBorrowedBookList(DataStorage dataStorage, int indexI, int indexJ)
    {
        Console.WriteLine("책아이디  :  {0}", dataStorage.userList[indexI].borrowBookList[indexJ].bookId);
        Console.WriteLine("책 제목   :  " + dataStorage.userList[indexI].borrowBookList[indexJ].bookName);
        Console.WriteLine("작가      :  " + dataStorage.userList[indexI].borrowBookList[indexJ].bookAuthor);
        Console.WriteLine("출판사    :  " + dataStorage.userList[indexI].borrowBookList[indexJ].bookPublisher);
        Console.WriteLine("수량      :  {0}", dataStorage.userList[indexI].borrowBookList[indexJ].bookQuantity);
        Console.WriteLine("가격      :  {0}", dataStorage.userList[indexI].borrowBookList[indexJ].bookPrice);
        Console.WriteLine("출시일    :  " + dataStorage.userList[indexI].borrowBookList[indexJ].bookPublicationDate);
        Console.WriteLine("ISBN      :  " + dataStorage.userList[indexI].borrowBookList[indexJ].isbn);
        Console.WriteLine("빌린 시간 :  " + dataStorage.userList[indexI].borrowBookList[indexJ].borrowTime);
        Console.WriteLine("반납 시간 :  " + dataStorage.userList[indexI].borrowBookList[indexJ].returnTime);
        Console.WriteLine("============================================================");
    }

}