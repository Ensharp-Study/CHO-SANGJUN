using System;
public class AdministratorLogin
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformationException userInformationException;
    BookInformationException bookInformationException;
    ProgramProcess programProcess;
    AdministratorMenu administratorMenu;
    public AdministratorLogin(DataStorage dataStorage, UserInformationException userInformationException, BookInformationException bookInformationException, ProgramProcess programProcess)
    {
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.signUpAndLoginUi = SignUpAndLoginUi.GetInstance();
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
        this.bookInformationException = bookInformationException;
        this.programProcess = programProcess;
        this.administratorMenu = new AdministratorMenu(dataStorage, programProcess, bookInformationException);
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
                id = InputByReadKey.ReceiveInput(53, 23); //입력값 키값으로 검사
                isJudgingCorrectString = userInformationException.JudgeIdWithRegularExpression(53, 23, id); //정규표현식 이용하여 검사
            } while (!isJudgingCorrectString); //정규표현식 확인후 거짓일 때만 재실행 
            
            Console.SetCursorPosition(61, 24);
            do //비밀번호 입력
            {
                password = InputByReadKey.ReceiveInputForMasking(61, 24);
                isJudgingCorrectString = userInformationException.JudgePasswordWithRegularExpression(61, 24, password);
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

