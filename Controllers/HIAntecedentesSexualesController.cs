﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{

    public class HIAntecedentesSexualesController : IDataBaseMethods
    {
        public void addElement(object o)
        {
            HIAntecedentesSexualesModel antecedentesSexuales = (HIAntecedentesSexualesModel)o;

        }

        public void editElement(int id, object o)
        {
            throw new NotImplementedException();
        }

        public void fetchElement(string f)
        {
            throw new NotImplementedException();
        }

        public void findElement(int id)
        {
            throw new NotImplementedException();
        }

    }

}
