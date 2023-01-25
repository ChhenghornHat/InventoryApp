using System.Data.SqlClient;
using System;

namespace InventoryApp.Models.Classes
{
    public class LoginDb1
    {
        private int errCode;
        private string errMsg;

        private SqlConnection Con;
        private SqlCommand Cmd;
        private SqlDataAdapter Ad;

        public int _errCode { get { return errCode; } }
        public string _errMsg { get { return errMsg; } }

        public SqlConnection _Con { get { return Con; } set { Con = value; } }
        public SqlCommand _Cmd { get { return Cmd; } set { Cmd = value; } }
        public SqlDataAdapter _Ad { get { return Ad; } set { Ad = value; } }
        public LoginDb1(string Database)
        {
            ConnDb(Database);
        }

        private void ConnDb(string Database)
        {
            try
            {
                string Server = ConnectionString.Server;
                string UserId = ConnectionString.UserId;
                string Password = ConnectionString.Password;
                string ConnString = "Server = " + Server + ";Initial Catalog = " + Database + "; User id = "+UserId+";Password = " + Password + "";

                _Con = new SqlConnection(ConnString);
                if (_Con.State == System.Data.ConnectionState.Closed) { _Con.Open(); }

                if (_Con.State == System.Data.ConnectionState.Open) { errCode = 0; }
                else { errCode = 9999; }
            }
            catch (Exception ex)
            {
                errCode = ex.HResult;
                errMsg = ex.Message;
            }
        }
    }
}
