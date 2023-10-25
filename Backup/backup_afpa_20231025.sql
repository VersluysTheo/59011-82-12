-- MySQL dump 10.13  Distrib 5.7.36, for Win64 (x86_64)
--
-- Host: localhost    Database: afpa
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
-- Current Database: `afpa`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `afpa` /*!40100 DEFAULT CHARACTER SET utf16 */;

USE `afpa`;

--
-- Table structure for table `formateurs`
--

DROP TABLE IF EXISTS `formateurs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formateurs` (
  `idFormateur` int(11) NOT NULL AUTO_INCREMENT,
  `nomFormateur` varchar(25) NOT NULL,
  `prenomFormateur` varchar(25) NOT NULL,
  PRIMARY KEY (`idFormateur`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formateurs`
--

LOCK TABLES `formateurs` WRITE;
/*!40000 ALTER TABLE `formateurs` DISABLE KEYS */;
INSERT INTO `formateurs` VALUES (1,'Poix','Martine'),(2,'Dubois','Thomas'),(3,'Butterdroghe','Hervé'),(4,'Batzic','Jean Paul');
/*!40000 ALTER TABLE `formateurs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formations`
--

DROP TABLE IF EXISTS `formations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formations` (
  `idFormation` int(11) NOT NULL AUTO_INCREMENT,
  `libelleFormation` varchar(50) NOT NULL,
  `idGroupe` int(11) NOT NULL,
  PRIMARY KEY (`idFormation`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formations`
--

LOCK TABLES `formations` WRITE;
/*!40000 ALTER TABLE `formations` DISABLE KEYS */;
/*!40000 ALTER TABLE `formations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `groupes`
--

DROP TABLE IF EXISTS `groupes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `groupes` (
  `idGroupe` int(11) NOT NULL,
  `libelleGroupe` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groupes`
--

LOCK TABLES `groupes` WRITE;
/*!40000 ALTER TABLE `groupes` DISABLE KEYS */;
/*!40000 ALTER TABLE `groupes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hebergement`
--

DROP TABLE IF EXISTS `hebergement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `hebergement` (
  `idHerbergement` int(11) NOT NULL AUTO_INCREMENT,
  `libelleHerbegement` varchar(50) NOT NULL,
  PRIMARY KEY (`idHerbergement`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hebergement`
--

LOCK TABLES `hebergement` WRITE;
/*!40000 ALTER TABLE `hebergement` DISABLE KEYS */;
/*!40000 ALTER TABLE `hebergement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matieres`
--

DROP TABLE IF EXISTS `matieres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matieres` (
  `idMatiere` int(11) NOT NULL,
  `nomMatiere` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matieres`
--

LOCK TABLES `matieres` WRITE;
/*!40000 ALTER TABLE `matieres` DISABLE KEYS */;
/*!40000 ALTER TABLE `matieres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stagiaires`
--

DROP TABLE IF EXISTS `stagiaires`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stagiaires` (
  `idStagiaire` int(11) NOT NULL AUTO_INCREMENT,
  `nomStagiaire` varchar(25) NOT NULL,
  `prenomStagiaire` varchar(25) NOT NULL,
  `adresseStagiaire` varchar(50) NOT NULL,
  `ville` varchar(25) NOT NULL,
  `codePostal` int(11) NOT NULL,
  `telStagiaire` varchar(14) NOT NULL,
  `dateEntree` date NOT NULL,
  `SexeStagiaire` varchar(1) NOT NULL,
  `dateNaissance` date NOT NULL,
  PRIMARY KEY (`idStagiaire`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stagiaires`
--

LOCK TABLES `stagiaires` WRITE;
/*!40000 ALTER TABLE `stagiaires` DISABLE KEYS */;
/*!40000 ALTER TABLE `stagiaires` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suivis`
--

DROP TABLE IF EXISTS `suivis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suivis` (
  `idSuivi` int(11) NOT NULL AUTO_INCREMENT,
  `idStagiaire` int(11) NOT NULL,
  `idMatiere` int(11) NOT NULL,
  `note` float NOT NULL,
  PRIMARY KEY (`idSuivi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suivis`
--

LOCK TABLES `suivis` WRITE;
/*!40000 ALTER TABLE `suivis` DISABLE KEYS */;
/*!40000 ALTER TABLE `suivis` ENABLE KEYS */;
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
