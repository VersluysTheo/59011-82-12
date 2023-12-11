-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 11 déc. 2023 à 16:12
-- Version du serveur : 8.2.0
-- Version de PHP : 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestionstocks`
--

-- --------------------------------------------------------

--
-- Structure de la table `articles`
--

DROP TABLE IF EXISTS `articles`;
CREATE TABLE IF NOT EXISTS `articles` (
  `Id_Articles` int NOT NULL AUTO_INCREMENT,
  `LibelleArticle` varchar(50) DEFAULT NULL,
  `QuantiteStockee` int DEFAULT NULL,
  `Id_Categories` int NOT NULL,
  PRIMARY KEY (`Id_Articles`),
  KEY `Id_Categories` (`Id_Categories`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `articles`
--

INSERT INTO `articles` (`Id_Articles`, `LibelleArticle`, `QuantiteStockee`, `Id_Categories`) VALUES
(1, 'iPhone X', 50, 1),
(2, 'Chemise en lin', 100, 2),
(3, 'Canapé en cuir', 20, 3),
(4, 'Pommes', 500, 4),
(5, 'Jeu de construction', 75, 5),
(6, 'Tapis de course', 10, 6),
(7, 'To Kill a Mockingbird', 30, 7),
(8, 'Perceuse sans fil', 40, 8),
(9, 'Aspirateur robot', 40, 1),
(10, 'Veste en cuir', 60, 2),
(11, 'Table de jardin en teck', 15, 3),
(12, 'Yaourts aux fruits', 150, 4),
(13, 'Nintendo Switch', 25, 5);

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

DROP TABLE IF EXISTS `categories`;
CREATE TABLE IF NOT EXISTS `categories` (
  `Id_Categories` int NOT NULL AUTO_INCREMENT,
  `LibelleCategorie` varchar(50) DEFAULT NULL,
  `Id_TypesProduits` int NOT NULL,
  PRIMARY KEY (`Id_Categories`),
  KEY `Id_TypesProduits` (`Id_TypesProduits`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `categories`
--

INSERT INTO `categories` (`Id_Categories`, `LibelleCategorie`, `Id_TypesProduits`) VALUES
(1, 'Smartphones', 1),
(2, 'Chemises', 2),
(3, 'Canapés', 3),
(4, 'Fruits et légumes', 4),
(5, 'Jeux éducatifs', 5),
(6, 'Équipement de fitness', 6),
(7, 'Romans', 7),
(8, 'Outils électriques', 8);

-- --------------------------------------------------------

--
-- Structure de la table `typesproduits`
--

DROP TABLE IF EXISTS `typesproduits`;
CREATE TABLE IF NOT EXISTS `typesproduits` (
  `Id_TypesProduits` int NOT NULL AUTO_INCREMENT,
  `LibelleTypeProduit` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_TypesProduits`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `typesproduits`
--

INSERT INTO `typesproduits` (`Id_TypesProduits`, `LibelleTypeProduit`) VALUES
(1, 'Électronique'),
(2, 'Vêtements'),
(3, 'Meubles'),
(4, 'Alimentation'),
(5, 'Jouets'),
(6, 'Articles de sport'),
(7, 'Livres'),
(8, 'Outils');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
