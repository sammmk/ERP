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
        public long _stockEntryId { get; set; }
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
        public double _misPlacedQty { get; set; }
        public int _dealerId { get; set; }
        public string _dealerName { get; set; }
        public int _stockUnitId { get; set; }
        public string _stockUnitSymbol { get; set; }
    }

    public class ClsReleaseStock
    {
        public long _releaseId { get; set; }
        public long _stockEntryId { get; set; }
        public int _destinationId { get; set; }
        public string _destinationName { get; set; }
        public string _itemCode { get; set; }
        public int _itemId { get; set; }
        public string _itemName { get; set; }
        public double _releaseUnitPrice { get; set; }
        public double _qty { get; set; }
        public double _remainQty { get; set; }
        public double _totalValue { get; set; }
        public double _discountPer { get; set; }
        public double _discount { get; set; }
        public double _finalPrice { get; set; }
        public DateTime _releaseDate { get; set; }
        public DateTime _sceduledDelivery { get; set; }
        public DateTime _delivered { get; set; }
        public string _comment { get; set; }
    }

    public class ClsManageReleaseQty
    {
        public string _stockEntryId { get; set; }
        public double _availableQty { get; set; }
        public double _remainAfterIssuedQty { get; set; }
        public double _issuedQty { get; set; }
    }
}
