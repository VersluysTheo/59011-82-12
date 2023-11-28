-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 28 nov. 2023 à 09:48
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
-- Base de données : `apicrud`
--

-- --------------------------------------------------------

--
-- Structure de la table `grade`
--

DROP TABLE IF EXISTS `grade`;
CREATE TABLE IF NOT EXISTS `grade` (
  `GradeId` int NOT NULL AUTO_INCREMENT,
  `GradeName` varchar(50) NOT NULL,
  `Section` varchar(50) NOT NULL,
  PRIMARY KEY (`GradeId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `grade`
--

INSERT INTO `grade` (`GradeId`, `GradeName`, `Section`) VALUES
(1, 'Art', 'bas'),
(2, 'Math', 'plusbas'),
(3, 'Etmatuidi', 'passenprofondeur'),
(4, 'Etmatuidi', 'passenprofondeur'),
(5, 'Hugo Llyoris', 'est au cage');

-- --------------------------------------------------------

--
-- Structure de la table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `CurrentGradeId` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `CurrentGradeId` (`CurrentGradeId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `student`
--

INSERT INTO `student` (`Id`, `Name`, `CurrentGradeId`) VALUES
(3, 'Glenda', 2),
(4, 'Warda', 2),
(5, 'Moldav', 1),
(6, 'Quackoubaie', 1),
(7, 'kolm', 3),
(8, 'Joachim', 4),
(9, 'Nkouloudjoko', 5);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`CurrentGradeId`) REFERENCES `grade` (`GradeId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
