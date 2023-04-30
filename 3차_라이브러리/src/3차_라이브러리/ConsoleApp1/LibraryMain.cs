using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Library 
{
    public class LibraryMain    
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
