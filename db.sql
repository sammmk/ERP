-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: usercontrol
-- ------------------------------------------------------
-- Server version	5.7.17-log

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
-- Table structure for table `tbl_forms`
--

DROP TABLE IF EXISTS `tbl_forms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_forms` (
  `formName` varchar(255) NOT NULL,
  `formId` int(11) NOT NULL,
  `project` varchar(255) DEFAULT NULL,
  `btnName` varchar(45) DEFAULT 'N/A',
  `isCommonForm` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`formId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_forms`
--

LOCK TABLES `tbl_forms` WRITE;
/*!40000 ALTER TABLE `tbl_forms` DISABLE KEYS */;
INSERT INTO `tbl_forms` VALUES ('FrmChangePassWd',10001,'LOGIN','N/A',1),('frm_Login',10002,'LOGIN','N/A',1),('Frm_Main',10003,'LOGIN','N/A',1),('FrmCreateUser',10004,'UserManage','btn_createUser',0),('FrmAddUserRole',10005,'UserManage','btn_userRole',0),('FrmEditUser',10006,'UserManage','btn_editUser',0),('FrmSetUserPermission',10007,'UserManage','btn_setFormPermission',0),('FrmEditUserRole',10008,'UserManage','btn_editUserRole',0),('FrmAddItem',10009,'InventoryManage','btn_addItem',0),('FrmAdjustReasedStock',10010,'InventoryManage','btn_adjustReleasedStock',0),('FrmAdjustStock',10011,'InventoryManage','btn_adjustStock',0),('FrmEditItem',10012,'InventoryManage','btn_editItem',0),('FrmReleaseStock',10013,'InventoryManage','btn_releaseStock',0),('FrmStockIntake',10014,'InventoryManage','btn_stockIntake',0),('FrmAddItemType',10015,'InventoryManage','btn_addItemType',0),('FrmEditItemType',10016,'InventoryManage','btn_editItemType',0);
/*!40000 ALTER TABLE `tbl_forms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_item`
--

DROP TABLE IF EXISTS `tbl_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_item` (
  `itemId` int(11) NOT NULL,
  `itemCode` varchar(255) NOT NULL,
  `itemName` varchar(255) NOT NULL,
  `altName` varchar(255) DEFAULT NULL,
  `itemTypeId` int(11) DEFAULT NULL,
  `deleteFlg` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`itemId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_item`
--

LOCK TABLES `tbl_item` WRITE;
/*!40000 ALTER TABLE `tbl_item` DISABLE KEYS */;
INSERT INTO `tbl_item` VALUES (40001,'2345678765ff','TEST01','test1',30002,0),(40002,'1122233','test2','Test2',30001,0),(40003,'45789','test3','Test3',30002,0),(40004,'848484','test4','මව',30002,0);
/*!40000 ALTER TABLE `tbl_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_itemtype`
--

DROP TABLE IF EXISTS `tbl_itemtype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_itemtype` (
  `typeId` int(11) NOT NULL,
  `itemType` varchar(255) NOT NULL,
  PRIMARY KEY (`typeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_itemtype`
--

LOCK TABLES `tbl_itemtype` WRITE;
/*!40000 ALTER TABLE `tbl_itemtype` DISABLE KEYS */;
INSERT INTO `tbl_itemtype` VALUES (30001,'FoodItem'),(30002,'Beverages');
/*!40000 ALTER TABLE `tbl_itemtype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_login`
--

DROP TABLE IF EXISTS `tbl_login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_login` (
  `userName` varchar(255) NOT NULL,
  `passWord` varchar(255) NOT NULL,
  `userId` int(11) DEFAULT NULL,
  `deleteFlag` int(11) DEFAULT '0',
  `roleId` int(11) DEFAULT NULL,
  PRIMARY KEY (`userName`,`passWord`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_login`
--

LOCK TABLES `tbl_login` WRITE;
/*!40000 ALTER TABLE `tbl_login` DISABLE KEYS */;
INSERT INTO `tbl_login` VALUES ('123qwe','46f94c8de14fb36680850768ff1b7f2a',1005,0,1005),('abc123','e99a18c428cb38d5f260853678922e03',1002,0,1002),('Admin','0cc175b9c0f1b6a831c399e269772661',1001,0,1),('fdsfdsfds','8e421035705ebe79f9e881f46426a5ef',1004,0,1004),('test','098f6bcd4621d373cade4e832627b4f6',1006,0,20005),('xyz321','6d9287069371e9345734ef4e60cb6853',1003,0,1003);
/*!40000 ALTER TABLE `tbl_login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_stockentry`
--

DROP TABLE IF EXISTS `tbl_stockentry`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_stockentry` (
  `stockEntryId` int(11) NOT NULL,
  `itemCode` int(11) NOT NULL,
  `itemId` int(11) DEFAULT NULL,
  `batchNo` varchar(45) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `buyingUnitPrice` double DEFAULT NULL,
  `sellingUnitPrice` double DEFAULT NULL,
  `stockEntryDate` datetime DEFAULT NULL,
  `createDate` datetime DEFAULT NULL,
  `expirationDate` datetime DEFAULT NULL,
  PRIMARY KEY (`stockEntryId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_stockentry`
--

LOCK TABLES `tbl_stockentry` WRITE;
/*!40000 ALTER TABLE `tbl_stockentry` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_stockentry` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userdetail`
--

DROP TABLE IF EXISTS `tbl_userdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_userdetail` (
  `userId` int(11) NOT NULL,
  `userName` varchar(45) NOT NULL,
  `firstName` varchar(255) DEFAULT NULL,
  `lastName` varchar(255) DEFAULT NULL,
  `dob` datetime DEFAULT NULL,
  `NIC` varchar(15) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `roleId` int(11) DEFAULT NULL,
  `phoneNo` varchar(15) DEFAULT NULL,
  `deleteFlg` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_userdetail`
--

LOCK TABLES `tbl_userdetail` WRITE;
/*!40000 ALTER TABLE `tbl_userdetail` DISABLE KEYS */;
INSERT INTO `tbl_userdetail` VALUES (1001,'Admin','Admin','Admin','2017-01-03 00:00:00','1212121','Admin','admin@admin.com',20001,'666666666',0),(1002,'abc123','Mohan','Kurerammm','1994-02-02 00:00:00','1234567890V','fgfgfdgfdgfdgfdgfdgfdgf\r\nds','vvvvaaa@hhh.com',20003,'000000011',0),(1003,'xyz321','Mohan','Kurera','2016-12-28 00:00:00','1234567890V','dcdsfdsds','vvvvxxx@hhh.com',20001,'454545888',0),(1004,'fdsfdsfds','dfdsfd','fdfdfdsfds','2017-07-19 00:00:00','2345676','sl','m@m.com',20004,'703562236',0),(1005,'123qwe','sasasa','qwert','2017-01-03 00:00:00','12345','dsgghjfdsadfghfdsa','a@h.com',20002,'222222222',0),(1006,'test','TESTER','tester','2017-03-31 00:00:00','777888999','assasasasa','a@c.com',20005,'45454545',0);
/*!40000 ALTER TABLE `tbl_userdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userpermission`
--

DROP TABLE IF EXISTS `tbl_userpermission`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_userpermission` (
  `formId` int(11) NOT NULL,
  `userRoleId` int(11) NOT NULL,
  `viewPermission` tinyint(1) DEFAULT '0',
  `actionPermission` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`userRoleId`,`formId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_userpermission`
--

LOCK TABLES `tbl_userpermission` WRITE;
/*!40000 ALTER TABLE `tbl_userpermission` DISABLE KEYS */;
INSERT INTO `tbl_userpermission` VALUES (10001,20001,1,1),(10002,20001,1,1),(10003,20001,1,1),(10004,20001,1,1),(10005,20001,1,1),(10006,20001,1,1),(10007,20001,1,1),(10008,20001,1,1),(10009,20001,1,1),(10010,20001,1,1),(10011,20001,1,1),(10012,20001,1,1),(10013,20001,1,1),(10014,20001,1,1),(10015,20001,1,1),(10016,20001,1,1),(10001,20002,0,0),(10002,20002,0,0),(10003,20002,0,0),(10004,20002,0,0),(10005,20002,0,0),(10006,20002,0,0),(10007,20002,0,0),(10008,20002,0,0),(10009,20002,0,0),(10010,20002,0,0),(10011,20002,0,0),(10012,20002,0,0),(10013,20002,0,0),(10014,20002,0,0),(10015,20002,0,0),(10016,20002,0,0),(10001,20003,1,0),(10002,20003,1,0),(10003,20003,1,0),(10004,20003,1,0),(10005,20003,1,0),(10006,20003,1,0),(10007,20003,1,0),(10008,20003,1,0),(10009,20003,0,0),(10010,20003,0,0),(10011,20003,0,0),(10012,20003,0,0),(10013,20003,0,0),(10014,20003,0,0),(10015,20003,0,0),(10016,20003,0,0),(10001,20004,0,0),(10002,20004,0,0),(10003,20004,0,0),(10004,20004,0,0),(10005,20004,0,0),(10006,20004,0,0),(10007,20004,0,0),(10008,20004,0,0),(10009,20004,0,0),(10010,20004,0,0),(10011,20004,0,0),(10012,20004,0,0),(10013,20004,0,0),(10014,20004,0,0),(10015,20004,0,0),(10016,20004,0,0),(10001,20005,1,1),(10002,20005,1,1),(10003,20005,1,1),(10004,20005,1,1),(10005,20005,1,1),(10006,20005,1,1),(10007,20005,1,1),(10008,20005,1,1),(10009,20005,1,1),(10010,20005,1,1),(10011,20005,1,1),(10012,20005,1,1),(10013,20005,1,1),(10014,20005,1,1),(10015,20005,1,1),(10016,20005,1,1);
/*!40000 ALTER TABLE `tbl_userpermission` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userrole`
--

DROP TABLE IF EXISTS `tbl_userrole`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_userrole` (
  `userRoleName` varchar(255) NOT NULL,
  `userRoleId` int(11) NOT NULL,
  PRIMARY KEY (`userRoleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_userrole`
--

LOCK TABLES `tbl_userrole` WRITE;
/*!40000 ALTER TABLE `tbl_userrole` DISABLE KEYS */;
INSERT INTO `tbl_userrole` VALUES ('Administrator',20001),('PoSUser',20002),('InventoryManager',20003),('TestRole',20004),('Manager',20005),('QA',20006);
/*!40000 ALTER TABLE `tbl_userrole` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-20 15:20:11
