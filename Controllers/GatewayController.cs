using System;
using Microsoft.AspNetCore.Mvc;

namespace Persist.Controllers
{
    public class GatewayController: Controller
    {
        [HttpGet("gateway")]
        public String Gateway()
        {
            return "{ \"Response\": \"Success\" }";
        }
        
    }
}