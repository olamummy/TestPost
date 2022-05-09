using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MIMPOC1.Models;

namespace MIMPOC1.Data
{
    public class MIMPOC1Context : DbContext
    {
        public MIMPOC1Context (DbContextOptions<MIMPOC1Context> options)
            : base(options)
        {
        }

        public DbSet<MIMPOC1.Models.Employee> Employee { get; set; }
    }
}
