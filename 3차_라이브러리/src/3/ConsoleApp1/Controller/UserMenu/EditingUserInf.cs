using System;

public class EditingUserInf
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInformation userInformation;
    UserInformationException userInformationException;
    ProgramProcess programProcess;

    public EditingUserInf(DataStorage dataStorage, UserModeUi userModeUi, UserInformation userInformation, UserInformationException userInformationException, ProgramProcess programProcess)
    {
        this.userModeUi = userModeUi;
        this.userInformation = userInformation;
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
        this.programProcess = programProcess;
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

            userModeUi.PrintBeforeUserInf(userInformation);
            userModeUi.PrintAfterUserInf(userInformation);
            Console.SetCursorPosition(54, 22);
            newId = userInformationException.JudgeIdWithRegularExpression(54, 22);
            Console.SetCursorPosition(54, 23);
            newPassword = userInformationException.JudgePasswordWithRegularExpression(54, 23);
            Console.SetCursorPosition(57, 24);
            newName = userInformationException.JudgeUserNameWithRegularExpression(57, 24);
            Console.SetCursorPosition(54, 25);
            newAge = userInformationException.JudgeUserAgeWithRegularExpression(54, 25);
            Console.SetCursorPosition(57, 26);
            newPhoneNumber = userInformationException.JudgeUserNumberWithRegularExpression(57, 26); ;
            Console.SetCursorPosition(60, 27);
            newAddress = Console.ReadLine();

            userInformation.Id = newId;
            userInformation.Password = newPassword;
            userInformation.UserName = newName;
            userInformation.UserAddress = newAddress;
            userInformation.UserAge = int.Parse(newAge);
            userInformation.UserPhoneNumber = newPhoneNumber;

            //프로그램 뒤로 나가기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
	
}
