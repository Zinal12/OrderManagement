using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OrderManagement_DataLayer
{
    public class DataObject
    {
        
            private String _ConnectionString { get; set; }
            private SqlTransaction _transaction { get; set; }

            public DataObject()
            {
                _ConnectionString = ConfigurationManager.ConnectionStrings["OrderCS"].ConnectionString;

            }
            public DataObject(SqlTransaction trans)
            {
                _ConnectionString = ConfigurationManager.ConnectionStrings["OrderCS"].ConnectionString;
                _transaction = trans;
            }

            public string ConnectionString => _ConnectionString;
            public SqlTransaction Transaction => _transaction;

        
    }
}