using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManage.BLL
{
    public class ClsInvManageData
    {
    }

    public class ClsItemTypeData
    {
        public int _itemTypeId { get; set; }
        public string _itemTypeName { get; set; }
    }

    public class ClsItemData
    {
        public int _itemId { get; set; }
        public string _itemCode { get; set; }
        public string _itemName { get; set; }
        public string _altName { get; set; }
        public string _itemTypeName { get; set; }
        public int _itemTypeId { get; set; }
    }

    public class ClsStockData
    {
        public int _stockEntryId { get; set; }
        public string _itemCode { get; set; }
        public int _itemId { get; set; }
        public string _itemName { get; set; }
        public double _quantity { get; set; }
        public double _buyUnitPrice { get; set; }
        public double _sellUnitPrice { get; set; }
        public DateTime _stockEntryDate { get; set; }
        public DateTime _createDate { get; set; }
        public DateTime _expireDate { get; set; }
        public double _totalValue { get; set; }
        public DateTime _updateDate { get; set; }
        public double _remainQuantity { get; set; }
        public double _priceAfterDiscount { get; set; }
        public string _comment { get; set; }
        public short _releaseFlg { get; set; }
    }
}
