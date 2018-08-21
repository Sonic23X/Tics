-- MySQL dump 10.13  Distrib 5.7.23, for Win64 (x86_64)
--
-- Host: localhost    Database: tics
-- ------------------------------------------------------
-- Server version	5.7.23-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `apellidos` varchar(50) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `direccion` varchar(80) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `nombre_organizacion` varchar(45) DEFAULT NULL,
  `ubicacion_organizacion` varchar(80) DEFAULT NULL,
  `telefono_organizacion` int(11) DEFAULT NULL,
  `cargo_organizacion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(40) DEFAULT NULL,
  `apellidos` varchar(50) DEFAULT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `sexo` enum('M','F') DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `direccion` varchar(60) DEFAULT NULL,
  `telefono` int(11) DEFAULT NULL,
  `edad` int(11) DEFAULT NULL,
  `tipo_sangre` varchar(5) DEFAULT NULL,
  `puesto` varchar(25) DEFAULT NULL,
  `estatus` enum('1','0') DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventario`
--

DROP TABLE IF EXISTS `inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) DEFAULT NULL,
  `marca` varchar(25) DEFAULT NULL,
  `unidad_medida` varchar(30) DEFAULT NULL,
  `categoria` varchar(45) DEFAULT NULL,
  `fecha_compra` date DEFAULT NULL,
  `costo_compra` float DEFAULT NULL,
  `costo_venta` float DEFAULT NULL,
  `cantidad` float DEFAULT NULL,
  `idProveedores` int(11) DEFAULT NULL,
  `estatus` enum('1','0') DEFAULT '1',
  PRIMARY KEY (`id`),
  KEY `id_idx` (`idProveedores`),
  CONSTRAINT `id` FOREIGN KEY (`idProveedores`) REFERENCES `proveedores` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventario`
--

LOCK TABLES `inventario` WRITE;
/*!40000 ALTER TABLE `inventario` DISABLE KEYS */;
INSERT INTO `inventario` VALUES (1,'Cable','Coblex','Metro','Con Categoria','2018-04-01',250.3,300.2,5,8,'1'),(2,'sadasdsa','asdasda','Litros','Con Categoria','2018-08-13',20,50,30,1,'0'),(10,'Maquina','Fiera','Litros','Con Categoria','2018-08-13',25.3,20.6,20,1,'0'),(25,'sadasdsa','asdasda','Litros','Con Categoria','2222-05-18',20,50,30,1,'0'),(26,'Alambre','Bron','Kilogramo','Con Categoria','2018-08-18',25,30,50,1,'0'),(27,'sdffsdfdsf','sdsdfsdfdsf','Gramo','Con Categoria','2018-08-18',21,12,12,7,'0');
/*!40000 ALTER TABLE `inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `material_proyectos`
--

DROP TABLE IF EXISTS `material_proyectos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `material_proyectos` (
  `idmaterial` int(11) NOT NULL,
  `idProyectos` int(11) DEFAULT NULL,
  `cantidad` float DEFAULT NULL,
  KEY `FK_Material_idx` (`idmaterial`),
  KEY `FK_Proyecto_idx` (`idProyectos`),
  CONSTRAINT `FK_Material` FOREIGN KEY (`idmaterial`) REFERENCES `inventario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Proyecto` FOREIGN KEY (`idProyectos`) REFERENCES `proyectos` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material_proyectos`
--

LOCK TABLES `material_proyectos` WRITE;
/*!40000 ALTER TABLE `material_proyectos` DISABLE KEYS */;
/*!40000 ALTER TABLE `material_proyectos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `RFC` varchar(14) DEFAULT NULL,
  `nombre_empresa` varchar(45) DEFAULT NULL,
  `domicilio_fiscal` varchar(85) DEFAULT NULL,
  `domicilio_ubicacion` varchar(85) DEFAULT NULL,
  `telefono` bigint(15) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `estatus` enum('1','0') DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedores`
--

LOCK TABLES `proveedores` WRITE;
/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
INSERT INTO `proveedores` VALUES (1,'asdfghj','sdfghjk','dfghjk','cvbnm,',1234567800,'xcvbnm','1'),(6,'LIGD9701163M3','Coca cola','Puente La Trinidad','Privada Hacienda San Isidro #127, Haciendas de Hidalgo, Pachuca de Soto Hgo.',7711245630,'prueba@gmail.com','1'),(7,'LIGD9701163M3','Coca cola','.....','Privada Hacienda San Isidro #127, Haciendas de Hidalgo, Pachuca de Soto Hgo.',7711363306,'deniselimon626@gmail.com','1'),(8,'qqqqq','qqqq','qqqq','qetyuio',4444444444,'qwertyui','1');
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proyectos`
--

DROP TABLE IF EXISTS `proyectos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proyectos` (
  `id` int(11) NOT NULL,
  `folio_volumetria` int(11) DEFAULT NULL,
  `proyecto` varchar(40) DEFAULT NULL,
  `descripcion` varchar(250) DEFAULT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_asignacion` date DEFAULT NULL,
  `fecha_cierre` date DEFAULT NULL,
  `costo_inversion` float DEFAULT NULL,
  `supervisor` int(11) DEFAULT NULL,
  `responsable` int(11) DEFAULT NULL,
  `cliente` int(11) DEFAULT NULL,
  `tipo_servicio` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_Supervisor_idx` (`supervisor`),
  KEY `FK_Responsable_idx` (`responsable`),
  KEY `FK_Cliente_idx` (`cliente`),
  CONSTRAINT `FK_Cliente` FOREIGN KEY (`cliente`) REFERENCES `clientes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Responsable` FOREIGN KEY (`responsable`) REFERENCES `empleados` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Supervisor` FOREIGN KEY (`supervisor`) REFERENCES `empleados` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proyectos`
--

LOCK TABLES `proyectos` WRITE;
/*!40000 ALTER TABLE `proyectos` DISABLE KEYS */;
/*!40000 ALTER TABLE `proyectos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `username` varchar(25) NOT NULL,
  `pass` varchar(20) NOT NULL,
  `idEmpleado` int(11) DEFAULT NULL,
  `estatus` enum('1','0') DEFAULT '1',
  PRIMARY KEY (`username`,`pass`),
  KEY `FK_Empleado_idx` (`idEmpleado`),
  CONSTRAINT `FK_Empleado` FOREIGN KEY (`idEmpleado`) REFERENCES `empleados` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-08-18 20:13:40
