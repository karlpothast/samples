using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesProcess;
using System.Drawing;
using System.Configuration;
using System.Data.Common;
using System.Collections.Specialized;

namespace SalesProcess
{
    class DataLayer
    {
        public Boolean OpenSQLConnection()
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
                sqlConn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean CloseSQLConnection()
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
                sqlConn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public String TestSQLConnection()
        {
            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();
            return "OK";
        }

        public String GetSQLConnectionString()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            var value = ConfigurationManager.AppSettings["SQLConnectionString"];

            return value;
        }

        public SqlConnection GetSQLConnection()
        {
            SqlConnection sqlConn;
            try
            {
                sqlConn = new SqlConnection(GetSQLConnectionString());
            }
            catch
            {
                sqlConn = null;
            }
            return sqlConn;
        }

        public Int32 InsertCustomer(String FirstName, String LastName, String Address, String City, String State, String Zip)
        {
            Int32 outputId = 0;

            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertCustomer";
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = City;
            cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = State;
            cmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = Zip;
            cmd.Parameters.Add("@NewId", SqlDbType.Int).Direction = ParameterDirection.Output;
            outputId = (Int32)cmd.ExecuteNonQuery();

            sqlConn.Close();

            return outputId;
        }

        public DataTable GetCustomerList()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetCustomerList";
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

        public SqlDataReader GetCustomer(Int32 CustomerId)
        {
            SqlDataReader reader;
            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();
            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetCustomerDetail";
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
            reader = cmd.ExecuteReader();
            return reader;
        }

        public Boolean UpdateCustomer(Int32 CustomerId, String FirstName, String LastName, String Address, String City, String State, String Zip)
        {
            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateCustomer";
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = CustomerId;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;
            cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = City;
            cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = State;
            cmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = Zip;
            cmd.ExecuteNonQuery();

            sqlConn.Close();
            return true;
        }

        public Boolean DeleteCustomer(Int32 CustomerId)
        {
            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteCustomer";
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = CustomerId;
            cmd.ExecuteNonQuery();

            sqlConn.Close();
            return true;
        }

        public DataTable GetItemList()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetItemList";
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

        public Decimal GetItemPrice(Int32 CustomerId)
        {
            Decimal returnVal;
            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();
            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetItemPrice";
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = CustomerId;
            var sqlValue = cmd.ExecuteScalar();
            if (sqlValue != null)
            {
                returnVal = (Decimal)cmd.ExecuteScalar();
            }
            else
            {
                returnVal = 0.0m;
            }
     
            return returnVal;
        }

        public Boolean CreateOrder(Int32 CustomerId, DateTime ShipDttm, Int32 ItemId, Int32 Qty, Decimal Price)
        {
            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spCreateOrder";
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
            cmd.Parameters.Add("@ShipDttm", SqlDbType.DateTime).Value = ShipDttm;
            cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = ItemId;
            cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
            cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = Price;
            cmd.ExecuteNonQuery();

            sqlConn.Close();

            return true;
        }

        public Boolean AddOrderItem(Int32 OrderId, Int32 ItemId, Int32 Qty, Decimal Price)
        {
            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spAddOrderItem";
            cmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = OrderId;
            cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = ItemId;
            cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
            cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = Price;
            cmd.ExecuteNonQuery();

            sqlConn.Close();

            return true;
        }

        public DataTable GetOpenCustomerOrders(Int32 CustomerId)
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetOpenCustomerOrders";
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

        public Decimal GetCustomerOrderTotal(Int32 CustomerId)
        {
            Decimal returnVal;
            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();
            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetCustomerOrderTotal";
            cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
            var sqlValue = cmd.ExecuteScalar();
            if (sqlValue != null)
            {
                returnVal = (Decimal)cmd.ExecuteScalar();
            }
            else
            {
                returnVal = 0.0m;
            }

            return returnVal;
        }

        public DataTable GetAllCustomerOrders()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlConn = new SqlConnection(GetSQLConnectionString());
            sqlConn.Open();

            SqlCommand cmd = sqlConn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spGetAllCustomerOrders";
            dt.Load(cmd.ExecuteReader());

            return dt;
        }







    }
}
