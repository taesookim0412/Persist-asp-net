using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persist.Data;

namespace Persist.Controllers
{
    public class GatewayController: Controller
    {
        private readonly PersistContext _context;

        public GatewayController(PersistContext context)
        {
            _context = context;
        }

        [HttpGet("gateway")]
        public String Gateway()
        {
            return "{ \"Response\": \"Success\" }";
        }

        [HttpGet("api/servers")]
        public async Task<String> Servers()
        {
            return JsonSerializer.Serialize(await _context.Server.ToListAsync());
        }
        
    }
}