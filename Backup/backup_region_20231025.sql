-- MySQL dump 10.13  Distrib 5.7.36, for Win64 (x86_64)
--
-- Host: localhost    Database: region
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
-- Current Database: `region`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `region` /*!40100 DEFAULT CHARACTER SET utf16 */;

USE `region`;

--
-- Table structure for table `region`
--

DROP TABLE IF EXISTS `region`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `region` (
  `idDepartement` int(11) NOT NULL AUTO_INCREMENT,
  `Departement` varchar(256) NOT NULL,
  `Region` varchar(256) NOT NULL,
  `Numero Departement` varchar(256) NOT NULL,
  `Numero Region` int(11) NOT NULL,
  PRIMARY KEY (`idDepartement`)
) ENGINE=InnoDB AUTO_INCREMENT=110 DEFAULT CHARSET=utf16;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `region`
--

LOCK TABLES `region` WRITE;
/*!40000 ALTER TABLE `region` DISABLE KEYS */;
INSERT INTO `region` VALUES (1,'Ain','Auvergne-Rhône-Alpes','1',1),(2,'Aisne','Hauts-de-France','2',7),(3,'Allier','Auvergne-Rhône-Alpes','3',1),(4,'Alpes-de-Haute-Provence','Provence-Alpes-Côte d\'Azur','4',13),(5,'Hautes-Alpes','Provence-Alpes-Côte d\'Azur','5',13),(6,'Alpes-Maritimes','Provence-Alpes-Côte d\'Azur','6',13),(7,'Ardèche','Auvergne-Rhône-Alpes','7',1),(8,'Ardennes','Grand-Est','8',6),(9,'Ariège','Occitanie','9',11),(10,'Aube','Grand-Est','10',6),(11,'Aude','Occitanie','11',11),(12,'Aveyron','Occitanie','12',11),(13,'Bouches-du-Rhône','Provence-Alpes-Côte d\'Azur','13',13),(14,'Calvados','Normandie','14',9),(15,'Cantal','Auvergne-Rhône-Alpes','15',1),(16,'Charente','Nouvelle-Aquitaine','16',10),(17,'Charente-Maritime','Nouvelle-Aquitaine','17',10),(18,'Cher','Centre-Val de Loire','18',4),(19,'Correze','Nouvelle-Aquitaine','19',10),(20,'Côte-d\'Or','Bourgogne-Franche-Comté','21',2),(21,'Côtes-d\'Armor','Bretagne','22',3),(22,'Creuse','Nouvelle-Aquitaine','23',10),(23,'Dordogne','Nouvelle-Aquitaine','24',10),(24,'Doubs','Bourgogne-Franche-Comté','25',2),(25,'Drôme','Auvergne-Rhône-Alpes','26',1),(26,'Eure','Normandie','27',9),(27,'Eure-et-Loir','Centre-Val de Loire','28',4),(28,'Finistère','Bretagne','29',3),(29,'Corse-du-Sud','Corse','2A',5),(30,'Haute-Corse ','Corse','2B',5),(31,'Gard','Occitanie','30',11),(32,'Haute-Garonne','Occitanie','31',11),(33,'Gers','Occitanie','32',11),(34,'Gironde','Nouvelle-Aquitaine','33',10),(35,'Hérault','Occitanie','34',11),(36,'Ille-et-Vilaine','Bretagne','35',3),(37,'Indre','Centre-Val de Loire','36',4),(38,'Indre-et-Loire','Centre-Val de Loire','37',4),(39,'Isère','Auvergne-Rhône-Alpes','38',1),(40,'Jura','Bourgogne-Franche-Comté','39',2),(41,'Landes','Nouvelle-Aquitaine','40',10),(42,'Loir-et-Cher','Centre-Val de Loire','41',4),(43,'Loire','Auvergne-Rhône-Alpes','42',1),(44,'Haute-Loire','Auvergne-Rhône-Alpes','43',1),(45,'Loire-Atlantique','Pays de la Loire','44',12),(46,'Loiret','Centre-Val de Loire','45',4),(47,'Lot','Occitanie','46',11),(48,'Lot-et-Garonne','Nouvelle-Aquitaine','47',10),(49,'Lozère','Occitanie','48',11),(50,'Maine-et-Loire','Pays de la Loire','49',12),(51,'Manche','Normandie','50',9),(52,'Marne','Grand-Est','51',6),(53,'Haute-Marne','Grand-Est','52',6),(54,'Mayenne','Pays de la Loire','53',12),(55,'Meurthe-et-Moselle','Grand-Est','54',6),(56,'Meuse','Grand-Est','55',6),(57,'Morbihan','Bretagne','56',3),(58,'Moselle','Grand-Est','57',6),(59,'Nièvre','Bourgogne-Franche-Comté','58',2),(60,'Nord','Hauts-de-France','59',7),(61,'Oise','Hauts-de-France','60',7),(62,'Orne','Normandie','61',9),(63,'Pas-de-Calais','Hauts-de-France','62',7),(64,'Puy-de-Dôme','Auvergne-Rhône-Alpes','63',1),(65,'Pyrénées-Atlantiques','Nouvelle-Aquitaine','64',10),(66,'Hautes-Pyrénées','Occitanie','65',11),(67,'Pyrénées-Orientales','Occitanie','66',11),(68,'Bas-Rhin','Grand-Est','67',6),(69,'Haut-Rhin','Grand-Est','68',6),(70,'Rhône','Auvergne-Rhône-Alpes','69',1),(71,'Haute-Saône','Bourgogne-Franche-Comté','70',2),(72,'Saône-et-Loire','Bourgogne-Franche-Comté','71',2),(73,'Sarthe','Pays de la Loire','72',12),(74,'Savoie','Auvergne-Rhône-Alpes','73',1),(75,'Haute-Savoie','Auvergne-Rhône-Alpes','74',1),(76,'Paris','Ile-de-France','75',8),(77,'Seine-Maritime','Normandie','76',9),(78,'Seine-et-Marne','Ile-de-France','77',8),(79,'Yvelines','Ile-de-France','78',8),(80,'Deux-Sèvres','Nouvelle-Aquitaine','79',10),(81,'Somme','Hauts-de-France','80',7),(82,'Tarn','Occitanie','81',11),(83,'Tarn-et-Garonne','Occitanie','82',11),(84,'Var','Provence-Alpes-Côte d\'Azur','83',13),(85,'Vaucluse','Provence-Alpes-Côte d\'Azur','84',13),(86,'Vendée','Pays de la Loire','85',12),(87,'Vienne','Nouvelle-Aquitaine','86',10),(88,'Haute-Vienne','Nouvelle-Aquitaine','87',10),(89,'Vosges','Grand-Est','88',6),(90,'Yonne','Bourgogne-Franche-Comté','89',2),(91,'Territoire de Belfort','Bourgogne-Franche-Comté','90',2),(92,'Essonne','Ile-de-France','91',8),(93,'Hauts-de-Seine','Ile-de-France','92',8),(94,'Seine-Saint-Denis','Ile-de-France','93',8),(95,'Val-de-Marne','Ile-de-France','94',8),(96,'Val-d\'Oise','Ile-de-France','95',8),(97,'Guadeloupe','DOM-TOM','971',14),(98,'Martinique','DOM-TOM','972',14),(99,'Guyane','DOM-TOM','973',14),(100,'La Réunion','DOM-TOM','974',14),(101,'Saint-Pierre-et-Miquelon','DOM-TOM','975',14),(102,'Mayotte','DOM-TOM','976',14),(103,'Saint-Barthélemy','DOM-TOM','977',14),(104,'Saint-Martin','DOM-TOM','978',14),(105,'Terres australes et antarctiques françaises','DOM-TOM','984',14),(106,'Wallis-et-Futuna','DOM-TOM','986',14),(107,'Polynésie française','DOM-TOM','987',14),(108,'Nouvelle-Calédonie','DOM-TOM','988',14),(109,'Clipperton','DOM-TOM','989',14);
/*!40000 ALTER TABLE `region` ENABLE KEYS */;
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
