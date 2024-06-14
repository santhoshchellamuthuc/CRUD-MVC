using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanthoshLibrary
{
    public class LocationRepository : ILocationRepository
    {
        SqlConnection refer;
        IConfiguration connect;
        public LocationRepository(IConfiguration configer)
        {
            connect = configer;
            var connection = connect.GetConnectionString("Dbconnection");
            refer = new SqlConnection(connection);
        }
        public IEnumerable<LocationEntity> Showall()
        {
            try
            {
                var value = $"exec Locationpoint";
                refer.Open();
                var result = refer.Query<LocationEntity>(value);
                refer.Close();
                return result;
            }
            catch (SqlException)
            {
                throw;
            }catch(Exception)
            {
                throw;
            }
        }
        public void Insert()
        {
            try
            {

            }catch(SqlException)
            {
                throw;
            }catch(Exception)
            {
                throw;
            }
        }
    }
}
