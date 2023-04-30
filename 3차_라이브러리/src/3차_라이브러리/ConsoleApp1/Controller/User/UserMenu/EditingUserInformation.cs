using System;

public class EditingUserInformation
{
    UserModeUi userModeUi;
    DataStorage dataStorage;
    UserInformation userInformation;
    UserInformationException userInformationException;
    BookInformationException bookInformationException;
    ProgramProcess programProcess;

    public EditingUserInformation(DataStorage dataStorage, UserInformation userInformation, UserInformationException userInformationException, BookInformationException bookInformationException, ProgramProcess programProcess)
    {
        this.userModeUi = UserModeUi.GetInstance();
        this.userInformation = userInformation;
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
        this.bookInformationException = bookInformationException;
        this.programProcess = programProcess;
    }

    bool isJudgingCorrectString;
    public void EditUserInformation()
	{
        string newId;
        string newPassword;
        String newName;
        string newAge;
        string newPhoneNumber;
        String newAddress;

        while (true)
        {
            userModeUi.PrintBeforeUserInformation(userInformation);
            userModeUi.PrintAfterUserInformation(userInformation); //유저 정보 수정하는 인터페이스 출력

            Console.SetCursorPosition(54, 22);
            do//아이디 입력
            {
                newId = InputByReadKey.ReceiveInput(54, 22, 15, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = userInformationException.JudgeIdWithRegularExpression(54, 22, newId);
            } while (!isJudgingCorrectString);
            
            Console.SetCursorPosition(54, 23);
            do//비밀번호 입력
            {
                newPassword = InputByReadKey.ReceiveInput(54, 23, 15, Constants.IS_PASSWORD);
                isJudgingCorrectString = userInformationException.JudgePasswordWithRegularExpression(54, 23, newPassword);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(57, 24);
            do//이름 입력
            {
                newName = InputByReadKey.ReceiveInput(57, 24, 10, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = userInformationException.JudgeUserNameWithRegularExpression(57, 24, newName);
            } while (!isJudgingCorrectString);
            
            Console.SetCursorPosition(54, 25);
            do//나이 입력
            {
                newAge = InputByReadKey.ReceiveInput(54, 25, 3, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = userInformationException.JudgeUserAgeWithRegularExpression(54, 25, newAge);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(57, 26);
            do//휴대폰 번호 입력
            {
                newPhoneNumber = InputByReadKey.ReceiveInput(57, 26, 13, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = userInformationException.JudgeUserNumberWithRegularExpression(57, 26, newPhoneNumber);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(60, 27);
            do//주소 입력
            {
                newAddress = InputByReadKey.ReceiveInput(60, 27, 30, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = true;  //아직 주소 정규표현식 미 구현
            } while (!isJudgingCorrectString);
          
            //데이터에 입력 받은 값 저장
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
