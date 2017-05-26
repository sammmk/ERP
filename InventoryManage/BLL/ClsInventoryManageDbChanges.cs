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

        public long getMaxId(string field, string table)
        {
            long maxId = 1;

            try
            {
                string querry = "SELECT MAX(" + field + ") from " + table + ";";
                maxId = CONN.getMaxId_long(querry);                
                
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

        public int getIdPrefix(string idName)
        {
            int id = 1;

            try
            {
                string querry = "SELECT prefixValue FROM tbl_prefix WHERE prefixName = '" + idName + "';";
                id = CONN.getPrefix(querry);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
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
                            remainQuantity, priceAfterDiscount, comment, dealerId) 
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
                querry += "'" + stockData._comment + "',";
                querry += "'" + stockData._dealerId + "'";
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
                querry += "remainQuantity = '" + stockData._remainQuantity + "', ";
                querry += "misPlacedQty = '" + stockData._misPlacedQty + "', ";
                querry += "comment = '" + stockData._comment + "', ";
                querry += "dealerId = '" + stockData._dealerId + "' ";
                querry += "WHERE stockEntryId = '" + stockData._stockEntryId + "';";

                isOK = CONN.update(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isOK;
        }

        public DataTable getCurrentDayStockDetails()
        {
            DataTable dt = new DataTable();
            string curr_date = DateTime.Today.ToString("yyyy/MM/dd");

            try
            {
                string querry = @"SELECT *
                                 FROM vw_stockentry
                                WHERE createDate = '" + curr_date + "' ORDER BY stockEntryId DESC;";

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
                string querry = @"SELECT *
                                 FROM vw_stockentry
                                WHERE releaseFlg != '1'" + str + " ORDER BY stockEntryId DESC;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public ClsStockData getSingleStockDetail(long stockEntryId)
        {
            ClsStockData stockData = new ClsStockData();
            DataTable dt = new DataTable();

            try
            {
                string querry = @"SELECT *
                                 FROM vw_stockentry
                                WHERE stockEntryId = '" + stockEntryId + "';";

                dt = CONN.getDataTable(querry);

                if(dt.Rows.Count >= 1)
                {
                    stockData._stockEntryId = Convert.ToInt64(dt.Rows[0]["stockEntryId"].ToString());
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
                    stockData._misPlacedQty = Convert.ToDouble(dt.Rows[0]["misPlacedQty"]);
                    stockData._dealerId = Convert.ToInt32(dt.Rows[0]["dealerId"]);
                    stockData._dealerName = dt.Rows[0]["dealerName"].ToString();
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

        public DataTable getStockEntryForItem(string itemCode)
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = @"SELECT * FROM vw_stockentry
                                    WHERE itemCode = '" + itemCode + "' AND remainQuantity > 0 ORDER BY stockEntryId ASC;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable getDealerDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = @"SELECT dealerId, dealerName, address FROM tbl_dealers;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable getDestinationDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = @"SELECT destinationId, destinationName, ownerName, address 
                                    FROM tbl_destinations WHERE deleteFlg != '1';";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable getStockEntryDetailsForItem(string itemCode)
        {
            DataTable dt = new DataTable();

            try
            {
                string querry = @"SELECT stockEntryId, itemName, itemCode, remainQuantity, sellingUnitPrice
                                    FROM vw_stockentry WHERE itemCode = '" + itemCode + "' AND remainQuantity > '0' ORDER BY stockEntryId ASC;";

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public double getTotalStockAmountForItem(string itemCode)
        {
            double qty = 0;

            try
            {
                string querry = @"SELECT  SUM(remainQuantity) AS QTY
                                    FROM tbl_stockentry WHERE itemCode = '" + itemCode + "';";

                qty = CONN.getSumOfColumn(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return qty;
        }

        public DataTable getDealerWhileSearching(int type, string str)
        {
            DataTable dt = new DataTable();
            string querry = string.Empty;
            try
            {
                if (type == 1)
                {
                    querry = "SELECT * FROM tbl_dealers WHERE dealerName LIKE '" + str + "%' AND deleteFlg != '1'";
                }
                else if (type == 2)
                {
                    querry = "SELECT * FROM tbl_dealers WHERE companyName LIKE '" + str + "%' AND deleteFlg != '1'";
                }
                else
                {
                    querry = "SELECT * FROM tbl_dealers WHERE deleteFlg != '1';";
                }

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable getDestinationWhileSearching(int type, string str)
        {
            DataTable dt = new DataTable();
            string querry = string.Empty;
            try
            {
                if (type == 1)
                {
                    querry = @"SELECT destinationId, destinationName, ownerName, address 
                                FROM tbl_destinations WHERE destinationName LIKE '" + str + "%' AND deleteFlg != '1'";
                }
                else if (type == 2)
                {
                    querry = @"SELECT destinationId, destinationName, ownerName, address 
                                FROM tbl_destinations WHERE ownerName LIKE '" + str + "%' AND deleteFlg != '1'";
                }
                else
                {
                    querry = @"SELECT destinationId, destinationName, ownerName, address 
                                FROM tbl_destinations WHERE deleteFlg != '1';";
                }

                dt = CONN.getDataTable(querry);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }
        
    }
}
