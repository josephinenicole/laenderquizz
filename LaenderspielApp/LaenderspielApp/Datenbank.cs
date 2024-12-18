using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace LaenderspielApp
{
    public static class Datenbank
    {
        


        private static MySqlConnection conn = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=laenderquiz;");

        public static void VerbindungOeffnen()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static MySqlCommand BefehlErstellen(string query, params MySqlParameter[] parameters)
        {
            VerbindungOeffnen();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandText = query;

            // Fügt Parameter hinzu
            foreach (var parameter in parameters)
            {
                cmd.Parameters.Add(parameter);
            }

            return cmd;
        }

        public static void VerbindungSchliessen()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }

}
