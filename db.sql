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
-- Table structure for table `tbl_assets`
--

DROP TABLE IF EXISTS `tbl_assets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_assets` (
  `assetId` int(11) NOT NULL,
  `assetName` varchar(255) DEFAULT NULL,
  `value` double DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `quantity` double DEFAULT NULL,
  `totalValue` double DEFAULT '0',
  `deleteFlg` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`assetId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_assets`
--

LOCK TABLES `tbl_assets` WRITE;
/*!40000 ALTER TABLE `tbl_assets` DISABLE KEYS */;
INSERT INTO `tbl_assets` VALUES (280001,'Test01',100,'testing1234',121,12100,0),(280002,'test2',1223,'test2trtr',1,1223,0),(280003,'03test',100000,'03Test03',2,200000,0),(280004,'22343rw',89.25689,'d23ref sdzv',2.56,228.4976384,0),(280005,'aaaa',45,'sdsdsdsd',89,4005,0);
/*!40000 ALTER TABLE `tbl_assets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_dealers`
--

DROP TABLE IF EXISTS `tbl_dealers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_dealers` (
  `dealerId` int(11) NOT NULL,
  `dealerName` varchar(255) DEFAULT NULL,
  `companyName` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `phoneNo` varchar(45) DEFAULT NULL,
  `mobile` varchar(45) DEFAULT NULL,
  `deleteFlg` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`dealerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_dealers`
--

LOCK TABLES `tbl_dealers` WRITE;
/*!40000 ALTER TABLE `tbl_dealers` DISABLE KEYS */;
INSERT INTO `tbl_dealers` VALUES (270001,'Abc','Test','colombo,','077585858','077636363',0),(270002,'xyz','xxxx','japan','45454545','12121212',0),(270003,'mohan','mmk','negombo','454545454','8989898989',0);
/*!40000 ALTER TABLE `tbl_dealers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_destinations`
--

DROP TABLE IF EXISTS `tbl_destinations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_destinations` (
  `destinationId` int(11) NOT NULL,
  `destinationName` varchar(255) DEFAULT NULL,
  `ownerName` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `phoneNo` varchar(20) DEFAULT NULL,
  `mobile` varchar(20) DEFAULT NULL,
  `deleteFlg` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`destinationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_destinations`
--

LOCK TABLES `tbl_destinations` WRITE;
/*!40000 ALTER TABLE `tbl_destinations` DISABLE KEYS */;
INSERT INTO `tbl_destinations` VALUES (260001,'MMk','mohan','colombo','454545','787878',0),(260002,'test','testing123','japan','45454','4545545',0),(260003,'ABC','AAA','asdfwert','1245782356','985623741',0),(260004,'XYZ','wwwww','skdkdkdkd;s:;s','899989','2312121',0);
/*!40000 ALTER TABLE `tbl_destinations` ENABLE KEYS */;
UNLOCK TABLES;

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
INSERT INTO `tbl_forms` VALUES ('FrmChangePassWd',10001,'LOGIN','N/A',1),('frm_Login',10002,'LOGIN','N/A',1),('Frm_Main',10003,'LOGIN','N/A',1),('FrmCreateUser',10004,'UserManage','btn_createUser',0),('FrmAddUserRole',10005,'UserManage','btn_userRole',0),('FrmEditUser',10006,'UserManage','btn_editUser',0),('FrmSetUserPermission',10007,'UserManage','btn_setFormPermission',0),('FrmEditUserRole',10008,'UserManage','btn_editUserRole',0),('FrmAddItem',10009,'InventoryManage','btn_addItem',0),('FrmAdjustReasedStock',10010,'InventoryManage','btn_adjustReleasedStock',0),('FrmAdjustStock',10011,'InventoryManage','btn_adjustStock',0),('FrmEditItem',10012,'InventoryManage','btn_editItem',0),('FrmReleaseStock',10013,'InventoryManage','btn_releaseStock',0),('FrmStockIntake',10014,'InventoryManage','btn_stockIntake',0),('FrmAddItemType',10015,'InventoryManage','btn_addItemType',0),('FrmEditItemType',10016,'InventoryManage','btn_editItemType',0),('FrmEditStockIntake',10017,'InventoryManage','btn_editStockEntry',0),('FrmAddAssets',10018,'MetaData','btn_addAssets',0),('FrmEditAssets',10019,'MetaData','btn_editAssets',0),('FrmAddDealers',10020,'MetaData','btn_addDealer',0),('FrmEditDealers',10021,'MetaData','btn_editDealer',0),('FrmAddDestinations',10022,'MetaData','btn_addDestination',0),('FrmEditDestinations',10023,'MetaData','btn_editDestination',0);
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
  `itemCode` varchar(15) NOT NULL,
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
INSERT INTO `tbl_item` VALUES (40001,'2345678765ff','TEST01','test1',30002,0),(40002,'1122233','test2','Test2',30001,0),(40003,'45789','test3','Test3',30002,0),(40004,'848484','test4','මව',30002,0),(40005,'12345','Testing111','checking',30002,0);
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
-- Table structure for table `tbl_prefix`
--

DROP TABLE IF EXISTS `tbl_prefix`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_prefix` (
  `prefixName` varchar(255) NOT NULL,
  `prefixValue` int(11) DEFAULT NULL,
  PRIMARY KEY (`prefixName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_prefix`
--

LOCK TABLES `tbl_prefix` WRITE;
/*!40000 ALTER TABLE `tbl_prefix` DISABLE KEYS */;
INSERT INTO `tbl_prefix` VALUES ('assetId',27),('dealerId',26),('destinationId',25),('formId',1),('itemId',22),('itemTypeId',24),('stockEntryId',77),('stockReleaseId',88),('userId',11),('userRoleId',12);
/*!40000 ALTER TABLE `tbl_prefix` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_stockentry`
--

DROP TABLE IF EXISTS `tbl_stockentry`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_stockentry` (
  `stockEntryId` bigint(15) NOT NULL,
  `itemCode` varchar(15) NOT NULL,
  `itemId` int(11) DEFAULT NULL,
  `updateDate` datetime DEFAULT NULL,
  `quantity` double DEFAULT NULL,
  `buyingUnitPrice` double DEFAULT NULL,
  `sellingUnitPrice` double DEFAULT NULL,
  `stockEntryDate` datetime DEFAULT NULL,
  `createDate` datetime DEFAULT NULL,
  `expirationDate` datetime DEFAULT NULL,
  `totalValue` double DEFAULT NULL,
  `remainQuantity` double DEFAULT NULL,
  `priceAfterDiscount` double DEFAULT NULL,
  `comment` varchar(255) DEFAULT NULL,
  `releaseFlg` tinyint(1) DEFAULT '0',
  `misPlacedQty` double DEFAULT '0',
  `dealerId` int(7) DEFAULT '0',
  PRIMARY KEY (`stockEntryId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_stockentry`
--

LOCK TABLES `tbl_stockentry` WRITE;
/*!40000 ALTER TABLE `tbl_stockentry` DISABLE KEYS */;
INSERT INTO `tbl_stockentry` VALUES (20170426770001,'45789',40003,'2017-05-18 00:00:00',23,458.56,500,'2017-04-26 00:00:00','2017-04-26 00:00:00','2017-12-26 00:00:00',10546.88,23,10000,'',0,0,270002),(20170426770002,'848484',40004,'2017-05-18 00:00:00',12,222,233,'2017-04-26 00:00:00','2017-04-26 00:00:00','2017-11-26 00:00:00',2664,12,2500,'',0,0,270001),(20170427770001,'45789',40003,'2017-04-27 00:00:00',12,222,300,'2017-04-27 00:00:00','2017-04-27 00:00:00','2017-10-27 00:00:00',2664,12,2500,NULL,0,0,0),(20170427770002,'45789',40003,'2017-04-27 00:00:00',20,300,300,'2017-04-27 00:00:00','2017-04-27 00:00:00','2017-08-16 00:00:00',6000,20,5800,NULL,0,0,0),(20170427770003,'848484',40004,'2017-04-27 00:00:00',60,650,700,'2017-04-27 00:00:00','2017-04-27 00:00:00','2017-08-11 00:00:00',39000,60,38000,NULL,0,0,0),(20170427770004,'45789',40003,'2017-04-27 00:00:00',34,34,56,'2017-04-27 00:00:00','2017-04-27 00:00:00','2017-09-22 00:00:00',1156,34,1000,NULL,0,0,0),(20170427770005,'848484',40004,'2017-05-10 00:00:00',23,78,89,'2017-04-27 00:00:00','2017-04-27 00:00:00','2017-06-22 00:00:00',1794,20,1500,'',0,3,0),(20170427770006,'45789',40003,'2017-04-27 00:00:00',45,54,54,'2017-04-27 00:00:00','2017-04-27 00:00:00','2017-07-27 00:00:00',2430,45,2300,NULL,0,0,0),(20170427770007,'45789',40003,'2017-05-18 00:00:00',78,500,666,'2017-04-27 00:00:00','2017-04-27 00:00:00','2017-07-20 00:00:00',39000,78,43000,'Test the comment',0,0,270003),(20170509770001,'45789',40003,'2017-05-09 00:00:00',23,77,88,'2017-05-09 00:00:00','2017-05-09 00:00:00','2017-06-09 00:00:00',1771,23,1700,'test',0,0,0),(20170509770002,'45789',40003,'2017-05-10 00:00:00',11,455,555,'2017-05-09 00:00:00','2017-05-09 00:00:00','2017-05-27 00:00:00',5005,10,5000,'',0,1,0),(20170518770001,'45789',40003,'2017-05-18 00:00:00',12,222,223,'2017-05-18 00:00:00','2017-05-18 00:00:00','2017-07-07 00:00:00',2664,10,2500,'testing',0,2,270003),(20170518770002,'848484',40004,'2017-05-18 00:00:00',45,555,666,'2017-05-18 00:00:00','2017-05-18 00:00:00','2017-06-10 00:00:00',24975,45,23500,'dsdfsfdsfsdtt4534534534',0,0,270002);
/*!40000 ALTER TABLE `tbl_stockentry` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_stockrelease`
--

DROP TABLE IF EXISTS `tbl_stockrelease`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_stockrelease` (
  `releaseId` int(11) NOT NULL,
  `stockEntryId` int(11) NOT NULL,
  `destinationId` int(11) DEFAULT NULL,
  `ItemCode` varchar(15) DEFAULT NULL,
  `itemId` int(11) DEFAULT NULL,
  `releaseUnitPrice` double DEFAULT NULL,
  `quantity` double DEFAULT NULL,
  `totalValue` double DEFAULT NULL,
  `discount_per` double DEFAULT NULL,
  `finalPrice` double DEFAULT NULL,
  `releaseDate` datetime DEFAULT NULL,
  `scheduledDeliveryDate` datetime DEFAULT NULL,
  `deliveredDate` datetime DEFAULT NULL,
  `comment` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`releaseId`,`stockEntryId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_stockrelease`
--

LOCK TABLES `tbl_stockrelease` WRITE;
/*!40000 ALTER TABLE `tbl_stockrelease` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_stockrelease` ENABLE KEYS */;
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
INSERT INTO `tbl_userpermission` VALUES (10001,20001,1,1),(10002,20001,1,1),(10003,20001,1,1),(10004,20001,1,1),(10005,20001,1,1),(10006,20001,1,1),(10007,20001,1,1),(10008,20001,1,1),(10009,20001,1,1),(10010,20001,1,1),(10011,20001,1,1),(10012,20001,1,1),(10013,20001,1,1),(10014,20001,1,1),(10015,20001,1,1),(10016,20001,1,1),(10017,20001,1,1),(10018,20001,1,1),(10019,20001,1,1),(10020,20001,1,1),(10021,20001,1,1),(10022,20001,1,1),(10023,20001,1,1),(10001,20002,0,0),(10002,20002,0,0),(10003,20002,0,0),(10004,20002,0,0),(10005,20002,0,0),(10006,20002,0,0),(10007,20002,0,0),(10008,20002,0,0),(10009,20002,0,0),(10010,20002,0,0),(10011,20002,0,0),(10012,20002,0,0),(10013,20002,0,0),(10014,20002,0,0),(10015,20002,0,0),(10016,20002,0,0),(10017,20002,0,0),(10018,20002,0,0),(10019,20002,0,0),(10020,20002,0,0),(10021,20002,0,0),(10022,20002,0,0),(10023,20002,0,0),(10001,20003,1,0),(10002,20003,1,0),(10003,20003,1,0),(10004,20003,1,0),(10005,20003,1,0),(10006,20003,1,0),(10007,20003,1,0),(10008,20003,1,0),(10009,20003,0,0),(10010,20003,0,0),(10011,20003,0,0),(10012,20003,0,0),(10013,20003,0,0),(10014,20003,0,0),(10015,20003,0,0),(10016,20003,0,0),(10017,20003,0,0),(10018,20003,0,0),(10019,20003,0,0),(10020,20003,0,0),(10021,20003,0,0),(10022,20003,0,0),(10023,20003,0,0),(10001,20004,0,0),(10002,20004,0,0),(10003,20004,0,0),(10004,20004,0,0),(10005,20004,0,0),(10006,20004,0,0),(10007,20004,0,0),(10008,20004,0,0),(10009,20004,0,0),(10010,20004,0,0),(10011,20004,0,0),(10012,20004,0,0),(10013,20004,0,0),(10014,20004,0,0),(10015,20004,0,0),(10016,20004,0,0),(10017,20004,0,0),(10018,20004,0,0),(10019,20004,0,0),(10020,20004,0,0),(10021,20004,0,0),(10022,20004,0,0),(10023,20004,0,0),(10001,20005,1,1),(10002,20005,1,1),(10003,20005,1,1),(10004,20005,1,1),(10005,20005,1,1),(10006,20005,1,1),(10007,20005,1,1),(10008,20005,1,1),(10009,20005,1,1),(10010,20005,1,1),(10011,20005,1,1),(10012,20005,1,1),(10013,20005,1,1),(10014,20005,1,1),(10015,20005,1,1),(10016,20005,1,1),(10017,20005,0,0),(10018,20005,0,0),(10019,20005,0,0),(10020,20005,0,0),(10021,20005,0,0),(10022,20005,0,0),(10023,20005,0,0),(10001,20006,0,0),(10002,20006,0,0),(10003,20006,0,0),(10004,20006,0,0),(10005,20006,0,0),(10006,20006,0,0),(10007,20006,0,0),(10008,20006,0,0),(10009,20006,0,0),(10010,20006,0,0),(10011,20006,0,0),(10012,20006,0,0),(10013,20006,0,0),(10014,20006,0,0),(10015,20006,0,0),(10016,20006,0,0),(10017,20006,0,0),(10018,20006,0,0),(10019,20006,0,0),(10020,20006,0,0),(10021,20006,0,0),(10022,20006,0,0),(10023,20006,0,0);
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

--
-- Temporary view structure for view `vw_stockentry`
--

DROP TABLE IF EXISTS `vw_stockentry`;
/*!50001 DROP VIEW IF EXISTS `vw_stockentry`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_stockentry` AS SELECT 
 1 AS `stockEntryId`,
 1 AS `itemCode`,
 1 AS `itemId`,
 1 AS `updateDate`,
 1 AS `quantity`,
 1 AS `buyingUnitPrice`,
 1 AS `sellingUnitPrice`,
 1 AS `stockEntryDate`,
 1 AS `createDate`,
 1 AS `expirationDate`,
 1 AS `totalValue`,
 1 AS `remainQuantity`,
 1 AS `priceAfterDiscount`,
 1 AS `comment`,
 1 AS `releaseFlg`,
 1 AS `misPlacedQty`,
 1 AS `dealerId`,
 1 AS `itemName`,
 1 AS `dealerName`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vw_stockentry`
--

/*!50001 DROP VIEW IF EXISTS `vw_stockentry`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_stockentry` AS select `tbl_stockentry`.`stockEntryId` AS `stockEntryId`,`tbl_stockentry`.`itemCode` AS `itemCode`,`tbl_stockentry`.`itemId` AS `itemId`,`tbl_stockentry`.`updateDate` AS `updateDate`,`tbl_stockentry`.`quantity` AS `quantity`,`tbl_stockentry`.`buyingUnitPrice` AS `buyingUnitPrice`,`tbl_stockentry`.`sellingUnitPrice` AS `sellingUnitPrice`,`tbl_stockentry`.`stockEntryDate` AS `stockEntryDate`,`tbl_stockentry`.`createDate` AS `createDate`,`tbl_stockentry`.`expirationDate` AS `expirationDate`,`tbl_stockentry`.`totalValue` AS `totalValue`,`tbl_stockentry`.`remainQuantity` AS `remainQuantity`,`tbl_stockentry`.`priceAfterDiscount` AS `priceAfterDiscount`,`tbl_stockentry`.`comment` AS `comment`,`tbl_stockentry`.`releaseFlg` AS `releaseFlg`,`tbl_stockentry`.`misPlacedQty` AS `misPlacedQty`,`tbl_stockentry`.`dealerId` AS `dealerId`,`tbl_item`.`itemName` AS `itemName`,`tbl_dealers`.`dealerName` AS `dealerName` from ((`tbl_stockentry` left join `tbl_item` on((`tbl_stockentry`.`itemId` = `tbl_item`.`itemId`))) left join `tbl_dealers` on((`tbl_dealers`.`dealerId` = `tbl_stockentry`.`dealerId`))) */;
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

-- Dump completed on 2017-05-26 17:10:31
