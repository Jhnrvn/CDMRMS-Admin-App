-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 08, 2024 at 05:55 PM
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

INSERT INTO `assignedcourse` (`id`, `instructor_id`, `Instructor`, `course`, `section_1`, `section_2`, `section_3`, `section_4`, `section_5`, `section_6`, `section_7`, `section_8`, `section_9`, `section_10`) VALUES
(1, 'CDM-1111', 'Geanga, John Irvin', 'PROG 1', 'BSIT-1A', 'BSIT-1B', 'BSIT-1C', '', '', '', '', '', '', ''),
(2, 'CDM-1111', 'Geanga, John Irvin', 'ITCOMP', 'BSIT-1A', 'BSIT-1B', 'BSIT-1C', 'BSIT-1D', '', '', '', '', '', ''),
(3, 'CDM-1111', '', 'GE 2', 'BSIT-1G', '', '', '', '', '', '', '', '', ''),
(4, 'CDM-1111', '', 'GE MATH', 'BSIT-1B', '', '', '', '', '', '', '', '', ''),
(5, 'CDM-1111', '', 'GE 1', 'BSIT-1A', '', '', '', '', '', '', '', '', ''),
(6, 'CDM-1111', '', 'GE FIL 1', 'BSIT-1F', '', '', '', '', '', '', '', '', ''),
(7, 'CDM-1111', '', 'PE 1', 'BSIT-1J', '', '', '', '', '', '', '', '', ''),
(8, 'CDM-1111', '', 'NSTP 1', 'BSIT-1E', '', '', '', '', '', '', '', '', ''),
(9, 'CDM-1111', 'Geanga, John Irvin', 'ELECT 1', 'BSIT-2C', '', '', '', '', '', '', '', '', ''),
(10, '', '', '', '', '', '', '', '', '', '', '', '', '');

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
  `DISCRETE` double NOT NULL,
  `PROG 2` double NOT NULL,
  `GE 3` double NOT NULL,
  `HUM` double NOT NULL,
  `GE FIL 2` double NOT NULL,
  `GEEL 2` double NOT NULL,
  `PE 2` double NOT NULL,
  `NSTP 2` double NOT NULL,
  `PROG 3` double NOT NULL,
  `ELECT 1` double NOT NULL,
  `GE 4` double NOT NULL,
  `GE 12` double NOT NULL,
  `SIA 1` double NOT NULL,
  `SP` double NOT NULL,
  `GE SCI` double NOT NULL,
  `PE 3` double NOT NULL,
  `ACSS` double NOT NULL,
  `ELECT 2` double NOT NULL,
  `NET` double NOT NULL,
  `GE 5` double NOT NULL,
  `FUBDS` double NOT NULL,
  `SSD` double NOT NULL,
  `IPTECH` double NOT NULL,
  `PE 4` double NOT NULL,
  `NET 2` double NOT NULL,
  `IM 1` double NOT NULL,
  `APPSDEV 1` double NOT NULL,
  `OS` double NOT NULL,
  `IAS 1` double NOT NULL,
  `HCI` double NOT NULL,
  `ADBS` double NOT NULL,
  `ELECT 3` double NOT NULL,
  `GE RIZAL` double NOT NULL,
  `IM 2` double NOT NULL,
  `QM` double NOT NULL,
  `SA` double NOT NULL,
  `IAS 2` double NOT NULL,
  `CAPSTONE 1` double NOT NULL,
  `ELECT 4` double NOT NULL,
  `CAPSTONE 2` double NOT NULL,
  `PRACTICUM` double NOT NULL,
  `1st Year 1st Sem GWA` double NOT NULL,
  `1st Year 2nd Sem GWA` double NOT NULL,
  `2nd Year 1st Sem GWA` double NOT NULL,
  `2nd Year 2nd Sem GWA` double NOT NULL,
  `3rd Year 1st Sem GWA` double NOT NULL,
  `3rd Year 2nd Sem GWA` double NOT NULL,
  `4th Year 1st Sem GWA` double NOT NULL,
  `4th Year 2nd Sem GWA` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bsit`
--

INSERT INTO `bsit` (`ID`, `Student ID`, `Student Name`, `Program`, `Year`, `Semester`, `Section`, `ITCOMP`, `PROG 1`, `GE 2`, `GE MATH`, `GE 1`, `GE FIL 1`, `PE 1`, `NSTP 1`, `DISCRETE`, `PROG 2`, `GE 3`, `HUM`, `GE FIL 2`, `GEEL 2`, `PE 2`, `NSTP 2`, `PROG 3`, `ELECT 1`, `GE 4`, `GE 12`, `SIA 1`, `SP`, `GE SCI`, `PE 3`, `ACSS`, `ELECT 2`, `NET`, `GE 5`, `FUBDS`, `SSD`, `IPTECH`, `PE 4`, `NET 2`, `IM 1`, `APPSDEV 1`, `OS`, `IAS 1`, `HCI`, `ADBS`, `ELECT 3`, `GE RIZAL`, `IM 2`, `QM`, `SA`, `IAS 2`, `CAPSTONE 1`, `ELECT 4`, `CAPSTONE 2`, `PRACTICUM`, `1st Year 1st Sem GWA`, `1st Year 2nd Sem GWA`, `2nd Year 1st Sem GWA`, `2nd Year 2nd Sem GWA`, `3rd Year 1st Sem GWA`, `3rd Year 2nd Sem GWA`, `4th Year 1st Sem GWA`, `4th Year 2nd Sem GWA`) VALUES
(1, '', 'Geanga, John Irvin', 'BSIT', '1st Year', '', 'BSIT-1B', 0, 1.5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, '', 'Geanga', 'BSIT', '1st Year', '', 'BSIT-3A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(3, '', '', 'BSIT', '1st Year', '', 'BSIT-1B', 0, 1.25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(4, '', '', 'BSIT', '1st Year', '', 'BSIT-1B', 0, 1.25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(5, '', '', 'BSIT', '1st Year', '', 'BSIT-1B', 0, 1.75, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(6, '', '', 'BSIT', '1st Year', '', 'BSIT-1B', 0, 1.25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(7, '', '', '', '', '', 'BSIT-1A', 0, 1.5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(8, '', '', '', '', '', 'BSIT-1A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(9, '', '', '', '', '', 'BSIT-1A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(10, '', '', '', '', '', 'BSIT-1A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(11, '', '', '', '', '', 'BSIT-1A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(12, '', '', '', '', '', 'BSIT-1A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(13, '', '', '', '', '', 'BSIT-1A', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

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
(2, 'Matt', 'N/A', 'Lawson', 'CDM-2222', 'Male', 'sample@gmail.com', '09222222222', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(3, 'Raymond', 'N/A', 'Linwood', 'CDM-3333', 'Male', 'sample@gmail.com', '09333333333', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(4, 'Jordyn', 'N/A', 'leo', 'CDM-4444', 'Male', 'sample@gmail.com', '09444444444', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(5, 'Sherie', 'N/A', 'Kali', 'CDM-5555', 'Female', 'sample@gmail.com', '09555555555', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(6, 'Silvia', 'N/A', 'Marty', 'CDM-6666', 'Female', 'sample@gmail.com', '09666666666', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(7, 'Edith', 'N/A', 'Bernadette', 'CDM-7777', 'Female', 'sample@gmail.com', '09777777777', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(8, 'Cydney', 'N/A', 'Kris', 'CDM-8888', 'Female', 'sample@gmail.com', '09888888888', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(9, 'Catherin', 'N/A', 'Shonda', 'CDM-9999', 'Female', 'sample@gmail.com', '09999999999', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(14, 'Max', 'N/A', 'Collins', 'CDM-1010', 'Male', 'sample@gmail.com', '09101010101', '2024-04-28', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(39, 'John Irvin', 'N/A', 'Geanga', 'CDM-1111', 'Male', 'johnirvingeanga@gmail.com', '09683061658', '2024-05-06', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 1),
(41, 'Gina', 'N/A', 'Matxalen', 'CDM-1212', 'Female', 'sample@gmail.com', '09121212121', '2024-05-08', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(42, 'Liese', 'N/A', 'Rosa', 'CDM-1345', 'Female', 'sample@gmail.com', '09456779877', '2024-05-08', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(43, 'Roberto', 'N/A', 'Hecate', 'CDM-0124', 'Male', 'sample@gmail.com', '09583629457', '2024-05-08', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4', 0),
(44, 'Gaia', 'N/A', 'Breanne', 'CDM-0453', 'Female', 'sample@gmail.com', '09476875565', '2024-05-08', '1bad6b8cf97131fceab8543e81f7757195fbb1d36b376ee994ad1cf17699c464', 0);

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
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `bsit`
--
ALTER TABLE `bsit`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `instructors`
--
ALTER TABLE `instructors`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `request`
--
ALTER TABLE `request`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
