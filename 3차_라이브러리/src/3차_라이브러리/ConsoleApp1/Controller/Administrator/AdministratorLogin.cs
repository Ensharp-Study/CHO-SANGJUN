using System;
public class AdministratorLogin
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;

    DataStorage dataStorage;
    ProgramProcess programProcess;
    AdministratorMenu administratorMenu;
    public AdministratorLogin(DataStorage dataStorage, ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.signUpAndLoginUi = SignUpAndLoginUi.GetInstance();
        
        this.dataStorage = dataStorage;
        this.programProcess = programProcess;
        this.administratorMenu = new AdministratorMenu(dataStorage, programProcess);
    }

    bool isJudgingCorrectString;
    public void GetAdministratorLogin()
    {
        string id;
        string password;

        while (true)
        {
            signUpAndLoginUi.PrintAdministratorLoginMenu();

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
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(61, 24, password, Constants.USER_PASSWORD_REGULAR_EXPRESSION, Constants.USER_PASSWORD_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);


            if (string.Equals(id, dataStorage.administratorInformation.Id)) //아이디 및 비밀번호 검사
            {
                if (string.Equals(password, dataStorage.administratorInformation.Password))
                {
                    Console.Clear();
                    administratorMenu.ControllAdministratorMenu(); //매니저 모드 메뉴로 진입
                }
                else
                {
                    Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                }
            }

            else
            {
                Console.WriteLine("\n\n                             아이디 또는 비밀번호 입력이 틀렸습니다. 다시 입력하세요");
            }

            //프로그램 탈출
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }

        }
    }

}

