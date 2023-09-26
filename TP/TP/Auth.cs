using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TP
{
    internal class Auth
    {
        Database db; 
        public Auth(Database db) 
        {
            this.db = db;
        }

        public int Login(string username, string password)
        {
            var query = String.Format("SELECT * FROM \"user\" where username = '{0}' and password = '{1}'", username, password);
            var user = db.CompleteSelectQuery(query);
            if (user.Read()){
                return 0;
            }
            return -1;
        }
        public int SignUp(string username, string password) 
        {
            var query = String.Format("INSERT INTO \"user\" (username, password, balance) VALUES ('{0}', '{1}', 0)", username, password);
            return db.CompleteNonReturningQuery(query); // if it returns 1+ rows - ok, otherwise - false
            
        }
    }
}
