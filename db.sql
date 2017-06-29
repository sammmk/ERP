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
INSERT INTO `tbl_forms` VALUES ('FrmChangePassWd',10001,'LOGIN','N/A',1),('frm_Login',10002,'LOGIN','N/A',1),('Frm_Main',10003,'LOGIN','N/A',1),('FrmCreateUser',10004,'UserManage','btn_createUser',0),('FrmAddUserRole',10005,'UserManage','btn_userRole',0),('FrmEditUser',10006,'UserManage','btn_editUser',0),('FrmSetUserPermission',10007,'UserManage','btn_setFormPermission',0),('FrmEditUserRole',10008,'UserManage','btn_editUserRole',0),('FrmAddItem',10009,'InventoryManage','btn_addItem',0),('FrmAdjustReasedStock',10010,'InventoryManage','btn_adjustReleasedStock',0),('FrmAdjustStock',10011,'InventoryManage','btn_adjustStock',0),('FrmEditItem',10012,'InventoryManage','btn_editItem',0),('FrmReleaseStock',10013,'InventoryManage','btn_releaseStock',0),('FrmStockIntake',10014,'InventoryManage','btn_stockIntake',0),('FrmAddItemType',10015,'InventoryManage','btn_addItemType',0),('FrmEditItemType',10016,'InventoryManage','btn_editItemType',0),('FrmEditStockIntake',10017,'InventoryManage','btn_editStockEntry',0),('FrmAddAssets',10018,'MetaData','btn_addAssets',0),('FrmEditAssets',10019,'MetaData','btn_editAssets',0),('FrmAddDealers',10020,'MetaData','btn_addDealer',0),('FrmEditDealers',10021,'MetaData','btn_editDealer',0),('FrmAddDestinations',10022,'MetaData','btn_addDestination',0),('FrmEditDestinations',10023,'MetaData','btn_editDestination',0),('FrmAddUnits',10024,'MetaData','btn_addUnits',0),('FrmEditUnits',10025,'MetaData','btn_editUnits',0),('FrmAddTax',10026,'MetaData','btn_addTax',0),('FrmEditTax',10027,'MetaData','btn_editTax',0);
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
  `stockUnitId` int(11) DEFAULT NULL,
  `shopUnitId` int(11) DEFAULT NULL,
  `deleteFlg` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`itemId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_item`
--

LOCK TABLES `tbl_item` WRITE;
/*!40000 ALTER TABLE `tbl_item` DISABLE KEYS */;
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
INSERT INTO `tbl_login` VALUES ('Admin','0cc175b9c0f1b6a831c399e269772661',1001,0,1);
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
INSERT INTO `tbl_prefix` VALUES ('assetId',27),('dealerId',26),('destinationId',25),('formId',1),('itemId',22),('itemTypeId',24),('stockEntryId',77),('stockReleaseId',88),('taxId',29),('unitId',28),('userId',11),('userRoleId',12);
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
  `stockUnitId` int(11) DEFAULT NULL,
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
-- Table structure for table `tbl_stockrelease`
--

