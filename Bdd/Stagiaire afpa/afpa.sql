-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 23 oct. 2023 à 07:04
-- Version du serveur : 5.7.36
-- Version de PHP : 8.1.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `afpa`
--

-- --------------------------------------------------------

--
-- Structure de la table `formateurs`
--

DROP TABLE IF EXISTS `formateurs`;
CREATE TABLE IF NOT EXISTS `formateurs` (
  `idFormateur` int(11) NOT NULL AUTO_INCREMENT,
  `nomFormateur` varchar(25) NOT NULL,
  `prenomFormateur` varchar(25) NOT NULL,
  PRIMARY KEY (`idFormateur`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf16;

--
-- Déchargement des données de la table `formateurs`
--

INSERT INTO `formateurs` (`idFormateur`, `nomFormateur`, `prenomFormateur`) VALUES
(1, 'Poix', 'Martine'),
(2, 'Dubois', 'Thomas'),
(3, 'Butterdroghe', 'Hervé'),
(4, 'Batzic', 'Jean Paul');

-- --------------------------------------------------------

--
-- Structure de la table `formations`
--

DROP TABLE IF EXISTS `formations`;
CREATE TABLE IF NOT EXISTS `formations` (
  `idFormation` int(11) NOT NULL AUTO_INCREMENT,
  `libelleFormation` varchar(50) NOT NULL,
  `idGroupe` int(11) NOT NULL,
  PRIMARY KEY (`idFormation`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `groupes`
--

DROP TABLE IF EXISTS `groupes`;
CREATE TABLE IF NOT EXISTS `groupes` (
  `idGroupe` int(11) NOT NULL,
  `libelleGroupe` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `hebergement`
--

DROP TABLE IF EXISTS `hebergement`;
CREATE TABLE IF NOT EXISTS `hebergement` (
  `idHerbergement` int(11) NOT NULL AUTO_INCREMENT,
  `libelleHerbegement` varchar(50) NOT NULL,
  PRIMARY KEY (`idHerbergement`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `matieres`
--

DROP TABLE IF EXISTS `matieres`;
CREATE TABLE IF NOT EXISTS `matieres` (
  `idMatiere` int(11) NOT NULL,
  `nomMatiere` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Structure de la table `stagiaires`
--

DROP TABLE IF EXISTS `stagiaires`;
CREATE TABLE IF NOT EXISTS `stagiaires` (
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

-- --------------------------------------------------------

--
-- Structure de la table `suivis`
--

DROP TABLE IF EXISTS `suivis`;
CREATE TABLE IF NOT EXISTS `suivis` (
  `idSuivi` int(11) NOT NULL AUTO_INCREMENT,
  `idStagiaire` int(11) NOT NULL,
  `idMatiere` int(11) NOT NULL,
  `note` float NOT NULL,
  PRIMARY KEY (`idSuivi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
