using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WareSystem.Classes
{
    public static class DBConnector
    {
        static MySqlConnection connector = new MySqlConnection(
            "server=31.31.196.94;" +
            "port=3306;" +
            "username=u2194893_proot;" +
            "password=GDcKIEW5qlT78gRAVUjXFQ06itM1J4vrB9Sye3PHoYHJLe38SGE6nAWi6Z3bEdj0;" +
            "database=u2194893_posuda"
        );
    }
}
