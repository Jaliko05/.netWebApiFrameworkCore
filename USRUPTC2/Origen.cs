using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class Origen
    {
       
        [Key]
        public int CodOrigen { get; set; }

        [StringLength(50)]
        public string DscOrigen { get; set; } = string.Empty;


    }
}
