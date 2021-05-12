-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: mlms
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `history`
--

DROP TABLE IF EXISTS `history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `history` (
  `BillNumber` int NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(45) DEFAULT NULL,
  `StaffName` varchar(45) DEFAULT NULL,
  `DateofStart` datetime DEFAULT NULL,
  `DateofCollection` datetime DEFAULT NULL,
  `TotalAmountPaid` decimal(5,2) DEFAULT NULL,
  `TotalCloth` int DEFAULT NULL,
  `Weight` decimal(5,2) DEFAULT NULL,
  `Suits` int DEFAULT NULL,
  `Jackets` int DEFAULT NULL,
  `Sweater` int DEFAULT NULL,
  `Shirts` int DEFAULT NULL,
  `Batik` int DEFAULT NULL,
  `TShirt` int DEFAULT NULL,
  `Dresses` int DEFAULT NULL,
  `Pants` int DEFAULT NULL,
  `Trouser` int DEFAULT NULL,
  `Skirts` int DEFAULT NULL,
  `Bed_Cover` int DEFAULT NULL,
  `Bed_Sheet` int DEFAULT NULL,
  `Pillow_Sheet` int DEFAULT NULL,
  `Blankets` int DEFAULT NULL,
  `Towels` int DEFAULT NULL,
  `Others` int DEFAULT NULL,
  PRIMARY KEY (`BillNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `history`
--

LOCK TABLES `history` WRITE;
/*!40000 ALTER TABLE `history` DISABLE KEYS */;
INSERT INTO `history` VALUES (1,'Daniel Ryan','Grace Leaf','2020-07-10 00:00:00','2020-07-10 00:00:00',15.00,20,4.00,1,0,0,0,0,5,0,7,0,0,1,2,2,1,1,0),(2,'Amanda Jessy','Robert Conny','2020-07-10 00:00:00','2020-07-10 00:00:00',12.50,15,3.50,0,1,2,5,0,2,0,4,0,0,1,0,0,0,0,0),(3,'Tan Yong','Grace Leaf','2020-07-11 00:00:00','2020-07-11 00:00:00',11.25,10,2.00,0,1,0,3,0,5,0,2,0,0,0,0,0,0,0,0),(4,'Tony Marole','Grace Leaf','2020-07-11 00:00:00','2020-07-11 00:00:00',25.00,136,5.00,1,2,3,5,4,7,6,9,8,11,10,13,12,15,14,16),(5,'Tan Yong','Grace Leaf','2020-07-11 00:00:00','2020-07-11 00:00:00',11.25,10,2.00,0,1,0,3,0,5,0,2,0,0,0,0,0,0,0,0),(6,'Tony Marole','Grace Leaf','2020-07-20 00:00:00','2020-07-20 00:00:00',25.00,136,5.00,1,2,3,5,4,7,6,9,8,11,10,13,12,15,14,16),(7,'Tan Yong','Grace Leaf','2020-07-20 00:00:00','2020-07-20 00:00:00',30.00,20,6.00,3,4,6,6,1,0,0,0,0,0,0,0,0,0,0,0),(8,'Tan Yong','Robert Conny','2020-07-20 00:00:00','2020-07-20 00:00:00',12.00,12,2.40,0,0,0,2,0,5,0,5,0,0,0,0,0,0,0,0),(9,'Diamond Ryan','Robert Conny','2020-07-20 00:00:00','2020-07-20 00:00:00',15.00,15,3.00,0,0,0,5,0,3,0,5,0,0,2,0,0,0,0,0),(10,'Diamond Ryan','Robert Conny','2020-07-20 00:00:00','2020-07-20 00:00:00',10.00,10,2.00,0,0,0,5,0,5,0,0,0,0,0,0,0,0,0,0),(11,'Tony Marole','Grace Leaf','2020-07-20 00:00:00','2020-07-20 00:00:00',25.00,136,5.00,1,2,3,5,4,7,6,9,8,11,10,13,12,15,14,16),(12,'Tan Yong','Grace Leaf','2020-07-20 00:00:00','2020-07-20 00:00:00',11.25,10,2.00,0,1,0,3,0,5,0,2,0,0,0,0,0,0,0,0),(13,'Tan Yong','Robert Conny','2020-07-20 00:00:00','2020-07-20 00:00:00',12.00,12,2.40,0,0,0,2,0,5,0,5,0,0,0,0,0,0,0,0),(14,'Tan Yong','Grace Leaf','2020-07-20 00:00:00','2020-07-20 00:00:00',14.00,12,2.00,0,1,5,0,1,5,0,0,0,0,0,0,0,0,0,0),(15,'Tony Marole','Grace Leaf','2020-07-20 00:00:00','2020-07-20 00:00:00',25.00,136,5.00,1,2,3,5,4,7,6,9,8,11,10,13,12,15,14,16),(16,'Tony Marole','Robert Conny','2020-07-20 00:00:00','2020-07-20 00:00:00',15.00,20,3.00,2,0,0,0,4,0,6,0,0,0,1,1,2,2,2,0),(17,'Tony Marole','Grace Leaf','2020-07-20 00:00:00','2020-07-20 00:00:00',25.00,0,5.00,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(18,'Tony Marole','Robert Conny','2020-07-20 00:00:00','2020-07-23 00:00:00',50.00,0,10.00,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(19,'Tan Yong','Grace Leaf','2020-07-20 00:00:00','2020-07-20 00:00:00',25.00,0,5.00,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(20,'Tan Yong','Grace Leaf','2020-07-20 00:00:00','2020-07-22 00:00:00',35.00,0,7.00,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(21,'Amanda Jessy','Grace Leaf','2020-07-21 00:00:00','2020-07-22 00:00:00',20.00,16,4.00,0,2,1,0,0,0,2,0,1,4,1,1,1,2,1,0),(22,'Daniel Ryan','Grace Leaf','2020-07-22 00:00:00','2020-07-22 00:00:00',15.00,18,3.00,0,0,0,5,0,6,0,7,0,0,0,0,0,0,0,0),(23,'William Niko','Robert Conny','2020-07-23 00:00:00','2020-07-23 00:00:00',10.00,0,2.00,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(24,'Daniel Ryan','Tiffany Kristine','2020-07-23 00:00:00','2020-07-25 05:02:50',25.00,0,5.00,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0),(25,'Amanda Jessy','Robert Conny','2020-07-23 00:00:00',NULL,10.00,10,2.00,0,0,0,3,0,0,0,3,0,2,0,0,0,1,1,0),(26,'Diamond Ryan','Nichkolas William','2020-07-23 00:00:00',NULL,5.00,6,1.00,0,0,0,0,0,3,0,2,0,0,0,0,0,1,0,0),(27,'Tony Marole','Grace Leaf','2020-07-23 00:00:00',NULL,10.00,7,2.00,0,0,1,0,0,2,0,2,0,0,0,0,1,1,0,0),(28,'William Niko','Tiffany Kristine','2020-07-25 04:59:00',NULL,20.00,13,4.00,0,1,0,4,0,3,0,2,0,0,1,0,0,0,2,0),(29,'Daniel Ryan','Tiffany Kristine','2020-07-29 03:02:59',NULL,5.00,9,1.00,1,0,0,1,0,5,0,2,0,0,0,0,0,0,0,0),(30,'Tan Yong','Tiffany Kristine','2020-07-29 03:04:42',NULL,15.00,4,3.00,0,0,0,1,0,2,0,1,0,0,0,0,0,0,0,0);
/*!40000 ALTER TABLE `history` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-29 22:24:16
