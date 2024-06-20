using InventoryApp.Models;
using InventoryApp.Models.Classes;
using InventoryApp.Models.CompanyName;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Threading.Tasks;

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

            return role switch
            {
                1 => RedirectToAction("InvLog", "Admin"),
                0 => RedirectToAction("Index", "Inventory"),
                _ => View()
            };
        }
        
        [HttpGet]
        public IActionResult PostLogin(string usercode, string password, string database, string ip, string cmpName)
        {
            var result = 1;
            var username = "";
            
            //ConnectionString.Database = database;
            var dt = new DataTable();
            var login = new LoginDb1(database);
            
            if (login._errCode == 0)
            {
                try
                {
                    var query = "EXEC _USP_User_Inventory '" + usercode + "'," + password + "";
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
                        username = row["UserName"].ToString();
                        
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("U_Price", row["U_Price"].ToString(), options);
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("UserCode", usercode, options);
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("Username", username, options);
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
                    var loginDb2 = new LoginDb2();
                    
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
                        
                        var message = $"Company Name: <b>{cmpName}</b>\nUserCode: <b>{usercode}</b>\nUsername: <b>{username}</b>\nIP Address: <b>{ip}</b>\nLogged in Date: <b>{DateTime.Now}</b>";

                        var url = $"https://api.telegram.org/bot{ConnectionString.Token}/sendMessage?chat_id={ConnectionString.ChatId}&parse_mode=html&text={message}";

                        using var webClient = new WebClient();
                        webClient.DownloadString(url);
                        
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
            var lstCompanyName = new List<ClsCompanyName>();
            ClsCompanyName companyName;

            var lstErr = new ReturnError();
            try
            {
                var dt = new DataTable();
                var login = new Login();

                if (login._errCode == 0)
                {
                    var query = ConnectionString.QueryDatabase;
                    login._Ad = new SqlDataAdapter(query, login._Con);
                    login._Ad.Fill(dt);

                    foreach(DataRow row in dt.Rows)
                    {
                        companyName = new ClsCompanyName
                        {
                            dbName = row[0].ToString(),
                            cmpName = row[1].ToString()
                        };

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
