-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: library
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `user_returned_book_list`
--

DROP TABLE IF EXISTS `user_returned_book_list`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_returned_book_list` (
  `UserId` int NOT NULL,
  `BookId` int NOT NULL,
  `BookName` varchar(15) NOT NULL,
  `BookAuthor` varchar(15) NOT NULL,
  `BookPublisher` varchar(15) NOT NULL,
  `BookQuantity` int NOT NULL,
  `BookPrice` int NOT NULL,
  `BookPublicationDate` varchar(10) NOT NULL,
  `Isbn` varchar(17) NOT NULL,
  `BookDescription` text NOT NULL,
  `BorrowTime` datetime NOT NULL,
  `ReturnTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_returned_book_list`
--

LOCK TABLES `user_returned_book_list` WRITE;
/*!40000 ALTER TABLE `user_returned_book_list` DISABLE KEYS */;
INSERT INTO `user_returned_book_list` VALUES (1,1,'C# 프로그래밍','윤인성','한빛 아카데미',1,25000,'2015-12-01','979-11-566420-4-6','다양한 예제와 단계별 학습으로 배우는 C# 프로그래밍의 기본','2023-05-04 20:13:43','2023-05-04 22:40:24'),(1,1,'C# 프로그래밍','윤인성','한빛 아카데미',1,25000,'2015-12-01','979-11-566420-4-6','다양한 예제와 단계별 학습으로 배우는 C# 프로그래밍의 기본','2023-05-04 23:32:22','2023-05-04 23:47:40'),(1,3,'어린왕자','앙투안 드 생텍쥐페리','마움',2,11250,'2015-12-01','979-11-566000-0-0','어린왕자 초판본원서 책과 책으로 만나는 한글판','2023-05-04 23:47:27','2023-05-04 23:47:42'),(1,1,'C# 프로그래밍','윤인성','한빛 아카데미',1,25000,'2015-12-01','979-11-566420-4-6','다양한 예제와 단계별 학습으로 배우는 C# 프로그래밍의 기본','2023-05-04 23:50:59','2023-05-04 23:51:41'),(1,3,'어린왕자','앙투안 드 생텍쥐페리','마움',2,11250,'2015-12-01','979-11-566000-0-0','어린왕자 초판본원서 책과 책으로 만나는 한글판','2023-05-04 23:51:16','2023-05-04 23:51:43'),(13,1,'C# 프로그래밍','윤인성','한빛 아카데미',1,25000,'2015-12-01','979-11-566420-4-6','다양한 예제와 단계별 학습으로 배우는 C# 프로그래밍의 기본','2023-05-05 05:15:36','2023-05-08 13:45:04');
/*!40000 ALTER TABLE `user_returned_book_list` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-08 13:50:19
