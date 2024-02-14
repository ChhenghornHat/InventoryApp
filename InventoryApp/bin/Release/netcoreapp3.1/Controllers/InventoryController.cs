using InventoryApp.Models;
using InventoryApp.Models.Category;
using InventoryApp.Models.Classes;
using InventoryApp.Models.Brand;
using InventoryApp.Models.SubCategory;
using InventoryApp.Models.WareHouse;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using InventoryApp.Models.Image;
using InventoryApp.Models.StoreImage;
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

            return role switch
            {
                1 => RedirectToAction("InvLog", "Admin"),
                0 => View(),
                _ => RedirectToAction("Index", "Login")
            };
        }
        
        [HttpGet]
        public IActionResult GetInventory(string whsCode, string itmsGrpCod, string itemName, string categoryCode, string subCategoryCode, string stockVal)
        {
            var dt = new DataTable();
            var lsErr = new ReturnError();
            try
            {
                var database = Request.Cookies["Database"];
                var priceList = Request.Cookies["U_Price"];
                var login = new LoginDb1(database);

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
            var str = DataTableSystemTextJson(dt);
            return Ok(str);
        }

        private static string DataTableSystemTextJson(DataTable dataTable)
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
        public async Task<IActionResult> GetPhotoBySKU(string sku)
        {
            var accessToken = ConnectionString.ApiAuth;

            var client = new HttpClient();

            var authHeader = new AuthenticationHeaderValue("Basic", accessToken);
            client.DefaultRequestHeaders.Authorization = authHeader;

            var content = await client.GetStringAsync($"{ConnectionString.ApiUrl}api/v2/products/images/{sku}");

            var result = JsonConvert.DeserializeObject<ClsImage>(content);

            return Json(result);
        }

        [HttpPost]
        public IActionResult IvnLog(string brand, string category, string subCategory, string code)
        {
            var result = 1;
            var loginDb2 = new LoginDb2();

            var userCode = Request.Cookies["UserCode"];
            var userName = Request.Cookies["Username"];
            var cmpName = Request.Cookies["CompanyName"];
            var ip = Request.Cookies["Ip"];
            if (loginDb2._errCode == 0)
            {
                const string query = "Search";
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
            var lstWareHouses = new List<ClsWareHouse>();
            ClsWareHouse warehouse;

            var lsErr = new ReturnError();
            try
            {
                var dt = new DataTable();
                var database = Request.Cookies["Database"];
                var login = new LoginDb1(database);
                if (login._errCode == 0)
                {
                    const string query = "EXEC _USP_Warehouse";
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
            var lsBrands = new List<ClsBrand>();
            ClsBrand brand;

            var lsErr = new ReturnError();
            try
            {
                var dt = new DataTable();
                var database = Request.Cookies["Database"];
                var login = new LoginDb1(database);

                if (login._errCode == 0)
                {
                    var query = ConnectionString.QueryBrand;
                    login._Ad = new SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);
                    login._Con.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        brand = new ClsBrand
                        {
                            ItmsGrpCod = row[0].ToString(),
                            ItmsGrpNam = row[1].ToString()
                        };

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
            var lsCategory = new List<ClsCategory>();
            ClsCategory category;

            var lsErr = new ReturnError();
            try
            {
                var dt = new DataTable();
                var database = Request.Cookies["Database"];
                var login = new LoginDb1(database);

                if (login._errCode == 0)
                {
                    var query = ConnectionString.QueryCategory;
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
            var lsSubCategory = new List<ClsSubCategory>();
            ClsSubCategory subcategory;

            var lsErr = new ReturnError();
            try
            {
                var dt = new DataTable();
                var database = Request.Cookies["Database"];
                var login = new LoginDb1(database);

                if (login._errCode == 0)
                {
                    var query = ""+ConnectionString.QuerySubCategory+" IN('"+code+"')";
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
            var storeImages = new List<StoreImage>();
            var path = ConnectionString.ImageUrl + folderName +"\\";
            //var Path = ConnectionString.ImageUrl;
            
            var place = new DirectoryInfo(path);
            var files = place.GetFiles();

            foreach(var i in files)
            {
                var image = new StoreImage();
                var bytes = System.IO.File.ReadAllBytes(path + i.Name);
                image.ImageUrl = path + i.Name;

                var base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                image.ImageName = "data:image/png;base64," + base64String;
                
                storeImages.Add(image);
            }

            return Ok(storeImages);
        }
        [HttpGet]
        public IActionResult ItemList(string Search)
        {
            var database = Request.Cookies["Database"];
            var date = DateTime.Now.Year+DateTime.Now.Month.ToString()+DateTime.Now.Day;
            var count = ClsItemList.itemLists.Where(row => row.Date == date && row.Database==database).ToList();
            if (count.Count == 0)
            {
                ClsItemList.itemLists.DefaultIfEmpty();
                var dt = new DataTable();
                var lsErr = new ReturnError();
                try
                {
                    var login = new LoginDb1(database);

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
                var str = DataTableSystemTextJson(dt);
                ClsItemList.itemLists = JsonConvert.DeserializeObject<List<ItemList>>(str, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            }

            var search=ClsItemList.itemLists.Where(row=>row.ItemCode.Contains(Search.ToUpper()) && row.Database == database).ToList();
            return Ok(search);

        }
    }
}
