﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigiEx.Controllers
{
    public class DBConectionController : Controller
    {

        public static SqlConnection con = new SqlConnection
        ("Data Source= DESKTOP-VHF3JQF; database = FUSAVO(Trabajo_Social); Initial Catalog = DatabaseConnectivity;Trusted_Connection=true;");
    }
}