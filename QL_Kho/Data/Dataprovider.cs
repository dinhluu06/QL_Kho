﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_Kho.Data
{
    class Dataprovider
    {
        private static SqlConnection conn;


        //tao ket noi vs sql
        public static SqlConnection Connect()
        {
            try
            {
                string sql = @"Data Source=DESKTOP-3LCR569\SQLEXPRESS;Initial Catalog=Quan_Ly_Kho;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sql);
                conn.Open();

                return conn;
            }
            catch (SqlException)
            {
                return null;
            }
        }




        //Dua du lieu vao bang
        public static DataTable GetData(string proc)
        {
            try
            {
                conn = Connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }

        //thuc hien thu tuc
        public static int ExecuteNonQuery(string proc, SqlParameter[] para)
        {
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);

                int val = cmd.ExecuteNonQuery();
                conn.Close();
                return val;
            }
            catch (SqlException)
            {
                return 0;
            }
        }
    }
}
