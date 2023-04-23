using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.ExceptionHandling;
using _4차_LectureTimeTable.Utility;
using System.Security.Policy;
using _4차_LectureTimeTable.View;

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

        public string lectureName; //과목명
        public string professor;   //교수명
        public string grade;       //학년
        public string courseCode;  //학수번호
        public string courseClass; //분반

        
        public string[] majorPrintList = { "전체", "컴퓨터공학과", "소프트웨어학과", "지능기전공학부", "기계항공우주공학부" };
        public string[] courseClassificationPrintList = { "전체", "공통교양필수", "전공필수", "전공선택" };
        public string[] LectureEntries = { "개설학과 전공", "이수구분", "교과목명", "교수명", "학년", "학수번호" };

        public int majorNumber;
        public int courseClassificationNumber;

        public void FindCourse()  //강의 찾기 내 메인 함수
        {
            GetExcelFile(); //엑셀파일 불러오기
            Console.Clear();
            menuUi.PrintSearchLectureGuideUi();
            menuUi.PrintCourseFinderMenu();

            menuSelectController.SelectMenuWithUpAndDown(LectureEntries,6,5,15);
            majorNumber = menuSelectController.SelectMenuWithRightAndLeft(majorPrintList, 5, 10, 15);
            courseClassificationNumber = menuSelectController.SelectMenuWithRightAndLeft(courseClassificationPrintList, 4, 10, 16);
            InputCourseInformation();
            CompareWithData();
        }

        public void InputCourseInformation() //원하는 강의 정보 입력 받는 함수
        {
            Console.CursorVisible = true;
            menuUi.PrintLectureDetailInformationInputMenu(10, 17);
            bool isInputValid = false;
            while (!isInputValid)
            {
                lectureName = ToReceiveInput.ReceiveInput(24, 17, 30, Constants.IS_NOT_PASSWORD);
                isInputValid = lectureException.JudgeLectureNameRegularExpression(24, 17, lectureName);
            }

            isInputValid = false;
            while (!isInputValid)
            {
                professor = ToReceiveInput.ReceiveInput(24, 18, 25, Constants.IS_NOT_PASSWORD);
                isInputValid = lectureException.JudgeProcessorRegularExpression(24, 18, professor);
            }

            isInputValid = false;
            while (!isInputValid)
            {
                grade = ToReceiveInput.ReceiveInput(24, 19, 1, Constants.IS_NOT_PASSWORD);
                isInputValid = lectureException.JudgeGradeRegularExpression(24, 19, grade);
            }

            isInputValid = false;
            while (!isInputValid)
            {
                courseCode = ToReceiveInput.ReceiveInput(24, 20, 6, Constants.IS_NOT_PASSWORD);
                isInputValid = lectureException.JudgeCourseCodeRegularExpression(24, 20, courseCode);
            }

            isInputValid = false;
            while (!isInputValid)
            {
                courseClass = ToReceiveInput.ReceiveInput(24, 21, 3, Constants.IS_NOT_PASSWORD);
                isInputValid = lectureException.JudgeCourseClassRegularExpression(24, 21, courseClass);
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
                        menuUi.PrintExistLectureInformation( dataStorage.lectureTotalData, i);
                    }
                    isExistCourseInData = false;
                }
            }
        }

        //엑셀 불러오기
        public void GetExcelFile()
        {
            try
            {
                // Excel Application 객체 생성
                Excel.Application application = new Excel.Application();

                // Workbook 객체 생성 및 파일 오픈 (바탕화면에 있는 excelStudy.xlsx 가져옴)
                Excel.Workbook workbook = application.Workbooks.Open(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\2023년도 1학기 강의시간표.xlsx");

                // sheets에 읽어온 엑셀값을 넣기 (한 workbook 내의 모든 sheet 가져옴)
                Excel.Sheets sheets = workbook.Sheets;

                // 특정 sheet의 값 가져오기
                Excel.Worksheet worksheet = sheets["Sheet1"] as Excel.Worksheet;

                // 범위 설정 (좌측 상단, 우측 하단)
                Excel.Range cellRange = worksheet.get_Range("A2", "L185") as Excel.Range;

                // 설정한 범위만큼 데이터 담기 (Value2 -셀의 기본 값 제공)
                Array lectureData = cellRange.Cells.Value2;

                dataStorage.lectureTotalData = lectureData;

                // 모든 워크북 닫기
                application.Workbooks.Close();

                // application 종료
                application.Quit();
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }



}
