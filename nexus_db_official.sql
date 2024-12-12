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
  `curriculum_year` char(9) DEFAULT NULL,
  `course_ware_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES ('COMP101','Introduction to Computing','2024-2025',1),('COMP102','Fundamentals of Programming(C++)','2024-2025',1),('COMP103','Intermediate Programming (Java)','2024-2025',2),('COMP104','Data Structures and Algorithms','2024-2025',3),('COMP105','Information Management','2024-2025',3),('COMP106','Applications and Development and Emerging Technologies','2024-2025',4),('GE001','Understanding the Self','2024-2025',2),('GE002','Readings in the Philippine History with Indigenous Peoples Education','2024-2025',4),('GE003','The Contemporary World with Peace Education','2022-2023',1),('GE004','Mathematic in the Modern World','2024-2025',1),('GE005','Purposive Communication','2024-2025',2),('GE006','Art Appreciation','2024-2025',1),('GE007','Science, Technology, and Society','2024-2025',2),('GE008','Ethics','2024-2025',3),('GE009','Rizals Life and Works','2024-2025',5),('GEE001','Environmental Science','2024-2025',2),('GEE002','Living in the IT Era','2024-2025',3),('IT101','Discrete Mathematics','2024-2025',2),('IT102','Quantitative Methods','2024-2025',3),('IT103','Advanced Database Systems','2024-2025',4),('IT104','Integrative Programming and Technologies I','2024-2025',4),('IT105','Networking I','2024-2025',4),('IT106','Systems Integration and Architecture I','2024-2025',5),('IT107','Networking II','2024-2025',5),('IT108','Information Assurance and Security I','2024-2025',6),('IT109','Introduction to Human Computer Interaction','2024-2025',6),('IT110','Social and Professional Issues','2024-2025',6),('IT111','IT Capstone Project I','2024-2025',6),('IT112','Information Assurance and Security II','2024-2025',6),('IT113','System Administration','2024-2025',7),('IT114','IT Capstone Project II','2024-2025',7),('IT115','On-the-Job Training (486 hours)','2024-2025',8),('IT201','IT Elective: Platform Technologies','2024-2025',3),('IT202','IT Elective: Object Oriented Programming (VB.NET)','2024-2025',3),('IT203','IT Elective: Integrative Programming and Technologies II','2024-2025',6),('IT204','IT Elective: Systems Integration and Architecture II','2024-2025',7),('IT301','Web Programming','2024-2025',4),('IT302','Software Engineering','2024-2025',5),('IT303','Technopreneurship','2024-2025',5),('IT304','IT Professional Ethics','2024-2025',5),('IT305','Web Development','2024-2025',5),('IT306','Multimedia and Technologies','2024-2025',6),('NSTP101','National Service Training Program (CWTS)','2024-2025',1),('NSTP102','National Service Training Program (CWTS)','2024-2025',2),('PE101','Wellness and Fitness','2024-2025',1),('PE102','Self-Defense','2024-2025',2),('PE103','Individual/Dual Games and Sports','2024-2025',3),('PE104','Team Games and Sports','2024-2025',4);
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (1,'CCS (College of Computer Studies)'),(2,'CON (College of Nursing)'),(3,'CAS (College of Arts and Sciences)');
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
  `Midterm_grade` decimal(4,2) DEFAULT NULL,
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
  `Finals_grade` decimal(4,2) DEFAULT NULL,
  `Semestral_grade` decimal(4,2) DEFAULT NULL,
  `Semester` varchar(50) DEFAULT NULL,
  `College_grade` decimal(4,2) DEFAULT NULL,
  `remarks` enum('PASSED','FAILED') DEFAULT NULL,
  PRIMARY KEY (`Grade_ID`),
  KEY `Subject_ID` (`course_id`),
  KEY `Student_ID` (`Student_ID`),
  KEY `Prof_ID` (`Prof_ID`),
  CONSTRAINT `fk_grades_students` FOREIGN KEY (`Student_ID`) REFERENCES `students` (`Student_ID`),
  CONSTRAINT `grades_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `courses` (`course_code`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grades`
--

LOCK TABLES `grades` WRITE;
/*!40000 ALTER TABLE `grades` DISABLE KEYS */;
INSERT INTO `grades` VALUES (1,'COMP104','23-00001','01-0000002',90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,94.50,'1st Semester',1.25,'PASSED'),(2,'COMP104','23-00002','01-0000002',90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,94.50,'1st Semester',1.25,'PASSED'),(3,'IT101','23-00163','01-0000002',90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,94.50,'1st Semester',1.25,'PASSED'),(4,'COMP103','23-00163','01-0000001',90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,94.50,'1st Semester',1.25,'PASSED'),(5,'GE001','23-00163','01-0000003',90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,94.50,'1st Semester',1.25,'PASSED'),(6,'GE005','23-00163','01-0000004',99,99,99,99,99,0,0,0,0,100,100,100,99,99,99,99,99,100,99.45,99,99,99,99,99,0,0,0,0,100,100,100,99,99,99,99,99,100,99.45,99.45,'1st Semester',1.00,'PASSED'),(7,'GE007','23-00163','01-0000005',90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,94.50,'1st Semester',1.25,'PASSED'),(8,'GEE001','23-00163','01-0000006',90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,94.50,'1st Semester',1.25,'PASSED'),(9,'NSTP102','23-00163','01-0000007',90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,94.50,'1st Semester',1.25,'PASSED'),(10,'PE102','23-00163','01-0000008',90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,90,90,90,90,90,0,0,0,0,100,100,100,90,90,90,90,90,100,94.50,94.50,'1st Semester',1.25,'PASSED');
/*!40000 ALTER TABLE `grades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `professors`
--

DROP TABLE IF EXISTS `professors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `professors` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Prof_ID` varchar(10) NOT NULL,
  `Prof_name` varchar(256) DEFAULT NULL,
  `dept_id` int(11) DEFAULT NULL,
  `course_handling` varchar(10) DEFAULT NULL,
  `user_id` int(11) NOT NULL,
  `section_handling` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_dept_id` (`dept_id`),
  KEY `fk_course_handling` (`course_handling`),
  KEY `fk_professor_user` (`user_id`),
  CONSTRAINT `fk_course_handling` FOREIGN KEY (`course_handling`) REFERENCES `courses` (`course_code`),
  CONSTRAINT `fk_dept_id` FOREIGN KEY (`dept_id`) REFERENCES `departments` (`Dept_ID`),
  CONSTRAINT `fk_professor_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`User_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `professors`
--

LOCK TABLES `professors` WRITE;
/*!40000 ALTER TABLE `professors` DISABLE KEYS */;
INSERT INTO `professors` VALUES (1,'01-0000001','Riegie D. Tan',1,'COMP103',3,'1A'),(2,'01-0000002','Laura M. Altea',1,'COMP104',4,'2A'),(3,'01-0000002','Laura M. Altea',1,'COMP104',4,'2B'),(5,'01-0000003','Lea S. Velasco',3,'GE001',7,'1A'),(6,'01-0000004','Christian Jay L. Labong',3,'GE005',8,'1A'),(7,'01-0000005','Fidel D. Magday Jr.',3,'GE007',9,'1A'),(8,'01-0000006','Joseph S. Cruz',3,'GEE001',10,'1A'),(9,'01-0000007','Raymundo J. Baui',3,'NSTP102',11,'1A'),(10,'01-0000008','Charito C. Areglo',3,'PE102',12,'1A'),(11,'01-0000002','Laura M. Altea',1,'IT101',4,'1A');
/*!40000 ALTER TABLE `professors` ENABLE KEYS */;
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
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Student_ID` varchar(10) NOT NULL,
  `Full_name` varchar(256) NOT NULL,
  `Year_Section` varchar(50) DEFAULT NULL,
  `program_id` int(11) DEFAULT NULL,
  `course_enrolled` varchar(11) DEFAULT NULL,
  `User_ID` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Course_ID` (`program_id`),
  KEY `fk_student_user` (`User_ID`),
  KEY `fk_students_grades` (`Student_ID`),
  CONSTRAINT `fk_student_user` FOREIGN KEY (`User_ID`) REFERENCES `users` (`User_ID`),
  CONSTRAINT `students_ibfk_1` FOREIGN KEY (`program_id`) REFERENCES `programs` (`program_id`),
  CONSTRAINT `students_ibfk_2` FOREIGN KEY (`program_id`) REFERENCES `programs` (`program_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (2,'23-00001','Goto, Ipei B.','2A',1,'COMP104',2),(3,'23-00001','Goto, Ipei B.','2A',1,'COMP105',2),(4,'23-00001','Goto, Ipei B.','2A',1,'GE008',2),(5,'23-00001','Goto, Ipei B.','2A',1,'GEE002',2),(6,'23-00001','Goto, Ipei B.','2A',1,'IT102',2),(7,'23-00001','Goto, Ipei B.','2A',1,'IT201',2),(8,'23-00001','Goto, Ipei B.','2A',1,'IT202',2),(9,'23-00001','Goto, Ipei B.','2A',1,'PE103',2),(10,'23-00002','Balbacal, Chrisha Mazel F.','2B',1,'COMP104',5),(11,'23-00002','Balbacal, Chrisha Mazel F.','2B',1,'COMP105',5),(12,'23-00002','Balbacal, Chrisha Mazel F.','2B',1,'GE008',5),(13,'23-00002','Balbacal, Chrisha Mazel F.','2B',1,'GEE002',5),(14,'23-00002','Balbacal, Chrisha Mazel F.','2B',1,'IT102',5),(15,'23-00002','Balbacal, Chrisha Mazel F.','2B',1,'IT201',5),(16,'23-00002','Balbacal, Chrisha Mazel F.','2B',1,'IT202',5),(17,'23-00002','Balbacal, Chrisha Mazel F.','2B',1,'PE103',5),(18,'23-00163','Quinto, Christopher A.','1A',1,'COMP101',6),(19,'23-00163','Quinto, Christopher A.','1A',1,'COMP102',6),(20,'23-00163','Quinto, Christopher A.','1A',1,'GE003',6),(21,'23-00163','Quinto, Christopher A.','1A',1,'GE004',6),(22,'23-00163','Quinto, Christopher A.','1A',1,'GE006',6),(23,'23-00163','Quinto, Christopher A.','1A',1,'NSTP101',6),(24,'23-00163','Quinto, Christopher A.','1A',1,'PE101',6);
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
  `recovery_answer` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`User_ID`),
  UNIQUE KEY `User_name` (`User_name`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'quinto_christopher_admin','passadmin','admin','lani angga'),(2,'goto_ipei_plp','pass1','student','answer1'),(3,'tan_riegie_fac','passprof1','professor','answerprof1'),(4,'altea_laura','passprof2','professor','answerprof2'),(5,'balbacal_chrisha_plp','pass2','student','answer2'),(6,'quinto_christopher_plp','pass3','student','Lani Angga'),(7,'velasco_lea_fac','passprof3','professor','answerprof3'),(8,'labong_christian_fac','passprof4','professor','answerprof4'),(9,'magday_fidel_fac','passprof4','professor','answerprof4'),(10,'cruz_joseph_fac','passprof6','professor','answerprof6'),(11,'baui_raymundo_fac','passprof7','professor','answerprof7'),(12,'areglo_charito_fac','passprof8','professor','answerprof8');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vcourse_title`
--

DROP TABLE IF EXISTS `vcourse_title`;
/*!50001 DROP VIEW IF EXISTS `vcourse_title`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vcourse_title` AS SELECT
 1 AS `User_ID`,
  1 AS `User_name`,
  1 AS `User_type`,
  1 AS `Prof_ID`,
  1 AS `Prof_name`,
  1 AS `dept_id`,
  1 AS `course_handling`,
  1 AS `course_title`,
  1 AS `section_handling` */;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vprof_account_info`
--

DROP TABLE IF EXISTS `vprof_account_info`;
/*!50001 DROP VIEW IF EXISTS `vprof_account_info`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vprof_account_info` AS SELECT
 1 AS `User_ID`,
  1 AS `User_name`,
  1 AS `User_type`,
  1 AS `Prof_ID`,
  1 AS `Prof_name`,
  1 AS `dept_id`,
  1 AS `course_handling`,
  1 AS `section_handling` */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vcourse_title`
--

/*!50001 DROP VIEW IF EXISTS `vcourse_title`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vcourse_title` AS select `u`.`User_ID` AS `User_ID`,`u`.`User_name` AS `User_name`,`u`.`User_type` AS `User_type`,`p`.`Prof_ID` AS `Prof_ID`,`p`.`Prof_name` AS `Prof_name`,`p`.`dept_id` AS `dept_id`,`p`.`course_handling` AS `course_handling`,`c`.`course_title` AS `course_title`,`p`.`section_handling` AS `section_handling` from ((`users` `u` join `professors` `p` on(`u`.`User_ID` = `p`.`user_id`)) join `courses` `c` on(`p`.`course_handling` = `c`.`course_code`)) where `u`.`User_type` = 'professor' */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vprof_account_info`
--

/*!50001 DROP VIEW IF EXISTS `vprof_account_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vprof_account_info` AS select `u`.`User_ID` AS `User_ID`,`u`.`User_name` AS `User_name`,`u`.`User_type` AS `User_type`,`p`.`Prof_ID` AS `Prof_ID`,`p`.`Prof_name` AS `Prof_name`,`p`.`dept_id` AS `dept_id`,`p`.`course_handling` AS `course_handling`,`p`.`section_handling` AS `section_handling` from (`users` `u` join `professors` `p` on(`u`.`User_ID` = `p`.`user_id`)) where `u`.`User_type` = 'professor' */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-13  3:32:00
