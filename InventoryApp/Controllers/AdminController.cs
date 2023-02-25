using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using InventoryApp.Models;
using InventoryApp.Models.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    public class AdminController : Controller
    {
        // public IActionResult AdminDashboard()
        // {
        //     var role = HttpContext.Session.GetInt32("Role");
        //     if (role == 1)
        //     {
        //         return View();
        //     }
        //     else if (role == 0)
        //     {
        //         return RedirectToAction("Index", "Inventory");
        //     }
        //     else
        //     {
        //         return RedirectToAction("Index", "Login");
        //     }
        // }

        public IActionResult InvLog()
        {
            var role = HttpContext.Session.GetInt32("Role");
            if (role == 1)
            {
                return View();
            }
            else if (role == 0)
            {
                return RedirectToAction("Index", "Inventory");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        
        [HttpGet]
        public IActionResult GetHistoryLog(int type, string cpmName, string dateFrom, string dateTo)
        {
            DataTable dt = new DataTable();
            ReturnError lsErr = new ReturnError();
            try
            {
                LoginDb2 loginDb2 = new LoginDb2();

                if (loginDb2._errCode == 0)
                {
                    loginDb2._Cmd = new SqlCommand("EXEC Report '"+type+"', '"+cpmName+"', '"+dateFrom+"', '"+dateTo+"'", loginDb2._Con);
                    loginDb2._Ad = new SqlDataAdapter(loginDb2._Cmd);
                    loginDb2._Ad.Fill(dt);
                    loginDb2._Con.Close();
                }
                else
                {
                    lsErr.errCode = loginDb2._errCode;
                    lsErr.errMsg = loginDb2._errMsg;
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
    }
}
