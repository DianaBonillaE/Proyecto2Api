﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Proyecto2MechanicalApi.Controllers
{
    [Produces("application/json")]
    [Route("api/vehicleDetail")]
    public class VehicleDetailController : Controller
    {
        private readonly IConfiguration configuration;

        public VehicleDetailController(IConfiguration configuration)
        {
            //this.configuration = configuration;
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

    }
}


