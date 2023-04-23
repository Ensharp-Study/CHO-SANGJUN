using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.ExceptionHandling;
using _4차_LectureTimeTable.Utility;
using System.Security.Policy;
using _4차_LectureTimeTable.View;
using System.Globalization;

namespace _4차_LectureTimeTable.Controller
{
    public class CourseFinder
    {
        DataStorage dataStorage;
        LectureException lectureException;
        MenuUi menuUi;
        MenuSelectController menuSelectController;
        public CourseFinder(DataStorage dataStorage, LectureException lectureException, MenuUi menuUi, MenuSelectController menuSelectController) 
        { 
            this.dataStorage = dataStorage;
            this.lectureException = lectureException;
            this.menuUi = menuUi;
            this.menuSelectController = menuSelectController;
        }

        public string lectureName=""; //과목명
        public string professor="";   //교수명
        public string grade = "";       //학년
        public string courseCode = "";  //학수번호
        public string courseClass = ""; //분반

        
        public string[] majorPrintList = { "전체", "컴퓨터공학과", "소프트웨어학과", "지능기전공학부", "기계항공우주공학부" };
        public string[] courseClassificationPrintList = { "전체", "공통교양필수", "전공필수", "전공선택" };
        public string[] LectureEntries = { "개설학과 전공", "이수구분", "교과목명     :", "교수명       :", "학년         :", "학수번호     :", "분반         :", "<검색하기>" };

        public int lectureEntriesNumber;
        public int majorNumber;
        public int courseClassificationNumber;

        bool isInputValid = false;
        bool isSearchCompleted = false;

        public void FindCourse()  //강의 찾기 내 메인 함수
        {
            Console.Clear();
            menuUi.PrintSearchLectureGuideUi();
            menuUi.PrintCourseFinderMenu();

            while (!isSearchCompleted)
            {
                lectureEntriesNumber = menuSelectController.SelectMenuWithUpAndDown(LectureEntries, 8, 5, 11);
                SelectLectureEntriesMenu();
            }
            Console.Clear();
            CompareWithData();
        }
        
        public void SelectLectureEntriesMenu()
        {
            isInputValid = false;
            isSearchCompleted = false;
            switch (lectureEntriesNumber)
            {
                case (int)LectureEntriesList.MAJOR_LECTURE:
                    majorNumber = menuSelectController.SelectMenuWithRightAndLeft(majorPrintList, 5, 20, 11);
                    break;

                case (int)LectureEntriesList.CLASSIFICATION:
                    courseClassificationNumber = menuSelectController.SelectMenuWithRightAndLeft(courseClassificationPrintList, 4, 20, 12);
                    break;

                case (int)LectureEntriesList.LECTURE_NAME:
                    while (!isInputValid)
                    {
                        lectureName = ToReceiveInput.ReceiveInput(20, 13, 30, Constants.IS_NOT_PASSWORD);
                        isInputValid = lectureException.JudgeLectureNameRegularExpression(20, 13, lectureName);
                    }
                    break;

                case (int)LectureEntriesList.PROFESSOR_NAME:
                    while (!isInputValid)
                    {
                        professor = ToReceiveInput.ReceiveInput(20, 14, 25, Constants.IS_NOT_PASSWORD);
                        isInputValid = lectureException.JudgeProcessorRegularExpression(20, 14, professor);
                    }
                    break;

                case (int)LectureEntriesList.GRADE:
                    while (!isInputValid)
                    {
                        grade = ToReceiveInput.ReceiveInput(20, 15, 1, Constants.IS_NOT_PASSWORD);
                        isInputValid = lectureException.JudgeGradeRegularExpression(20, 15, grade);
                    }
                    break;

                case (int)LectureEntriesList.COURSE_NUMBER:
                    while (!isInputValid)
                    {
                        courseCode = ToReceiveInput.ReceiveInput(20, 16, 6, Constants.IS_NOT_PASSWORD);
                        isInputValid = lectureException.JudgeCourseCodeRegularExpression(20, 16, courseCode);
                    }
                    break;
                case (int)LectureEntriesList.CLASS_NUMBER:
                    while (!isInputValid)
                    {
                        courseClass = ToReceiveInput.ReceiveInput(20, 17, 3, Constants.IS_NOT_PASSWORD);
                        isInputValid = lectureException.JudgeCourseClassRegularExpression(20, 17, courseClass);
                    }
                    break;
                case (int)LectureEntriesList.SEARCH:
                    isSearchCompleted = true;
                    break;
            }
        } 

        public void CompareWithData()
        {
            bool isExistCourseInData = false;
            for (int i = 1; i <= dataStorage.lectureTotalData.GetLength(0); i++)
            {
                if (string.IsNullOrEmpty(lectureName) == false ||   // 입력받은 값이 공백인 경우 제외
                   string.IsNullOrEmpty(professor) == false ||
                   string.IsNullOrEmpty(grade) == false ||
                   string.IsNullOrEmpty(courseCode) == false ||
                   string.IsNullOrEmpty(courseClass) == false)
                {
                    if (
                        (dataStorage.lectureTotalData.GetValue(i, 2).ToString()).Contains(majorPrintList[majorNumber]) &&
                        (dataStorage.lectureTotalData.GetValue(i, 6).ToString()).Contains(courseClassificationPrintList[courseClassificationNumber]) &&
                        (dataStorage.lectureTotalData.GetValue(i, 5).ToString() ).Contains(lectureName) &&
                        (dataStorage.lectureTotalData.GetValue(i, 11).ToString()).Contains(professor) &&
                        (dataStorage.lectureTotalData.GetValue(i, 7).ToString()).Contains(grade) &&
                        (dataStorage.lectureTotalData.GetValue(i, 3).ToString()).Contains(courseCode) &&
                        (dataStorage.lectureTotalData.GetValue(i, 4).ToString()).Contains(courseClass)){

                        isExistCourseInData = true;
                    }

                }

                if (isExistCourseInData) // 일치하면 출력
                {
                    {
                        SetAndArrangeData(dataStorage.lectureTotalData, i);//문자열 수 확인하는 함수
                    }
                    isExistCourseInData = false;
                }
            }
        }

        //문자열 바이트 수 확인하고 출력 정렬 맞춰주는 함수
        public void SetAndArrangeData(Array lectureTotalData, int index)
        {
            string[] maximumLengthOfStringsInEachRow = { "184", "기계항공우주공학부", "004714","001", "K-MOOC:모두를위한머신러닝", "공통교양필수", "1", "1", "수 16:30~18:30, 금 09:00~11:00", "센B201,센B209", "Abolghasem Sadeghi-Niaraki", "영어/한국어" };
            for (int i = 1; i <= 12; i++)
            {
                menuUi.PrintExistLectureInformation(lectureTotalData.GetValue(index, i).ToString(), lectureTotalData.GetValue(index, i).ToString().Length + Encoding.Default.GetByteCount(maximumLengthOfStringsInEachRow[i - 1])  - Encoding.Default.GetByteCount(lectureTotalData.GetValue(index, i).ToString()) );
            
            }
            Console.WriteLine("  ");

        }

    }



}
