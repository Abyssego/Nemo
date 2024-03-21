-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 21 mars 2024 à 10:54
-- Version du serveur : 8.0.30
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `nemo`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `ID_Client` int NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Telephone` varchar(20) DEFAULT NULL,
  `Adresse` varchar(100) DEFAULT NULL,
  `Ville` varchar(50) DEFAULT NULL,
  `Code_Postal` varchar(10) DEFAULT NULL,
  `Pays` varchar(50) DEFAULT NULL,
  `Date_Inscription` date DEFAULT NULL,
  `Niveau_Pl_SousMarine` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `materiel`
--

CREATE TABLE `materiel` (
  `IdMateriel` int NOT NULL,
  `NomMateriel` varchar(50) DEFAULT NULL,
  `PrixLocationDemiJourMateriel` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `materiel`
--

INSERT INTO `materiel` (`IdMateriel`, `NomMateriel`, `PrixLocationDemiJourMateriel`) VALUES
(1, 'Combinaison', 15.50),
(2, 'Bouteille', 10.00),
(3, 'PMT', 8.00);

-- --------------------------------------------------------

--
-- Structure de la table `niveauxplonger`
--

CREATE TABLE `niveauxplonger` (
  `IdNiveauPlonger` int NOT NULL,
  `DescriptionNiveauxPlonger` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `niveauxplonger`
--

INSERT INTO `niveauxplonger` (`IdNiveauPlonger`, `DescriptionNiveauxPlonger`) VALUES
(0, 'Pas de niveau acquis'),
(1, 'Niveau 1'),
(2, 'Niveau 2'),
(3, 'Niveau 3'),
(4, 'Niveau 4');

-- --------------------------------------------------------

--
-- Structure de la table `participantplonger`
--

CREATE TABLE `participantplonger` (
  `DatePlonger` date NOT NULL,
  `IdParticipantPlonger` int NOT NULL,
  `IdPlongerParticipantPlonger` int DEFAULT NULL,
  `IdPlongeurParticipantPlonger` int DEFAULT NULL,
  `IdPersonnelParticipantPlonger` int DEFAULT NULL,
  `MaterielLouerParticipantPlonger` varchar(100) DEFAULT NULL,
  `PresentParticipantPlonger` bit(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `participantplonger`
--

INSERT INTO `participantplonger` (`DatePlonger`, `IdParticipantPlonger`, `IdPlongerParticipantPlonger`, `IdPlongeurParticipantPlonger`, `IdPersonnelParticipantPlonger`, `MaterielLouerParticipantPlonger`, `PresentParticipantPlonger`) VALUES
('2023-05-10', 1, 1, 1, 1, 'Combinaison', b'1'),
('2023-06-25', 2, 2, 2, 2, 'Bouteille, Gilet', b'1'),
('2023-07-15', 3, 3, 3, 1, 'PMT, Combinaison', b'1');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

CREATE TABLE `personnel` (
  `IdPersonnel` int NOT NULL,
  `NomPersonnel` varchar(50) DEFAULT NULL,
  `PrenomPersonnel` varchar(50) DEFAULT NULL,
  `RolePersonnel` varchar(50) DEFAULT NULL,
  `DateEmbauchePersonnel` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IdPersonnel`, `NomPersonnel`, `PrenomPersonnel`, `RolePersonnel`, `DateEmbauchePersonnel`) VALUES
(1, 'Dupont', 'Jean', 'Moniteur', '2020-01-15'),
(2, 'Martin', 'Sophie', 'Assistant', '2019-07-22'),
(3, 'Lefebvre', 'Pierre', 'Moniteur', '2021-03-10');

-- --------------------------------------------------------

--
-- Structure de la table `plonger`
--

