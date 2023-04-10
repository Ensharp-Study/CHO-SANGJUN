using System;

public class SignUp
{
	Ui ui;
	MagicNumber magicNumber;
    UserInf newUserInf = new UserInf();
	string reInputPassword; 

    public SignUp()
	{

	}
	public void SignUpAccount(Ui ui, MagicNumber magicNumber, Data data)
	{
		ui.PrintSignUpMenu();
		ui.PrintSignUpInputMenu();

        Console.SetCursorPosition(60, 28);
		newUserInf.id = Console.ReadLine();
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
        
        data.userList.Add(newUserInf);
        Console.Clear();
        return;
    }
}
