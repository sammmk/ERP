using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaData.BLL
{
    public class ClsMetaDataInfo
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

    public class ClsDealerData
    {
        public int _dealerId { get; set; }
        public string _dealerName { get; set; }
        public string _companyName { get; set; }
        public string _address { get; set; }
        public string _phoneNo { get; set; }
        public string _mobile { get; set; }
    }

    public class ClsDestinationData
    {
        public int _destId { get; set; }
        public string _destName { get; set; }
        public string _ownerName { get; set; }
        public string _address { get; set; }
        public string _phoneNo { get; set; }
        public string _mobile { get; set; }
    }

    public class ClsAssetData
    {
        public int _assetId { get; set; }
        public string _assetName { get; set; }
        public double _value { get; set; }
        public double _quantity { get; set; }
        public string _descrption { get; set; }
        public double _totalValue { get; set; }
    }
}
