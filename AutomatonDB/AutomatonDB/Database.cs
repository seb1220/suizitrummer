using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AutomatonDB
{
    internal class Database
    {
        public static int NOT_FOUND = -1;

        private static readonly string CONN_SERVER;
        private static readonly string CONN_DATABASE;
        private static readonly string CONN_USER_ID;
        private static readonly string CONN_PASSWORD;

        private static SqlConnection conn;

        // static Constructor
        // used at first time class is used
        static Database()
        {
            string line;
            string[] parts;

            StreamReader sr = new StreamReader("../../config.txt");
            line = sr.ReadLine();
            parts = line.Split('=');
            Console.WriteLine(parts[1]);
            line = sr.ReadLine();
            parts = line.Split('=');
            CONN_DATABASE = parts[1];
            line = sr.ReadLine();
            parts = line.Split('=');
            CONN_USER_ID = parts[1];
            line = sr.ReadLine();
            parts = line.Split('=');
            CONN_PASSWORD = parts[1];
        }

        private Database()
        {

        }

        private static SqlConnection GetSqlConnection()
        {

            if (conn == null)
            {
                conn = new SqlConnection();
                conn.ConnectionString =
                    "server=" + CONN_SERVER + ";" +
                    "database=" + CONN_DATABASE + ";" +
                    "user id=" + CONN_USER_ID + ";" +
                    "password=" + CONN_PASSWORD + "; MultipleActiveResultSets=True";
            }
            return conn;
        }

        public static SqlConnection Connect()
        {
            GetSqlConnection();
            conn.Open();
            return conn;
        }

        public static void Disconnect()
        {
            if (conn != null)
                conn.Close();
        }

        public static int PostAutomaton(String desc, Dictionary<string, State> states, State start, List<string> alphabet)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into Automaton (desc) values (" + desc + ");";
            cmd.ExecuteScalar();
            
            foreach (var stateDesc in states.Keys)
            {
                //cmd.CommandText = "insert into State values (" 
            }
            return 0;
        }

        public static int GetID(string table, string description)
        {
            int id = NOT_FOUND;
            SqlDataReader reader;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID From " + table + " Where Description='" + description + "'";

            reader = cmd.ExecuteReader();

            if (reader.Read())
                id = (int)reader[0];
            reader.Close();

            return id;
        }

        public static int GetIDClass(string description, int idSchool)
        {
            int id = NOT_FOUND;
            SqlDataReader reader;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID From Class WHERE Description='" + description + "' AND ";
            cmd.CommandText += "ID_School=" + idSchool;

            reader = cmd.ExecuteReader();

            if (reader.Read())
                id = (int)reader[0];
            reader.Close();

            return id;
        }

        public static int GetIDTeacher(string description, int idSchool)
        {
            int id = NOT_FOUND;
            SqlDataReader reader;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID From Teacher WHERE Description='" + description + "' AND ";
            cmd.CommandText += "ID_School=" + idSchool;

            reader = cmd.ExecuteReader();

            if (reader.Read())
                id = (int)reader[0];
            reader.Close();

            return id;
        }
    }
}