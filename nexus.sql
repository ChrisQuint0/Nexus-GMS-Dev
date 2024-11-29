-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 29, 2024 at 01:43 PM
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
-- Database: `nexus`
--

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `Course_ID` int(8) NOT NULL,
  `Course_name` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`Course_ID`, `Course_name`) VALUES
(1, 'BS in Information Technology');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `Dept_ID` int(10) NOT NULL,
  `Dept_name` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`Dept_ID`, `Dept_name`) VALUES
(1, 'College of Computer Studies');

-- --------------------------------------------------------

--
-- Table structure for table `grades`
--

CREATE TABLE `grades` (
  `Grade_ID` int(8) NOT NULL,
  `Subject_ID` varchar(10) NOT NULL,
  `Student_ID` varchar(10) NOT NULL,
  `Prof_ID` varchar(10) NOT NULL,
  `Midterm_attendance` int(4) DEFAULT NULL,
  `Midterm_quiz_1` int(4) DEFAULT NULL,
  `Midterm_quiz_1_total` int(4) DEFAULT NULL,
  `Midterm_quiz_2` int(4) DEFAULT NULL,
  `Midterm_quiz_2_total` int(4) DEFAULT NULL,
  `Midterm_quiz_3` int(4) DEFAULT NULL,
  `Midterm_quiz_3_total` int(4) DEFAULT NULL,
  `Midterm_quiz_4` int(4) DEFAULT NULL,
  `Midterm_quiz_4_total` int(4) DEFAULT NULL,
  `Midterm_quiz_total` int(4) DEFAULT NULL,
  `Midterm_quiz_items` int(4) DEFAULT NULL,
  `Midterm_quiz_grade` int(4) DEFAULT NULL,
  `Midterm_lab` int(4) DEFAULT NULL,
  `Midterm_recitation` int(4) DEFAULT NULL,
  `Midterm_casestudy` int(4) DEFAULT NULL,
  `Midterm_exam` int(4) DEFAULT NULL,
  `Midterm_exam_items` int(4) DEFAULT NULL,
  `Midterm_exam_grade` int(4) DEFAULT NULL,
  `Midterm_grade` int(4) DEFAULT NULL,
  `Finals_attendance` int(4) DEFAULT NULL,
  `Finals_quiz_1` int(4) DEFAULT NULL,
  `Finals_quiz_1_total` int(4) DEFAULT NULL,
  `Finals_quiz_2` int(4) DEFAULT NULL,
  `Finals_quiz_2_total` int(4) DEFAULT NULL,
  `Finals_quiz_3` int(4) DEFAULT NULL,
  `Finals_quiz_3_total` int(4) DEFAULT NULL,
  `Finals_quiz_4` int(4) DEFAULT NULL,
  `Finals_quiz_4_total` int(4) DEFAULT NULL,
  `Finals_quiz_total` int(4) DEFAULT NULL,
  `Finals_quiz_items` int(4) DEFAULT NULL,
  `Finals_quiz_grade` int(4) DEFAULT NULL,
  `Finals_lab` int(4) DEFAULT NULL,
  `Finals_recitation` int(4) DEFAULT NULL,
  `Finals_casestudy` int(4) DEFAULT NULL,
  `Finals_exam` int(4) DEFAULT NULL,
  `Finals_exam_items` int(4) DEFAULT NULL,
  `Finals_exam_grade` int(4) DEFAULT NULL,
  `Finals_grade` int(4) DEFAULT NULL,
  `Semestral_grade` decimal(4,0) DEFAULT NULL,
  `Semester` varchar(50) DEFAULT NULL,
  `College_grade` decimal(4,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `grades`
--

INSERT INTO `grades` (`Grade_ID`, `Subject_ID`, `Student_ID`, `Prof_ID`, `Midterm_attendance`, `Midterm_quiz_1`, `Midterm_quiz_1_total`, `Midterm_quiz_2`, `Midterm_quiz_2_total`, `Midterm_quiz_3`, `Midterm_quiz_3_total`, `Midterm_quiz_4`, `Midterm_quiz_4_total`, `Midterm_quiz_total`, `Midterm_quiz_items`, `Midterm_quiz_grade`, `Midterm_lab`, `Midterm_recitation`, `Midterm_casestudy`, `Midterm_exam`, `Midterm_exam_items`, `Midterm_exam_grade`, `Midterm_grade`, `Finals_attendance`, `Finals_quiz_1`, `Finals_quiz_1_total`, `Finals_quiz_2`, `Finals_quiz_2_total`, `Finals_quiz_3`, `Finals_quiz_3_total`, `Finals_quiz_4`, `Finals_quiz_4_total`, `Finals_quiz_total`, `Finals_quiz_items`, `Finals_quiz_grade`, `Finals_lab`, `Finals_recitation`, `Finals_casestudy`, `Finals_exam`, `Finals_exam_items`, `Finals_exam_grade`, `Finals_grade`, `Semestral_grade`, `Semester`, `College_grade`) VALUES
(1, 'IT101', '23-00163', '01-00001', 100, 43, 50, 35, 50, NULL, NULL, NULL, NULL, 93, 100, 89, 95, 95, 98, 78, 90, 93, 94, 100, 43, 50, 35, 50, NULL, NULL, NULL, NULL, 93, 100, 89, 95, 95, 98, 78, 90, 93, 94, 94, '1st Semester', 2);

-- --------------------------------------------------------

--
-- Table structure for table `professor`
--

CREATE TABLE `professor` (
  `Prof_ID` varchar(10) NOT NULL,
  `Full_name` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `professor`
--

INSERT INTO `professor` (`Prof_ID`, `Full_name`) VALUES
('01-00001', 'Rodolfo Mirabel Jr.');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `Student_ID` varchar(10) NOT NULL,
  `Full_name` varchar(256) NOT NULL,
  `Year_Section` varchar(50) DEFAULT NULL,
  `Course_ID` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`Student_ID`, `Full_name`, `Year_Section`, `Course_ID`) VALUES
('23-00163', 'Dela Cruz, Juan', '2A', 1);

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `Subject_ID` varchar(10) NOT NULL,
  `Subject_name` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`Subject_ID`, `Subject_name`) VALUES
('IT101', 'Object Oriented Programming');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `User_ID` int(8) NOT NULL,
  `User_name` varchar(256) NOT NULL,
  `Password` int(8) NOT NULL,
  `User_type` enum('student','professor','admin') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`User_ID`, `User_name`, `Password`, `User_type`) VALUES
