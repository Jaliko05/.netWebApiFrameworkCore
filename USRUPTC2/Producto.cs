using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class Producto
    {
        [Key]
        public int CodProducto { get; set; }

        [StringLength(50)]
        public string DscProducto { get; set; } = string.Empty;

        [StringLength(50)]
        public string Cargo { get; set; } = string.Empty;


        public int TipoProductoId { get; set; }
        public TipoProducto? TipoProducto { get; set; }


        public int OrigenId { get; set; }
        public Origen? Origen { get; set; }

        
    }
}
