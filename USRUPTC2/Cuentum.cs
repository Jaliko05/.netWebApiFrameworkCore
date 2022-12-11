using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class Cuentum
    {
        [Key]
        public int CodCuenta { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; } = string.Empty;
        public int Telefono { get; set; }
    }
}
