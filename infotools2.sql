-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Jeu 02 Mai 2024 à 11:47
-- Version du serveur :  5.7.11
-- Version de PHP :  5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `infotools2`
--
CREATE DATABASE IF NOT EXISTS `infotools2` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin;
USE `infotools2`;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `IdCli` int(11) NOT NULL,
  `NomCli` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `PrenomCli` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `MailCli` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `VilleCli` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `NomRueCli` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `CPCli` int(11) DEFAULT NULL,
  `IdProspect` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `client`
--

INSERT INTO `client` (`IdCli`, `NomCli`, `PrenomCli`, `MailCli`, `VilleCli`, `NomRueCli`, `CPCli`, `IdProspect`) VALUES
(1, 'ClientNom1', 'ClientPrenom1', 'client1@example.com', 'Ville1', 'Rue1', 10001, 1),
(2, 'ClientNom2', 'ClientPrenom2', 'client2@example.com', 'Ville2', 'Rue2', 10002, 2),
(3, 'ClientNom3', 'ClientPrenom3', 'client3@example.com', 'Ville3', 'Rue3', 10003, 3),
(4, 'ClientNom4', 'ClientPrenom4', 'client4@example.com', 'Ville4', 'Rue4', 10004, 4),
(5, 'ClientNom5', 'ClientPrenom5', 'client5@example.com', 'Ville5', 'Rue5', 10005, 5),
(6, 'ClientNom6', 'ClientPrenom6', 'client6@example.com', 'Ville6', 'Rue6', 10006, 6),
(7, 'ClientNom7', 'ClientPrenom7', 'client7@example.com', 'Ville7', 'Rue7', 10007, 7),
(8, 'ClientNom8', 'ClientPrenom8', 'client8@example.com', 'Ville8', 'Rue8', 10008, 8),
(9, 'ClientNom9', 'ClientPrenom9', 'client9@example.com', 'Ville9', 'Rue9', 10009, 9),
(10, 'ClientNom10', 'ClientPrenom10', 'client10@example.com', 'Ville10', 'Rue10', 10010, 10);

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

