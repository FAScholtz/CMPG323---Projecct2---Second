using Dim_Dat_Pro_2._0.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dim_Dat_Pro_2._0.Data
{
    public class DimDatSetContext : DbContext
    {
        public DimDatSetContext(DbContextOptions<DimDatSetContext> options)
            : base(options)
        {
        }
        public DbSet<DimDatSet> DimDatSets { get; set; }
    }
}
