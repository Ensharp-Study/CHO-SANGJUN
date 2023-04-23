using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.ExceptionHandling;
using _4차_LectureTimeTable.View;
using _4차_LectureTimeTable.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.Controller
{
    public class LectureTimeTableStart
    {
     
        MainUi mainUi = new MainUi();
        UserException userException = new UserException();
        DataStorage dataStorage = new DataStorage();
        
        public string id;
        public string password;
        public bool isInputValid;
        public bool isAccountExist;

        public void GetLogin()
        {
            LectureTimeTableMenu lectureTimeTableMenu = new LectureTimeTableMenu(dataStorage);
            while (true)
            {
                Console.SetWindowSize(100, 30);
                mainUi.PrintMainUi();
                mainUi.PrintLoginUi();//UI 출력

                //아이디 비밀번호 입력 받기
                InputUserIdAndPassword();

                //데이터 베이스와 비교하기
                isAccountExist = false;
                for (int i = 0; i < dataStorage.userData.Count; i++)
                {
                    if (string.Equals(id, dataStorage.userData[i].UserId)) //아이디 및 비밀번호 검사
                    {
                        isAccountExist = true;
                        if (string.Equals(password, dataStorage.userData[i].UserPassword))
                        {
                            Console.Clear();
                            lectureTimeTableMenu.ControllLectureTimeTableMenu(dataStorage.userData[i]); //메뉴로 이동
                            break;
                        }
                        
                        else
                        {
                            Console.SetCursorPosition(30, 22);
                            Console.WriteLine("비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                        }
                    }
                }

                if (isAccountExist == false)
                {
                    Console.SetCursorPosition(35, 22);
                    Console.WriteLine("아이디 또는 비밀 번호가 틀렸습니다.");
                }

                Console.ReadKey(true);
                Console.Clear();

                //시스템 종료기능 추가하기
            }
        }


        public void InputUserIdAndPassword() // 사용자로 부터 아이디 및 비밀번호 입력 받기 
        {
            isInputValid = false;
            while (!isInputValid)
            {
                id = ToReceiveInput.ReceiveInput(38, 18 ,8, Constants.IS_NOT_PASSWORD);
                isInputValid = userException.JudgeIdWithRegularExpression(38, 18, id);
            }

            isInputValid = false;
            while (!isInputValid)
            {
                //Console.CursorVisible = false;
                password = ToReceiveInput.ReceiveInput(38, 19 ,35, Constants.IS_PASSWORD);
                isInputValid = userException.JudgePasswordWithRegularExpression(38, 19, password);
            }
        }
    }
}
