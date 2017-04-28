using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManage.BLL
{
    public class ClsInventoryManageDbChanges
    {
        private CommonControls.Classes.dbConnection CONN;
        private CommonControls.Classes.ClsCommonMethods COMMON;
        private CommonControls.Classes.ClsCommonMethods COM_METHODS;

        public ClsInventoryManageDbChanges()
        {
            CONN = new CommonControls.Classes.dbConnection();
            COMMON = new CommonControls.Classes.ClsCommonMethods();
            COM_METHODS = new CommonControls.Classes.ClsCommonMethods();
        }

        public int getMaxItemTypeID()
        {
            int maxUserId = 1;

            try
            {
                string querry = "SELECT MAX(typeId) from tbl_itemtype;";
                maxUserId = CONN.getMaxId(querry);

                //30000 for item type Id or something like that : add only for the first value   
                if (maxUserId <= 1)
                    maxUserId += 30000;
            }
            catch (Exception e)
            {
                throw e;
            }

            return maxUserId;
        }

        public int getMaxItemId()
        {
            int maxId = 1;

            try
            {
                string querry = "SELECT MAX(itemId) from tbl_item;";
                maxId = CONN.getMaxId(querry);

                //40000 for item Id
                if(maxId <= 1)
                {
                    maxId += 40000;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return maxId;
        }

        public int getMaxStockEntryId()
        {
            int maxId = 1;

            try
            {
                string querry = "SELECT MAX(stockEntryId) from tbl_stockentry;";
                maxId = CONN.getMaxId(querry);                
                
                if (maxId <= 1)
                {
                    maxId = 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return maxId;
        }

        public bool insertData_itemType(int typeId, string typeName)
        {
            bool ret = false;
            string itemType = string.Empty;

            try
            {
                itemType = "INSERT INTO tbl_itemtype (typeId, itemType) VALUES (";
                itemType += "'" + typeId + "',";
                itemType += "'" + typeName;
                itemType += "');";

                ret = CONN.update(itemType);
            }
            catch (Exception ex)
            {
                ret = false;
                throw ex;
            }
            return ret;
        }

        public bool updateData_itemType(int typeId, string typeName)
        {
            bool ret = false;
            string itemType = string.Empty;

            try
            {
                itemType = "UPDATE tbl_itemtype SET ";
                itemType += "itemType = '" + typeName+ "' ";
                itemType += "WHERE typeId = '" + typeId + "';";

                ret = CONN.update(itemType);
            }
            catch (Exception ex)
            {
                ret = false;
                throw ex;
            }
            return ret;
        }

        public DataTable getItemTypeDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = "SELECT * FROM tbl_itemtype;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public ClsItemTypeData getSingleItemTypeData(int itemTypeId)
        {
            ClsItemTypeData itemTypeData = new ClsItemTypeData();
            DataTable dt = new DataTable();

            try
            {
                string querry = "SELECT * FROM tbl_itemtype WHERE typeId = '" + itemTypeId + "';";
                
                dt = CONN.getDataTable(querry);

                if (dt.Rows.Count > 0)
                {
                    itemTypeData._itemTypeId = Convert.ToInt16(dt.Rows[0]["typeId"]);
                    itemTypeData._itemTypeName = dt.Rows[0]["itemType"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return itemTypeData;
        }

        public DataTable getItemTypeList()
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = "SELECT * FROM tbl_itemtype;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                dt = null;
                throw ex;
            }

            return dt;
        }

        public bool deleteItem(int itemId)
        {
            bool ret = false;
            string q = string.Empty;
            string qq = string.Empty;

            try
            {
                q = "UPDATE tbl_item SET deleteFlg = '1' WHERE itemId = '" + itemId + "';";
                ret = CONN.update(q);
                                
            }
            catch (Exception ex)
            {
                ret = false;
                throw ex;
            }
            return ret;
        }

        public bool insertData_item(ClsItemData itemData)
        {
            bool isError = false;
            string querry = string.Empty;

            try
            {
                querry += "INSERT INTO tbl_item (itemId, itemCode, itemName, altName, itemTypeId) VALUES (";
                querry += "'" + itemData._itemId + "',";
                querry += "'" + itemData._itemCode + "',";
                querry += "'" + itemData._itemName + "',";
                querry += "'" + itemData._altName + "',";
                querry += "'" + itemData._itemTypeId + "'";
                querry += ");";

                isError = CONN.update(querry);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return isError;
        }

        public bool insertData_stockEntry(ClsStockData stockData)
        {
            bool isError = false;
            string querry = string.Empty;

            try
            {
                querry += @"INSERT INTO tbl_stockentry 
                            (stockEntryId, itemCode, itemId, updateDate, quantity, 
                            buyingUnitPrice, sellingUnitPrice, stockEntryDate, 
                            createDate, expirationDate, totalValue, 
                            remainQuantity, priceAfterDiscount, comment) 
                            VALUES (";
                querry += "'" + stockData._stockEntryId + "',";
                querry += "'" + stockData._itemCode + "',";
                querry += "'" + stockData._itemId + "',";
                querry += "'" + stockData._updateDate + "',";
                querry += "'" + stockData._quantity + "',";
                querry += "'" + stockData._buyUnitPrice + "',";
                querry += "'" + stockData._sellUnitPrice + "',";
                querry += "'" + stockData._stockEntryDate + "',";
                querry += "'" + stockData._createDate + "',";
                querry += "'" + stockData._expireDate + "',";
                querry += "'" + stockData._totalValue + "',";
                querry += "'" + stockData._remainQuantity + "',";
                querry += "'" + stockData._priceAfterDiscount + "',";
                querry += "'" + stockData._comment + "'";
                querry += ");";

                isError = CONN.update(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isError;
        }

        public bool updateData_stockEntry(ClsStockData stockData)
        {
            bool isOK = false;
            string querry = string.Empty;

            try
            {
                querry += @"UPDATE tbl_stockentry SET ";
                querry += "itemCode = '" + stockData._itemCode + "', ";
                querry += "updateDate = '" + stockData._updateDate + "', ";
                querry += "quantity = '" + stockData._quantity + "', ";
                querry += "buyingUnitPrice = '" + stockData._buyUnitPrice + "', ";
                querry += "sellingUnitPrice = '" + stockData._sellUnitPrice + "', ";
                querry += "stockEntryDate = '" + stockData._stockEntryDate + "', ";
                querry += "expirationDate = '" + stockData._expireDate + "', ";
                querry += "totalValue = '" + stockData._totalValue + "', ";
                querry += "priceAfterDiscount = '" + stockData._priceAfterDiscount + "', ";
                querry += "comment = '" + stockData._comment + "' ";
                querry += "WHERE stockEntryId = '" + stockData._stockEntryId + "';";

                isOK = CONN.update(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isOK;
        }

        public bool updateData_item(ClsItemData itemData)
        {
            bool isOK = false;
            string querry = string.Empty;

            try
            {
                querry += "UPDATE tbl_item SET ";
                querry += "itemName = '" + itemData._itemName + "', ";
                querry += "altName = '" + itemData._altName + "', ";
                querry += "itemTypeId = '" + itemData._itemTypeId + "' ";
                querry += "WHERE itemId = '" + itemData._itemId + "';";

                isOK = CONN.update(querry);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return isOK;
        }

        public DataTable getItemDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = @"SELECT u.*, r.itemType 
                                    FROM tbl_item u 
                                        LEFT JOIN tbl_itemtype r 
                                            ON u.itemTypeId = r.typeId  
                                    WHERE deleteFlg != 1;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable getCurrentDayStockDetails()
        {
            DataTable dt = new DataTable();
            string curr_date = DateTime.Today.ToString("yyyy/MM/dd");

            try
            {
                string querry = @"SELECT 
	                                s.*,
                                    i.itemName
                                 FROM tbl_stockentry s
                                    LEFT JOIN tbl_item i ON s.itemId = i.itemId
                                WHERE s.createDate = '" + curr_date + "' ORDER BY stockEntryId DESC;";

                dt = CONN.getDataTable(querry);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable getStockDetails(string str)
        {
            DataTable dt = new DataTable();
            string tmp = string.Empty;

            try
            {
                string querry = @"SELECT 
	                                s.*,
                                    i.itemName
                                 FROM tbl_stockentry s
                                    LEFT JOIN tbl_item i ON s.itemId = i.itemId
                                WHERE s.releaseFlg != '1'" + str + " ORDER BY stockEntryId DESC;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public ClsStockData getSingleStockDetail(int stockEntryId)
        {
            ClsStockData stockData = new ClsStockData();
            DataTable dt = new DataTable();

            try
            {
                string querry = @"SELECT 
	                                s.*,
                                    i.itemName
                                 FROM tbl_stockentry s
                                    LEFT JOIN tbl_item i ON s.itemId = i.itemId
                                WHERE s.stockEntryId = '" + stockEntryId + "';";

                dt = CONN.getDataTable(querry);

                if(dt.Rows.Count >= 1)
                {
                    stockData._stockEntryId = Convert.ToInt32(dt.Rows[0]["stockEntryId"].ToString());
                    stockData._itemCode = dt.Rows[0]["itemCode"].ToString();
                    stockData._itemId = Convert.ToInt32(dt.Rows[0]["itemId"].ToString());
                    stockData._updateDate = Convert.ToDateTime(dt.Rows[0]["updateDate"]);
                    stockData._quantity = Convert.ToDouble(dt.Rows[0]["quantity"]);
                    stockData._buyUnitPrice = Convert.ToDouble(dt.Rows[0]["buyingUnitPrice"]);
                    stockData._sellUnitPrice = Convert.ToDouble(dt.Rows[0]["sellingUnitPrice"]);
                    stockData._stockEntryDate = Convert.ToDateTime(dt.Rows[0]["stockEntryDate"]);
                    stockData._createDate = Convert.ToDateTime(dt.Rows[0]["createDate"]);
                    stockData._expireDate = Convert.ToDateTime(dt.Rows[0]["expirationDate"]);
                    stockData._totalValue = Convert.ToDouble(dt.Rows[0]["totalValue"]);
                    stockData._itemName = dt.Rows[0]["itemName"].ToString();
                    stockData._remainQuantity = Convert.ToDouble(dt.Rows[0]["remainQuantity"]);
                    stockData._priceAfterDiscount = Convert.ToDouble(dt.Rows[0]["priceAfterDiscount"]);
                    stockData._comment = dt.Rows[0]["comment"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return stockData;
        }

        public DataTable getItemDataForStockEntry(string itemCode)
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = @"SELECT * FROM tbl_item
                                    WHERE itemCode = '" + itemCode + "';";

                dt = CONN.getDataTable(querry);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public ClsItemData getSingleItemData(int itemId)
        {
            ClsItemData itemData = new ClsItemData();

            try
            {
                string querry = @"SELECT u.itemId, u.itemCode, u.itemName, u.altName, u.itemTypeId, r.itemType  
                                    FROM tbl_item u
                                        LEFT JOIN tbl_itemtype r
                                            ON u.itemTypeId = r.typeId  
                                    WHERE itemId = '" + itemId + "'; ";

                DataTable dt = new DataTable();

                dt = CONN.getDataTable(querry);

                if (dt.Rows.Count > 0)
                {
                    itemData._itemId = Convert.ToInt32(dt.Rows[0]["itemId"].ToString());
                    itemData._itemCode = dt.Rows[0]["itemCode"].ToString();
                    itemData._itemName = dt.Rows[0]["itemName"].ToString();
                    itemData._altName = dt.Rows[0]["altName"].ToString();
                    itemData._itemTypeId = Convert.ToInt32(dt.Rows[0]["itemTypeId"].ToString());
                    itemData._itemTypeName = dt.Rows[0]["itemType"].ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return itemData;
        }
    }
}
