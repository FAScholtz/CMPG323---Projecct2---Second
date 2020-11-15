using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dim_Dat_Pro_2._0.Models
{
    public class DimDatSet
    {
        [Key]
        public string employeeNumber { get; set; }
        public string age { get; set; }
        public string department { get; set; }
    }
}
