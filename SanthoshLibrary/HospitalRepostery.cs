using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace SanthoshLibrary
{
    public class HospitalRepostery
    {
        SqlConnection refer;
        IConfiguration Connective;
        public HospitalRepostery(IConfiguration configurestion)
        {
            Connective = configurestion;
            var store = Connective.GetConnectionString("Dbconnection");
            refer = new SqlConnection(store);
        }

        public IEnumerable<HospitalEntity> Showall()
        {
            try
            {
                var value = $" exec HospitalShowall";
                refer.Open();
                var result = refer.Query<HospitalEntity>(value);
                refer.Close();
                return (result);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