CREATE TABLE `employe` (
  `IdEmp` int(11) NOT NULL,
  `NomEmp` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `PrenomEmp` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `TelEmp` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `MailEmp` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `PosteEmp` varchar(255) COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `employe`
--

INSERT INTO `employe` (`IdEmp`, `NomEmp`, `PrenomEmp`, `TelEmp`, `MailEmp`, `PosteEmp`) VALUES
(1, 'Nom0', 'Prenom0', '0101010101', 'email0@@example.com', 'Poste0'),
(2, 'Nom1', 'Prenom1', '0101010101', 'email1@example.com', 'Poste1'),
(3, 'Nom2', 'Prenom2', '0202020202', 'email2@example.com', 'Poste2'),
(4, 'Nom3', 'Prenom3', '0303030303', 'email3@example.com', 'Poste3'),
(5, 'Nom4', 'Prenom4', '0404040404', 'email4@example.com', 'Poste4'),
(6, 'Nom5', 'Prenom5', '0505050505', 'email5@example.com', 'Poste5'),
(7, 'Nom6', 'Prenom6', '0606060606', 'email6@example.com', 'Poste6'),
(8, 'Nom7', 'Prenom7', '0707070707', 'email7@example.com', 'Poste7'),
(9, 'Nom8', 'Prenom8', '0808080808', 'email8@example.com', 'Poste8'),
(10, 'Nom9', 'Prenom9', '0909090909', 'email9@example.com', 'Poste9'),
(11, 'Nom10', 'Prenom10', '1010101010', 'email10@example.com', 'Poste10');

-- --------------------------------------------------------

--
-- Structure de la table `facture`
--

CREATE TABLE `facture` (
  `IdFac` int(11) NOT NULL,
  `IdCli` int(11) DEFAULT NULL,
  `DateFac` date DEFAULT NULL,
  `Total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `facture`
--

INSERT INTO `facture` (`IdFac`, `IdCli`, `DateFac`, `Total`) VALUES
(1, 1, '2024-04-01', '150.00'),
(2, 2, '2024-04-02', '250.00'),
(3, 3, '2024-04-03', '350.00'),
(4, 4, '2024-04-04', '450.00'),
(5, 5, '2024-04-05', '550.00'),
(6, 6, '2024-04-06', '650.00'),
(7, 7, '2024-04-07', '750.00'),
(8, 8, '2024-04-08', '850.00'),
(9, 9, '2024-04-09', '950.00'),
(10, 10, '2024-04-10', '1050.00');

-- --------------------------------------------------------

--
-- Structure de la table `lignefacture`
--

CREATE TABLE `lignefacture` (
  `IdLigneFac` int(11) NOT NULL,
  `IdFac` int(11) DEFAULT NULL,
  `IdProd` int(11) DEFAULT NULL,
  `Qte` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `lignefacture`
--

INSERT INTO `lignefacture` (`IdLigneFac`, `IdFac`, `IdProd`, `Qte`) VALUES
(1, 1, 1, 1),
(2, 2, 2, 2),
(3, 3, 3, 3),
(4, 4, 4, 4),
(5, 5, 5, 5),
(6, 6, 6, 6),
(7, 7, 7, 7),
(8, 8, 8, 8),
(9, 9, 9, 9),
(10, 10, 10, 10);

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

CREATE TABLE `produit` (
  `IdProd` int(11) NOT NULL,
  `TypeProd` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `PrixProd` decimal(10,2) DEFAULT NULL,
  `NomProd` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `DescProd` text COLLATE utf8_bin
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `produit`
--

INSERT INTO `produit` (`IdProd`, `TypeProd`, `PrixProd`, `NomProd`, `DescProd`) VALUES
(1, 'Type1', '100.00', 'NomProduit1', 'Description du produit 1'),
(2, 'Type2', '200.00', 'NomProduit2', 'Description du produit 2'),
(3, 'Type3', '300.00', 'NomProduit3', 'Description du produit 3'),
(4, 'Type4', '400.00', 'NomProduit4', 'Description du produit 4'),
(5, 'Type5', '500.00', 'NomProduit5', 'Description du produit 5'),
(6, 'Type6', '600.00', 'NomProduit6', 'Description du produit 6'),
(7, 'Type7', '700.00', 'NomProduit7', 'Description du produit 7'),
(8, 'Type8', '800.00', 'NomProduit8', 'Description du produit 8'),
(9, 'Type9', '900.00', 'NomProduit9', 'Description du produit 9'),
(10, 'Type10', '1000.00', 'NomProduit10', 'Description du produit 10');

-- --------------------------------------------------------

--
-- Structure de la table `rdv`
--

CREATE TABLE `rdv` (
  `IdRdv` int(11) NOT NULL,
  `IdCli` int(11) DEFAULT NULL,
  `IdEmp` int(11) DEFAULT NULL,
  `DateRdv` date DEFAULT NULL,
  `HeureRdv` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Contenu de la table `rdv`
--

INSERT INTO `rdv` (`IdRdv`, `IdCli`, `IdEmp`, `DateRdv`, `HeureRdv`) VALUES
(3, 3, 3, '2024-03-03', '11:00:00'),
(6, 6, 6, '2024-03-06', '14:00:00'),
(7, 7, 7, '2024-03-07', '15:00:00'),
(8, 8, 8, '2024-03-08', '16:00:00'),
(9, 9, 9, '2024-03-09', '17:00:00');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`IdCli`);

--
-- Index pour la table `employe`
--
ALTER TABLE `employe`
  ADD PRIMARY KEY (`IdEmp`);

--
-- Index pour la table `facture`
--
ALTER TABLE `facture`
  ADD PRIMARY KEY (`IdFac`),
  ADD KEY `IdCli` (`IdCli`);

--
-- Index pour la table `lignefacture`
--
ALTER TABLE `lignefacture`
  ADD PRIMARY KEY (`IdLigneFac`),
  ADD KEY `IdFac` (`IdFac`),
  ADD KEY `IdProd` (`IdProd`);

--
-- Index pour la table `produit`
--
ALTER TABLE `produit`
  ADD PRIMARY KEY (`IdProd`);

--
-- Index pour la table `rdv`
--
ALTER TABLE `rdv`
  ADD PRIMARY KEY (`IdRdv`),
  ADD KEY `IdCli` (`IdCli`),
  ADD KEY `IdEmp` (`IdEmp`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `client`
--
ALTER TABLE `client`
  MODIFY `IdCli` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT pour la table `employe`
--
ALTER TABLE `employe`
  MODIFY `IdEmp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT pour la table `facture`
--
ALTER TABLE `facture`
  MODIFY `IdFac` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT pour la table `lignefacture`
--
ALTER TABLE `lignefacture`
  MODIFY `IdLigneFac` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT pour la table `produit`
--
ALTER TABLE `produit`
  MODIFY `IdProd` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT pour la table `rdv`
--
ALTER TABLE `rdv`
  MODIFY `IdRdv` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `facture`
--
ALTER TABLE `facture`
  ADD CONSTRAINT `facture_ibfk_1` FOREIGN KEY (`IdCli`) REFERENCES `client` (`IdCli`);

--
-- Contraintes pour la table `lignefacture`
--
ALTER TABLE `lignefacture`
  ADD CONSTRAINT `lignefacture_ibfk_1` FOREIGN KEY (`IdFac`) REFERENCES `facture` (`IdFac`),
  ADD CONSTRAINT `lignefacture_ibfk_2` FOREIGN KEY (`IdProd`) REFERENCES `produit` (`IdProd`);

--
-- Contraintes pour la table `rdv`
--
ALTER TABLE `rdv`
  ADD CONSTRAINT `rdv_ibfk_1` FOREIGN KEY (`IdCli`) REFERENCES `client` (`IdCli`),
  ADD CONSTRAINT `rdv_ibfk_2` FOREIGN KEY (`IdEmp`) REFERENCES `employe` (`IdEmp`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
