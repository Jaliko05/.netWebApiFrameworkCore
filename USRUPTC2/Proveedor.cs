using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class Proveedor
    {
        [Key]
        public int CodProveedor { get; set; }

        [StringLength(50)]
        public string DscProveedot { get; set; } = string.Empty;

        [StringLength(50)]
        public string PaginaWeb { get; set; } = string.Empty;

        public int Telefono { get; set; }

        [StringLength(50)]
        public string Contacto { get; set; } = string.Empty;

        public int MarcaId { get; set; }
        public  Marca? Marca { get; set; } 
    }
}
