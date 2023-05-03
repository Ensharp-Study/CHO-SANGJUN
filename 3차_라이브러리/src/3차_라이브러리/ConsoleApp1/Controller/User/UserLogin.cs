using ConsoleApp1.DataBase;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class UserLogin //유저모드 로그인 기능 클래스
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;

    ProgramProcess programProcess;

    UserDAO userDAO;
    UserMenu usermenu;

    private string id;
    private string password;

    public UserLogin(ProgramProcess programProcess)
    { 
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.signUpAndLoginUi = SignUpAndLoginUi.GetInstance();


        this.programProcess = programProcess;

        this.userDAO = new UserDAO();
        this.usermenu = new UserMenu(programProcess);
    }

    public void GetUserLogin()
    {
        bool isJudgingCorrectInput = false; //로그인 성공여부를 판단하는 bool형 변수
        List<UserDTO> userinformation;

        while (!isJudgingCorrectInput)
        {
            Console.Clear();
            mainMenuUi.ViewMainMenu();
            mainMenuUi.ViewMenuSquare();
            signUpAndLoginUi.PrintUserLoginMenu();  //메뉴 인터페이스 출력

            ReceieveIdAndPassword(); //아이디 비밀번호 입력 받기
            userinformation = userDAO.CompareAccountInformation(id); //일치하는 id가 있는지 판단

            if (userinformation.Count == 0) //리스트 원소가 없는경우 == 일치하는 id가 없는 경우
            {
                Console.SetCursorPosition(40 , 27);
                Console.WriteLine("해당 아이디가 없습니다. 다시 입력하세요");
                Console.ReadKey(true);
            }
            else //일치하는 id가 있는 경우
            {
                if (userinformation[0].Password == password) //비밀번호가 일치할 경우 로그인 성공
                {
                    isJudgingCorrectInput = true; //반복문 탈출
                }
                else //비밀번호가 틀릴경우
                {
                    Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                    Console.ReadKey(true);
                }
            }
        }
        Console.Clear();
        usermenu.ControllUserMenu(); //유저 모드 메뉴로 진입
    }
    public void ReceieveIdAndPassword()
    {
        bool isJudgingCorrectString; //입력값 검사 후 탈출용 진리형 변수 

        isJudgingCorrectString = false;
        Console.SetCursorPosition(53, 23);
        while (!isJudgingCorrectString) //아이디 입력
        {
            id = InputByReadKey.ReceiveInput(53, 23, 15, Constants.IS_NOT_PASSWORD); //입력값 키값으로 검사
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(53, 23, id, Constants.USER_ID_REGULAR_EXPRESSION, Constants.USER_ID_ERROR_MESSAGE); //정규표현식 이용하여 검사
        }  //정규표현식 확인후 거짓일 때만 재실행 

        isJudgingCorrectString = false;
        Console.SetCursorPosition(61, 24);
        while (!isJudgingCorrectString) //비밀번호 입력
        {
            password = InputByReadKey.ReceiveInput(61, 24, 15, Constants.IS_PASSWORD);
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(53, 23, id, Constants.USER_PASSWORD_REGULAR_EXPRESSION, Constants.USER_PASSWORD_ERROR_MESSAGE);
        } 

    }
}
