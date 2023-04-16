using System;

public class EditingUserInf
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInformation userInformation;
    UserInformationException userInformationException;

    public EditingUserInf(DataStorage dataStorage, UserModeUi userModeUi, UserInformation userInformation, UserInformationException userInformationException)
    {
        this.userModeUi = userModeUi;
        this.userInformation = userInformation;
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;

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

            userModeUi.PrintBeforeUserInf(userInformation);
            userModeUi.PrintAfterUserInf(userInformation);
            Console.SetCursorPosition(54, 22);
            newId = userInformationException.JudgeIdAndPasswordWithRegularExpression(54, 22);
            Console.SetCursorPosition(54, 23);
            newPassword = userInformationException.JudgeIdAndPasswordWithRegularExpression(54, 23);
            Console.SetCursorPosition(57, 24);
            newName = userInformationException.JudgeUserNameWithRegularExpression(57, 24);
            Console.SetCursorPosition(54, 25);
            newAge = userInformationException.JudgeUserAgeWithRegularExpression(54, 25);
            Console.SetCursorPosition(57, 26);
            newPhoneNumber = userInformationException.JudgeUserNumberWithRegularExpression(57, 26); ;
            Console.SetCursorPosition(60, 27);
            newAddress = Console.ReadLine();

            userInformation.id = newId;
            userInformation.password = newPassword;
            userInformation.userName = newName;
            userInformation.userAddress = newAddress;
            userInformation.userAge = int.Parse(newAge);
            userInformation.userPhoneNumber = newPhoneNumber;

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
