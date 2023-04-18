-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 18, 2023 at 05:03 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbrentalhouse`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblscanned`
--

CREATE TABLE `tblscanned` (
  `ScannedId` int(11) NOT NULL,
  `TenID` int(11) NOT NULL,
  `ImageCaption` varchar(90) NOT NULL,
  `ImageType` varchar(90) NOT NULL,
  `FileLocation` varchar(90) NOT NULL,
  `DateUpload` date NOT NULL,
  `IMGBLOB` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblscanned`
--

INSERT INTO `tblscanned` (`ScannedId`, `TenID`, `ImageCaption`, `ImageType`, `FileLocation`, `DateUpload`, `IMGBLOB`) VALUES
(3, 222, 's.pdf', 'pds', 's.pdf', '2018-08-31', ''),
(4, 1000001, 's.pdf', 'pds', 's.pdf', '2018-08-31', ''),
(5, 222, 's.pdf', 'pds', 's.pdf', '2018-08-31', ''),
(7, 1000001, 's.pdf', 'otr', 's.pdf', '2018-08-31', ''),
(11, 1000001, 'Easy Way to Search Data in ListView Using C.docx', 'pds', 'Easy Way to Search Data in ListView Using C.docx', '2019-05-13', ''),
(12, 222, 'determine the date based on the given days in c#.docx', 'pds', 'determine the date based on the given days in c#.docx', '2019-05-13', ''),
(18, 3333, 'Please_DocuSign_KodeGo_MOA__Participation_D.pdf', 'pds', 'Please_DocuSign_KodeGo_MOA__Participation_D.pdf', '2022-11-29', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbltenant`
--

CREATE TABLE `tbltenant` (
  `ID` int(11) NOT NULL,
  `TenantID` int(11) NOT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `MiddleName` varchar(255) DEFAULT NULL,
  `Occupation` text DEFAULT NULL,
  `PhoneNumber` varchar(255) DEFAULT NULL,
  `EmailAddress` varchar(255) DEFAULT NULL,
  `BirthDate` datetime DEFAULT NULL,
  `PressentAddress` varchar(255) DEFAULT NULL,
  `Gender` varchar(255) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `EMERG_CONTACT` varchar(255) DEFAULT NULL,
  `TPImage` varchar(255) NOT NULL,
  `Status` varchar(90) NOT NULL,
  `DateOfRegistration` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `tbltenant`
--

INSERT INTO `tbltenant` (`ID`, `TenantID`, `LastName`, `FirstName`, `MiddleName`, `Occupation`, `PhoneNumber`, `EmailAddress`, `BirthDate`, `PressentAddress`, `Gender`, `Age`, `EMERG_CONTACT`, `TPImage`, `Status`, `DateOfRegistration`) VALUES
(38, 9909, 'Laurete', 'Susaine', 'Lagra', 'Nursing Student', '09559237562', 'susainerose@gmail.com', '2001-08-08 00:00:00', 'CAgayan de oro City', 'Male', 21, NULL, 'www.YTS.MX.jpg', 'Single', '2022-11-30'),
(28, 456, 'Momo', 'Hirai', 'Tanaka', 'Dancer', '090000000', 'momohirai@gmail.com', '1996-11-09 00:00:00', 'Tokyo Japan', 'Female', 26, NULL, '70de796f0e7e60bff483ae87c9366994.jpg', 'Married ', '2022-11-21'),
(36, 55555, 'Tolentino', 'Clarice', 'Mission', 'Med Tech', '09153019324', 'ClariceJowinTolentino@gmail.com', '1998-11-29 00:00:00', 'Purok 6 Valencia City, Bukidnon', 'Male', 24, NULL, '269620379_703362437494375_7160635411874602531_n.jpg', 'Single', '2022-11-23'),
(33, 3333, 'Abelanio', 'Clyde Richard', 'Laurete', 'IT', '09153019324', 'richardabelanio@gmail.com', '1995-05-14 00:00:00', 'bagontaas, Valencia City, Bukidnon', 'Male', 27, NULL, '5d120f61a57fc0119b589ee1554cd044.jpg', 'Single', '2022-11-23');

-- --------------------------------------------------------

--
-- Table structure for table `tbltenantcontactinfo`
--

CREATE TABLE `tbltenantcontactinfo` (
  `ID` int(11) NOT NULL,
  `TenantID` varchar(255) NOT NULL,
  `LastNameContact` varchar(30) NOT NULL,
  `FirstNameContract` varchar(30) NOT NULL,
  `MiddleNameContract` varchar(30) DEFAULT NULL,
  `OccupationContact` varchar(30) DEFAULT NULL,
  `PhoneNumberContract` text DEFAULT NULL,
  `PressentAddressContract` varchar(1000) DEFAULT NULL,
  `EmailAddressContact` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `tbltenantcontactinfo`
--

INSERT INTO `tbltenantcontactinfo` (`ID`, `TenantID`, `LastNameContact`, `FirstNameContract`, `MiddleNameContract`, `OccupationContact`, `PhoneNumberContract`, `PressentAddressContract`, `EmailAddressContact`) VALUES
(29, '0000000', 'Permanent', 'Teaching', NULL, '2022-11-20', '4444', '44', 'pppp'),
(44, '9909', 'Abelanio', 'Rosalie', 'Laurete', 'Nurse', '09153019324', 'Purok 4A Valencia city, Bukidnon', 'r_abelani@gmail.com'),
(23, '333', 'Contractual', 'Non-Teaching', NULL, '2022-11-20', '888', '888', 'none'),
(20, 'kikier09765', 'Permanent', 'Non-Teaching', NULL, '2022-11-20', '0', '0', 'tttt'),
(19, 'uuuurrr-999', 'Contractual', 'Non-Teaching', NULL, '2022-11-20', '0', '0', 'ttttt'),
(34, '456', 'mmmmmmm', 'mmmmmmmm', 'mmmmm', '2022-11-21', '7777', '777', 'mmmmm'),
(35, 'rrr', 'rrrrrrrr', 'rrrrrrr', 'rrrrrrrr', 'rrrrrr', '8888888', '88888', 'rrrrrrrr'),
(42, '55555', 'iiiii', 'iiiiiiii', 'iiii', 'iiiiiiii', 'iiiiiii', 'iiiiiiii', 'iiiii'),
(39, '3333', 'Abelanio', 'Rosalie', 'Laurete', 'Nurse', '09556772538', 'Bagontaas - 4A, Valencia City Bukidnon, 8709 Philippines', 'r_abelanio@yahoo.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblscanned`
--
ALTER TABLE `tblscanned`
  ADD PRIMARY KEY (`ScannedId`);

--
-- Indexes for table `tbltenant`
--
ALTER TABLE `tbltenant`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `EMPLOYEE_ID` (`TenantID`);

--
-- Indexes for table `tbltenantcontactinfo`
--
ALTER TABLE `tbltenantcontactinfo`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `EMPLOYEE_ID` (`TenantID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblscanned`
--
ALTER TABLE `tblscanned`
  MODIFY `ScannedId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tbltenant`
--
ALTER TABLE `tbltenant`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `tbltenantcontactinfo`
--
ALTER TABLE `tbltenantcontactinfo`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
