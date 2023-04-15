using System;

public class EditingUserInf
{
    DataStorage dataStorage;
    Ui ui;
    UserInf user;
    ExceptionHandling exceptionHandling;

    public EditingUserInf(DataStorage dataStorage, Ui ui, UserInf user, ExceptionHandling exceptionHandling)
    {
        this.ui = ui;
        this.user = user;
        this.dataStorage = dataStorage;
        this.exceptionHandling = exceptionHandling;

    }
    public void EditUserInf()
	{
        while (true)
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
            newId = exceptionHandling.JudgeIdAndPasswordWithRegularExpression(54, 22);
            Console.SetCursorPosition(54, 23);
            newPassword = exceptionHandling.JudgeIdAndPasswordWithRegularExpression(54, 23);
            Console.SetCursorPosition(57, 24);
            newName = exceptionHandling.JudgeUserNameWithRegularExpression(57, 24);
            Console.SetCursorPosition(54, 25);
            newAge = exceptionHandling.JudgeUserAgeWithRegularExpression(54, 25);
            Console.SetCursorPosition(57, 26);
            newPhoneNumber = exceptionHandling.JudgeUserNumberWithRegularExpression(57, 26); ;
            Console.SetCursorPosition(60, 27);
            newAddress = Console.ReadLine();

            user.id = newId;
            user.password = newPassword;
            user.userName = newName;
            user.userAddress = newAddress;
            user.userAge = int.Parse(newAge);
            user.userPhoneNumber = newPhoneNumber;

            inputKey = Console.ReadKey();

            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
            }
            else if (inputKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                break;
            }
        }
    }
	
}
