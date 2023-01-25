using InventoryApp.Models;
using InventoryApp.Models.Category;
using InventoryApp.Models.Classes;
using InventoryApp.Models.FilterData;
using InventoryApp.Models.PriceList;
using InventoryApp.Models.SubCategory;
using InventoryApp.Models.WareHouse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using InventoryApp.Models.StoreImage;
using static System.Net.Mime.MediaTypeNames;

namespace InventoryApp.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult SearchFilter()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
            {
                return View();
            }
            else
            {
                return RedirectToAction("ViewLogin", "Login");
            }
        }

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
        public IActionResult ShowInventory(string whsCode, string itmsGrpCod, string itemName, string categoryCode, string subCategoryCode, string stockVal)
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
            {
                ClsParameter cp = new ClsParameter();
                cp.whsCode = whsCode;
                cp.itmsGrpCod = itmsGrpCod;
                cp.itemName = itemName;
                cp.categoryCode = categoryCode;
                cp.subCategoryCode = subCategoryCode;
                cp.stockVal = stockVal;
                return View(cp);
            }
            else
            {
                return RedirectToAction("ViewLogin", "Login");
            }
        }
        [HttpGet]
        public IActionResult getInventory(string whsCode, string itmsGrpCod, string itemName, string categoryCode, string subCategoryCode, string stockVal)
        {
            DataTable dt = new DataTable();
            ReturnError lsErr = new ReturnError();
            try
            {
                LoginDb1 login = new LoginDb1(ConnectionString.Database);

                if (login._errCode == 0)
                {
                    login._Cmd = new System.Data.SqlClient.SqlCommand("EXEC _USP_Inventory_Search " + whsCode + ",'" + ClsPriceList.PriceList + "'," + itmsGrpCod + "," + itemName + "," + categoryCode + "," + subCategoryCode + ","+stockVal+"", login._Con);
                    login._Ad = new System.Data.SqlClient.SqlDataAdapter(login._Cmd);
                    login._Cmd.ExecuteNonQuery();
                    login._Ad.Fill(dt);
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

        [HttpGet]
        public IActionResult getInInventory(string whsCodes, string itmsGrpCods, string itemNames, string categoryCodes, string subCategoryCodes, string stockVal)
        {
            DataTable dt = new DataTable();
            ReturnError lsErr = new ReturnError();
            try
            {
                LoginDb1 login = new LoginDb1(ConnectionString.Database);

                if (login._errCode == 0)
                {
                    login._Cmd = new System.Data.SqlClient.SqlCommand("EXEC _USP_Inventory_Search '" + whsCodes + "','" + ClsPriceList.PriceList + "','" + itmsGrpCods + "','" + itemNames + "','" + categoryCodes + "','" + subCategoryCodes + "','"+stockVal+"'", login._Con);
                    login._Ad = new System.Data.SqlClient.SqlDataAdapter(login._Cmd);
                    login._Cmd.ExecuteNonQuery();
                    login._Ad.Fill(dt);
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
        [HttpGet]
        public IActionResult getWareHouse()
        {
            List<ClsWareHouse> lstWareHouses = new List<ClsWareHouse>();
            ClsWareHouse warehouse;

            ReturnError lsErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                LoginDb1 login = new LoginDb1(ConnectionString.Database);
                if (login._errCode == 0)
                {
                    string query = "EXEC _USP_Warehouse";
                    login._Ad = new System.Data.SqlClient.SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);

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
        public IActionResult getBrand()
        {
            List<ClsBrand> lsBrands = new List<ClsBrand>();
            ClsBrand brand;

            ReturnError lsErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                LoginDb1 login = new LoginDb1(ConnectionString.Database);

                if (login._errCode == 0)
                {
                    string query = "SELECT ItmsGrpCod, ItmsGrpNam FROM OITB";
                    login._Ad = new System.Data.SqlClient.SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);

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
        public IActionResult getCategory()
        {
            List<ClsCategory> lsCategory = new List<ClsCategory>();
            ClsCategory category;

            ReturnError lsErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                LoginDb1 login = new LoginDb1(ConnectionString.Database);

                if (login._errCode == 0)
                {
                    string query = ConnectionString.QueryCategory;
                    login._Ad = new System.Data.SqlClient.SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);

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
        public IActionResult getCategoryFilter(string code)
        {
            List<ClsSubCategory> lsSubCategory = new List<ClsSubCategory>();
            ClsSubCategory subcategory;

            ReturnError lsErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                LoginDb1 login = new LoginDb1(ConnectionString.Database);

                if (login._errCode == 0)
                {
                    string query = ""+ConnectionString.QuerySubCategory+" IN('"+code+"')";
                    login._Ad = new System.Data.SqlClient.SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);

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
    }
}
