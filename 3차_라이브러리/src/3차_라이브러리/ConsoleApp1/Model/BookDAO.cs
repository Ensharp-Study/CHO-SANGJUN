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

        public BookDAO() 
        {
            this.connectionWithServer = new ConnectionWithServer();
        }

        public List<BookDTO> ReadAllBookData() //모든 책 정보를 가져오는 함수
        {
            BookDTO bookDTO;
            List<BookDTO> allBookInformation= new List<BookDTO>();  //모든 책 정보를 담을 리스트 선언

            string queryStatement = "SELECT * FROM book_data ;";
            MySqlDataReader readedData = connectionWithServer.SelectUsedExecuteReader(queryStatement);

            while (readedData.Read()) 
            {
                bookDTO = new BookDTO(); //왜 와일문 밖에 작성하면 마지막 값으로 다 저장되는지 물어보기
                bookDTO.BookId = readedData.GetInt32(0);
                bookDTO.BookName = readedData.GetString(1);
                bookDTO.BookAuthor = readedData.GetString(2);
                bookDTO.BookPublisher = readedData.GetString(3);
                bookDTO.BookQuantity = readedData.GetInt32(4);
                bookDTO.BookPrice = readedData.GetInt32(5);
                bookDTO.BookPublicationDate = readedData.GetString(6);
                bookDTO.Isbn = readedData.GetString(7);
                bookDTO.BookDescription = readedData.GetString(8);

                allBookInformation.Add(bookDTO);//책 리스트에 추가
            }
            readedData.Close();
            return allBookInformation; //모든 책정보가 담겨 있는 리스트 전달
        }
    }
}
