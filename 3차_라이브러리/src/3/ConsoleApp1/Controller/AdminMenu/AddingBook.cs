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

	public void AddNewBook() //새로운 책 추가하기
	{
        while (true)
        {
            administratorModeUi.PrintAddingBookMenu();  // 책 추가 메뉴 인터페이스 출력
            BookInformation bookInformation = new BookInformation(); //새로운 책 정보 담을 인스턴스 생성

            Console.SetCursorPosition(29, 11);
            bookInformation.BookName = bookInformationException.JudgeBookNameRegularExpression(29, 11);
            Console.SetCursorPosition(29, 12);
            bookInformation.BookAuthor = bookInformationException.JudgeBookAuthorRegularExpression(29, 12);
            Console.SetCursorPosition(29, 13);
            bookInformation.BookPublisher = bookInformationException.JudgeBookPublisherRegularExpression(29, 13);
            Console.SetCursorPosition(29, 14);
            bookInformation.BookQuantity = int.Parse(bookInformationException.JudgeBookQuantityRegularExpression(29, 14));
            Console.SetCursorPosition(29, 15);
            bookInformation.BookPrice = int.Parse(bookInformationException.JudgeBookPriceRegularExpression(29, 15));
            Console.SetCursorPosition(29, 16);
            bookInformation.BookPublicationDate = bookInformationException.JudgeBookPublishDateRegularExpression(29, 16);
            Console.SetCursorPosition(29, 17);
            bookInformation.Isbn = bookInformationException.JudgeBookIsbnRegularExpression(29, 17);
            Console.SetCursorPosition(29, 18);
            bookInformation.BookDescription = bookInformationException.JudgeBookInformationRegularExpression(29, 18);

            dataStorage.bookList.Add(bookInformation);
            Console.Clear();

            administratorModeUi.PrintAddingBookSuccessSentence(); //책 추가 완료 인터페이스 출력

            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }

        }

    }

    
}
