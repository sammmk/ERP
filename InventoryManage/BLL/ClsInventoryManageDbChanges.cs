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

        public bool updateData_item(ClsItemData itemData)
        {
            bool isError = false;
            string querry = string.Empty;

            try
            {
                querry += "UPDATE tbl_item SET ";
                querry += "itemName = '" + itemData._itemName + "', ";
                querry += "altName = '" + itemData._altName + "', ";
                querry += "itemTypeId = '" + itemData._itemTypeId + "' ";
                querry += "WHERE itemId = '" + itemData._itemId + "';";

                isError = CONN.update(querry);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return isError;
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
