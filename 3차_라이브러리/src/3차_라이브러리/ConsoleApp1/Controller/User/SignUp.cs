using System;

public class SignUp
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformationException userInformationException;
    UserInformation newUserInformation;

    public SignUp(DataStorage dataStorage, UserInformationException userInformationException) 
    {
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.signUpAndLoginUi = SignUpAndLoginUi.GetInstance();
        this.newUserInformation = new UserInformation();

        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
        
    }

    public void SignUpAccount() //회원가입
	{
        bool isJudgingCorrectString;

        mainMenuUi.ViewMainMenu();
        mainMenuUi.ViewMenuSquare();
        signUpAndLoginUi.PrintSignUpMenu();
        signUpAndLoginUi.PrintSignUpInputMenu();

        string passwordConfirmation;

        Console.SetCursorPosition(60, 28);
        do //아이디 입력
        {
            newUserInformation.Id = InputByReadKey.ReceiveInput(60, 28, 15, Constants.IS_NOT_PASSWORD); //입력값 키값으로 검사
            isJudgingCorrectString = userInformationException.JudgeIdWithRegularExpression(60, 28, newUserInformation.Id); //정규표현식 이용하여 검사
        } while (!isJudgingCorrectString); //정규표현식 확인후 거짓일 때만 재실행 
       
        Console.SetCursorPosition(60, 29);
        do //비밀번호 입력
        {
            newUserInformation.Password = InputByReadKey.ReceiveInput(60, 29, 15, Constants.IS_PASSWORD);
            isJudgingCorrectString = userInformationException.JudgePasswordWithRegularExpression(60, 29, newUserInformation.Password);
        } while (!isJudgingCorrectString);
        

        while (true)
        {
            Console.SetCursorPosition(60, 30);
            do //비밀번호 확인 입력
            {
                passwordConfirmation = InputByReadKey.ReceiveInput(60, 30, 15, Constants.IS_PASSWORD);
                isJudgingCorrectString = userInformationException.JudgePasswordWithRegularExpression(60, 30, passwordConfirmation);
            } while (!isJudgingCorrectString);
            
            if (passwordConfirmation != newUserInformation.Password) //비밀번호가 서로 다른 경우
            {
                signUpAndLoginUi.PrintpasswordConfirmation(60,30);
                Console.ReadKey(true);
                continue;
            }
            else
            {
                break;
            }

        }

        Console.SetCursorPosition(64, 31);
        do//이름 입력
        {
            newUserInformation.UserName = InputByReadKey.ReceiveInput(64, 31, 15, Constants.IS_NOT_PASSWORD); 
            isJudgingCorrectString = userInformationException.JudgeUserNameWithRegularExpression(64, 31, newUserInformation.UserName);
        } while (!isJudgingCorrectString); 
        
        Console.SetCursorPosition(59, 32);
        do//나이 입력
        {
            newUserInformation.UserAge = int.Parse(InputByReadKey.ReceiveInput(59, 32, 3, Constants.IS_NOT_PASSWORD));
            isJudgingCorrectString = userInformationException.JudgeUserAgeWithRegularExpression(59, 32, (newUserInformation.UserAge).ToString());
        } while (!isJudgingCorrectString);
       
        Console.SetCursorPosition(62, 33);
        do//핸드폰 번호 입력
        {
            newUserInformation.UserPhoneNumber = InputByReadKey.ReceiveInput(62, 33, 13, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = userInformationException.JudgeUserNumberWithRegularExpression(62, 33, newUserInformation.UserPhoneNumber);
        } while (!isJudgingCorrectString);
         

        Console.SetCursorPosition(69, 34);
        do//주소 입력
        {
            newUserInformation.UserAddress = InputByReadKey.ReceiveInput(69, 34, 30, Constants.IS_NOT_PASSWORD);
            isJudgingCorrectString = true; //아직 주소 정규식 처리 미완료
        } while (!isJudgingCorrectString);
        
        dataStorage.userList.Add(newUserInformation); //유저 데이터 추가
        
        Console.Clear();
        signUpAndLoginUi.PrintAccountDeletionSentence(newUserInformation.UserName);
        
        Console.ReadKey();
        Console.SetCursorPosition(60, 28);
        
        return;
    }
}
