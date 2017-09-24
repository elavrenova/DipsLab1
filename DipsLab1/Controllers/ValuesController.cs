using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DipsLab1.Controllers
{
    [Route("/")]
    public class ValuesController : Controller
    {

        // GET api/values/5
        [HttpGet("{id}")]
        public string GetString(int id, [FromQuery] string name)
        {
            if (String.IsNullOrWhiteSpace(name))
                name = "Somebody";
            if (id == 0)
                return name + " doesn't have any cats";
            else
                return name + " has " + id + " cats";
        }


    }
}
