using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DigiEx.Controllers
{
    public class DBConection
    {
        SqlConnection con = new SqlConnection
        ("Data Source=.;Initial Catalog = DatabaseConnectivity;Trusted_Connection=true;");
    }
}
