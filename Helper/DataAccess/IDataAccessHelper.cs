using System;
using System.Collections.Generic;
using System.Data; 
namespace Helper
{
    public interface IDataAccessHelper
    {
        DataTable List(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null);
        DataTable Get(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null);
        int Post(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null);
        int Put(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null);
        int Delete(string connectionString, string storeProcedureName, List<DataAccessHelperParameter> parameters = null);
    }
}