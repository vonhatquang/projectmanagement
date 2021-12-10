using System;
using System.Collections.Generic;
using System.Collections;
using System.Data; 
using System.Data.SqlClient; 
using Newtonsoft.Json;
namespace Helper
{
    public class DataAccessHelper:IDataAccessHelper
    {
        public DataTable List(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null){
            DataTable listResult = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString)){
                con.Open();  
                using(SqlCommand cmd = new SqlCommand(storeProcedureName, con)){
                    cmd.CommandType = CommandType.StoredProcedure;  
                    if(parameters != null && parameters.Count>0){
                        foreach(DataAccessHelperParameter parameter in parameters){
                            cmd.Parameters.AddWithValue(String.Concat("@",parameter.Name),parameter.Value);
                        }
                    }
                    SqlDataReader rdr = cmd.ExecuteReader(); 
                    listResult.Load(rdr);
                }
                con.Close(); 
            }            
            return listResult;
        }
        public DataTable Get(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null){
            DataTable getResult = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString)){
                con.Open();  
                using(SqlCommand cmd = new SqlCommand(storeProcedureName, con)){
                    cmd.CommandType = CommandType.StoredProcedure;  
                    if(parameters != null && parameters.Count>0){
                        foreach(DataAccessHelperParameter parameter in parameters){
                            cmd.Parameters.AddWithValue(String.Concat("@",parameter.Name),parameter.Value);
                        }
                    }
                    SqlDataReader rdr = cmd.ExecuteReader();  
                    getResult.Load(rdr);
                }
                con.Close(); 
            }
            return getResult;
        }

        public int Post(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null){
            int postResult = 0;
            using (SqlConnection con = new SqlConnection(connectionString)){
                con.Open();  
                using(SqlCommand cmd = new SqlCommand(storeProcedureName, con)){
                    cmd.CommandType = CommandType.StoredProcedure;  
                    if(parameters != null && parameters.Count>0){
                        foreach(DataAccessHelperParameter parameter in parameters){
                            cmd.Parameters.AddWithValue(String.Concat("@",parameter.Name),parameter.Value);
                        }
                    }
                    postResult = cmd.ExecuteNonQuery(); 
                }
                con.Close(); 
            }
            return postResult;
        }

        public int Put(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null){
            int putResult = 0;
            using (SqlConnection con = new SqlConnection(connectionString)){
                con.Open();  
                using(SqlCommand cmd = new SqlCommand(storeProcedureName, con)){
                    cmd.CommandType = CommandType.StoredProcedure;  
                    if(parameters != null && parameters.Count>0){
                        foreach(DataAccessHelperParameter parameter in parameters){
                            cmd.Parameters.AddWithValue(String.Concat("@",parameter.Name),parameter.Value);
                        }
                    }
                    putResult = cmd.ExecuteNonQuery(); 
                }
                con.Close(); 
            }
            return putResult;
        }
        
        public int Delete(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null){
            int deleteResult = 0;
            using (SqlConnection con = new SqlConnection(connectionString)){
                con.Open();  
                using(SqlCommand cmd = new SqlCommand(storeProcedureName, con)){
                    cmd.CommandType = CommandType.StoredProcedure;  
                    if(parameters != null && parameters.Count>0){
                        foreach(DataAccessHelperParameter parameter in parameters){
                            cmd.Parameters.AddWithValue(String.Concat("@",parameter.Name),parameter.Value);
                        }
                    }
                    deleteResult = cmd.ExecuteNonQuery(); 
                }
                con.Close(); 
            }
            return deleteResult;
        }
    }
}