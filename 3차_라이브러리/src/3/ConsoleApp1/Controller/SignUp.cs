﻿using System;

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
		newUserInformation.id = userInformationException.JudgeIdAndPasswordWithRegularExpression(60, 28);
        Console.SetCursorPosition(60, 29);
        newUserInformation.password = userInformationException.JudgeIdAndPasswordWithRegularExpression(60, 29);
        while (true)
        {
            Console.SetCursorPosition(60, 30);
            passwordConfirmation = userInformationException.JudgeIdAndPasswordWithRegularExpression(60, 30);
            if (passwordConfirmation != newUserInformation.password)
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
        newUserInformation.userName = userInformationException.JudgeUserNameWithRegularExpression(64, 31);
        Console.SetCursorPosition(59, 32);
        newUserInformation.userAge = int.Parse(userInformationException.JudgeUserAgeWithRegularExpression(59, 32));
        Console.SetCursorPosition(62, 33);
        newUserInformation.userPhoneNumber = userInformationException.JudgeUserNumberWithRegularExpression(62, 33);
        Console.SetCursorPosition(69, 34);
        newUserInformation.userAddress = Console.ReadLine(); //정규식 예외처리 하기
        
        dataStorage.userList.Add(newUserInformation);
        
        Console.Clear();
        signUpAndLoginUi.PrintAccountDeletionSentence(newUserInformation.userName);
        
        Console.ReadKey();
        Console.SetCursorPosition(60, 28);
        
        return;
    }
}
