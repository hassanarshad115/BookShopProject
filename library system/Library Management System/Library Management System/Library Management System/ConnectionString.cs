using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Library_Management_System
{
    class ConnectionString
    {
        public static SqlConnection My_Sql_Connection;
        public static SqlConnection GetConnection()
        {
            if (My_Sql_Connection == null)
            {
                My_Sql_Connection = new SqlConnection();
                My_Sql_Connection.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\Mawaat\InProgress\LMS\Library Management System\Library Management System\LMS.mdf;Integrated Security=True;User Instance=True";
                My_Sql_Connection.Open();
            }
            return My_Sql_Connection;
        }
    }
}
