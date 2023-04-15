using System;

public class SignUp
{
    Ui ui;
    DataStorage dataStorage;
    ExceptionHandling exceptionHandling;

    UserInf newUserInf = new UserInf();

    public SignUp(Ui ui, DataStorage dataStorage, ExceptionHandling exceptionHandling)
    {
        this.ui = ui;
        this.dataStorage = dataStorage;
        this.exceptionHandling = exceptionHandling;
    }
	public void SignUpAccount()
	{
        ui.ViewMainMenu();
        ui.ViewMenuSquare();
		ui.PrintSignUpMenu();
		ui.PrintSignUpInputMenu();
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
        Console.SetCursorPosition(60, 28);
        return;
    }
}
