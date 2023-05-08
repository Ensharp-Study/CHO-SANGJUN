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
-- Table structure for table `user_apply_book_list`
--

DROP TABLE IF EXISTS `user_apply_book_list`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_apply_book_list` (
  `BookId` int NOT NULL AUTO_INCREMENT,
  `BookName` varchar(100) NOT NULL,
  `BookAuthor` varchar(100) NOT NULL,
  `BookPublisher` varchar(100) NOT NULL,
  `BookPrice` varchar(45) NOT NULL,
  `BookPublicationDate` varchar(45) NOT NULL,
  `BookIsbn` varchar(45) NOT NULL,
  `BookDescription` mediumtext NOT NULL,
  PRIMARY KEY (`BookId`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_apply_book_list`
--

LOCK TABLES `user_apply_book_list` WRITE;
/*!40000 ALTER TABLE `user_apply_book_list` DISABLE KEYS */;
INSERT INTO `user_apply_book_list` VALUES (39,'우유의 역사 (생명의 음료, 우유로 읽는 1만 년 인류문명사)','마크 쿨란스키','와이즈맵','16250','20220815','979-11-893284-2-9','“우유는 어떻게 인류의 운명을 바꿔 왔는가”\n\n그리스 창조 신화부터 몽골 제국 건설, 인도 식민지배와 냉전 미사일 위기까지\n한 잔 우유에 담긴 1만 년 문명사를 만나다!\n“신화, 전쟁, 혁신, 논란의 기록으로 가득한 매혹의 세계사”\n\n‘생명의 음료’ 우유를 통해 1만 년의 장대한 문명사를 조망한 《우유의 역사》. 저자  쿨란스키는 《우유의 역사》를 집필하기 위해 직접 전 세계 낙농가와 유제품 전문가, 환경운동가, 유목민 집단 등을 인터뷰했으며 시대와 대륙, 과학과 역사를 넘나들며 우유의 모든 것을 집대성했다. 책에는 우유가 빚어낸 세계사의 결정적인 순간과 그로 인해 뒤바뀐 인류의 운명이 고스란히 담겨 있다. 냉전시대 쿠바 미사일 위기가 불러온 세계 최대의 아이스크림 가게, 영국의 식민 지배에 우유로 저항한 인도, 고작 네 마리 소에서 출발한 아메리카 대륙의 식민지 낙농 산업, 낙태 문제의 초기 버전인 모유 수유 대 인공 수유 논쟁, 낙농업에 대한 불신을 키운 광우병 스캔들 등이 모두 우유가 만들어낸 역사 속 장면들이다. 그동안 주류 역사에서는 주목하지 않던 우유에 관한 흥미롭고 논쟁적인 사실들이 쿨란스키에 의해 재발견되어 세상에 나왔다. \n\n책의 Part1에서는 고대에 낙농 문화가 처음 등장한 지점에서 출발해 우유에 관한 최초의 기록을 살펴본다. 인간이 다른 동물의 젖을 먹어온 방식과 버터, 치즈, 요거트, 아이스크림 등의 유제품이 탄생한 역사적 배경을 추적한다. Part2는 우유의 안전성에 대한 두려움이 팽배하던 시기, 깨끗한 우유를 갈망한 인류가 이뤄낸 기술적 발전을 보여준다. 또한 산업혁명으로 우유가 대량 생산되며 생긴 사회적, 문화적 변화들을 돌아본다. Part3에서는 티베트, 중국, 인도 등 아시아 지역에서 독특하게 발전한 우유 문화를 살핀다. 또한 GMO 우유, 공장식 농장과 동물권 등 환경 문제를 다루며 우유에 관한 현재진행형인 쟁점들을 소개하고 있다. 책에는 역사 속에서 우유가 묘사된 그림, 조각, 사진, 우표 등이 도판으로 수록되어 있다. 또한 과거의 시대상이 녹아 있고 우유, 버터, 치즈, 요거트 등을 활용한 동서고금의 다양한 ‘레시피’를 담아내고 있다.'),(40,'사탕 트리','백유연','웅진주니어','11700','20201207','978-89-012476-5-6','찬 바람이 불기 시작하는 날이에요. 동물 친구들은 다가올 겨울을 준비하며 크리스마스트리를 만들어요. 솔방울, 나뭇잎, 도토리 자신들이 좋아하는 것을 가져와 예쁘게 장식하죠. 여기에 고라니가 아주 특별한 선물을 준비하죠. 드디어 기다리고 기다리던 크리스마스 아침이 밝았어요. 추운 겨울을 따뜻하게 만들어 주는 동물 친구들의 마법 같은 선물을 만나 볼까요?');
/*!40000 ALTER TABLE `user_apply_book_list` ENABLE KEYS */;
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
