using System;

public class AddingBook
{
    DataStorage dataStorage;
    AdministratorModeUi administratorModeUi;
    BookInformationException bookInformationException;
    ProgramProcess programProcess;

    public AddingBook(DataStorage dataStorage, AdministratorModeUi administratorModeUi, BookInformationException bookInformationException, ProgramProcess programProcess) { 
    
        this.dataStorage = dataStorage;
        this.administratorModeUi = administratorModeUi;
        this.bookInformationException = bookInformationException;
        this.programProcess = programProcess;
    }

    bool isJudgingCorrectString = false;
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
        BookInformation bookInformation = new BookInformation(); //새로운 책 정보 담을 인스턴스 생성

        Console.SetCursorPosition(29, 11);
        do// 책이름 입력
        {
            bookInformation.BookName = ToReceiveInput.ReceiveInput(29, 11);
            isJudgingCorrectString = bookInformationException.JudgeBookNameRegularExpression(29, 11, bookInformation.BookName);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 12);
        do// 저자 입력
        {
            bookInformation.BookAuthor = ToReceiveInput.ReceiveInput(29, 12);
            isJudgingCorrectString = bookInformationException.JudgeBookAuthorRegularExpression(29, 12, bookInformation.BookAuthor);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 13);
        do// 출판사 입력
        {
            bookInformation.BookPublisher = ToReceiveInput.ReceiveInput(29, 13);
            isJudgingCorrectString = bookInformationException.JudgeBookPublisherRegularExpression(29, 13, bookInformation.BookPublisher);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 14);

        while (!isJudgingCorrectString)// 수량 입력
        {
            bool A = ToReceiveInput.JudgingIsStringNumber(ToReceiveInput.ReceiveInput(29, 14));
            if (A) //문자열이 숫자인지 검사
            {
                bookInformation.BookQuantity = int.Parse(ToReceiveInput.ReceiveInput(29, 14));
                isJudgingCorrectString = bookInformationException.JudgeBookQuantityRegularExpression(29, 14, (bookInformation.BookQuantity).ToString());
            }

        }

        Console.SetCursorPosition(29, 15);
        do// 책가격 입력
        {
            if (ToReceiveInput.JudgingIsStringNumber(ToReceiveInput.ReceiveInput(29, 14))) //문자열이 숫자인지 검사
            {
                bookInformation.BookPrice = int.Parse(ToReceiveInput.ReceiveInput(29, 15));
                isJudgingCorrectString = bookInformationException.JudgeBookPriceRegularExpression(29, 15, (bookInformation.BookPrice).ToString());
            }

        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 16);
        do// 책출시일 입력
        {
            bookInformation.BookPublicationDate = ToReceiveInput.ReceiveInput(29, 16);
            isJudgingCorrectString = bookInformationException.JudgeBookPublishDateRegularExpression(29, 16, bookInformation.BookPublicationDate);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 17);
        do// 책 isbn 입력
        {
            bookInformation.Isbn = ToReceiveInput.ReceiveInput(29, 17);
            isJudgingCorrectString = bookInformationException.JudgeBookIsbnRegularExpression(29, 17, bookInformation.Isbn);
        } while (!isJudgingCorrectString);

        Console.SetCursorPosition(29, 18);
        do// 책 설명 입력
        {
            bookInformation.BookDescription = ToReceiveInput.ReceiveInput(29, 18);
            isJudgingCorrectString = bookInformationException.JudgeBookInformationRegularExpression(29, 18, bookInformation.BookDescription);
        } while (!isJudgingCorrectString);


        return bookInformation;
    }

    
}
