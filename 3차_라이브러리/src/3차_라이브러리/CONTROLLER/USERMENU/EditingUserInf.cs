using System;

public class EditingUserInf
{
	public void EditUserInf(Data data, Ui ui,UserInf user)
	{
		string newId;
		string newPassword;
		String newName;
		string newAge;
		string newPhoneNumber;
		String newAddress;
        ConsoleKeyInfo inputKey;

        ui.PrintBeforeUserInf(user);
		ui.PrintAfterUserInf(user);
		Console.SetCursorPosition(54, 22);
		newId = Console.ReadLine();
        Console.SetCursorPosition(54, 23);
        newPassword = Console.ReadLine();
        Console.SetCursorPosition(57, 24);
        newName = Console.ReadLine();
        Console.SetCursorPosition(54, 25);
        newAge = Console.ReadLine();
        Console.SetCursorPosition(57, 26);
        newPhoneNumber = Console.ReadLine();
        Console.SetCursorPosition(60, 27);
        newAddress = Console.ReadLine();

		user.id =newId;
		user.password =newPassword;
		user.userName = newName;
		user.userAddress =newAddress;
		user.userAge = int.Parse(newAge);
		user.userPhoneNumber = newPhoneNumber;

        inputKey = Console.ReadKey();
        if (inputKey.Key == ConsoleKey.Escape)
        {
            return;
        }
        else
        {

        }
    }
	
}
