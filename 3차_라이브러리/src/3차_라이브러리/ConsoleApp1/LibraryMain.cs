using System;
using System.ComponentModel;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ConsoleApp1.Utility;
using ConsoleApp1.Controller.User.UserMenu;

namespace Library 
{
    public class LibraryMain    
    {
        static void Main(string[] args)
        {
            LibraryMode libraryStart = new LibraryMode();
            libraryStart.SelectMenu();

        }
    }
}
