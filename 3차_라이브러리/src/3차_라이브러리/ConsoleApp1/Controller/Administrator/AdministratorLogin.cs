using ConsoleApp1.DataBase;
using System;
using System.Xml.Linq;

public class AdministratorLogin
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;

    ProgramProcess programProcess;
    AdministratorMenu administratorMenu;
    UserDAO userDAO;

    public AdministratorLogin(ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.signUpAndLoginUi = SignUpAndLoginUi.GetInstance();
        
        this.programProcess = programProcess;
        this.administratorMenu = new AdministratorMenu(programProcess);
        this.userDAO = new UserDAO();
    }

    private bool isJudgingCorrectString;
    private string id;
    private string password;

    public void GetAdministratorLogin()
    {
        /*
        int userDataCount;
        UserDTO userinformation;  
        while (true)
        {
            signUpAndLoginUi.PrintAdministratorLoginMenu();
            ReceiveIdAndPassword();

           userDataCount = userDAO.ReadAllUserCount("SELECT COUNT(*) FROM adminstrator_data;"); //데이터 베이스에 저장된 모든 관리자의 수 구하기
            
            for(int i=1; i<= userDataCount; i++)
            {
               userinformation = userDAO.CompareAccountInformation("SELECT id, password FROM adminstrator_data;", i); //쿼리문 ID PASSWORD값만 데이터 베이스 테이블에서 가져오기

                if (string.Equals(id, userinformation.Id)) //아이디 및 비밀번호 검사
                {
                    if (string.Equals(password, userinformation.Password))
                    {
                        Console.Clear();
                        administratorMenu.ControllAdministratorMenu(); //매니저 모드 메뉴로 진입
                        break;
                    }
                    Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                }
                else
                {
                    Console.WriteLine("\n\n                             아이디 또는 비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                }
            }

            //프로그램 탈출
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }

        }*/
    }

    public void ReceiveIdAndPassword()
    {
        isJudgingCorrectString = false;
        Console.SetCursorPosition(53, 23);
        while (!isJudgingCorrectString)//정규표현식 확인후 거짓일 때만 재실행  
        {
            id = InputByReadKey.ReceiveInput(53, 23, 15, Constants.IS_NOT_PASSWORD); //아이디 입력
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(53, 23, id, Constants.USER_ID_REGULAR_EXPRESSION, Constants.USER_ID_ERROR_MESSAGE); //정규표현식 이용하여 검사
        }

        isJudgingCorrectString = false;
        Console.SetCursorPosition(61, 24);
        while (!isJudgingCorrectString)
        {
            password = InputByReadKey.ReceiveInput(61, 24, 15, Constants.IS_PASSWORD);//비밀번호 입력
            isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(61, 24, password, Constants.USER_PASSWORD_REGULAR_EXPRESSION, Constants.USER_PASSWORD_ERROR_MESSAGE);
        }
    }

}

