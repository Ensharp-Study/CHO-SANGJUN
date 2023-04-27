using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.ExceptionHandling;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.Utility;
using _4차_LectureTimeTable.View;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.Controller
{
    public class CourseRegistration : CourseFinder
    {
        //인스턴스 상속받기
        public CourseRegistration(MenuUi menuUi, DataStorage dataStorage, LectureException lectureException, MenuSelectController menuSelectController) : base(dataStorage, lectureException, menuUi, menuSelectController)
        {
        }

        public string[] lectureRegistrationPrintList = { "수강신청", "수강신청 내역", "수강신청 시간표", "수강과목 삭제" };
        public int selectedMenu;
        bool isDoGoBackToBeforeMenu = false;
        
        public void ControllCourseRegistrationMenu(UserDTO userInformation)
        {
            Console.Clear();
            isDoGoBackToBeforeMenu = false;
            menuUi.PrintMenuUi(userInformation.UserName);
            selectedMenu = menuSelectController.SelectMenuWithUpAndDown(lectureRegistrationPrintList, 4, 42, 12);

            switch (selectedMenu)
            {
                case (int)LectureRegistrationMenuList.LECTURE_REGISTRATION:
                    Console.SetWindowSize(192, 30);
                    break;
                case (int)LectureRegistrationMenuList.CHECK_LECTURE_REGISTRATION:
                    break;
                case (int)LectureRegistrationMenuList.TIMETABLE_OF_LECTURE_REGISTRATION:  
                    break;
                case (int)LectureRegistrationMenuList.DELETE_REGISTRATED_LECTURE:
                    break;
            }

        }

        public void RegistrateLectureWithInterestList(UserDTO userInformation)
        {
            Console.Clear();
            menuUi.PrintStatusOfInterestedLecture(userInformation.AvailableCreditsForRegistrationOfInterestLecture, userInformation.EarnedCreditsOfInterestLecture);
            CheckInterestLecture(userInformation); //관심과목 담긴 목록 확인하는 함수 호출

        }

        public void CheckInterestLecture(UserDTO userInformation)
        {
            for (int i = 0; i < userInformation.UserInterestLecture.Count; i++)
            {
                string[] maximumLengthOfStringsInEachRow = { "184", "기계항공우주공학부", "004714", "001", "Capstone디자인(산학협력프로젝트)", "공통교양필수", "1", "1", "수 16:30~18:30, 금 09:00~11:00", "센B201,센B209", "Abolghasem Sadeghi-Niaraki", "영어/한국어" };

                //문자열과 출력해야 하는 공백 칸수 함수에 인자로 전달 
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].LectureId, userInformation.UserInterestLecture[i].LectureId.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[0]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].LectureId));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].Major, userInformation.UserInterestLecture[i].Major.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[1]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].Major));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].CourseNumber, userInformation.UserInterestLecture[i].CourseNumber.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[2]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].CourseNumber));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].CourseClass, userInformation.UserInterestLecture[i].CourseClass.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[3]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].CourseClass));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].LectureName, userInformation.UserInterestLecture[i].LectureName.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[4]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].LectureName));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].CourseClassification, userInformation.UserInterestLecture[i].CourseClassification.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[5]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].CourseClassification));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].Grade, userInformation.UserInterestLecture[i].Grade.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[6]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].Grade));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].Credit, userInformation.UserInterestLecture[i].Credit.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[7]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].Credit));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].LectureTime, userInformation.UserInterestLecture[i].LectureTime.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[8]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].LectureTime));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].LectureClassroom, userInformation.UserInterestLecture[i].LectureClassroom.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[9]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].LectureClassroom));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].Professor, userInformation.UserInterestLecture[i].Professor.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[10]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].Professor));
                menuUi.PrintExistLectureInformation(userInformation.UserInterestLecture[i].Language, userInformation.UserInterestLecture[i].Language.Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[11]) - Encoding.Default.GetByteCount(userInformation.UserInterestLecture[i].Language));
                Console.WriteLine("");//줄 띄우기
            }
            Console.ReadKey(true);
        }

        public void  ChangeTimeTypeToDateTimeStruct(string time)//시간대 저장형태 구분하고 DateTime 형태로 변환 하는 함수
        {
            string dayOfTheWeek;
            DateTime startTime;
            DateTime endTime;

            if (lectureException.JudgeTimeTypeRegularExpression(time, @"^[가-힣]{2}$")) //한글이 2번 있을 때 > 일주일에 수업이 2번 있는 경우
            {
                if (lectureException.JudgeTimeTypeRegularExpression(time, @"^[^,] *,[^,] *$")) //일주일에 수업 두번 있고 서로 시간대가 다른 경우 (쉼표로 구분되어 있다)
                {
                    dayOfTheWeek = time.Substring(0, 1);
                    startTime = DateTime.ParseExact(time.Substring(2,5), "HH:mm", CultureInfo.InvariantCulture);
                    endTime = DateTime.ParseExact(time.Substring(8, 5), "HH:mm", CultureInfo.InvariantCulture);

                }
                else //일주일에 수업이 두번 있고 서로 시간대가 같은 경우 (쉼표가 없다)
                {

                } 
            }

            else if(lectureException.JudgeTimeTypeRegularExpression(time, @"^[가-힣]{1}$"))//일주일에 수업이 한번 있는 경우
            {

            }

            else if (lectureException.JudgeTimeTypeRegularExpression(time, @"^[가-힣]{0}$")) // 시간 정보란이 공백일 때 > 비대면 강의일 경우
            {

            }
        }

        public void GetClassTime(DateTime startTime, DateTime endTime) // 수업시간 구하기
        {
            int countOFHalfHourIntervals; //총 수강시간이 30분단위로 몇번 반복 되는지 저장 ( 1시간 30분의 경우 3이 저장된다.) 
            TimeSpan timeDifference = endTime - startTime; //수업시간을 구하기 위해 시간 차이 빼기
            countOFHalfHourIntervals = (int)(timeDifference.TotalMinutes / 30);

        }

        public void SetTimeTable(UserDTO userInformation, DateTime startTime, int countOFHalfHourIntervals, string dayOfTheWeek)
        {
            // 배열의 x y 좌표값 구하기
            int arrayColumn = 0;
            int arrayRow = 26;

            //x값 > 요일
            for(int i = 1; i<=5; i++)//월~금 탐색
            {
                if (userInformation.TimeTable[0,i] == dayOfTheWeek)
                {
                    arrayColumn = i;
                    break;
                }
            }
            //요일이 없을 경우, 예외값처리하기

            //y값
            for(int i =1; i<=25; i++) 
            {
                 //시간표 0번 열(좌측 열)에 저장된 시간값과 강의의 시작시간과 비교해서 시간표에 저장할 위치 찾기
                if (DateTime.ParseExact(userInformation.TimeTable[i, 0].Substring(0, 5), "HH:mm", CultureInfo.InvariantCulture) == startTime)
                {
                    arrayRow = i;
                }
            }

            for(int i=0; i< countOFHalfHourIntervals; i++)
            {
                userInformation.TimeTable
            }
            //userInformation.timeTableOfOfflineLecture
        }

        

    }

}
