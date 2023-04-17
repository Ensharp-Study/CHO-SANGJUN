using System;

public class AddingBook
{
    DataStorage dataStorage;
    AdministratorModeUi administratorModeUi;
    BookInformationException bookInformationException;

    public AddingBook(DataStorage dataStorage, AdministratorModeUi administratorModeUi, BookInformationException bookInformationException) { 
    
        this.dataStorage = dataStorage;
        this.administratorModeUi = administratorModeUi;
        this.bookInformationException = bookInformationException;
    }

	public void AddNewBook() //새로운 책 추가하기
	{
        while (true)
        {
            administratorModeUi.PrintAddingBookMenu();  // 책 추가 메뉴 인터페이스 출력
            BookInformation bookInformation = new BookInformation(); //새로운 책 정보 담을 인스턴스 생성

            Console.SetCursorPosition(29, 11);
            bookInformation.bookName = bookInformationException.JudgeBookNameRegularExpression(29, 11);
            Console.SetCursorPosition(29, 12);
            bookInformation.bookAuthor = bookInformationException.JudgeBookAuthorRegularExpression(29, 12);
            Console.SetCursorPosition(29, 13);
            bookInformation.bookPublisher = bookInformationException.JudgeBookPublisherRegularExpression(29, 13);
            Console.SetCursorPosition(29, 14);
            bookInformation.bookQuantity = int.Parse(bookInformationException.JudgeBookQuantityRegularExpression(29, 14));
            Console.SetCursorPosition(29, 15);
            bookInformation.bookPrice = int.Parse(bookInformationException.JudgeBookPriceRegularExpression(29, 15));
            Console.SetCursorPosition(29, 16);
            bookInformation.bookPublicationDate = bookInformationException.JudgeBookPublishDateRegularExpression(29, 16);
            Console.SetCursorPosition(29, 17);
            bookInformation.isbn = bookInformationException.JudgeBookIsbnRegularExpression(29, 17);
            Console.SetCursorPosition(29, 18);
            bookInformation.bookInf = bookInformationException.JudgeBookInformationRegularExpression(29, 18);

            dataStorage.bookList.Add(bookInformation);
            Console.Clear();

            administratorModeUi.PrintAddingBookSuccessSentence(); //책 추가 완료 인터페이스 출력
        }

    }

    
}
