using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.Model
{
    public class UserDTO
    {
        private string userId;
        public string UserId
        {
            get { return userId; } 
            set { userId = value; }
        }

        private string userPassword;
        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

    }
}
