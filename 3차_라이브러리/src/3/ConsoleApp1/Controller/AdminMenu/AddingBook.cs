using System;

public class AddingBook
{
    DataStorage dataStorage;
    AdministratorModeUi administratorModeUi;
    BookInformation bookInformation;

    public AddingBook(DataStorage dataStorage, AdministratorModeUi administratorModeUi, BookInformation bookInformation) { 
    
        this.dataStorage = dataStorage;
        this.administratorModeUi = administratorModeUi;
        this.bookInformation = bookInformation;
    }

	public void AddNewBook() //새로운 책 추가하기
	{
        while (true)
        {
            ConsoleKeyInfo inputKey;
            administratorModeUi.PrintAddingBookMenu();  // 책 추가 메뉴 인터페이스 출력
            BookInf bookInf = new BookInf(); //새로운 책 정보 담을 인스턴스 생성

            Console.SetCursorPosition(29, 11);
            bookInf.bookName = bookInformation.JudgeBookNameRegularExpression(29, 11);
            Console.SetCursorPosition(29, 12);
            bookInf.bookAuthor = bookInformation.JudgeBookAuthorRegularExpression(29, 12);
            Console.SetCursorPosition(29, 13);
            bookInf.bookPublisher = bookInformation.JudgeBookPublisherRegularExpression(29, 13);
            Console.SetCursorPosition(29, 14);
            bookInf.bookQuantity = int.Parse(bookInformation.JudgeBookQuantityRegularExpression(29, 14));
            Console.SetCursorPosition(29, 15);
            bookInf.bookPrice = int.Parse(bookInformation.JudgeBookPriceRegularExpression(29, 15));
            Console.SetCursorPosition(29, 16);
            bookInf.bookPublicationDate = bookInformation.JudgeBookPublishDateRegularExpression(29, 16);
            Console.SetCursorPosition(29, 17);
            bookInf.isbn = bookInformation.JudgeBookIsbnRegularExpression(29, 17);
            Console.SetCursorPosition(29, 18);
            bookInf.bookInf = bookInformation.JudgeBookInformationRegularExpression(29, 18);
            
            dataStorage.bookList.Add(bookInf);
            Console.Clear();

            administratorModeUi.PrintAddingBookSuccessSentence(); //책 추가 완료 인터페이스 출력

            inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
            }
            else if (inputKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                break;
            }

        }

    }
}
