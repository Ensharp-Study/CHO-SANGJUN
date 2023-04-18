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
	public void SignUpAccount()
	{
        mainMenuUi.ViewMainMenu();
        mainMenuUi.ViewMenuSquare();
        signUpAndLoginUi.PrintSignUpMenu();
        signUpAndLoginUi.PrintSignUpInputMenu();
        string passwordConfirmation;

        Console.SetCursorPosition(60, 28);
		//newUserInformation.Id = userInformationException.JudgeIdWithRegularExpression(60, 28);
        Console.SetCursorPosition(60, 29);
        //newUserInformation.Password = userInformationException.JudgePasswordWithRegularExpression(60, 29);
        while (true)
        {
            Console.SetCursorPosition(60, 30);
            //passwordConfirmation = userInformationException.JudgePasswordWithRegularExpression(60, 30);
            /*if (passwordConfirmation != newUserInformation.Password)
            {
                signUpAndLoginUi.PrintpasswordConfirmation(60,30);
                Console.ReadKey(true);
                continue;
            }
            else
            {
                break;
            }*/

        }
        Console.SetCursorPosition(64, 31);
        newUserInformation.UserName = userInformationException.JudgeUserNameWithRegularExpression(64, 31);
        Console.SetCursorPosition(59, 32);
        newUserInformation.UserAge = int.Parse(userInformationException.JudgeUserAgeWithRegularExpression(59, 32));
        Console.SetCursorPosition(62, 33);
        newUserInformation.UserPhoneNumber = userInformationException.JudgeUserNumberWithRegularExpression(62, 33);
        Console.SetCursorPosition(69, 34);
        newUserInformation.UserAddress = Console.ReadLine(); //정규식 예외처리 하기
        
        dataStorage.userList.Add(newUserInformation);
        
        Console.Clear();
        signUpAndLoginUi.PrintAccountDeletionSentence(newUserInformation.UserName);
        
        Console.ReadKey();
        Console.SetCursorPosition(60, 28);
        
        return;
    }
}
