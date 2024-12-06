-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: nexus_db
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `courses`
--

DROP TABLE IF EXISTS `courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courses` (
  `course_code` varchar(10) NOT NULL,
  `course_title` varchar(256) DEFAULT NULL,
  `curriculum_year` char(4) DEFAULT NULL,
  `course_ware_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES ('BIO101','Anatomy and Physiology','2024',2),('COMP102','Information Management','2024',1),('IT201','Object Oriented Programming','2024',1),('IT999','Quantum Computing','2024',3),('PHAR201','Pharmacology','2024',2);
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departments` (
  `Dept_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Dept_name` varchar(256) NOT NULL,
  PRIMARY KEY (`Dept_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (1,'CCS (College of Computer Studies)'),(2,'CON (College of Nursing)');
/*!40000 ALTER TABLE `departments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grades`
--

DROP TABLE IF EXISTS `grades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grades` (
  `Grade_ID` int(11) NOT NULL AUTO_INCREMENT,
  `course_id` varchar(10) DEFAULT NULL,
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
  `College_grade` decimal(4,0) DEFAULT NULL,
  PRIMARY KEY (`Grade_ID`),
  KEY `Subject_ID` (`course_id`),
  KEY `Student_ID` (`Student_ID`),
  KEY `Prof_ID` (`Prof_ID`),
  CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `courses` (`course_code`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `grades_ibfk_2` FOREIGN KEY (`Student_ID`) REFERENCES `students` (`Student_ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `grades_ibfk_3` FOREIGN KEY (`Prof_ID`) REFERENCES `professor` (`Prof_ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
/*!40000 ALTER TABLE `grades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `professor`
--

DROP TABLE IF EXISTS `professor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `professor` (
  `Prof_ID` varchar(10) NOT NULL,
  `Full_name` varchar(256) NOT NULL,
  PRIMARY KEY (`Prof_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `professor`
--

LOCK TABLES `professor` WRITE;
/*!40000 ALTER TABLE `professor` DISABLE KEYS */;
INSERT INTO `professor` VALUES ('01-00001','Rodolfo Mirabel Jr.');
/*!40000 ALTER TABLE `professor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programs`
--

DROP TABLE IF EXISTS `programs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `programs` (
  `program_id` int(11) NOT NULL,
  `program_name` varchar(256) DEFAULT NULL,
  `Dept_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`program_id`),
  KEY `fk_department` (`Dept_ID`),
  CONSTRAINT `fk_department` FOREIGN KEY (`Dept_ID`) REFERENCES `departments` (`Dept_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programs`
--

LOCK TABLES `programs` WRITE;
/*!40000 ALTER TABLE `programs` DISABLE KEYS */;
INSERT INTO `programs` VALUES (1,'BS in Information Technology',1),(2,'BS in Computer Science',1),(3,'BS in Nursing',2);
/*!40000 ALTER TABLE `programs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `students` (
  `Student_ID` varchar(10) NOT NULL,
  `Full_name` varchar(256) NOT NULL,
  `Year_Section` varchar(50) DEFAULT NULL,
  `program_id` int(11) DEFAULT NULL,
  `courseware_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`Student_ID`),
  KEY `Course_ID` (`program_id`),
  CONSTRAINT `students_ibfk_1` FOREIGN KEY (`program_id`) REFERENCES `programs` (`program_id`),
  CONSTRAINT `students_ibfk_2` FOREIGN KEY (`program_id`) REFERENCES `programs` (`program_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES ('23-00163','Quinto, Christopher','2A',1,1),('23-00165','Nightingale, Florence','Nightingale',3,2);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `User_ID` int(8) NOT NULL AUTO_INCREMENT,
  `User_name` varchar(256) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `User_type` enum('student','professor','admin') NOT NULL,
  PRIMARY KEY (`User_ID`),
  UNIQUE KEY `User_name` (`User_name`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'quinto_christopher','passadmin0713','admin');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-06 19:23:10
