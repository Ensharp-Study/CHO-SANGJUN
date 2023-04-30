﻿using System;
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

    AdministratorModeUi administratorModeUi;
    CommonFunctionUi commonFunctionUi;
    DataStorage dataStorage;
    BookInformationException bookInformationException;
    ProgramProcess programProcess;

    public EditingBook(DataStorage dataStorage, BookInformationException bookInformationException, ProgramProcess programProcess)
    {
        this.administratorModeUi = AdministratorModeUi.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();
        this.dataStorage = dataStorage;
        this.bookInformationException = bookInformationException;
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
            do
            {
                title = InputByReadKey.ReceiveInput(63, 24, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = bookInformationException.JudgeBookNameRegularExpression(63, 24, title);
            } while (!isJudgingCorrectString);
         
            Console.SetCursorPosition(63, 25);
            do
            {
                author = InputByReadKey.ReceiveInput(63, 25, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = bookInformationException.JudgeBookAuthorRegularExpression(63, 25, author);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(63, 26);
            do
            {
                publisher = InputByReadKey.ReceiveInput(63, 26, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = bookInformationException.JudgeBookPublisherRegularExpression(63, 26, publisher);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(63, 27);
            do
            {
                quantity = InputByReadKey.ReceiveInput(63, 27, 3, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = bookInformationException.JudgeBookQuantityRegularExpression(63, 27, quantity);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(63, 28);
            do
            {
                price = InputByReadKey.ReceiveInput(63, 28, 6, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = bookInformationException.JudgeBookPriceRegularExpression(63, 28, price);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(63, 29);
            do
            {
                publishDate = InputByReadKey.ReceiveInput(63, 29, 10, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = bookInformationException.JudgeBookPublishDateRegularExpression(63, 29, publishDate);
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
                    commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
                }
                PrintPossiblity = 0;
            }
        }
    }

}

