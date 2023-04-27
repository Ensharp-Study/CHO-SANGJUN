using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.ExceptionHandling;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.Utility;
using _4차_LectureTimeTable.View;
using System;
using System.Collections.Generic;
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


    }

}
