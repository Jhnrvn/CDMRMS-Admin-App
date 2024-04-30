-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 30, 2024 at 03:47 AM
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
  `section_3` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `assignedcourse`
--

INSERT INTO `assignedcourse` (`id`, `instructor_id`, `Instructor`, `course`, `section_1`, `section_2`, `section_3`) VALUES
(1, 'CDM-1111', 'Geanga, John Irvin C.', 'IT ELECT', 'BSIT-2A', 'BSIT-2B', 'BSIT-2C'),
(2, 'CDM-2222', '', 'SSDEV', '', '', ''),
(3, 'CDM-3333', '', 'FUDBS', '', '', ''),
(4, 'CDM-4444', '', 'IP TECH', '', '', ''),
(5, 'CDM-4444', '', 'ADM', '', '', ''),
(6, 'CDM-1010', '', 'PROG 2', '', '', ''),
(7, 'CDM-1111', 'Geanga, John Irvin C.', 'SIA 2', '', '', ''),
(8, 'CDM-1111', 'Geanga, John Irvin C.', 'GE 1', '', '', ''),
(9, 'CDM-1111', 'Geanga, John Irvin C.', 'GE 4', '', '', '');

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
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `instructors`
--

INSERT INTO `instructors` (`id`, `firstname`, `middlename`, `lastname`, `instructorid`, `gender`, `email`, `contact#`, `birthday`, `password`) VALUES
(1, 'John Irvin', 'N/A', 'Geanga', 'CDM-1111', 'Male', 'johnirvingeanga@gmail.com', '09111111111', '2024-04-24', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4'),
(2, 'Matt', 'N/A', 'Lawson', 'CDM-2222', 'Male', 'sample@gmail.com', '09222222222', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4'),
(3, 'Raymond', 'N/A', 'Linwood', 'CDM-3333', 'Male', 'sample@gmail.com', '09333333333', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4'),
(4, 'Jordyn', 'N/A', 'leo', 'CDM-4444', 'Male', 'sample@gmail.com', '09444444444', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4'),
(5, 'Sherie', 'N/A', 'Kali', 'CDM-5555', 'Female', 'sample@gmail.com', '09555555555', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4'),
(6, 'Silvia', 'N/A', 'Marty', 'CDM-6666', 'Female', 'sample@gmail.com', '09666666666', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4'),
(7, 'Edith', 'N/A', 'Bernadette', 'CDM-7777', 'Female', 'sample@gmail.com', '09777777777', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4'),
(8, 'Cydney', 'N/A', 'Kris', 'CDM-8888', 'Female', 'sample@gmail.com', '09888888888', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4'),
(9, 'Catherin', 'N/A', 'Shonda', 'CDM-9999', 'Female', 'sample@gmail.com', '09999999999', '2024-04-26', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4'),
(14, 'Max', 'N/A', 'Collins', 'CDM-1010', 'Male', 'sample@gmail.com', '09101010101', '2024-04-28', '938db8c9f82c8cb58d3f3ef4fd250036a48d26a712753d2fde5abd03a85cabf4');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assignedcourse`
--
ALTER TABLE `assignedcourse`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `instructors`
--
ALTER TABLE `instructors`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `assignedcourse`
--
ALTER TABLE `assignedcourse`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `instructors`
--
ALTER TABLE `instructors`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
