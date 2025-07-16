-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: fahrradverwaltung
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `fertigwaren`
--

DROP TABLE IF EXISTS `fertigwaren`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fertigwaren` (
  `fwnr` int(11) NOT NULL AUTO_INCREMENT,
  `fwmodell` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`fwnr`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fertigwaren`
--

LOCK TABLES `fertigwaren` WRITE;
/*!40000 ALTER TABLE `fertigwaren` DISABLE KEYS */;
INSERT INTO `fertigwaren` VALUES (11,'Moutain Bike'),(12,'Rennrad'),(13,'E-bike'),(14,'Motor-Bike'),(15,'Faster'),(16,'Rock');
/*!40000 ALTER TABLE `fertigwaren` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fwrs`
--

DROP TABLE IF EXISTS `fwrs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fwrs` (
  `fwrsnummer` int(11) NOT NULL AUTO_INCREMENT,
  `fwnr` int(11) DEFAULT NULL,
  `rsnr` int(11) DEFAULT NULL,
  `rohwarenAnzahl` int(11) DEFAULT NULL,
  PRIMARY KEY (`fwrsnummer`),
  KEY `fwnr` (`fwnr`),
  KEY `rsnr` (`rsnr`),
  CONSTRAINT `fwrs_ibfk_1` FOREIGN KEY (`fwnr`) REFERENCES `fertigwaren` (`fwnr`),
  CONSTRAINT `fwrs_ibfk_2` FOREIGN KEY (`rsnr`) REFERENCES `rohstoffe` (`rsnr`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fwrs`
--

LOCK TABLES `fwrs` WRITE;
/*!40000 ALTER TABLE `fwrs` DISABLE KEYS */;
INSERT INTO `fwrs` VALUES (39,13,10,1),(40,11,10,2),(41,12,12,2),(42,12,13,1),(43,11,11,2),(44,14,10,3),(45,16,14,1),(46,16,10,2),(47,13,11,2);
/*!40000 ALTER TABLE `fwrs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rohstoffe`
--

DROP TABLE IF EXISTS `rohstoffe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rohstoffe` (
  `rsnr` int(11) NOT NULL AUTO_INCREMENT,
  `preis` double DEFAULT NULL,
  `bezeichnung` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`rsnr`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rohstoffe`
--

LOCK TABLES `rohstoffe` WRITE;
/*!40000 ALTER TABLE `rohstoffe` DISABLE KEYS */;
INSERT INTO `rohstoffe` VALUES (10,25.4,'Kette'),(11,12.99,'Lampe'),(12,30.59,'Rad'),(13,150.4,'Rahmen'),(14,80.44,'Sitz'),(20,22.4,'Rohware1'),(21,33.4,'Rohware2'),(23,24.88,'Rohware3');
/*!40000 ALTER TABLE `rohstoffe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vfertigwaren_details`
--

DROP TABLE IF EXISTS `vfertigwaren_details`;
/*!50001 DROP VIEW IF EXISTS `vfertigwaren_details`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vfertigwaren_details` AS SELECT
 1 AS `fwmodell`,
  1 AS `bezeichnung`,
  1 AS `rohwarenAnzahl`,
  1 AS `gesamtPreis` */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vfertigwaren_details`
--

/*!50001 DROP VIEW IF EXISTS `vfertigwaren_details`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vfertigwaren_details` AS select `f`.`fwmodell` AS `fwmodell`,`rs`.`bezeichnung` AS `bezeichnung`,`v`.`rohwarenAnzahl` AS `rohwarenAnzahl`,`rs`.`preis` * `v`.`rohwarenAnzahl` AS `gesamtPreis` from ((`fertigwaren` `f` join `fwrs` `v` on(`f`.`fwnr` = `v`.`fwnr`)) join `rohstoffe` `rs` on(`v`.`rsnr` = `rs`.`rsnr`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-07-06 23:39:00
