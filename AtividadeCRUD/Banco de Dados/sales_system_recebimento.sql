CREATE DATABASE  IF NOT EXISTS `sales_system` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `sales_system`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: sales_system
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `recebimento`
--

DROP TABLE IF EXISTS `recebimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recebimento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `valor` double DEFAULT NULL,
  `vencimento` datetime DEFAULT NULL,
  `data_pagamento` datetime DEFAULT NULL,
  `status_recebimento` tinyint(1) DEFAULT NULL,
  `fk_id_venda` int DEFAULT NULL,
  `fk_id_caixa` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_id_venda` (`fk_id_venda`),
  KEY `fk_id_caixa` (`fk_id_caixa`),
  CONSTRAINT `recebimento_ibfk_1` FOREIGN KEY (`fk_id_venda`) REFERENCES `venda` (`id`),
  CONSTRAINT `recebimento_ibfk_2` FOREIGN KEY (`fk_id_caixa`) REFERENCES `caixa` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recebimento`
--

LOCK TABLES `recebimento` WRITE;
/*!40000 ALTER TABLE `recebimento` DISABLE KEYS */;
INSERT INTO `recebimento` VALUES (1,100,'2024-08-30 00:00:00','2024-07-30 00:00:00',1,2,1),(2,100,'2024-08-30 00:00:00','2024-07-30 00:00:00',1,2,1);
/*!40000 ALTER TABLE `recebimento` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-03 10:31:31
