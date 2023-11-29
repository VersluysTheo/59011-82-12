-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 29 nov. 2023 à 08:34
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `crudapirelationnn`
--

-- --------------------------------------------------------

--
-- Structure de la table `enfant`
--

DROP TABLE IF EXISTS `enfant`;
CREATE TABLE IF NOT EXISTS `enfant` (
  `Id_Enfant` int NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) DEFAULT NULL,
  `Prenom` varchar(50) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  PRIMARY KEY (`Id_Enfant`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `enfant`
--

INSERT INTO `enfant` (`Id_Enfant`, `Nom`, `Prenom`, `Age`) VALUES
(1, 'Open', 'Tibo', 12),
(2, 'Nkouloudjoko', 'Joachim Jr', 8),
(3, 'Xin', 'Lin', 3),
(4, 'Linba', 'Ludwig', 14);

-- --------------------------------------------------------

--
-- Structure de la table `parent`
--

DROP TABLE IF EXISTS `parent`;
CREATE TABLE IF NOT EXISTS `parent` (
  `Id_Parent` int NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) DEFAULT NULL,
  `Prenom` varchar(50) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  PRIMARY KEY (`Id_Parent`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `parent`
--

INSERT INTO `parent` (`Id_Parent`, `Nom`, `Prenom`, `Age`) VALUES
(1, 'Villeray', 'Jean Charles', 54),
(2, 'Linba', 'Christine', 47),
(3, 'Nkouloudjoko', 'Joachim', 31),
(4, 'Jollivet', 'Sylvie', 51),
(5, 'Xin', 'Fen', 23),
(6, 'Dassdu', 'Maurice', 38),
(7, 'Devynck', 'Florent', 25),
(8, 'Pourakavitch', 'Lydia', 28);

-- --------------------------------------------------------

--
-- Structure de la table `parent_enfant`
--

DROP TABLE IF EXISTS `parent_enfant`;
CREATE TABLE IF NOT EXISTS `parent_enfant` (
  `Id_Parent` int DEFAULT NULL,
  `Id_Enfant` int DEFAULT NULL,
  `id_parent_enfant` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_parent_enfant`),
  KEY `Id_Parent` (`Id_Parent`),
  KEY `Id_Enfant` (`Id_Enfant`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `parent_enfant`
--

INSERT INTO `parent_enfant` (`Id_Parent`, `Id_Enfant`, `id_parent_enfant`) VALUES
(2, 4, 5),
(5, 3, 6),
(3, 2, 7),
(7, 1, 8);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `parent_enfant`
--
ALTER TABLE `parent_enfant`
  ADD CONSTRAINT `parent_enfant_ibfk_1` FOREIGN KEY (`Id_Parent`) REFERENCES `parent` (`Id_Parent`),
  ADD CONSTRAINT `parent_enfant_ibfk_2` FOREIGN KEY (`Id_Enfant`) REFERENCES `enfant` (`Id_Enfant`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;