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
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
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
            
            if (login._errCode == 0)
            {
                try
                {
                    string query = "EXEC _USP_User_Inventory '" + usercode + "'," + password + "";
                    login._Ad = new SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);
                    login._Con.Close();
                    var options = new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(1),
                    };
                    _httpContextAccessor.HttpContext.Response.Cookies.Append("Database",database, options);

                    foreach (DataRow row in dt.Rows)
                    {
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("U_Price", row["U_Price"].ToString(), options);
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("UserCode", usercode, options);
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("Username", row["UserName"].ToString(), options);
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("CompanyName", cmpName, options);
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("Ip", ip, options);
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("Role", row["Role"].ToString(), options);
                        
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
                    var username = Request.Cookies["Username"];
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
            // Response.Cookies.Delete();
            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }
            return RedirectToAction("Index", "Login");
        }
    }
}
