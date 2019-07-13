using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class PersonController : PersonModel, IDataBaseMethods
    {
        public void addElement()
        {
            
        }

        public void editElement()
        {
            throw new NotImplementedException();
        }

        public void fetchElement()
        {
            throw new NotImplementedException();
        }

        public void findElement()
        {
            throw new NotImplementedException();
        }
    }
}
