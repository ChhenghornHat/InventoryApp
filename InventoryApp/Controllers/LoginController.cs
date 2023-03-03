using InventoryApp.Models;
using InventoryApp.Models.Classes;
using InventoryApp.Models.CompanyName;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventoryApp.Controllers
{
    public class LoginController : Controller
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
                return RedirectToAction("Index", "Inventory");
            }
            else
            {
                return View();
            }
        }
        
        [HttpGet]
        public IActionResult PostLogin(string usercode, string password, string database, string ip, string cmpName)
        {
            int result = 1;
            
            //ConnectionString.Database = database;
            DataTable dt = new DataTable();
            LoginDb1 login = new LoginDb1(database);
            HttpContext.Session.SetString("Database",database);
            if (login._errCode == 0)
            {
                try
                {
                    string query = "EXEC _USP_User_Inventory '" + usercode + "'," + password + "";
                    login._Ad = new SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);
                    login._Con.Close();

                    
                    foreach (DataRow row in dt.Rows)
                    {
                        HttpContext.Session.SetString("U_Price", row["U_Price"].ToString());
                        HttpContext.Session.SetString("UserCode", usercode);
                        HttpContext.Session.SetString("Username", row["UserName"].ToString());
                        HttpContext.Session.SetString("CompanyName", cmpName);
                        HttpContext.Session.SetString("Ip", ip);
                        HttpContext.Session.SetInt32("Role", Convert.ToInt32(row["Role"].ToString()));

                        result = 0;
                    }
                }
                catch (Exception)
                {
                    result = 1;
                }
                finally
                {
                    LoginDb2 loginDb2 = new LoginDb2();
                    var username = HttpContext.Session.GetString("Username");
                    try
                    {
                        string query = "login";
                        loginDb2._Cmd = new SqlCommand(query, loginDb2._Con);
                        loginDb2._Cmd.CommandType = CommandType.StoredProcedure;
                        loginDb2._Cmd.Parameters.AddWithValue("@UserCode", usercode);
                        loginDb2._Cmd.Parameters.AddWithValue("@UserName", username);
                        loginDb2._Cmd.Parameters.AddWithValue("@IpAddress", ip);
                        loginDb2._Cmd.Parameters.AddWithValue("@Company", cmpName);

                        loginDb2._Cmd.ExecuteNonQuery();
                        loginDb2._Con.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    
                }
            } 
            else
            {
                //HttpContext.Session.SetString("Role", "");
                result = login._errCode;
            }
            return Ok(result);
        }
        
        public IActionResult GetCompanyName()
        {
            List<ClsCompanyName> lstCompanyName = new List<ClsCompanyName>();
            ClsCompanyName companyName;

            ReturnError lstErr = new ReturnError();
            try
            {
                DataTable dt = new DataTable();
                Login login = new Login();

                if (login._errCode == 0)
                {
                    string query = ConnectionString.QueryDatabase;
                    login._Ad = new SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);

                    foreach(DataRow row in dt.Rows)
                    {
                        companyName = new ClsCompanyName();

                        companyName.dbName = row[0].ToString();
                        companyName.cmpName = row[1].ToString();

                        lstCompanyName.Add(companyName);
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
            HttpContext.Session.Remove("Role");
            return RedirectToAction("Index", "Login");
        }
    }
}
