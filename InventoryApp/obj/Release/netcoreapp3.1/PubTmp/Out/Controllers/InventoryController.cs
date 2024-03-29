﻿using InventoryApp.Models;
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
using System.Text.Json.Serialization;
using System.Threading;
using InventoryApp.Models.ItemList;
using Newtonsoft.Json;

namespace InventoryApp.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            var strRole = Request.Cookies["Role"];
            int role;
            if (strRole == null)
            {
                role = -1;
            }
            else
            {
                role = Convert.ToInt32(strRole);
            }
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
        public IActionResult GetInventory(string whsCode, string itmsGrpCod, string itemName, string categoryCode, string subCategoryCode, string stockVal)
        {
            DataTable dt = new DataTable();
            ReturnError lsErr = new ReturnError();
            try
            {
                var database = Request.Cookies["Database"];
                var priceList = Request.Cookies["U_Price"];
                LoginDb1 login = new LoginDb1(database);

                if (login._errCode == 0)
                {
                    login._Cmd = new SqlCommand("EXEC _USP_Inventory_Search '"+whsCode+"','"+priceList+"','"+itmsGrpCod+"','"+itemName+"','"+categoryCode+"','"+subCategoryCode+"','"+stockVal+"'", login._Con);
                    login._Cmd.CommandTimeout = 60;
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
        public IActionResult IvnLog(string brand, string category, string subCategory, string code)
        {
            int result = 1;
            LoginDb2 loginDb2 = new LoginDb2();

            var userCode = Request.Cookies["UserCode"];
            var userName = Request.Cookies["Username"];
            var cmpName = Request.Cookies["CompanyName"];
            var ip = Request.Cookies["Ip"];
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
                var database = Request.Cookies["Database"];
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
                var database = Request.Cookies["Database"];
                LoginDb1 login = new LoginDb1(database);

                if (login._errCode == 0)
                {
                    string query = ConnectionString.QueryBrand;
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
                var database = Request.Cookies["Database"];
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
        public IActionResult GetCategoryFilter(string code)
        {
            List<ClsSubCategory> lsSubCategory = new List<ClsSubCategory>();
            ClsSubCategory subcategory;

            ReturnError lsErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                var database = Request.Cookies["Database"];
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
        [HttpGet]
        public IActionResult ItemList(string Search)
        {
            var database = Request.Cookies["Database"];
            string date = DateTime.Now.Year.ToString()+DateTime.Now.Month.ToString()+DateTime.Now.Day.ToString();
            var Count = ClsItemList.itemLists.Where(row => row.Date == date && row.Database==database).ToList();
            if (Count.Count == 0)
            {
                ClsItemList.itemLists.DefaultIfEmpty();
                DataTable dt = new DataTable();
                ReturnError lsErr = new ReturnError();
                try
                {
                    LoginDb1 login = new LoginDb1(database);

                    if (login._errCode == 0)
                    {
                        login._Cmd = new SqlCommand(ConnectionString.QueryItemList+" '"+ database+"'", login._Con);
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
                ClsItemList.itemLists = JsonConvert.DeserializeObject<List<ItemList>>(str, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            }

            var search=ClsItemList.itemLists.Where(row=>row.ItemCode.Contains(Search.ToUpper()) && row.Database == database).ToList();
            return Ok(search);

        }
    }
}
