using System;

public class BorrowingBook
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    UserModeUi userModeUi;
    CommonFunctionUi commonFunctionUi;

    DataStorage dataStorage;
    UserDTO userInformation;
    ProgramProcess programProcess;

    public BorrowingBook(DataStorage dataStorage, UserDTO userInformation, ProgramProcess programProcess) 
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.userModeUi = UserModeUi.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();

        this.dataStorage = dataStorage;
        this.userInformation = userInformation;
        this.programProcess = programProcess;

    }

    bool isJudgingCorrectString;

    public void BorrowBook()
	{

        while (true)
        {
            string bookId;
            int sameIndex = -1;

            Console.Clear();
            userModeUi.PrintBorrowingBookMenu();//책 빌리기 메뉴 출력
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
            }

            while (sameIndex == -1)
            {
                Console.SetCursorPosition(36, 3);
                Console.Write("                                         ");
                Console.SetCursorPosition(36, 3);

                do //책 아이디 입력
                {
                    bookId = InputByReadKey.ReceiveInput(36, 3, 3, Constants.IS_NOT_PASSWORD);
                    isJudgingCorrectString = true; 
                } while (!isJudgingCorrectString);

                //입력받은 책 id와 저장된 책 리스트 비교
                for (int i = 0; i < dataStorage.bookList.Count; i++)
                {
                    if (dataStorage.bookList[i].BookId == int.Parse(bookId))
                    {
                        sameIndex = i;
                        break;
                    }
                }

                if (sameIndex == -1) //일치하는 책이 없을 경우
                {
                    Console.SetCursorPosition(36, 3);
                    userModeUi.PrintNotCorrectBook();
                    Console.ReadKey(true);//창 넘기기
                }
            }

            if (dataStorage.bookList[sameIndex].BookQuantity > 0) //책 수량 검사로 대여 가능한지 판별
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("      책 빌리기 성공!                          ");
                Console.WriteLine("                                               ");
                dataStorage.bookList[sameIndex].BookQuantity -= 1;
                for (int i = 0; i < dataStorage.userList.Count; i++)
                {
                    if (userInformation.UserNumber == dataStorage.userList[i].UserNumber)
                    {
                        dataStorage.userList[i].BorrowBookList.Add(dataStorage.bookList[sameIndex]); //유저 대여 리스트에 저장
                        break;
                    }
                }
            }
            else if (dataStorage.bookList[sameIndex].BookQuantity == 0)
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("전 수량이 대여 중 입니다.         ");
                Console.WriteLine("                                  ");

            }
            else if (sameIndex == -1) //일치하는 책이 없을 경우
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("잘못된 ID를 입력하였습니다. 다시 입력해 주세요.");
                Console.WriteLine("                            ");
            }

            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape) //메뉴 탈출하기
            {
                break;
            }

        }

    }
}
