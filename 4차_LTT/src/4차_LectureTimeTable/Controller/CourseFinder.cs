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

namespace _4차_LectureTimeTable.Controller
{
    public class CourseFinder
    {
        DataStorage dataStorage;
        LectureException lectureException;
        public CourseFinder(DataStorage dataStorage, LectureException lectureException) 
        { 
            this.dataStorage = dataStorage;
            this.lectureException = lectureException;
        }
        public string lectureName; //과목명
        public string professor;   //교수명
        public string grade;       //학년
        public string courseCode;  //학수번호
        public string courseClass; //분반

        public void FindCourse()
        {
            GetExcelFile();
            InputCourseInformation();
            CompareWithData();
        }

        //엑셀 불러오기
        public void GetExcelFile()
        {
            try
            {
                // Excel Application 객체 생성
                Excel.Application application = new Excel.Application();

                // Workbook 객체 생성 및 파일 오픈 (바탕화면에 있는 excelStudy.xlsx 가져옴)
                Excel.Workbook workbook = application.Workbooks.Open(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\excelStudy.xlsx");

                // sheets에 읽어온 엑셀값을 넣기 (한 workbook 내의 모든 sheet 가져옴)
                Excel.Sheets sheets = workbook.Sheets;

                // 특정 sheet의 값 가져오기
                Excel.Worksheet worksheet = sheets["ensharp"] as Excel.Worksheet;

                // 범위 설정 (좌측 상단, 우측 하단)
                Excel.Range cellRange = worksheet.get_Range("A2", "L185") as Excel.Range;

                // 설정한 범위만큼 데이터 담기 (Value2 -셀의 기본 값 제공)
                Array lectureData = cellRange.Cells.Value2;

                dataStorage.lectureTotalData =lectureData;

                // 데이터 출력
                //Console.WriteLine(lectureData.GetValue(1, 1));

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

        public void InputCourseInformation() //원하는 정보 입력 받는 함수
        {
            bool isInputValid = false;
            while (!isInputValid)
            {
                lectureName = ToReceiveInput.ReceiveInput(38, 18, 8, Constants.isNotPassword);
                isInputValid = lectureException.JudgeLectureNameRegularExpression(38, 18, lectureName);
            }

            isInputValid = false;
            while (!isInputValid)
            {
                professor = ToReceiveInput.ReceiveInput(38, 18, 8, Constants.isNotPassword);
                isInputValid = lectureException.JudgeProcessorRegularExpression(38, 18, professor);
            }

            isInputValid = false;
            while (!isInputValid)
            {
                grade = ToReceiveInput.ReceiveInput(38, 18, 8, Constants.isNotPassword);
                isInputValid = lectureException.JudgeGradeRegularExpression(38, 18, grade);
            }

            isInputValid = false;
            while (!isInputValid)
            {
                courseCode = ToReceiveInput.ReceiveInput(38, 18, 8, Constants.isNotPassword);
                isInputValid = lectureException.JudgeCourseCodeRegularExpression(38, 18, courseCode);
            }

            isInputValid = false;
            while (!isInputValid)
            {
                courseClass = ToReceiveInput.ReceiveInput(38, 18, 8, Constants.isNotPassword);
                isInputValid = lectureException.JudgeCourseClassRegularExpression(38, 18, courseClass);
            }
        }

        public void CompareWithData()
        {
            bool isExistCourseInData = false;
            for (int i = 0; i < dataStorage.lectureTotalData.GetLength(0); i++)
            {
                if (string.IsNullOrEmpty(lectureName) == false ||   // 입력받은 값이 공백인 경우 제외
                   string.IsNullOrEmpty(professor) == false ||
                   string.IsNullOrEmpty(grade) == false ||
                   string.IsNullOrEmpty(courseCode) == false ||
                   string.IsNullOrEmpty(courseClass) == false)

                {
                    if ( (dataStorage.lectureTotalData.GetValue(i, 4).ToString() ).Contains(lectureName) &&
                        (dataStorage.lectureTotalData.GetValue(i, 10).ToString()).Contains(professor) &&
                        (dataStorage.lectureTotalData.GetValue(i, 6).ToString()).Contains(grade) &&
                        (dataStorage.lectureTotalData.GetValue(i, 2).ToString()).Contains(courseCode) &&
                        (dataStorage.lectureTotalData.GetValue(i, 3).ToString()).Contains(courseClass)){

                        isExistCourseInData = true;
                    }

                }

                if (isExistCourseInData) // 일치하면 출력
                {
                    {
                        //출력 //commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
                    }
                    isExistCourseInData = false;
                }
            }
        }

    }



}