DROP TABLE IF EXISTS `tbl_stockrelease`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_stockrelease` (
  `releaseId` bigint(15) NOT NULL,
  `stockEntryId` bigint(15) NOT NULL,
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
-- Table structure for table `tbl_tax`
--

DROP TABLE IF EXISTS `tbl_tax`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_tax` (
  `taxId` int(11) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `symbol` varchar(45) NOT NULL,
  `taxPercentage` double NOT NULL,
  `effective_from` datetime DEFAULT NULL,
  `effective_to` datetime DEFAULT NULL,
  `deleteFlg` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`taxId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_tax`
--

LOCK TABLES `tbl_tax` WRITE;
/*!40000 ALTER TABLE `tbl_tax` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tax` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_units`
--

DROP TABLE IF EXISTS `tbl_units`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_units` (
  `unitId` int(11) NOT NULL,
  `description` varchar(45) DEFAULT NULL,
  `symbol` varchar(45) DEFAULT NULL,
  `deleteFlg` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`unitId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_units`
--

LOCK TABLES `tbl_units` WRITE;
/*!40000 ALTER TABLE `tbl_units` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_units` ENABLE KEYS */;
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
INSERT INTO `tbl_userdetail` VALUES (110001,'Admin','Admin','Admin','2017-01-03 00:00:00','1212121','Admin','admin@admin.com',120001,'666666666',0);
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
INSERT INTO `tbl_userpermission` VALUES (10001,120001,1,1),(10002,120001,1,1),(10003,120001,1,1),(10004,120001,1,1),(10005,120001,1,1),(10006,120001,1,1),(10007,120001,1,1),(10008,120001,1,1),(10009,120001,1,1),(10010,120001,1,1),(10011,120001,1,1),(10012,120001,1,1),(10013,120001,1,1),(10014,120001,1,1),(10015,120001,1,1),(10016,120001,1,1),(10017,120001,1,1),(10018,120001,1,1),(10019,120001,1,1),(10020,120001,1,1),(10021,120001,1,1),(10022,120001,1,1),(10023,120001,1,1),(10024,120001,1,1),(10025,120001,1,1),(10026,120001,1,1),(10027,120001,1,1);
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
INSERT INTO `tbl_userrole` VALUES ('Administrator',120001);
/*!40000 ALTER TABLE `tbl_userrole` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vw_item`
--

DROP TABLE IF EXISTS `vw_item`;
/*!50001 DROP VIEW IF EXISTS `vw_item`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vw_item` AS SELECT 
 1 AS `itemId`,
 1 AS `itemCode`,
 1 AS `itemName`,
 1 AS `altName`,
 1 AS `itemTypeId`,
 1 AS `stockUnitId`,
 1 AS `shopUnitId`,
 1 AS `deleteFlg`,
 1 AS `itemType`,
 1 AS `shopUnit`,
 1 AS `stockUnit`*/;
SET character_set_client = @saved_cs_client;

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
 1 AS `stockUnitId`,
 1 AS `itemName`,
 1 AS `dealerName`,
 1 AS `symbol`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vw_item`
--

/*!50001 DROP VIEW IF EXISTS `vw_item`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_item` AS select `item`.`itemId` AS `itemId`,`item`.`itemCode` AS `itemCode`,`item`.`itemName` AS `itemName`,`item`.`altName` AS `altName`,`item`.`itemTypeId` AS `itemTypeId`,`item`.`stockUnitId` AS `stockUnitId`,`item`.`shopUnitId` AS `shopUnitId`,`item`.`deleteFlg` AS `deleteFlg`,`itype`.`itemType` AS `itemType`,`unit1`.`symbol` AS `shopUnit`,`unit2`.`symbol` AS `stockUnit` from (((`tbl_item` `item` left join `tbl_itemtype` `itype` on((`item`.`itemTypeId` = `itype`.`typeId`))) left join `tbl_units` `unit1` on((`unit1`.`unitId` = `item`.`shopUnitId`))) left join `tbl_units` `unit2` on((`unit2`.`unitId` = `item`.`stockUnitId`))) where (`item`.`deleteFlg` <> 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

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
/*!50001 VIEW `vw_stockentry` AS select `tbl_stockentry`.`stockEntryId` AS `stockEntryId`,`tbl_stockentry`.`itemCode` AS `itemCode`,`tbl_stockentry`.`itemId` AS `itemId`,`tbl_stockentry`.`updateDate` AS `updateDate`,`tbl_stockentry`.`quantity` AS `quantity`,`tbl_stockentry`.`buyingUnitPrice` AS `buyingUnitPrice`,`tbl_stockentry`.`sellingUnitPrice` AS `sellingUnitPrice`,`tbl_stockentry`.`stockEntryDate` AS `stockEntryDate`,`tbl_stockentry`.`createDate` AS `createDate`,`tbl_stockentry`.`expirationDate` AS `expirationDate`,`tbl_stockentry`.`totalValue` AS `totalValue`,`tbl_stockentry`.`remainQuantity` AS `remainQuantity`,`tbl_stockentry`.`priceAfterDiscount` AS `priceAfterDiscount`,`tbl_stockentry`.`comment` AS `comment`,`tbl_stockentry`.`releaseFlg` AS `releaseFlg`,`tbl_stockentry`.`misPlacedQty` AS `misPlacedQty`,`tbl_stockentry`.`dealerId` AS `dealerId`,`tbl_stockentry`.`stockUnitId` AS `stockUnitId`,`tbl_item`.`itemName` AS `itemName`,`tbl_dealers`.`dealerName` AS `dealerName`,`tbl_units`.`symbol` AS `symbol` from (((`tbl_stockentry` left join `tbl_item` on((`tbl_stockentry`.`itemId` = `tbl_item`.`itemId`))) left join `tbl_dealers` on((`tbl_dealers`.`dealerId` = `tbl_stockentry`.`dealerId`))) left join `tbl_units` on((`tbl_units`.`unitId` = `tbl_stockentry`.`stockUnitId`))) */;
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

-- Dump completed on 2017-06-28 16:03:33
