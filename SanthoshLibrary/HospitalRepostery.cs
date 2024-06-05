using System;
using System.Data.SqlClient;

namespace SanthoshLibrary
{
    public class HospitalRepostery
    {
        SqlConnection refer;
      public HospitalRepostery()
        {
            refer = new SqlConnection("");
        }
    }
}