(1, 'superAdmin', 0, 'admin'),
(2, 'quinto_christopher', 0, 'student'),
(3, 'mirabel_rodolfo', 0, 'professor');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`Course_ID`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`Dept_ID`);

--
-- Indexes for table `grades`
--
ALTER TABLE `grades`
  ADD PRIMARY KEY (`Grade_ID`),
  ADD KEY `Subject_ID` (`Subject_ID`),
  ADD KEY `Student_ID` (`Student_ID`),
  ADD KEY `Prof_ID` (`Prof_ID`);

--
-- Indexes for table `professor`
--
ALTER TABLE `professor`
  ADD PRIMARY KEY (`Prof_ID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`Student_ID`),
  ADD KEY `Course_ID` (`Course_ID`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`Subject_ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`User_ID`),
  ADD UNIQUE KEY `User_name` (`User_name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `User_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `grades`
--
ALTER TABLE `grades`
  ADD CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`Subject_ID`) REFERENCES `subjects` (`Subject_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`Student_ID`) REFERENCES `student` (`Student_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `grades_ibfk_3` FOREIGN KEY (`Prof_ID`) REFERENCES `professor` (`Prof_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `student_ibfk_1` FOREIGN KEY (`Course_ID`) REFERENCES `courses` (`Course_ID`),
  ADD CONSTRAINT `student_ibfk_2` FOREIGN KEY (`Course_ID`) REFERENCES `courses` (`Course_ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
