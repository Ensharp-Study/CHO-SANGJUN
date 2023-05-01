using System;

public class EditingUserInformation
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    UserModeUi userModeUi;

    DataStorage dataStorage;
    UserDTO userInformation;
    ProgramProcess programProcess;

    public EditingUserInformation(DataStorage dataStorage, UserDTO userInformation, ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.userModeUi = UserModeUi.GetInstance();

        this.dataStorage = dataStorage;
        this.userInformation = userInformation;
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
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(54, 22, newId, Constants.USER_ID_REGULAR_EXPRESSION, Constants.USER_ID_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);
            
            Console.SetCursorPosition(54, 23);
            do//비밀번호 입력
            {
                newPassword = InputByReadKey.ReceiveInput(54, 23, 15, Constants.IS_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(54, 23, newPassword, Constants.USER_PASSWORD_REGULAR_EXPRESSION, Constants.USER_PASSWORD_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(57, 24);
            do//이름 입력
            {
                newName = InputByReadKey.ReceiveInput(57, 24, 10, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(57, 24, newName, Constants.USER_NAME_REGULAR_EXPRESSION, Constants.USER_NAME_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);
            
            Console.SetCursorPosition(54, 25);
            do//나이 입력
            {
                newAge = InputByReadKey.ReceiveInput(54, 25, 3, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(54, 25, newAge, Constants.USER_AGE_REGULAR_EXPRESSION, Constants.USER_AGE_ERROR_MESSAGE);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(57, 26);
            do//휴대폰 번호 입력
            {
                newPhoneNumber = InputByReadKey.ReceiveInput(57, 26, 13, Constants.IS_NOT_PASSWORD);
                isJudgingCorrectString = regularExpression.JudgeWithRegularExpression(57, 26, newPhoneNumber, Constants.USER_NUMBER_REGULAR_EXPRESSION, Constants.USER_NUMBER_ERROR_MESSAGE);
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
