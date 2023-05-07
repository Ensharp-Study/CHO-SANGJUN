using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class LogDAO
    {
        public ConnectionWithServer connectionWithServer;

        public LogDAO()
        {
            this.connectionWithServer = new ConnectionWithServer();
        }

        public void AddLogInData(string logTime, string logUSer, string logInformation, string logAction)
        {
            string queryStatement = string.Format("INSERT INTO log_data (logTime, logUser, logInformation, logAction) VALUES ('{0}', '{1}','{2}','{3}');", logTime, logUSer, logInformation, logAction);
            connectionWithServer.CreateUpdateDelete(queryStatement);
        }
    }
}
