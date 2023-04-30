using System;

public class AddingBook
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    AdministratorModeUi administratorModeUi;
    
    DataStorage dataStorage;
    ProgramProcess programProcess;
    BookInformation bookInformation; //새로운 책 정보 담을 인스턴스 생성

    public AddingBook(DataStorage dataStorage, ProgramProcess programProcess) {
        
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.administratorModeUi = AdministratorModeUi.GetInstance();
        
        this.dataStorage = dataStorage;
        this.programProcess = programProcess;
        this.bookInformation = new BookInformation();
    }

    bool isJudgingCorrectString = false;
    bool isNumber = false;
    public void AddNewBook() //새로운 책 추가하기
	{
        while (true)
        {
            administratorModeUi.PrintAddingBookMenu();  // 책 추가 메뉴 인터페이스 출력

            dataStorage.bookList.Add(InputNewBookInformation()); //책 리스트에 추가
            Console.Clear();

            administratorModeUi.PrintAddingBookSuccessSentence(); //책 추가 완료 인터페이스 출력

            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }

    public BookInformation InputNewBookInformation() //정보 입력 받는 함수
    {
        isNumber = false;
        Console.SetCursorPosition(29, 11);

        do// 책이름 입력
        {
            bookInformation.BookName = InputByReadKey.ReceiveInput(29, 11, 15, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(29, 11, bookInformation.BookName, Constants.BOOK_NAME_REGULAR_EXPRESSION, Constants.BOOK_NAME_ERROR_MESSAGE);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 12);
        do// 저자 입력
        {
            bookInformation.BookAuthor = InputByReadKey.ReceiveInput(29, 12, 15, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(29, 12, bookInformation.BookAuthor, Constants.BOOK_AUTHOR_REGULAR_EXPRESSION, Constants.BOOK_AUTHOR_ERROR_MESSAGE);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 13);
        do// 출판사 입력
        {
            bookInformation.BookPublisher = InputByReadKey.ReceiveInput(29, 13, 15, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(29, 13, bookInformation.BookPublisher, Constants.BOOK_PUBLISHER_REGULAR_EXPRESSION, Constants.BOOK_PUBLISHER_ERROR_MESSAGE);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 14);

        while (!isJudgingCorrectString)// 수량 입력
        {
            if (regularExpression.JudgeWithRegularExpression(29, 14, InputByReadKey.ReceiveInput(29, 14, 3, Constants.IS_NOT_PASSWORD), Constants.NUMBER_REGULAR_EXPRESSION, Constants.NUMBER_ERROR_MESSAGE)) //문자열이 숫자인지 검사
            {
                bookInformation.BookQuantity = int.Parse(InputByReadKey.ReceiveInput(29, 14, 3, Constants.IS_NOT_PASSWORD));
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(29, 14, (bookInformation.BookQuantity).ToString(), Constants.BOOK_QUANTITY_REGULAR_EXPRESSION, Constants.BOOK_QUANTITY_ERROR_MESSAGE);
            }
        }

        Console.SetCursorPosition(29, 15);
        do// 책가격 입력
        {
            if (regularExpression.JudgeWithRegularExpression(29,15,InputByReadKey.ReceiveInput(29, 15, 6, Constants.IS_NOT_PASSWORD),Constants.NUMBER_REGULAR_EXPRESSION,Constants.NUMBER_ERROR_MESSAGE)) //문자열이 숫자인지 검사
            {
                bookInformation.BookPrice = int.Parse(InputByReadKey.ReceiveInput(29, 15, 6, Constants.IS_NOT_PASSWORD));
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(29, 15, (bookInformation.BookPrice).ToString(), Constants.BOOK_PRICE_REGULAR_EXPRESSION, Constants.BOOK_PRICE_ERROR_MESSAGE);
            }

        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 16);
        do// 책출시일 입력
        {
            bookInformation.BookPublicationDate = InputByReadKey.ReceiveInput(29, 16, 10, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(29, 16, bookInformation.BookPublicationDate, Constants.BOOK_PUBLISH_DATE_REGULAR_EXPRESSION, Constants.BOOK_PUBLISH_DATE_ERROR_MESSAGE);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 17);
        do// 책 isbn 입력
        {
            bookInformation.Isbn = InputByReadKey.ReceiveInput(29, 17, 17, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(29, 17, bookInformation.Isbn, Constants.BOOK_ISBN_REGULAR_EXPRESSION, Constants.BOOK_ISBN_ERROR_MESSAGE);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 18);
        do// 책 설명 입력
        {
            bookInformation.BookDescription = InputByReadKey.ReceiveInput(29, 18, 200, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(29, 18, bookInformation.BookDescription, Constants.BOOK_INFORMATION_REGULAR_EXPRESSION, Constants.BOOK_INFORMATION_ERROR_MESSAGE);
        } while (!isJudgingCorrectString);

        return bookInformation;
    }

    
}
