using System;

public class SignUp
{
    Ui ui;
    DataStorage dataStorage;
    ExceptionHandling exceptionHandling;

    UserInf newUserInf = new UserInf();
	string reInputPassword; 

    public SignUp(Ui ui, DataStorage dataStorage, ExceptionHandling exceptionHandling)
    {
        this.ui = ui;
        this.dataStorage = dataStorage;
        this.exceptionHandling = exceptionHandling;
    }
	public void SignUpAccount()
	{
		ui.PrintSignUpMenu();
		ui.PrintSignUpInputMenu();

        Console.SetCursorPosition(60, 28);
		newUserInf.id = exceptionHandling.JudgeIdAndPasswordWithRegularExpression(53, 23);
        Console.SetCursorPosition(60, 29);
        newUserInf.password = Console.ReadLine();
        Console.SetCursorPosition(60, 30);
        reInputPassword = Console.ReadLine();
		if(reInputPassword != newUserInf.password)
		{
			//예외처리
		}
        Console.SetCursorPosition(64, 31);
        newUserInf.userName = Console.ReadLine();
        Console.SetCursorPosition(59, 32);
        newUserInf.userAge = int.Parse(Console.ReadLine()); //예외처리
        Console.SetCursorPosition(62, 33);
        newUserInf.userPhoneNumber = Console.ReadLine();
        Console.SetCursorPosition(69, 34);
        newUserInf.userAddress = Console.ReadLine();
        
        dataStorage.userList.Add(newUserInf);
        Console.SetCursorPosition(60, 28);
        return;
    }
}
