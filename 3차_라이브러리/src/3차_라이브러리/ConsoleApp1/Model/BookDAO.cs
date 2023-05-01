using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataBase
{
    public class BookDAO
    {
        public ConnectionWithServer connectionWithServer;
        public BookDTO bookDTO;

        public BookDAO(BookDTO bookDTO) 
        {
            this.connectionWithServer = new ConnectionWithServer();
            this.bookDTO = bookDTO;
        }

        public int ReadAllBookCount() //저장된 모든 책들의 개수 구하는 함수 
        {
            string queryStatement = "SELECT COUNT(*) FROM book_data;";
            object readedData = connectionWithServer.SelectUsedExecuteScalarMethod(queryStatement);
            return Convert.ToInt32(readedData);
        }
        public BookDTO ReadAllBookData(int bookId)
        {
            string queryStatement = "SELECT * FROM book_data;";
            MySqlDataReader readedData = connectionWithServer.SelectUsedExecuteReader(queryStatement);

            for (int i = 0; i < bookId; i++) 
            {
                readedData.Read(); 
            } //책 Id에 따라 데이터 베이스의 행 선택

            bookDTO.BookId = readedData.GetInt32(0);
            bookDTO.BookName = readedData.GetString(1);
            bookDTO.BookAuthor = readedData.GetString(2);
            bookDTO.BookPublisher = readedData.GetString(3);
            bookDTO.BookQuantity = readedData.GetInt32(4);
            bookDTO.BookPrice = readedData.GetInt32(5);
            bookDTO.BookPublicationDate = readedData.GetString(6);
            bookDTO.Isbn = readedData.GetString(7);
            bookDTO.BookDescription = readedData.GetString(8);

            readedData.Close();
            return bookDTO;
        }
    }
}
