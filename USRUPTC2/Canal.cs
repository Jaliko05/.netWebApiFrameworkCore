using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class Canal
    {
        [Key]
        public int CodigoCanal { get; set; }
        [StringLength(50)]
        public string NombreCanal { get; set; } = string.Empty;
        [StringLength(50)]
        public string LogoCanal { get; set; } = string.Empty;
        [StringLength(50)]
        public string TipoCanal { get; set; } = string.Empty;
    }
}
