using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class TipoProducto
    {
        
        [Key]
        public int Consecutivo { get; set; }


        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;


    }
}
