using _4차_LectureTimeTable.DataBase;
using _4차_LectureTimeTable.ExceptionHandling;
using _4차_LectureTimeTable.Model;
using _4차_LectureTimeTable.Utility;
using _4차_LectureTimeTable.View;
using System;

namespace _4차_LectureTimeTable.Controller
{
    public class CourseOfInterestAdder :CourseFinder
    {
        LectureOfInterestAdderUi lectureOfInterestAdderUi = new LectureOfInterestAdderUi();

        public CourseOfInterestAdder( MenuUi menuUi,DataStorage dataStorage, LectureException lectureException, MenuSelectController menuSelectController) : base(dataStorage,lectureException, menuUi,menuSelectController)
        { 
        }

        public int selectedMenu;
        public string[] menuList = { "○ 관심과목 검색", "○ 관심과목 내역", "○ 관심과목 삭제" };
        public void ControllAddInterestLectureMenu(UserDTO userInformation)
        {
            Console.Clear();
            menuUi.PrintMenuUi(userInformation.UserName);
            selectedMenu = menuSelectController.SelectMenuWithUpAndDown(menuList, 3, 42, 12);

            switch (selectedMenu)
            {
                case (int)InterestLectureMenuList.ADDER:
                    AddLecture();
                    break;
                case (int)InterestLectureMenuList.CHECKER:
                   
                    break;

                case (int)InterestLectureMenuList.DELETER:

                    break;

            }
        }

        public void AddLecture()
        {
            FindCourse();

        }




    }
}
