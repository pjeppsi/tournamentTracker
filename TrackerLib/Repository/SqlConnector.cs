using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TrackerLib.Interfaces;
using TrackerLib.Models;
using System.Data.SqlClient;

namespace TrackerLib.Repository
{
    public class SqlConnector : IDataRepository
    {
        //zasada cu ovdje staviti connString
        string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        #region INSERT_INITIAL
        public NagradaModel CreateNagradaModel(NagradaModel model)
        {
            string sqlQuery = $"INSERT INTO tablica(s1,s2,s3...)" + 
                "VALUES("+model.Plasman+","+model.PlasmanNaziv+ ","+model.IznosNagrade+ ","+model.PostotakNagrade+ ");";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            try
            {
                connection.Open();
                command.ExecuteReader();//treba li mi reader ili nonquery, nisam sig jesam li transakcije napravio?
                connection.Close();
            }
            catch (Exception e)
            {
                throw;
            }

            return model;
        }
        #endregion













        #region GET
        #endregion

        #region UPDATE
        #endregion

        #region DELETE
        #endregion
    }
}
