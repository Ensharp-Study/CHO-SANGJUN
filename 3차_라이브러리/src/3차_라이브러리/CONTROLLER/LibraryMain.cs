using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Library //최상단
{
    internal class LibraryMain 
       
    {
        static void Main(string[] args)
        {
            while (true)
            {
                LibraryStart libraryStart = new LibraryStart();
                libraryStart.SelectMenu();
            }
        }
    }
}
