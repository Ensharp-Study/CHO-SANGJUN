using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1.Utility
{
    public class NaverSearchFunctionAPI
    {

        public void SearchBook()
        {
            string bookName = "김현아";
            string bookCount = "5";
            string url = string.Format(Constants.URL, bookName, bookCount);
            string id = "OX9S3Tu5F_h3qCJCerI3";
            string secret = "OdL8kKSsRm";

            //웹서비스 요청
            //네이버 검색 서비스를 사용하기 위해서 요청할 때 Client ID와 Client Secret을 헤더에 추가하여 보내기
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", id);
            request.Headers.Add("X-Naver-Client-Secret", secret);

            //웹서비스 응답
            //네이버 검색 서비스를 실제 사용하기위해 WebRequest 개체의 GetResponse 메서드를 호출해서 응답받기
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //응답 결과 처리하기
            string status = response.StatusCode.ToString(); //응답 상태 코드가져오기
            if (status == "OK")
            {
                Stream stream = response.GetResponseStream(); //응답 본문에 대한 스트림 가져오기
                StreamReader reader = new StreamReader(stream, Encoding.UTF8); //응답 스트림 읽기
                string jsonString = reader.ReadToEnd(); //응답 본문 문자열에 저장
                reader.Close();
                Console.WriteLine(jsonString);
                ParseJSON(jsonString); // 파싱하기
            }

            else
            {
                Console.WriteLine("Error 발생=" + status);
            }
        }

        public void ParseJSON(string jsonString)
        {
            List <BookDTO> searchBookList = new List<BookDTO>();

            // Native Object 생성
            JObject json = JObject.Parse(jsonString);
            JArray itemsArray = (JArray)json["items"];

            foreach (JObject index in itemsArray)
            {
                BookDTO searchedBookDTO = new BookDTO();

                searchedBookDTO.BookName = (string)index["title"];
                searchedBookDTO.BookAuthor = (string)index["author"];
                searchedBookDTO.BookPublisher = (string)index["publisher"];
                searchedBookDTO.BookPrice = (int)index["discount"];        
                searchedBookDTO.BookPublicationDate = (string)index["pubdate"];              
                searchedBookDTO.Isbn = (string)index["isbn"];
                searchedBookDTO.BookDescription = (string)index["description"];

                searchBookList.Add(searchedBookDTO);
            }
        }


    }
}
