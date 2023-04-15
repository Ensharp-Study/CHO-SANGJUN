using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Library 
{
    internal class LibraryMain 
       
    {
        static void Main(string[] args)
        {
            while (true)
            {
                LibraryMode libraryStart = new LibraryMode();
                libraryStart.SelectMenu();
            }
        }
    }
}
