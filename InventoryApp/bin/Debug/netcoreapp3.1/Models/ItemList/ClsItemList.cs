using System;
using System.Collections.Generic;

namespace InventoryApp.Models.ItemList
{
    public static class ClsItemList
    {
        public  static List<ItemList> itemLists = new List<ItemList>();
    }
    public class ItemList
    {
        public string ItemCode { get; set; }
        public  string ItemName { get; set; }
        public  string Date { get; set; }
        public string Database { get; set; }
    }
}
