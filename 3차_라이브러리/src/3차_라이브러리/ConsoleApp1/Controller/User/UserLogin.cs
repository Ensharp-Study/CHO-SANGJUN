using ConsoleApp1.DataBase;
using System;
using System.Text.RegularExpressions;

public class UserLogin //유저모드 로그인 기능 클래스
{
    UserDAO userDAO;
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    ProgramProcess programProcess;
    UserMenu usermenu;

    public UserLogin( DataStorage dataStorage, ProgramProcess programProcess)
    {
        this.userDAO = new UserDAO();
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.signUpAndLoginUi = SignUpAndLoginUi.GetInstance();

        this.dataStorage = dataStorage;
        this.programProcess = programProcess;

        this.usermenu = new UserMenu(programProcess);
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
                id = InputByReadKey.ReceiveInput(53, 23, 15, Constants.IS_NOT_PASSWORD); //입력값 키값으로 검사
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(53, 23, id, Constants.USER_ID_REGULAR_EXPRESSION, Constants.USER_ID_ERROR_MESSAGE); //정규표현식 이용하여 검사
            } while (!isJudgingCorrectString); //정규표현식 확인후 거짓일 때만 재실행 

            
            Console.SetCursorPosition(61, 24);
            do //비밀번호 입력
            {
                password = InputByReadKey.ReceiveInput(61, 24, 15, Constants.IS_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(53, 23, id, Constants.USER_PASSWORD_REGULAR_EXPRESSION, Constants.USER_PASSWORD_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);
            

            if (userDAO.CompareAccountInformation(id, password) != null)
            {
                Console.Clear();
                usermenu.ControllUserMenu();//유저메뉴로 진입
            }
            

        }
    }
}
