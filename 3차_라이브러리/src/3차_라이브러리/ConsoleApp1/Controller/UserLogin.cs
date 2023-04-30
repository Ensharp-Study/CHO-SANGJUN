using System;
using System.Text.RegularExpressions;

public class UserLogin //유저모드 로그인 기능 클래스
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformationException userInformationException;
    BookInformationException bookInformationException;
    ProgramProcess programProcess;

    public UserLogin(MainMenuUi mainMenuUi, SignUpAndLoginUi signUpAndLoginUi, DataStorage dataStorage, UserInformationException userInformationException, BookInformationException bookInformationException, ProgramProcess programProcess)
    {
        this.mainMenuUi = mainMenuUi;
        this.signUpAndLoginUi = signUpAndLoginUi;
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
        this.bookInformationException = bookInformationException;
        this.programProcess = programProcess;
        
    }

    public void GetUserLogin() 
    {
        string id;
        string password;
        bool isJudgingCorrectInput = true; //ESC 탈출 기능용 진리형 변수
        bool isJudgingCorrectString; //입력값 검사 후 탈출용 진리형 변수 

        while (isJudgingCorrectInput)
        {
            Console.Clear();
            mainMenuUi.ViewMainMenu();
            mainMenuUi.ViewMenuSquare();
            signUpAndLoginUi.PrintUserLoginMenu();  //메뉴 인터페이스 출력

           
            Console.SetCursorPosition(53, 23);
            do //아이디 입력
            {
                id = InputByReadKey.ReceiveInput(53, 23); //입력값 키값으로 검사
                isJudgingCorrectString = userInformationException.JudgeIdWithRegularExpression(53, 23, id); //정규표현식 이용하여 검사
            } while (!isJudgingCorrectString); //정규표현식 확인후 거짓일 때만 재실행 

            
            Console.SetCursorPosition(61, 24);
            do //비밀번호 입력
            {
                password = InputByReadKey.ReceiveInputForMasking(61, 24);
                isJudgingCorrectString = userInformationException.JudgePasswordWithRegularExpression(61, 24, password);
            } while (!isJudgingCorrectString);
            

            //아이디와 비밀번호 : 데이터값과 입력값 비교
            bool isJudgingCorrectId = false; //아이디가 유저 데이터에 있을 때 참 값인 진리형 변수

            for (int indexI = 0; indexI < dataStorage.userList.Count; indexI++)
            {
                if (string.Equals(id, dataStorage.userList[indexI].Id)) //아이디 비교
                {
                    isJudgingCorrectId = true;
                    if (string.Equals(password, dataStorage.userList[indexI].Password)) //비밀번호 비교
                    {
                        Console.Clear() ;
                        UserMenu usermenu = new UserMenu(mainMenuUi, dataStorage,  dataStorage.userList[indexI],  userInformationException, bookInformationException, programProcess); //유저메뉴로 진입
                        usermenu.ControllUserMenu();
                        //isJudgingCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요        "); //아이디만 맞고 비밀번호는 틀렸을 경우
                        Console.ReadKey();
                    }
                }
            }

            if(isJudgingCorrectId == false) //입력한 아이디 유저데이터에 없을 경우
            {
                Console.WriteLine("\n\n                             아이디 또는 비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                Console.ReadKey();
            }
        }
    }
}
