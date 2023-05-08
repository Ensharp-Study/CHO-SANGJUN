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
-- Table structure for table `book_data`
--

DROP TABLE IF EXISTS `book_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_data` (
  `BookId` int NOT NULL AUTO_INCREMENT,
  `BookName` varchar(45) NOT NULL,
  `BookAuthor` varchar(45) NOT NULL,
  `BookPublisher` varchar(45) NOT NULL,
  `BookQuantity` int NOT NULL,
  `BookPrice` int NOT NULL,
  `BookPublicationDate` varchar(45) NOT NULL,
  `Isbn` varchar(45) NOT NULL,
  `BookDescription` mediumtext NOT NULL,
  PRIMARY KEY (`BookId`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_data`
--

LOCK TABLES `book_data` WRITE;
/*!40000 ALTER TABLE `book_data` DISABLE KEYS */;
INSERT INTO `book_data` VALUES (1,'C# 프로그래밍','윤인성','한빛 아카데미',1,25000,'2015-12-01','979-11-566420-4-6','다양한 예제와 단계별 학습으로 배우는 C# 프로그래밍의 기본'),(3,'어린왕자','앙투안 드 생텍쥐페리','마움',1,11250,'2015-12-01','979-11-566000-0-0','어린왕자 초판본원서 책과 책으로 만나는 한글판'),(4,'쿠키앤크린아몬드','조상준','삼성',8,30000,'2000-11-11','111-22-111111-2-2','하이'),(6,'딸기 우유 공약','문경민','주니어김영사',5,10800,'20190114','978-89-349834-6-0','“흰 우유는 징글징글해. 급식 우유를 딸기 우유로 바꿀까 봐.” \n전교어린이회장에 출마하기로 결심한 후 엄마 앞에서 무심결에 내뱉은 이 말이 나현이의 선거 공약이 되어 버렸다. 나현이는 우연히 학교에서 ‘딸기 우유’에 얽힌 덕주의 사연을 접하게 되고, 덕주는 꼭 회장이 되면 공약을 지키라면서 나현이를 돕는다. \n어떤 수를 써서라도 전교어린이회장이 되겠다는 후보자 시은이의 모략은 다른 후보자 미주의 용감한 행동으로 전교생에게 알려지고 학교는 발칵 뒤집어진다. 이 사건 이후 덕주와 나현이는 반 친구 이상으로 더욱 친해지고 한 뼘 더 성숙해진다.'),(7,'내가 그대를 사랑합니다','손힘찬(오가타 마리토)','떠오름(RISE)',5,14400,'20230224','979-11-923723-0-3','미처 말하지 못한 그러나 꼭 해주고 싶은 말 한마디,\n‘내가 그대를 사랑합니다.’\n사랑이 무엇인지, 어떻게 해야 하는지 알려주는 책.\n\n국내 누적 판매 50만 부! 《저 별은 모두 당신을 위해 빛나고 있다》, 《나는 나답게 살기로 했다》, 《오늘은 이만 좀 쉴게요》 등의 작품으로 독자들의 사랑을 받고 있는 작가 손힘찬. 그가 소소하지만 특별한 사랑 이야기를 담은 신작으로 돌아왔다. 일반적인 사랑 이야기와 달리 저자의 개인적이고 내밀한 내용들을 풀어놓은 이 책은 저자가 경험한 사랑과 소회를 고스란히 담아냈다.\n“사랑이라는 감정은 복잡미묘하다. 우리는 사랑이라는 이름 아래 인생의 희로애락을 겪지만, 사랑했던 사람과의 추억을 회상하며 내 삶의 이야기를 새롭게 쓸 수 있다”라는 저자의 말처럼, 사랑은 우리의 잃어버린 영혼과 인생의 활기를 되찾아주는 원동력이기에 모든 사랑은 소중하고, 특별하지 않은 사랑도 없다.\n우리는 저마다 가슴속에 묻어둔 마음이 있다. 바로 말하고 싶었으나 전할 용기가 없어서, 이미 전할 수 없는 관계가 되어서 등 그 사유는 다양할 것이다. 때로는 누군가가 내게 표현해주는 마음보다 나 자신이 보여줄 수 있는 마음이 중요하다.\n이 책은 내가 사랑하는 모든 사람에게 가슴 한편에 묻어둔 진심을 전하는 내용으로 구성했다. 순수하고 열정적인 연인의 사랑부터 아무 조건 없는 가족의 사랑, 돈독한 친구와의 사랑, 그리고 남을 사랑하느라 정작 돌보지 못한 자기 자신까지. 사랑이란 이름 아래 담긴 모든 감정을 진지하게 담아냈다. 또한, 각 장의 끝에는 자신의 마음을 편지글의 형식으로 담아 고백하는 장을 따로 마련했다.\n사랑하지만 제대로 마음을 표현한 적이 없다면, 이 책으로 소중한 한마디를 전해보자.\n\n‘사랑하는 연인에게’\n‘사랑하는 가족에게’\n‘사랑하는 친구에게’\n‘사랑하는 나 자신에게’\n\n“내가 그대를 사랑합니다.”'),(8,'사랑의 이해','이혁진','민음사',5,13500,'20190419','978-89-374399-3-3','사랑과 사랑을 둘러싼 것들에 대한 가장 보통의 사랑론!\n\n2016년 한겨레문학상 수상작가 이혁진의 신작 장편소설 『사랑의 이해』. 은행을 배경으로 펼쳐지는 네 남녀의 발칙하고 속물적이고 사실적인 사내 연애를 그린 작품으로, 회사로 표상되는 계급의 형상이 우리 인생 곳곳을, 무엇보다 사랑의 영역을 어떻게 구획 짓고 사랑의 행로를 어떻게 변화시키는지 자세하게 담아냈다.\n\n하상수 계장은 옆자리의 안수영 주임을 좋아하지만 둘 사이의 감정은 얽힌 실타래처럼 답답하게 꼬여 있다. 그러던 중 안수영 주임이 청원경찰인 종현과 호감을 주고받는 관계라는 사실을 눈치 챈 상수는 수영을 향한 마음을 접고 능력 있는 상사 박미경 대리와 프로젝트를 진행하며 서서히 가까워진다. 한편 종현이 연거푸 경찰 시험에 떨어지며 둘 사이에는 미세한 불화의 조짐이 싹트고, 상수는 자신을 압도하는 미경에게 자격지심과 열등감을 느끼고 있는 스스로를 인정하고 싶지 않은데…….\n\n은행이란 공간은 말없이 존재하는 배경인 동시에 모든 말들의 배경이기도 하다. 교환가치를 바탕으로 선택이 이뤄지고 선택이 또 다른 가치를 만들어 내는 은행은 자본주의의 꽃이자 자본주의 시대를 살아가는 현대인들의 보편적인 사고방식을 상징이기도 한다. 소설의 표면은 방황하는 연인들의 연애담이지만 그 이면은 설렘과 환희를 비롯해 자격지심, 열등감, 자존심, 질투, 시기심 등 사랑을 둘러싼 감정들, 즉 사랑할 때 우리가 말하는 것들과 이별할 때 우리가 침묵하는 것들에 대한 재발견으로 가득하다.'),(9,'상큼한 연애 달콤한 결혼 (이인철 변호사의 사랑 레시피 | 이인철 에세이)','이인철','아라크네',5,11800,'20160105','979-11-577421-9-6','\"괜찮은 사람이 있긴 한 걸까?\" \"이 사람이랑 연애를 해도 되나?\" \"이 사람은 나에게 마음이 있는 걸까?\" \"이 사람과 결혼을 하면 행복할까?\" \"어떻게 하면 그 사람과 결혼할 수 있을까?\" 연애나 결혼을 꿈꾸는 미혼 청춘남녀라면 현재 이 질문 중 하나 이상은 하고 있을 것이다. 이런 질문은 결혼을 결심하고서도 이어진다.\n\n\n\n\"결혼 준비, 잘하고 있는 걸까?\" \"사랑과 조건 중 어떤 것을 택해야 할까?\" \"과연 속궁합이 맞을까?\" \"남편의 거짓말, 어디까지 이해해야 할까?\" \"사랑 넘치는 부부로 살려면 어떻게 해야 할까?\" \n\n\n\n꼬리에 꼬리를 무는 질문에 오늘도 잠 못 이룬다. 그만큼 연애와 결혼(동거도 포함)이라는 주제는 만고불변의 관심사이자 쉽게 해결책을 찾을 수 없는 문제다. 이에 좋은 이성을 만나서 상큼한 연애와 달콤한 결혼생활을 하고 싶은 모든 청춘남녀들의 고민과 해결책을 담은 &lt;상큼한 연애 달콤한 결혼&gt;이 출간되었다. \n\n\n\n훤칠한 외모와 재치 있는 입담으로 지상파와 종편을 넘나들며 남녀관계와 부부문제 프로그램의 단골 게스트로 출연해 시청자들에게도 얼굴이 친근한 이인철 변호사가 이 책의 저자다. 이 변호사는 자신의 경험담과 의뢰인들의 고민 상담, 그리고 변호사로서의 전문적인 식견을 담은 이 책을 통해 연애와 결혼생활의 정확하고 예리한 해법을 제시해 준다.'),(10,'동행','우유수염','단비어린이',5,11550,'20220722','978-89-630103-2-8','동행, 그 아름다운 것들에 대하여\n\n《동행》은 홀로였던 한 남자가 한 여자를 만나서 가족을 이루어 가는 과정을, 남자의 집에 있는 소파의 시선으로 그려 낸 그림책입니다. 사회가 변함에 따라 가족의 형태도 1인 가족, 조손 가족 등 다양하게 변하게 되었고, 이전의 가족 형태만으로는 가족이 무엇인지 설명하는 데 한계가 있습니다. 하지만 가족의 형태가 다양하게 변한다고 해도, 가족의 소중함은 결코 변할 수 없겠지요. 기쁠 때나 슬플 때나 언제나 변함없이 그 자리에서 함께하고 있어서, 때로는 그 존재를 잠시 잊을 때도 있지만, 우리가 삶을 살아가는 데 있어서 가장 힘이 되어 주는 가족의 소중함을 이 책을 통해 다시 한번 가슴에 새기게 되길 기대해 봅니다.\n\n그림책 속 남자는 가족을 이루면서 외로움을 극복합니다. 하지만 가족을 이룬 뒤에도 또다시 혼자 남는 외로움에 빠지게 됩니다. 그리고 그 외로움에서 다시 빠져나오는 것 또한 가족으로 가능하게 됩니다. 단 한 명의 자신을 사랑해 주는 사람, 단 한 명의 자신을 믿어 주는 사람, 단 한 명의 자신을 챙겨 줄 사람이 있다면, 그 사람은 결코 잘못된 길로 가지 않는다는 말이 있습니다. 이 단 한 명이 바로 가족이 아닐까요? 그림책 속 남자가 외로움에서 가족으로 인하여 다시 행복을 찾게 되듯이 말이에요. 내가 세상을 살아갈 때, 나에게 찾아오는 기쁨과 슬픔을 오래오래 끝까지 함께 나누어 줄 사람, 그게 바로 가족이 아닐까요? 가족은 세상이 끝날 때까지, 아니 세상이 끝난 뒤에도 영원히 나와 함께하는 소중한 존재임을 기억하길 바랍니다.'),(11,'운명','T. D. 제이크스','믿음의말씀사',5,14400,'20170925','978-89-949017-4-9','『운명』은 놀라운 책이다. 수없이 많은 문을 열어주며, 운명과 인생에 대해 수없이 많은 현실의 의문에 해답을 제시한다. 나도 진작 이 책을 읽었더라면 적지 않은 고민을 덜 수 있었을 것이다(스티브 하비).');
/*!40000 ALTER TABLE `book_data` ENABLE KEYS */;
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
