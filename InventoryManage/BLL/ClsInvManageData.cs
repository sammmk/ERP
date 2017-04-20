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
}
