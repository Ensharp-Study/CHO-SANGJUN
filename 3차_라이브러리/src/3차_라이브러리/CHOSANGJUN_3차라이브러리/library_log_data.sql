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
-- Table structure for table `log_data`
--

DROP TABLE IF EXISTS `log_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log_data` (
  `logNumber` int NOT NULL AUTO_INCREMENT,
  `logTime` varchar(45) NOT NULL,
  `logUser` varchar(45) NOT NULL,
  `logInformation` varchar(45) NOT NULL,
  `logAction` varchar(45) NOT NULL,
  PRIMARY KEY (`logNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log_data`
--

LOCK TABLES `log_data` WRITE;
/*!40000 ALTER TABLE `log_data` DISABLE KEYS */;
INSERT INTO `log_data` VALUES (49,'2023-05-08 오전 3:41:04','관리자','초기화','로그 초기화'),(50,'2023-05-08 오전 3:41:17','관리자','관리자 권한','로그인'),(51,'2023-05-08 오전 3:41:18','관리자','신청 도서 추가하기','메뉴선택'),(52,'2023-05-08 오전 3:42:04','관리자','관리자 권한','로그인'),(53,'2023-05-08 오전 3:42:05','관리자','신청 도서 추가하기','메뉴선택'),(54,'2023-05-08 오전 3:42:07','관리자','책 검색','메뉴선택'),(55,'2023-05-08 오전 3:42:42','관리자','관리자 권한','로그인'),(56,'2023-05-08 오전 3:42:44','관리자','신청 도서 추가하기','메뉴선택'),(57,'2023-05-08 오전 3:42:46','관리자','책 검색','메뉴선택'),(58,'2023-05-08 오후 1:43:44','조상준','tkdwns123','로그인'),(59,'2023-05-08 오후 1:43:45','조상준','책 검색','메뉴선택'),(60,'2023-05-08 오후 1:43:50','조상준','ESC','책 검색'),(61,'2023-05-08 오후 1:43:55','조상준','ESC','책 검색'),(62,'2023-05-08 오후 1:43:58','조상준','ESC','책 검색'),(63,'2023-05-08 오후 1:44:13','조상준','프로','책 검색'),(64,'2023-05-08 오후 1:44:46','조상준','tkdwns123','로그인'),(65,'2023-05-08 오후 1:44:47','조상준','책 검색','메뉴선택'),(66,'2023-05-08 오후 1:44:56','조상준','프로','책 검색'),(67,'2023-05-08 오후 1:44:58','조상준','tkdwns123','로그인'),(68,'2023-05-08 오후 1:45:02','조상준','책 반납','메뉴선택'),(69,'2023-05-08 오후 1:45:04','조상준','책 아이디: 1','책 반납'),(70,'2023-05-08 오후 1:45:05','조상준','tkdwns123','로그인'),(71,'2023-05-08 오후 1:45:08','조상준','네이버 책 검색 및 도서신청','메뉴선택'),(72,'2023-05-08 오후 1:45:12','조상준','우유','책 검색'),(73,'2023-05-08 오후 1:45:20','조상준','우유의 역사 (생명의 음료, 우유로 읽는 1만 년 인류문명사)','책 신청'),(74,'2023-05-08 오후 1:47:07','조상준','tkdwns123','로그인'),(75,'2023-05-08 오후 1:47:10','조상준','네이버 책 검색 및 도서신청','메뉴선택'),(76,'2023-05-08 오후 1:47:15','조상준','사탕','책 검색'),(77,'2023-05-08 오후 1:47:20','조상준','사탕 트리','책 신청'),(78,'2023-05-08 오후 1:47:21','조상준','tkdwns123','로그인'),(79,'2023-05-08 오후 1:47:30','조상준','책 검색','메뉴선택');
/*!40000 ALTER TABLE `log_data` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-08 13:50:18
