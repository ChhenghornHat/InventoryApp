using InventoryApp.Models;
using InventoryApp.Models.Classes;
using InventoryApp.Models.CompanyName;
using InventoryApp.Models.PriceList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventoryApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult ViewLogin()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId"))) 
            {
                return View();
            } 
            else
            {
                return RedirectToAction("ShowFilterData", "FilterData");
            }
        }
        [HttpGet]
        public IActionResult PostLogin(string usercode, string password, string database)
        {
            int Result = 1;
            ConnectionString.Database = database;
            DataTable dt = new DataTable();
            LoginDb1 login = new LoginDb1(database);
            if (login._errCode == 0)
            {
                try
                {
                    string query = "SELECT * FROM [@USERLOGIN] WHERE (Code IN('" + usercode + "') AND Name IN('" + password + "'))";
                    login._Ad = new System.Data.SqlClient.SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        HttpContext.Session.SetString("UserId", usercode);
                        ClsPriceList.PriceList = row["U_Price"].ToString();
                        Result = 0;
                    }
                }
                catch (Exception)
                {
                    Result = 1;
                }
            } 
            else
            {
                HttpContext.Session.SetString("UserId", "");
                Result = login._errCode;
            }
            return Ok(Result);   
        }
        
        public IActionResult getCompanyName()
        {
            List<ClsCompanyName> lstCompanyName = new List<ClsCompanyName>();
            ClsCompanyName compayName;

            ReturnError lstErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                Login login = new Login();

                if(login._errCode == 0)
                {
                    string query = "SELECT dbName, cmpName FROM [SRGC] ORDER BY dbName DESC";
                    login._Ad = new System.Data.SqlClient.SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);

                    foreach(DataRow row in dt.Rows)
                    {
                        compayName = new ClsCompanyName();

                        compayName.dbName = row[0].ToString();
                        compayName.cmpName = row[1].ToString();

                        lstCompanyName.Add(compayName);
                    }
                } 
                else
                {
                    lstErr.errCode = login._errCode;
                    lstErr.errMsg = login._errMsg;
                }
            }
            catch (Exception ex)
            {
                lstErr.errCode = ex.HResult;
                lstErr.errMsg = ex.Message;
            }
            return Ok(lstCompanyName);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("UserId", "");
            return RedirectToAction("ViewLogin", "Login");
        }
    }
}
