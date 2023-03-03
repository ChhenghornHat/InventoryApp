using InventoryApp.Models;
using InventoryApp.Models.Category;
using InventoryApp.Models.Classes;
using InventoryApp.Models.Brand;
using InventoryApp.Models.SubCategory;
using InventoryApp.Models.WareHouse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using InventoryApp.Models.StoreImage;

namespace InventoryApp.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            var role = HttpContext.Session.GetInt32("Role");
            if (role == 1)
            {
                return RedirectToAction("InvLog", "Admin");
            }
            else if (role == 0)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        
        [HttpGet]
        public IActionResult GetInventory(string whsCode, string itmsGrpCod, string itemName, string categoryCode, string subCategoryCode, string stockVal, string database, string priceList)
        {
            DataTable dt = new DataTable();
            ReturnError lsErr = new ReturnError();
            try
            {
                //var priceList = HttpContext.Session.GetString("U_Price");
                //var database = HttpContext.Session.GetString("Database");
                LoginDb1 login = new LoginDb1(database);

                if (login._errCode == 0)
                {
                    login._Cmd = new SqlCommand("EXEC _USP_Inventory_Search '"+whsCode+"','"+priceList+"','"+itmsGrpCod+"','"+itemName+"','"+categoryCode+"','"+subCategoryCode+"','"+stockVal+"'", login._Con);
                    login._Ad = new SqlDataAdapter(login._Cmd);
                    login._Ad.Fill(dt);
                    login._Con.Close();
                }
                else
                {
                    lsErr.errCode = login._errCode;
                    lsErr.errMsg = login._errMsg;
                }
            }
            catch (Exception ex)
            {
                lsErr.errCode = ex.HResult;
                lsErr.errMsg = ex.Message;
            }
            string str = DataTableSystemTextJson(dt);
            return Ok(str);
        }
        public static string DataTableSystemTextJson(DataTable dataTable)
        {
            if (dataTable == null)
            {
                return string.Empty;
            }

            var data = dataTable.Rows.OfType<DataRow>()
                        .Select(row => dataTable.Columns.OfType<DataColumn>()
                            .ToDictionary(col => col.ColumnName, c => row[c]));

            return System.Text.Json.JsonSerializer.Serialize(data);
        }

        [HttpPost]
        public IActionResult IvnLog(string brand, string category, string subCategory, string code, string userCode, string userName, string cmpName, string ip)
        {
            int result = 1;
            LoginDb2 loginDb2 = new LoginDb2();

            //var userCode = HttpContext.Session.GetString("UserCode");
            // var userName = HttpContext.Session.GetString("Username");
            // var cmpName = HttpContext.Session.GetString("CompanyName");
            //var ip = HttpContext.Session.GetString("Ip");
            if (loginDb2._errCode == 0)
            {
                string query = "Search";
                loginDb2._Cmd = new SqlCommand(query, loginDb2._Con);
                loginDb2._Cmd.CommandType = CommandType.StoredProcedure;
                loginDb2._Cmd.Parameters.AddWithValue("@UserCode", userCode);
                loginDb2._Cmd.Parameters.AddWithValue("@UserName", userName);
                loginDb2._Cmd.Parameters.AddWithValue("@Company", cmpName);
                loginDb2._Cmd.Parameters.AddWithValue("@IpAddress", ip);
                loginDb2._Cmd.Parameters.AddWithValue("@Brand", brand);
                loginDb2._Cmd.Parameters.AddWithValue("@Category", category);
                loginDb2._Cmd.Parameters.AddWithValue("@SubCategory", subCategory);
                loginDb2._Cmd.Parameters.AddWithValue("@ItemCode", code);
                loginDb2._Cmd.ExecuteNonQuery();
                loginDb2._Con.Close();
            }
            else
            {
                result = loginDb2._errCode;
            }

            return Ok(result);
        }

        public IActionResult GetWareHouse()
        {
            List<ClsWareHouse> lstWareHouses = new List<ClsWareHouse>();
            ClsWareHouse warehouse;

            ReturnError lsErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                var database = HttpContext.Session.GetString("Database");
                LoginDb1 login = new LoginDb1(database);
                if (login._errCode == 0)
                {
                    string query = "EXEC _USP_Warehouse";
                    login._Ad = new SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);
                    login._Con.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        warehouse = new ClsWareHouse();
                        warehouse.WhsCode = row[0].ToString();
                        warehouse.WhsName = row[1].ToString();

                        lstWareHouses.Add(warehouse);
                    }
                }
                else
                {
                    lsErr.errCode = login._errCode;
                    lsErr.errMsg = login._errMsg;
                }
            }
            catch (Exception ex)
            {
                lsErr.errCode = ex.HResult;
                lsErr.errMsg = ex.Message;
            }
            return Ok(lstWareHouses);
        }
        [HttpGet]
        public IActionResult GetBrand()
        {
            List<ClsBrand> lsBrands = new List<ClsBrand>();
            ClsBrand brand;

            ReturnError lsErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                var database = HttpContext.Session.GetString("Database");
                LoginDb1 login = new LoginDb1(database);

                if (login._errCode == 0)
                {
                    string query = "SELECT ItmsGrpCod, ItmsGrpNam FROM OITB";
                    login._Ad = new SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);
                    login._Con.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        brand = new ClsBrand();
                        brand.ItmsGrpCod = row[0].ToString();
                        brand.ItmsGrpNam = row[1].ToString();

                        lsBrands.Add(brand);
                    }
                }
                else
                {
                    lsErr.errCode = login._errCode;
                    lsErr.errMsg = login._errMsg;
                }
            }
            catch (Exception ex)
            {
                lsErr.errCode = ex.HResult;
                lsErr.errMsg = ex.Message;
            }
            return Ok(lsBrands);
        }
        [HttpGet]
        public IActionResult GetCategory()
        {
            List<ClsCategory> lsCategory = new List<ClsCategory>();
            ClsCategory category;

            ReturnError lsErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                var database = HttpContext.Session.GetString("Database");
                LoginDb1 login = new LoginDb1(database);

                if (login._errCode == 0)
                {
                    string query = ConnectionString.QueryCategory;
                    login._Ad = new SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);
                    login._Con.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        category = new ClsCategory();
                        category.categoryCode = row[0].ToString();
                        category.categoryName = row[1].ToString();

                        lsCategory.Add(category);
                    }
                }
                else
                {
                    lsErr.errCode = login._errCode;
                    lsErr.errMsg = login._errMsg;
                }
            }
            catch (Exception ex)
            {
                lsErr.errCode = ex.HResult;
                lsErr.errMsg = ex.Message;
            }
            return Ok(lsCategory);
        }
        [HttpGet]
        public IActionResult GetCategoryFilter(string code, string database)
        {
            List<ClsSubCategory> lsSubCategory = new List<ClsSubCategory>();
            ClsSubCategory subcategory;

            ReturnError lsErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                //var database = HttpContext.Session.GetString("Database");
                LoginDb1 login = new LoginDb1(database);

                if (login._errCode == 0)
                {
                    string query = ""+ConnectionString.QuerySubCategory+" IN('"+code+"')";
                    login._Ad = new SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);
                    login._Con.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        subcategory = new ClsSubCategory();
                        subcategory.subCategoryCode = row[0].ToString();
                        subcategory.subCategoryName = row[1].ToString();

                        lsSubCategory.Add(subcategory);
                    }
                }
                else
                {
                    lsErr.errCode = login._errCode;
                    lsErr.errMsg = login._errMsg;
                }
            }
            catch (Exception ex)
            {
                lsErr.errCode = ex.HResult;
                lsErr.errMsg = ex.Message;
            }
            return Ok(lsSubCategory);
        }
        
        [HttpGet]
        public IActionResult CallImage(string folderName)
        {
            List<StoreImage> storeImages = new List<StoreImage>();
            var Path = ConnectionString.ImageUrl + folderName +"\\";
            //var Path = ConnectionString.ImageUrl;
            
            DirectoryInfo place = new DirectoryInfo(Path);
            FileInfo[] Files = place.GetFiles();

            foreach(FileInfo i in Files)
            {
                StoreImage image = new StoreImage();
                byte[] bytes = System.IO.File.ReadAllBytes(Path + i.Name);
                image.ImageUrl = Path + i.Name;

                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                image.ImageName = "data:image/png;base64," + base64String;
                
                storeImages.Add(image);
            }

            return Ok(storeImages);
        }
    }
}
