using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class Cliente1
    {
        [Key]
        public int Numero { get; set; }
        [StringLength(50)]
        public string Nombres { get; set; } = string.Empty;
        [StringLength(50)]
        public string Apellidos { get; set; } = string.Empty;
        public int Celular { get; set; }
    }
}
