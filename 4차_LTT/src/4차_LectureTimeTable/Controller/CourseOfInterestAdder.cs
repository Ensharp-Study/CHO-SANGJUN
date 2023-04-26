using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.ExceptionHandling;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.Utility;
using _4차_LectureTimeTable.View;
using System;
using System.Runtime.InteropServices;

namespace _4차_LectureTimeTable.Controller
{
    public class CourseOfInterestAdder :CourseFinder //관심과목 담기 클래스 (강의 검색 기능 클래스 상속 받기)
    {
        LectureOfInterestAdderUi lectureOfInterestAdderUi = new LectureOfInterestAdderUi();

        public CourseOfInterestAdder( MenuUi menuUi,DataStorage dataStorage, LectureException lectureException, MenuSelectController menuSelectController) : base(dataStorage,lectureException, menuUi,menuSelectController)
        { 
        }

        public int selectedMenu;
        public string[] menuList = { "○ 관심과목 검색", "○ 관심과목 내역", "○ 관심과목 삭제" };
        public void ControllAddInterestLectureMenu(UserDTO userInformation) //관심과목 메뉴 선택 함수
        {
            Console.Clear();
            menuUi.PrintMenuUi(userInformation.UserName);
            selectedMenu = menuSelectController.SelectMenuWithUpAndDown(menuList, 3, 42, 12); //관심과목 메뉴 상하키로 선택하는 함수

            switch (selectedMenu)
            {
                case (int)InterestLectureMenuList.ADDER:
                    AddLecture(userInformation); //관심과목 추가하는 함수 호출
                    break;
                case (int)InterestLectureMenuList.CHECKER: 
                    CheckInterestLecture(userInformation); //관심과목 담긴 목록 확인하는 함수 호출
                    break;

                case (int)InterestLectureMenuList.DELETER:

                    break;

            }
        }

        public string courseRegistrationNumber; //담는 과목 번호
        bool isInputValid = false;
        bool isAddPosibility = true;
      
        public void AddLecture(UserDTO userInformation) //관심과목 호출하는 함수
        {
            FindCourse();
            userInformation.AvailableCreditsForRegistrationOfInterestLecture = 24;
            userInformation.EarnedCreditsOfInterestLecture = 0;
            while (true)
            {
                menuUi.PrintStatusOfInterestedLecture(userInformation.AvailableCreditsForRegistrationOfInterestLecture, userInformation.EarnedCreditsOfInterestLecture);
                isInputValid = false;
                isAddPosibility = true;
                while (!isInputValid) //담을 과목 번호 입력 받기
                {
                    courseRegistrationNumber = ToReceiveInput.ReceiveInput(55, Console.CursorTop-1, 3, Constants.IS_NOT_PASSWORD);
                    isInputValid = lectureException.JudgeCourseNumberRegularExpression(55, Console.CursorTop-1, courseRegistrationNumber);
                }
                
                for (int j = 0; j < userInformation.UserInterestLecture.Count; j++) 
                {
                    if (userInformation.UserInterestLecture[j].LectureId == courseRegistrationNumber) //예외처리 1.이미 관심과목에 담았을때
                    {
                        menuUi.PrintAlreadyContainErrorMesseage(); //오류메세지 출력
                        isAddPosibility = false;
                    }
                }
                //예외처리 2. 학점수가 초과되거나 해당리스트에 없을때
                if ((userInformation.AvailableCreditsForRegistrationOfInterestLecture - Convert.ToInt32((dataStorage.lectureTotalData.GetValue(int.Parse(courseRegistrationNumber),8) )) )<0) 
                {
                    menuUi.PrintExcessCreditsErrorMesseage(); //오류메세지 출력
                    isAddPosibility = false;

                }

                if (isAddPosibility)//강의가 미리 담겨지지 않았을 경우에만 실행
                {
                    for (int i = 1; i <= dataStorage.lectureTotalData.GetLength(0); i++) //엑셀 모든 열 탐색
                    {
                        if (dataStorage.lectureTotalData.GetValue(i, 1).ToString() == courseRegistrationNumber) // 엑셀 번호값이랑 입력번호값이랑 비교
                        {
                            LectureDTO lectureDTO = new LectureDTO();
                            lectureDTO.LectureId = dataStorage.lectureTotalData.GetValue(i, 1).ToString();
                            lectureDTO.Major = dataStorage.lectureTotalData.GetValue(i, 2).ToString();
                            lectureDTO.CourseNumber = dataStorage.lectureTotalData.GetValue(i, 3).ToString();
                            lectureDTO.CourseClass = dataStorage.lectureTotalData.GetValue(i, 4).ToString();
                            lectureDTO.LectureName = dataStorage.lectureTotalData.GetValue(i, 5).ToString();
                            lectureDTO.CourseClassification = dataStorage.lectureTotalData.GetValue(i, 6).ToString();
                            lectureDTO.Grade = dataStorage.lectureTotalData.GetValue(i, 7).ToString();
                            lectureDTO.Credit = dataStorage.lectureTotalData.GetValue(i, 8).ToString();
                            lectureDTO.LectureTime = dataStorage.lectureTotalData.GetValue(i, 9).ToString();
                            lectureDTO.LectureClassroom = dataStorage.lectureTotalData.GetValue(i, 10).ToString();
                            lectureDTO.Professor = dataStorage.lectureTotalData.GetValue(i, 11).ToString();
                            //해당 번호 강의 정보 DTO에 저장하기

                            userInformation.AvailableCreditsForRegistrationOfInterestLecture -= int.Parse(lectureDTO.Credit); //신청가능 학점 수 줄이기
                            userInformation.EarnedCreditsOfInterestLecture += int.Parse(lectureDTO.Credit); //신청학점 수 추가하기

                            userInformation.UserInterestLecture.Add(lectureDTO);//해당 DTO 인스턴스 데이터 저장소에 저장
                        }
                    }
                }

            }

        }

        public void CheckInterestLecture(UserDTO userInformation)
        {

        }




    }
}
