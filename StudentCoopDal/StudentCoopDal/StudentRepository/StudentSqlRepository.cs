using StudentCoopCommon;
using StudentCoopCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.SqlClient;
using System.Configuration;
using ConsoleApp.Shared;
using System.Data;

namespace StudentCoopDal

{
    public class StudentSqlRepository : IStudentRepository
    {
        private string devConnectionString;

        private SqlConnection GetConnection()
        {
            return new SqlConnection(this.devConnectionString);
        }

        public void Add(Student student)
        {
            var sqlConnection = GetConnection();

            string sqlADD = string.Format("INSERT INTO dbo.student {0}", student);
            SqlCommand command = this.GetSqlCommand(sqlADD, sqlConnection);
            sqlConnection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            sqlConnection.Close();

            Console.WriteLine("rowsAffected = {0}", rowsAffected);
        }

        public void Delete(string id)
        {
            var sqlConnection = GetConnection();

            string sqlDelete = string.Format("DELETE FROM dbo.student WHERE ID='{0}'", id);
            SqlCommand command = this.GetSqlCommand(sqlDelete, sqlConnection);
            sqlConnection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            sqlConnection.Close();

            Console.WriteLine("rowsAffected = {0}", rowsAffected);
        }

        public Student Get(string id)
        {
            SqlConnection sqlConnection = this.GetConnection();
            string sqlSelect = "SELECT COUNT(*) FROM dbo.student WHERE id == "+id;

            SqlCommand command = new SqlCommand(sqlSelect, sqlConnection);

            sqlConnection.Open();
            var count = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();

            Console.WriteLine("Count is = {0}", count);
        }

        public void Update(string id,Student student)
        {
            var sqlConnection = GetConnection();

            string sqlUpdate = string.Format("MODIFY FROM dbo.student WHERE ID='{0}' {1}", id, student);
            SqlCommand command = this.GetSqlCommand(sqlUpdate, sqlConnection);
            sqlConnection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            sqlConnection.Close();

            Console.WriteLine("rowsAffected = {0}", rowsAffected);
        }
    }
}