using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class Plan
    {
        [Key]
        public int Codigo { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        public int Costo { get; set; }
    }
}
