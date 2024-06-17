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
                var value =( $" exec HospitalShowall");
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
        public void Login(HospitalEntity reg)
        {
            try
            {
                var Sqlvalue = ($"EXEC HospitalLogin'{reg.Name}','{reg.Email}','{reg.Address}',{reg.Phonenumber},{reg.Pincode}");
                refer.Open();
                refer.Execute(Sqlvalue);
                refer.Close();
            }
            catch (SqlException )
            {
                throw ;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<HospitalEntity>Search(int  Id)
        {
            try
            {
                var value = ($"Exec HospitalSearch {Id}");
                refer.Open();
                var result = refer.Query<HospitalEntity>(value);
                refer.Close();
                return(result);
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
        public void Edit( HospitalEntity reg)
        {
            try
            {
                var value = ($"Exec HospitalEdit {reg.Id},'{reg.Name}','{reg.Email}','{reg.Address}',{reg.Phonenumber},{reg.Pincode}");
                refer.Open();
                refer.Execute(value);
                refer.Close();
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
        public void Delete(long Id)
        {
            try
            {
                var value = ($"exec HospitalDelete {Id}");
                refer.Open();
                refer.Execute(value);
                refer.Close();
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
