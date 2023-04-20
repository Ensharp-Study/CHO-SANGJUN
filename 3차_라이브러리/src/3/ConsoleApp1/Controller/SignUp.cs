using System;

public class SignUp
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformationException userInformationException;

    UserInformation newUserInformation = new UserInformation();

    public SignUp(MainMenuUi mainMenuUi, SignUpAndLoginUi signUpAndLoginUi, DataStorage dataStorage, UserInformationException userInformationException) 
    {
        this.mainMenuUi = mainMenuUi;
        this.signUpAndLoginUi = signUpAndLoginUi;
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
    }

    bool isJudgingCorrectString;

    public void SignUpAccount() //회원가입
	{
        mainMenuUi.ViewMainMenu();
        mainMenuUi.ViewMenuSquare();
        signUpAndLoginUi.PrintSignUpMenu();
        signUpAndLoginUi.PrintSignUpInputMenu();
        string passwordConfirmation;

        Console.SetCursorPosition(60, 28);
        do //아이디 입력
        {
            newUserInformation.Id = ToReceiveInput.ReceiveInput(60, 28); //입력값 키값으로 검사
            isJudgingCorrectString = userInformationException.JudgeIdWithRegularExpression(60, 28, newUserInformation.Id); //정규표현식 이용하여 검사
        } while (!isJudgingCorrectString); //정규표현식 확인후 거짓일 때만 재실행 
       
        Console.SetCursorPosition(60, 29);
        do //비밀번호 입력
        {
            newUserInformation.Password = ToReceiveInput.ReceiveInputForMasking(60, 29);
            isJudgingCorrectString = userInformationException.JudgePasswordWithRegularExpression(60, 29, newUserInformation.Password);
        } while (!isJudgingCorrectString);
        

        while (true)
        {
            Console.SetCursorPosition(60, 30);
            do //비밀번호 확인 입력
            {
                passwordConfirmation = ToReceiveInput.ReceiveInputForMasking(60, 30);
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
            newUserInformation.UserName = ToReceiveInput.ReceiveInput(64, 31); 
            isJudgingCorrectString = userInformationException.JudgeUserNameWithRegularExpression(64, 31, newUserInformation.UserName);
        } while (!isJudgingCorrectString); 
        
        Console.SetCursorPosition(59, 32);
        do//나이 입력
        {
            newUserInformation.UserAge = int.Parse(ToReceiveInput.ReceiveInput(59, 32));
            isJudgingCorrectString = userInformationException.JudgeUserAgeWithRegularExpression(59, 32, (newUserInformation.UserAge).ToString());
        } while (!isJudgingCorrectString);
       
        Console.SetCursorPosition(62, 33);
        do//핸드폰 번호 입력
        {
            newUserInformation.UserPhoneNumber = ToReceiveInput.ReceiveInput(62, 33);
            isJudgingCorrectString = userInformationException.JudgeUserNumberWithRegularExpression(62, 33, newUserInformation.UserPhoneNumber);
        } while (!isJudgingCorrectString);
         

        Console.SetCursorPosition(69, 34);
        do//주소 입력
        {
            newUserInformation.UserAddress = ToReceiveInput.ReceiveInput(69, 34);
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
