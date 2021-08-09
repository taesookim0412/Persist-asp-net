using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persist.Data;

namespace Persist.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PersistContext(serviceProvider.GetRequiredService<DbContextOptions<PersistContext>>()))
            {
                if (context.Server.Any())
                {
                    return;
                }
                context.Server.AddRange(
                    new Server
                    {
                        Ip = "1.1.1.1",
                        Port = "80"
                    },
                    new Server
                    {
                        Ip = "2.2.2.2",
                        Port = "80"
                    },
                    new Server
                    {
                        Ip = "3.3.3.3",
                        Port = "80"
                    },
                    new Server
                    {
                        Ip = "4.4.4.4",
                        Port = "80"
                    },
                    new Server
                    {
                        Ip = "5.5.5.5",
                        Port = "80"
                    }
                    );
                    context.SaveChanges();
            }
        }
    }
}
