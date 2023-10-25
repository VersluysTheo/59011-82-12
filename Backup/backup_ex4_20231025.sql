-- MySQL dump 10.13  Distrib 5.7.36, for Win64 (x86_64)
--
-- Host: localhost    Database: ex4
-- ------------------------------------------------------
-- Server version	5.7.36

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
-- Current Database: `ex4`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `ex4` /*!40100 DEFAULT CHARACTER SET utf16 */;

USE `ex4`;

--
-- Table structure for table `departement`
--

DROP TABLE IF EXISTS `departement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departement` (
  `nodep` int(11) NOT NULL AUTO_INCREMENT,
  `ville` varchar(50) DEFAULT NULL,
  `nomdep` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`nodep`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departement`
--

LOCK TABLES `departement` WRITE;
/*!40000 ALTER TABLE `departement` DISABLE KEYS */;
INSERT INTO `departement` VALUES (10,'Aix','Formation'),(20,'Paris','Ingénierie'),(30,'Bordeaux','Industrie'),(40,'Paris','Direction générale');
/*!40000 ALTER TABLE `departement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employe`
--

DROP TABLE IF EXISTS `employe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employe` (
  `noemp` int(11) NOT NULL AUTO_INCREMENT,
  `nomemp` varchar(50) DEFAULT NULL,
  `fonction` varchar(50) DEFAULT NULL,
  `noresp` int(11) DEFAULT NULL,
  `datemb` date DEFAULT NULL,
  `sala` decimal(19,2) DEFAULT NULL,
  `comm` decimal(19,2) DEFAULT NULL,
  `noemp_1` int(11) DEFAULT NULL,
  `nodep` int(11) NOT NULL,
  PRIMARY KEY (`noemp`),
  KEY `noemp_1` (`noemp_1`),
  KEY `Id_Departement` (`nodep`),
  CONSTRAINT `employe_ibfk_1` FOREIGN KEY (`noemp_1`) REFERENCES `employe` (`noemp`),
  CONSTRAINT `employe_ibfk_2` FOREIGN KEY (`nodep`) REFERENCES `departement` (`nodep`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employe`
--

LOCK TABLES `employe` WRITE;
/*!40000 ALTER TABLE `employe` DISABLE KEYS */;
INSERT INTO `employe` VALUES (1,'Costanza','psychologue',8,'1994-10-19',1715.00,200.00,1,30),(2,'Mioche','Directeur',6,'1990-03-15',2200.00,1000.00,2,20),(3,'Durand','Responsable',2,'1996-04-18',3250.00,0.00,3,10),(4,'Xiong','vendeur',5,'1994-12-15',1150.00,200.00,4,30),(5,'Manoukian','vendeur',11,'1993-08-15',2530.00,500.00,5,30),(6,'Bourdais','directeur',15,'2002-07-12',3550.00,850.00,6,40),(7,'Moreno','ouvrier',3,'1999-05-05',1075.00,50.00,7,10),(8,'Perou','directeur',2,'1995-07-05',2450.00,800.00,8,10),(9,'Bibaut','chef de service',8,'1993-06-07',2200.00,0.00,9,20),(10,'Manian','assistant',9,'1996-10-18',1000.00,250.00,10,10),(11,'Colin','analyste',2,'1992-07-05',2703.00,625.00,11,30),(12,'Coulon','ouvrier',8,'2002-09-18',858.00,125.00,12,20),(13,'Roméo','assistant',8,'2001-08-16',1025.00,1150.00,13,10),(14,'Solal','secrétaire',3,'1992-02-15',1225.00,0.00,14,20),(15,'Bailly','Président',NULL,'1985-01-05',4275.00,2000.00,15,40),(16,'Jazarin','Ouvrier',2,'2001-07-05',875.00,0.00,16,10),(17,'Font','Ouvrier',2,'1990-08-04',1200.00,250.00,17,10),(18,'Servel','ouvrier',3,'1998-12-02',1025.00,55.00,18,30);
/*!40000 ALTER TABLE `employe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grade`
--

DROP TABLE IF EXISTS `grade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grade` (
  `Id_Grade` int(11) NOT NULL AUTO_INCREMENT,
  `nograde` int(11) DEFAULT NULL,
  `salmin` decimal(19,4) DEFAULT NULL,
  `salmax` decimal(19,4) DEFAULT NULL,
  PRIMARY KEY (`Id_Grade`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grade`
--

LOCK TABLES `grade` WRITE;
/*!40000 ALTER TABLE `grade` DISABLE KEYS */;
INSERT INTO `grade` VALUES (1,1,0.0000,1000.0000),(2,2,1000.0000,2000.0000),(3,3,2000.0000,3000.0000),(4,4,3000.0000,4000.0000),(5,5,4000.0000,5000.0000),(6,6,5000.0000,6000.0000);
/*!40000 ALTER TABLE `grade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `histofonction`
--

DROP TABLE IF EXISTS `histofonction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `histofonction` (
  `Id_Histofonction` int(11) NOT NULL AUTO_INCREMENT,
  `noemp` int(11) DEFAULT NULL,
  `datenom` date DEFAULT NULL,
  `fonction` varchar(50) DEFAULT NULL,
  `noemp_1` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Histofonction`),
  KEY `noemp_1` (`noemp_1`),
  CONSTRAINT `histofonction_ibfk_1` FOREIGN KEY (`noemp_1`) REFERENCES `employe` (`noemp`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `histofonction`
--

LOCK TABLES `histofonction` WRITE;
/*!40000 ALTER TABLE `histofonction` DISABLE KEYS */;
INSERT INTO `histofonction` VALUES (1,1,'1994-10-19','vendeur',NULL),(2,1,'1996-12-18','psychologue',NULL),(3,2,'1990-03-15','responsable',NULL),(4,2,'1994-10-18','directeur',NULL),(5,3,'1996-04-18','vendeur',NULL),(6,3,'1998-06-18','responsable',NULL),(7,4,'1994-12-15','vendeur',NULL),(8,5,'1993-08-15','vendeur',NULL),(9,6,'2002-07-12','directeur',NULL),(10,7,'1999-05-05','ouvrier',NULL),(11,8,'1995-07-05','vendeur',NULL),(12,8,'1997-04-15','responsable',NULL),(13,8,'1999-10-18','directeur',NULL),(14,10,'1996-10-18','assistant',NULL),(15,11,'1992-07-05','vendeur',NULL),(16,11,'1995-07-15','responsable',NULL),(17,11,'1999-05-19','analyste',NULL),(18,12,'2002-09-18','ouvrier',NULL);
/*!40000 ALTER TABLE `histofonction` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-25 15:09:18
