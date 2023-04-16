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
    ConsoleKeyInfo inputKey;

    DataStorage dataStorage;
    AdministratorModeUi administratorModeUi;
    CommonFunctionUi commonFunctionUi;
    BookInformation bookInformation;

    public EditingBook(DataStorage dataStorage, AdministratorModeUi administratorModeUi , CommonFunctionUi commonFunctionUi, BookInformation bookInformation) {

        this.dataStorage = dataStorage;
        this.administratorModeUi = administratorModeUi;
        this.commonFunctionUi = commonFunctionUi;
        this.bookInformation = bookInformation;
    }


    public void EditBook()
    {
        while (true)
        {
            commonFunctionUi.PrintBookFinderMenu();
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
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
                    if ((dataStorage.bookList[i].bookName).Contains(title) &&
                        (dataStorage.bookList[i].bookAuthor).Contains(author) &&
                        (dataStorage.bookList[i].bookPublisher).Contains(publisher)) //제목 일치하는지 확인
                    {
                        PrintPossiblity++;
                    }
                }

                if (PrintPossiblity > 0) // 일치하면 출력
                {
                    {
                        commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
                    }
                    PrintPossiblity = 0;
                }
            }

            Console.SetCursorPosition(64, 2);
            EditedBookIdString = Console.ReadLine();
            EditedBookIdInt = int.Parse(EditedBookIdString);
            Console.Clear();
            administratorModeUi.PrintEditingBookMenu();
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                if (dataStorage.bookList[i].bookId == EditedBookIdInt)
                {
                    administratorModeUi.PrintCurrentSavedBookInformation(dataStorage, i);
                    break;
                }
            }

            administratorModeUi.PrintEditingBookInformation();

            Console.SetCursorPosition(63, 24);
            title = bookInformation.JudgeBookNameRegularExpression(63, 24);
            Console.SetCursorPosition(63, 25);
            author = bookInformation.JudgeBookAuthorRegularExpression(63, 25);
            Console.SetCursorPosition(63, 26);
            publisher = bookInformation.JudgeBookPublisherRegularExpression(63, 26);
            Console.SetCursorPosition(63, 27);
            quantity = bookInformation.JudgeBookQuantityRegularExpression(63, 27);
            Console.SetCursorPosition(63, 28);
            price = bookInformation.JudgeBookPriceRegularExpression(63, 28);
            Console.SetCursorPosition(63, 29);
            publishDate = bookInformation.JudgeBookPublishDateRegularExpression(63, 29);

            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                if (dataStorage.bookList[i].bookId == EditedBookIdInt)
                {
                    dataStorage.bookList[i].bookName = title;
                    dataStorage.bookList[i].bookAuthor = author;
                    dataStorage.bookList[i].bookPublisher = publisher;
                    dataStorage.bookList[i].bookQuantity = int.Parse(quantity);
                    dataStorage.bookList[i].bookPrice = int.Parse(price);
                    dataStorage.bookList[i].bookPublicationDate = publishDate;
                    break;
                }
            }
            Console.Clear();
            administratorModeUi.PrintEditingBookSuccessSentence();
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

