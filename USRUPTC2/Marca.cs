using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class Marca
    {
       
        [Key]
        public int NumMarca { get; set; }

        [StringLength(50)]
        public string Marca1 { get; set; } = string.Empty;
        public DateTime FechaRegustro { get; set; }

    }
}