CREATE TABLE `plonger` (
  `IdPlonger` int NOT NULL,
  `IdSitePlonger` int DEFAULT NULL,
  `DatePlonger` date DEFAULT NULL,
  `DurerPlonger` time DEFAULT NULL,
  `TypePlonger` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `plonger`
--

INSERT INTO `plonger` (`IdPlonger`, `IdSitePlonger`, `DatePlonger`, `DurerPlonger`, `TypePlonger`) VALUES
(1, 1, '2023-05-10', '08:30:00', 'Demi-journée'),
(2, 2, '2023-06-25', '10:00:00', 'Journée complète'),
(3, 3, '2023-07-15', '09:00:00', 'Demi-journée');

-- --------------------------------------------------------

--
-- Structure de la table `plongeur`
--

CREATE TABLE `plongeur` (
  `IdPlongeur` int NOT NULL,
  `NomPlongeur` varchar(50) DEFAULT NULL,
  `PrenomPlongeur` varchar(50) DEFAULT NULL,
  `NiveauPlongeur` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `plongeur`
--

INSERT INTO `plongeur` (`IdPlongeur`, `NomPlongeur`, `PrenomPlongeur`, `NiveauPlongeur`) VALUES
(1, 'Tremblay', 'Marc', 1),
(2, 'Lavoie', 'Catherine', 2),
(3, 'Gagnon', 'Patrick', 1);

-- --------------------------------------------------------

--
-- Structure de la table `pret`
--

CREATE TABLE `pret` (
  `IdPret` int NOT NULL,
  `IdPlongeurPret` int DEFAULT NULL,
  `DemandePret` bit(1) DEFAULT NULL,
  `Date_Pret` date NOT NULL,
  `AutoriserPret` bit(1) DEFAULT NULL,
  `NomMaterielPret` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `siteplonger`
--

CREATE TABLE `siteplonger` (
  `IdSitePlonger` int NOT NULL,
  `NomSitePlonger` varchar(50) DEFAULT NULL,
  `ProfondeurMaxSitePlonger` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `siteplonger`
--

INSERT INTO `siteplonger` (`IdSitePlonger`, `NomSitePlonger`, `ProfondeurMaxSitePlonger`) VALUES
(1, 'Récif corallien', 30),
(2, 'Épave du Titanic', 120),
(3, 'Fosse des Mariannes', 11000);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `materiel`
--
ALTER TABLE `materiel`
  ADD PRIMARY KEY (`IdMateriel`),
  ADD KEY `index_NomMateriel` (`NomMateriel`);

--
-- Index pour la table `niveauxplonger`
--
ALTER TABLE `niveauxplonger`
  ADD PRIMARY KEY (`IdNiveauPlonger`);

--
-- Index pour la table `participantplonger`
--
ALTER TABLE `participantplonger`
  ADD PRIMARY KEY (`DatePlonger`,`IdParticipantPlonger`),
  ADD KEY `FK_Plonger_ParticipantPlonger` (`IdPlongerParticipantPlonger`),
  ADD KEY `FK_Plongeur_ParticipantPlonger` (`IdPlongeurParticipantPlonger`),
  ADD KEY `FK_Personnel_ParticipantPlonger` (`IdPersonnelParticipantPlonger`);

--
-- Index pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`IdPersonnel`);

--
-- Index pour la table `plonger`
--
ALTER TABLE `plonger`
  ADD PRIMARY KEY (`IdPlonger`),
  ADD KEY `IdSitePlonger` (`IdSitePlonger`);

--
-- Index pour la table `plongeur`
--
ALTER TABLE `plongeur`
  ADD PRIMARY KEY (`IdPlongeur`),
  ADD KEY `FK_Niveau` (`NiveauPlongeur`);

--
-- Index pour la table `siteplonger`
--
ALTER TABLE `siteplonger`
  ADD PRIMARY KEY (`IdSitePlonger`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `participantplonger`
--
ALTER TABLE `participantplonger`
  ADD CONSTRAINT `FK_Personnel_ParticipantPlonger` FOREIGN KEY (`IdPersonnelParticipantPlonger`) REFERENCES `personnel` (`IdPersonnel`),
  ADD CONSTRAINT `FK_Plonger_ParticipantPlonger` FOREIGN KEY (`IdPlongerParticipantPlonger`) REFERENCES `plonger` (`IdPlonger`),
  ADD CONSTRAINT `FK_Plongeur_ParticipantPlonger` FOREIGN KEY (`IdPlongeurParticipantPlonger`) REFERENCES `plongeur` (`IdPlongeur`);

--
-- Contraintes pour la table `plonger`
--
ALTER TABLE `plonger`
  ADD CONSTRAINT `plonger_ibfk_1` FOREIGN KEY (`IdSitePlonger`) REFERENCES `siteplonger` (`IdSitePlonger`);

--
-- Contraintes pour la table `plongeur`
--
ALTER TABLE `plongeur`
  ADD CONSTRAINT `FK_Niveau` FOREIGN KEY (`NiveauPlongeur`) REFERENCES `niveauxplonger` (`IdNiveauPlonger`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
