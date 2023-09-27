using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    internal class Database
    {
        string cs;
        NpgsqlConnection con;
       public Database(string address) {
        
        cs = address;
        con = new NpgsqlConnection(cs);
        
       }
        
       public int CompleteNonReturningQuery(string query)
        {
            con.Open();
            var cmd = new NpgsqlCommand(query, con);
            var res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
       public NpgsqlDataReader CompleteSelectQuery(string query)
        {
            con.Open();
            var cmd = new NpgsqlCommand(query, con);
            var res = cmd.ExecuteReader();
            //con.Close();
            return res;
        } 

        public object CompleteQueryWithOneRow(string query)
        {
            con.Open();
            var cmd = new NpgsqlCommand(query, con);
            var res = cmd.ExecuteScalar();
            
            con.Close();
            return res;
        }
        
    }
}
