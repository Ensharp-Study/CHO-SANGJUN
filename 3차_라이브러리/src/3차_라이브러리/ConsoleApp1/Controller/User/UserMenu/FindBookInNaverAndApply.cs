using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Utility;

namespace ConsoleApp1.Controller.User.UserMenu
{
    public class FindBookInNaverAndApply
    {
        public UserModeUi userModeUi;
        public InputProcess inputProcess;
        public NaverSearchFunctionAPI naverSearchFunctionAPI;

        public FindBookInNaverAndApply()
        {
            this.userModeUi = UserModeUi.GetInstance();
            this.inputProcess = InputProcess.GetInstance();
            this.naverSearchFunctionAPI =  new NaverSearchFunctionAPI();
        }

        public void FindBookInNaverAndApplyMain()
        {
            bool isMenuExecute = true; //메뉴 탈출 진리형 변수

            while (isMenuExecute)
            {
                Console.SetWindowSize(115, 40);
                SearchBookInNaver();
                Console.ReadKey(true);
                ApplyBookToAdministrator();
                Console.ReadKey(true);
            }
        }

        public void SearchBookInNaver()
        {
            List<BookDTO> searchedBookList;

            userModeUi.PrintSearchBookInNaverMenu();
            string bookName = inputProcess.InputProcessFunction(48, 10, 15, Constants.IS_NOT_PASSWORD, Constants.BOOK_NAME_REGULAR_EXPRESSION, Constants.BOOK_NAME_ERROR_MESSAGE); // 책이름 검색
            string bookCount = inputProcess.InputProcessFunction(48, 11, 3, Constants.IS_NOT_PASSWORD, Constants.NUMBER_REGULAR_EXPRESSION, Constants.NUMBER_ERROR_MESSAGE); // 검색 책 수량 검색

            searchedBookList = naverSearchFunctionAPI.SearchBook(bookName, bookCount);  // 네이버 api연결 (url에 보내줄 책이름, 수량 전달)

            Console.SetCursorPosition(0,16);
            foreach (BookDTO index in searchedBookList)
            {
                userModeUi.PrintBookListSearchedByNaver(index);
            }
        }

        public void ApplyBookToAdministrator()
        {
            userModeUi.ResetMenuScreen();
            userModeUi.PrintApplyBookInNaverMenu();
        }


    }
}
