using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Harvir_Pen_Ass_1.Models;

namespace Harvir_Pen_Ass_1.Data
{
    public class PenContext : DbContext
    {
        public PenContext(DbContextOptions<PenContext> options) : base(options)
        {
        }

        public DbSet<Pen> Pen { get; set; }
    }
}
