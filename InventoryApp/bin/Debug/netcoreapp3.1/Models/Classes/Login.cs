using System;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace InventoryApp.Models.Classes
{
    public class Login
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
        public Login() 
        {
            ConnDb();
        }

        private void ConnDb()
        {
            try
            {
                string ConnString = ConnectionString.Constr;
                _Con = new SqlConnection(ConnString);
                if (_Con.State == System.Data.ConnectionState.Closed) { _Con.Open(); }

                if (_Con.State == System.Data.ConnectionState.Open) { errCode = 0; }
                else { errCode = 9999; }
            }
            catch(Exception ex)
            {
                errCode = ex.HResult;
                errMsg = ex.Message;
            }
        }
    }
}
