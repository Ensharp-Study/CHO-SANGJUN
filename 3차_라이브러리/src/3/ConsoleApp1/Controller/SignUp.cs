using System;

public class SignUp
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformation exceptionHandling;

    UserInf newUserInf = new UserInf();

    public SignUp(MainMenuUi mainMenuUi, SignUpAndLoginUi signUpAndLoginUi, DataStorage dataStorage, UserInformation exceptionHandling)
    {
        this.mainMenuUi = mainMenuUi;
        this.signUpAndLoginUi = signUpAndLoginUi;
        this.dataStorage = dataStorage;
        this.exceptionHandling = exceptionHandling;
    }
	public void SignUpAccount()
	{
        mainMenuUi.ViewMainMenu();
        mainMenuUi.ViewMenuSquare();
        signUpAndLoginUi.PrintSignUpMenu();
        signUpAndLoginUi.PrintSignUpInputMenu();
        string passwordConfirmation;

        Console.SetCursorPosition(60, 28);
		newUserInf.id = exceptionHandling.JudgeIdAndPasswordWithRegularExpression(60, 28);
        Console.SetCursorPosition(60, 29);
        newUserInf.password = exceptionHandling.JudgeIdAndPasswordWithRegularExpression(60, 29);
        while (true)
        {
            Console.SetCursorPosition(60, 30);
            passwordConfirmation = exceptionHandling.JudgeIdAndPasswordWithRegularExpression(60, 30);
            if (passwordConfirmation != newUserInf.password)
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
        newUserInf.userName = exceptionHandling.JudgeUserNameWithRegularExpression(64, 31);
        Console.SetCursorPosition(59, 32);
        newUserInf.userAge = int.Parse(exceptionHandling.JudgeUserAgeWithRegularExpression(59, 32));
        Console.SetCursorPosition(62, 33);
        newUserInf.userPhoneNumber = exceptionHandling.JudgeUserNumberWithRegularExpression(62, 33);
        Console.SetCursorPosition(69, 34);
        newUserInf.userAddress = Console.ReadLine();
        
        dataStorage.userList.Add(newUserInf);
        
        Console.Clear();
        signUpAndLoginUi.PrintAccountDeletionSentence(newUserInf.userName);
        
        Console.ReadKey();
        Console.SetCursorPosition(60, 28);
        
        return;
    }
}
