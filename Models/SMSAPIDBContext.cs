using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruckAppAPISolution.Models
{
    public class SMSAPIDBContext:DbContext
    {
        public SMSAPIDBContext(DbContextOptions<SMSAPIDBContext> options) : base(options)
        {
            
        }
        public DbSet<SMSCallback> smsCallback{ get; set; }
    }
}
