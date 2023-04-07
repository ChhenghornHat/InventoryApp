namespace InventoryApp.Models.Classes
{
    public static class ConnectionString
    {
        public static string Constr { get; set; }
        public static string Constr2 { get; set; }
        public static string Server { get; set; }
        public static string UserId { get; set; }
        public static string Password { get; set; }
        
        public static string QueryDatabase { get; set; }
        // Query for get data into dropdown
        public static string QueryBrand { get; set; }
        public static string QueryCategory { get; set; }
        public static string QuerySubCategory { get; set; }
        public static string ImageUrl { get; set; }
        
        public static string AppName { get; set; }
        public static string AppInfo { get; set; }
        public static string AppVersion { get; set; }
    }
}