-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2024 at 09:13 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cdmregistrarmanagementsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `assignedcourse`
--

CREATE TABLE `assignedcourse` (
  `id` int(100) NOT NULL,
  `instructor_id` varchar(100) NOT NULL,
  `Instructor` varchar(100) NOT NULL,
  `course` varchar(100) NOT NULL,
  `program` varchar(100) NOT NULL,
  `section_1` varchar(100) NOT NULL,
  `section_2` varchar(100) NOT NULL,
  `section_3` varchar(100) NOT NULL,
  `section_4` varchar(100) NOT NULL,
  `section_5` varchar(100) NOT NULL,
  `section_6` varchar(100) NOT NULL,
  `section_7` varchar(100) NOT NULL,
  `section_8` varchar(100) NOT NULL,
  `section_9` varchar(100) NOT NULL,
  `section_10` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `assignedcourse`
--

INSERT INTO `assignedcourse` (`id`, `instructor_id`, `Instructor`, `course`, `program`, `section_1`, `section_2`, `section_3`, `section_4`, `section_5`, `section_6`, `section_7`, `section_8`, `section_9`, `section_10`) VALUES
(13, 'CDM-1111', '', 'ITCOMP', '', 'BSIT-1A', '', '', '', '', '', '', '', '', ''),
(14, 'CDM-1111', '', 'PROG 1', '', 'BSIT-1A', '', '', '', '', '', '', '', '', ''),
(15, 'CDM-1111', '', 'GE 2', '', 'BSIT-1A', '', '', '', '', '', '', '', '', ''),
(16, 'CDM-1111', '', 'GE 1', '', 'BSIT-1A', '', '', '', '', '', '', '', '', ''),
(17, 'CDM-1111', '', 'GE MATH', '', 'BSIT-1A', '', '', '', '', '', '', '', '', ''),
(18, 'CDM-1111', '', 'GE FIL 1', '', 'BSIT-1A', '', '', '', '', '', '', '', '', ''),
(19, 'CDM-1111', '', 'PE 1', '', 'BSIT-1A', '', '', '', '', '', '', '', '', ''),
(20, 'CDM-1111', '', 'NSTP 1', '', 'BSIT-1A', '', '', '', '', '', '', '', '', ''),
(22, 'CDM-1104', '', 'NSTP 2', '', 'BSIT-2C', '', '', '', '', '', '', '', '', ''),
(23, 'CDM-1001', '', 'PE 3', '', 'BSIT-2G', 'BSIT-2G', '', '', '', '', '', '', '', ''),
(24, 'CDM-1002', '', 'GE 5', '', 'BSIT-2H', 'BSIT-2G', '', '', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `bscpe`
--

CREATE TABLE `bscpe` (
  `ID` int(11) NOT NULL,
  `Student ID` varchar(100) NOT NULL,
  `Student Name` varchar(100) NOT NULL,
  `Program` varchar(100) NOT NULL,
  `Year` varchar(100) NOT NULL,
  `Semester` varchar(100) NOT NULL,
  `Section` varchar(100) NOT NULL,
  `SUBJECT 1` double NOT NULL,
  `SUBJECT 2` double NOT NULL,
  `SUBJECT 3` double NOT NULL,
  `SUBJECT 4` double NOT NULL,
  `SUBJECT 5` double NOT NULL,
  `SUBJECT 6` double NOT NULL,
  `PE 1` double NOT NULL,
  `NSTP 1` double NOT NULL,
  `1st Year 1st Sem GWA` double NOT NULL,
  `SUBJECT 7` double NOT NULL,
  `SUBJECT 8` double NOT NULL,
  `SUBJECT 9` double NOT NULL,
  `SUBJECT 10` double NOT NULL,
  `SUBJECT 11` double NOT NULL,
  `SUBJECT 12` double NOT NULL,
  `PE 2` double NOT NULL,
  `NSTP 2` double NOT NULL,
  `1st Year 2nd Sem GWA` double NOT NULL,
  `SUBJECT 13` double NOT NULL,
  `SUBJECT 14` double NOT NULL,
  `SUBJECT 15` double NOT NULL,
  `SUBJECT 16` double NOT NULL,
  `SUBJECT 17` double NOT NULL,
  `SUBJECT 18` double NOT NULL,
  `SUBJECT 19` double NOT NULL,
  `PE 3` double NOT NULL,
  `2nd Year 1st Sem GWA` double NOT NULL,
  `SUBJECT 20` double NOT NULL,
  `SUBJECT 21` double NOT NULL,
  `SUBJECT 22` double NOT NULL,
  `SUBJECT 23` double NOT NULL,
  `SUBJECT 24` double NOT NULL,
  `SUBJECT 25` double NOT NULL,
  `SUBJECT 26` double NOT NULL,
  `PE 4` double NOT NULL,
  `2nd Year 2nd Sem GWA` double NOT NULL,
  `SUBJECT 27` double NOT NULL,
  `SUBJECT 28` double NOT NULL,
  `SUBJECT 29` double NOT NULL,
  `SUBJECT 30` double NOT NULL,
  `SUBJECT 31` double NOT NULL,
  `SUBJECT 32` double NOT NULL,
  `SUBJECT 33` double NOT NULL,
  `SUBJECT 34` double NOT NULL,
  `3rd Year 1st Sem GWA` double NOT NULL,
  `SUBJECT 35` double NOT NULL,
  `SUBJECT 36` double NOT NULL,
  `SUBJECT 37` double NOT NULL,
  `SUBJECT 38` double NOT NULL,
  `SUBJECT 39` double NOT NULL,
  `SUBJECT 40` double NOT NULL,
  `SUBJECT 41` double NOT NULL,
  `SUBJECT 42` double NOT NULL,
  `3rd Year 2nd Sem GWA` double NOT NULL,
  `SUBJECT 43` double NOT NULL,
  `SUBJECT 44` double NOT NULL,
  `SUBJECT 45` double NOT NULL,
  `SUBJECT 46` double NOT NULL,
  `SUBJECT 47` double NOT NULL,
  `SUBJECT 48` double NOT NULL,
  `SUBJECT 49` double NOT NULL,
  `SUBJECT 50` double NOT NULL,
  `4th Year 1st Sem GWA` double NOT NULL,
  `SUBJECT 51` double NOT NULL,
  `SUBJECT 52` double NOT NULL,
  `SUBJECT 53` double NOT NULL,
  `SUBJECT 54` double NOT NULL,
  `SUBJECT 55` double NOT NULL,
  `SUBJECT 56` double NOT NULL,
  `SUBJECT 57` double NOT NULL,
  `SUBJECT 58` double NOT NULL,
  `4th Year 2nd Sem GWA` double NOT NULL,
  `Email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bscpe`
--

INSERT INTO `bscpe` (`ID`, `Student ID`, `Student Name`, `Program`, `Year`, `Semester`, `Section`, `SUBJECT 1`, `SUBJECT 2`, `SUBJECT 3`, `SUBJECT 4`, `SUBJECT 5`, `SUBJECT 6`, `PE 1`, `NSTP 1`, `1st Year 1st Sem GWA`, `SUBJECT 7`, `SUBJECT 8`, `SUBJECT 9`, `SUBJECT 10`, `SUBJECT 11`, `SUBJECT 12`, `PE 2`, `NSTP 2`, `1st Year 2nd Sem GWA`, `SUBJECT 13`, `SUBJECT 14`, `SUBJECT 15`, `SUBJECT 16`, `SUBJECT 17`, `SUBJECT 18`, `SUBJECT 19`, `PE 3`, `2nd Year 1st Sem GWA`, `SUBJECT 20`, `SUBJECT 21`, `SUBJECT 22`, `SUBJECT 23`, `SUBJECT 24`, `SUBJECT 25`, `SUBJECT 26`, `PE 4`, `2nd Year 2nd Sem GWA`, `SUBJECT 27`, `SUBJECT 28`, `SUBJECT 29`, `SUBJECT 30`, `SUBJECT 31`, `SUBJECT 32`, `SUBJECT 33`, `SUBJECT 34`, `3rd Year 1st Sem GWA`, `SUBJECT 35`, `SUBJECT 36`, `SUBJECT 37`, `SUBJECT 38`, `SUBJECT 39`, `SUBJECT 40`, `SUBJECT 41`, `SUBJECT 42`, `3rd Year 2nd Sem GWA`, `SUBJECT 43`, `SUBJECT 44`, `SUBJECT 45`, `SUBJECT 46`, `SUBJECT 47`, `SUBJECT 48`, `SUBJECT 49`, `SUBJECT 50`, `4th Year 1st Sem GWA`, `SUBJECT 51`, `SUBJECT 52`, `SUBJECT 53`, `SUBJECT 54`, `SUBJECT 55`, `SUBJECT 56`, `SUBJECT 57`, `SUBJECT 58`, `4th Year 2nd Sem GWA`, `Email`) VALUES
(7, '22-12422', 'Leonel Messi', 'BSCPE', '4th Year', '1st Sem', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1.25, 1.5, 1, 1, 1.09, 1, 1, 1, 1, 1, 1, 1, 1, 1, ''),
(8, '22-11235', 'Neymar Jr.', 'BSCPE', '3rd Year', '1st Sem', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1.5, 1, 1.25, 1.75, 2.5, 1.38, 1, 1, 1, 1, 1, 1, 1, 0, 0.88, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, ''),
(13, '22-54041', 'Mbappe', 'BSCPE', '2nd Year', '1st Sem', '', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 1, 2, 1, 1.25, 0, 1.32, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, ''),
(14, '22-00134', 'Haaland', 'BSCPE', '1st Year', '1st Sem', '', 1, 2, 1.25, 1.5, 1.5, 1.25, 0, 0, 1.42, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `bsit`
--

CREATE TABLE `bsit` (
  `ID` int(11) NOT NULL,
  `Student ID` varchar(100) NOT NULL,
  `Student Name` varchar(100) NOT NULL,
  `Program` varchar(100) NOT NULL,
  `Year` varchar(100) NOT NULL,
  `Semester` varchar(100) NOT NULL,
  `Section` varchar(100) NOT NULL,
  `ITCOMP` double NOT NULL,
  `PROG 1` double NOT NULL,
  `GE 2` double NOT NULL,
  `GE MATH` double NOT NULL,
  `GE 1` double NOT NULL,
  `GE FIL 1` double NOT NULL,
  `PE 1` double NOT NULL,
  `NSTP 1` double NOT NULL,
  `1st Year 1st Sem GWA` double NOT NULL,
  `DISCRETE` double NOT NULL,
  `PROG 2` double NOT NULL,
  `GE 3` double NOT NULL,
  `HUM` double NOT NULL,
  `GE FIL 2` double NOT NULL,
  `GEEL 2` double NOT NULL,
  `PE 2` double NOT NULL,
  `NSTP 2` double NOT NULL,
  `1st Year 2nd Sem GWA` double NOT NULL,
  `PROG 3` double NOT NULL,
  `ELECT 1` double NOT NULL,
  `GE 4` double NOT NULL,
  `GE 12` double NOT NULL,
  `SIA 1` double NOT NULL,
  `SP` double NOT NULL,
  `GE SCI` double NOT NULL,
  `PE 3` double NOT NULL,
  `2nd Year 1st Sem GWA` double NOT NULL,
  `ACSS` double NOT NULL,
  `ELECT 2` double NOT NULL,
  `NET 1` double NOT NULL,
  `GE 5` double NOT NULL,
  `FUDBS` double NOT NULL,
  `SSD` double NOT NULL,
  `IPTECH` double NOT NULL,
  `PE 4` double NOT NULL,
  `2nd Year 2nd Sem GWA` double NOT NULL,
  `NET 2` double NOT NULL,
  `IM 1` double NOT NULL,
  `APPSDEV 1` double NOT NULL,
  `OS` double NOT NULL,
  `IAS 1` double NOT NULL,
  `HCI` double NOT NULL,
  `ADBS` double NOT NULL,
  `ELECT 3` double NOT NULL,
  `3rd Year 1st Sem GWA` double NOT NULL,
  `GE RIZAL` double NOT NULL,
  `IM 2` double NOT NULL,
  `QM` double NOT NULL,
  `SA` double NOT NULL,
  `IAS 2` double NOT NULL,
  `CAPSTONE 1` double NOT NULL,
  `ELECT 4` double NOT NULL,
  `3rd Year 2nd Sem GWA` double NOT NULL,
  `CAPSTONE 2` double NOT NULL,
  `4th Year 1st Sem GWA` double NOT NULL,
  `PRACTICUM` double NOT NULL,
  `4th Year 2nd Sem GWA` double NOT NULL,
  `Email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bsit`
--

INSERT INTO `bsit` (`ID`, `Student ID`, `Student Name`, `Program`, `Year`, `Semester`, `Section`, `ITCOMP`, `PROG 1`, `GE 2`, `GE MATH`, `GE 1`, `GE FIL 1`, `PE 1`, `NSTP 1`, `1st Year 1st Sem GWA`, `DISCRETE`, `PROG 2`, `GE 3`, `HUM`, `GE FIL 2`, `GEEL 2`, `PE 2`, `NSTP 2`, `1st Year 2nd Sem GWA`, `PROG 3`, `ELECT 1`, `GE 4`, `GE 12`, `SIA 1`, `SP`, `GE SCI`, `PE 3`, `2nd Year 1st Sem GWA`, `ACSS`, `ELECT 2`, `NET 1`, `GE 5`, `FUDBS`, `SSD`, `IPTECH`, `PE 4`, `2nd Year 2nd Sem GWA`, `NET 2`, `IM 1`, `APPSDEV 1`, `OS`, `IAS 1`, `HCI`, `ADBS`, `ELECT 3`, `3rd Year 1st Sem GWA`, `GE RIZAL`, `IM 2`, `QM`, `SA`, `IAS 2`, `CAPSTONE 1`, `ELECT 4`, `3rd Year 2nd Sem GWA`, `CAPSTONE 2`, `4th Year 1st Sem GWA`, `PRACTICUM`, `4th Year 2nd Sem GWA`, `Email`) VALUES
(2, '22-00396', 'John Irvin C. Geanga', 'BSIT', '1st Year', '2nd Sem', 'BSIT-1A', 1.5, 1.25, 1, 1.25, 1.75, 1.25, 1.5, 1.5, 1.33, 1.25, 1.5, 1.25, 1.5, 1.75, 1.5, 0, 0, 1.46, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'johnirvingeanga@gmail.com'),
(9, '22-11111', 'Reymark Hintapan', 'BSIT', '2nd Year', '2nd Sem', 'BSIT-2A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1.25, 1.5, 1.25, 1, 0, 1.14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, ''),
(10, '22-12314', 'Monkey D. Luffy', 'BSIT', '3rd Year', '2nd Sem', 'BSIT-3A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1.5, 1.75, 1.5, 1.25, 1.25, 1.75, 2, 1.57, 0, 0, 0, 0, ''),
(12, '20-23222', 'John Loyd Anagap', 'BSIT', '4th Year', '2nd Sem', 'BSIT-4A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1.5, 1.5, ''),
(18, '22-21900', 'Raijen Alfonso', 'BSIT', '2nd Year', '1st Sem', 'BSIT-2G', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1.75, 1, 2, 1.5, 1.25, 1, 2.75, 1, 1.61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'lannuaubreyn@gmail.com'),
(19, '22-00872', 'Edna Sophia Fernandez', 'BSIT', '2nd Year', '2nd Sem', 'BSIT-2H', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1.25, 1.75, 1.5, 1.5, 1.5, 1.5, 1.75, 1.5, 1.54, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'wakwak@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `deanslist`
--

CREATE TABLE `deanslist` (
  `ID` int(11) NOT NULL,
  `Student ID` varchar(100) NOT NULL,
  `Student Name` varchar(100) NOT NULL,
  `Program` varchar(100) NOT NULL,
  `Year` varchar(100) NOT NULL,
  `Semester` varchar(100) NOT NULL,
  `Section` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `instructors`
--

CREATE TABLE `instructors` (
  `id` int(100) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `middlename` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `instructorid` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `contact#` varchar(100) NOT NULL,
  `birthday` date NOT NULL,
  `password` varchar(100) NOT NULL,
  `Status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `instructors`
--

INSERT INTO `instructors` (`id`, `firstname`, `middlename`, `lastname`, `instructorid`, `gender`, `email`, `contact#`, `birthday`, `password`, `Status`) VALUES
(1, 'Reymark', 'N/A', 'Hintapan', 'CDM-1234', 'Male', 'reymarkhintapan@gmail.com', '09396249555', '2024-05-10', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 0),
(2, 'erica', 'cano', 'damaso', 'CDM-0123', 'Female', 'ericajanne@gmail.com', '09123456789', '2024-05-10', '1be2e452b46d7a0d9656bbb1f768e8248eba1b75baed65f5d99eafa948899a6a', 0),
(3, 'el', 'c', 'b', 'CDM-123', 'Female', 'el@gmail.com', '09123456789', '2024-05-10', 'd8e94cad8f38dda51cd605553b93390766d06a82243e3ca1f9db02e360e49a30', 1),
(4, 'John Irvin', 'Chavez', 'Geanga', 'CDM-1111', 'Male', 'johnirvingeanga@gmail.com', '09683061658', '2003-06-30', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(5, 'khelly', 'c', 'garcia', 'CDM-1211', 'Female', 'garcia@gmail.com', '09673421927', '2004-07-11', '814effb92aedbc900e9e3aaf767a192366ccbfe8fd0fda152aa2207f350ea6b6', 0),
(6, 'Itachi', 'N/A', 'Uchiha', 'CDM-0021', 'Male', 'calces@gmail.com', '09888888888', '2024-05-24', '65e84be33532fb784c48129675f9eff3a682b27168c0ea744b2cf58ee02337c5', 1),
(7, 'Rizza', 'N/A', 'brao', 'CDM-1221', 'Female', 'Rizza@gmail.com', '09345665556', '2024-05-15', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1),
(8, 'khelly', 'c', 'garcia', 'CDM-1104', 'Female', 'khelly@gmail.com', '09000000000', '2004-07-11', '97b199e0744663efd83786f2a94a9cc9b4091c071ce756bf79e26edd8f230a4b', 0),
(9, 'aubrey', 'narca', 'lannu', 'CDM-1001', 'Female', 'lannuaubreyn@gmail.com', '09084953109', '2004-10-01', 'a3dbe29f1bb15c00138e10b3d440f7506002a5d753e9f3669c905a314b737142', 1),
(10, 'phia', 'N/A', 'fernandez', 'CDM-1002', 'Female', 'wakwak@gmail.com', '09123456782', '2024-05-20', '80c09222674a0c8c06f8ddb5225973bf99f225f7254bd4b8d564fddb5ef22501', 1);

-- --------------------------------------------------------

--
-- Table structure for table `request`
--

CREATE TABLE `request` (
  `ID` int(11) NOT NULL,
  `Instructor ID` varchar(100) NOT NULL,
  `Instructor Name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assignedcourse`
--
ALTER TABLE `assignedcourse`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bscpe`
--
ALTER TABLE `bscpe`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bsit`
--
ALTER TABLE `bsit`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `instructors`
--
ALTER TABLE `instructors`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `assignedcourse`
--
ALTER TABLE `assignedcourse`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `bscpe`
--
ALTER TABLE `bscpe`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `bsit`
--
ALTER TABLE `bsit`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `instructors`
--
ALTER TABLE `instructors`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `request`
--
ALTER TABLE `request`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
