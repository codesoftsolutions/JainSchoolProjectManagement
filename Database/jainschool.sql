-- MySQL dump 10.13  Distrib 5.5.48, for Win32 (x86)
--
-- Host: localhost    Database: jainschool
-- ------------------------------------------------------
-- Server version	5.5.48

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `create_user`
--

DROP TABLE IF EXISTS `create_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `create_user` (
  `_id` varchar(20) NOT NULL,
  `user_name` varchar(20) DEFAULT NULL,
  `password` varchar(20) DEFAULT NULL,
  `name` varchar(20) DEFAULT NULL,
  `user_roll_type` int(11) DEFAULT NULL,
  `desgination` varchar(20) DEFAULT NULL,
  `isApproved` int(11) DEFAULT NULL,
  PRIMARY KEY (`_id`),
  UNIQUE KEY `user_name` (`user_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `create_user`
--

LOCK TABLES `create_user` WRITE;
/*!40000 ALTER TABLE `create_user` DISABLE KEYS */;
INSERT INTO `create_user` VALUES ('10001','sdfsdf','sdfsdf','sdfsdf',0,'sdfsdf',1),('10002','wrtrwt','wrtwrtrwt','wrtrwt',0,'wrtwrtrwt',1),('10003','dfsdf','dfsdf','sdfsdf',0,'dfsdf',1),('10004','gfdg','fgfgfgf','sfsdf',0,'gfsgsfgsfg',1),('10005','aa','aa','aa',0,'aa',0);
/*!40000 ALTER TABLE `create_user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-03 20:42:23
