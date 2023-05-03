using System;
using System.Security.Policy;

public class EditingBook
{
    string title;
    string author;
    string publisher;
    string quantity;
    string price;
    string publishDate;

    int PrintPossiblity = 0;
    string EditedBookIdString;
    int EditedBookIdInt;

    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    AdministratorModeUi administratorModeUi;
    CommonFunctionUi commonFunctionUi;
    
    DataStorage dataStorage;
    ProgramProcess programProcess;

    public EditingBook(DataStorage dataStorage, ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.administratorModeUi = AdministratorModeUi.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();
        
        this.dataStorage = dataStorage;
        this.programProcess = programProcess;
    }

    bool isJudgingCorrectString;
    public void EditBook()
    {
        while (true)
        {
            //책 검색하기
            FindBook();

            //책 수정하기
            Console.SetCursorPosition(64, 2);
            EditedBookIdString = Console.ReadLine();
            EditedBookIdInt = int.Parse(EditedBookIdString);
            Console.Clear();
            administratorModeUi.PrintEditingBookMenu();
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                if (dataStorage.bookList[i].BookId == EditedBookIdInt)
                {
                    administratorModeUi.PrintCurrentSavedBookInformation(dataStorage.bookList[i]);
                    break;
                }
            }

            administratorModeUi.PrintEditingBookInformation();

            Console.SetCursorPosition(63, 24);
            do //책 이름
            {
                title = InputByReadKey.ReceiveInput(63, 24, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(63, 24, title, Constants.BOOK_NAME_REGULAR_EXPRESSION, Constants.BOOK_NAME_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);
         
            Console.SetCursorPosition(63, 25);
            do //책 작가
            {
                author = InputByReadKey.ReceiveInput(63, 25, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(63, 25, author, Constants.BOOK_AUTHOR_REGULAR_EXPRESSION, Constants.BOOK_AUTHOR_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(63, 26);
            do //출판사
            {
                publisher = InputByReadKey.ReceiveInput(63, 26, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(63, 26, publisher, Constants.BOOK_PUBLISHER_REGULAR_EXPRESSION, Constants.BOOK_PUBLISHER_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(63, 27);
            do //수량
            {
                quantity = InputByReadKey.ReceiveInput(63, 27, 3, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(63, 27, quantity, Constants.BOOK_QUANTITY_REGULAR_EXPRESSION, Constants.BOOK_QUANTITY_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(63, 28);
            do //가격
            {
                price = InputByReadKey.ReceiveInput(63, 28, 6, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(63, 28, price, Constants.BOOK_PRICE_REGULAR_EXPRESSION, Constants.BOOK_PRICE_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(63, 29);
            do //출판 일시
            {
                publishDate = InputByReadKey.ReceiveInput(63, 29, 10, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(63, 29, publishDate, Constants.BOOK_PUBLISH_DATE_REGULAR_EXPRESSION, Constants.BOOK_PUBLISH_DATE_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);

            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                if (dataStorage.bookList[i].BookId == EditedBookIdInt)
                {
                    dataStorage.bookList[i].BookName = title;
                    dataStorage.bookList[i].BookAuthor = author;
                    dataStorage.bookList[i].BookPublisher = publisher;
                    dataStorage.bookList[i].BookQuantity = int.Parse(quantity);
                    dataStorage.bookList[i].BookPrice = int.Parse(price);
                    dataStorage.bookList[i].BookPublicationDate = publishDate;
                    break;
                }
            }
            Console.Clear();
            administratorModeUi.PrintEditingBookSuccessSentence();

            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
    public void FindBook()
    {
        commonFunctionUi.PrintBookFinderMenu();
        for (int i = 0; i < dataStorage.bookList.Count; i++)
        {
            //commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
        }

        Console.SetCursorPosition(17, 1);
        title = Console.ReadLine();
        Console.SetCursorPosition(19, 2);
        author = Console.ReadLine();
        Console.SetCursorPosition(17, 3);
        publisher = Console.ReadLine();
        Console.WriteLine("\n\n\n");

        Console.Clear();

        administratorModeUi.PrintEditingBookAskingMenu(); //수정할 아이디 받는 창과 리스트 나열 출력
        for (int i = 0; i < dataStorage.bookList.Count; i++)
        {
            if (string.IsNullOrEmpty(title) == false ||
               string.IsNullOrEmpty(author) == false ||
               string.IsNullOrEmpty(publisher) == false) // 입력받은 값이 공백인 경우 제외
            {
                if ((dataStorage.bookList[i].BookName).Contains(title) &&
                    (dataStorage.bookList[i].BookAuthor).Contains(author) &&
                    (dataStorage.bookList[i].BookPublisher).Contains(publisher)) //제목 일치하는지 확인
                {
                    PrintPossiblity++;
                }
            }

            if (PrintPossiblity > 0) // 일치하면 출력
            {
                {
                   // commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
                }
                PrintPossiblity = 0;
            }
        }
    }

}

