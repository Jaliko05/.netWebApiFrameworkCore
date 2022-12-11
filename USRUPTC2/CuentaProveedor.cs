using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace USRUPTC1.Models
{
    public partial class CuentaProveedor
    {
        public int Id { get; set; } 


        public int ProveedorId { get; set; }
        public Proveedor? Proveedor { get; set; }

        public int CuentumId { get; set; }
        public Cuentum? Cuentum { get; set; }

        public int PlanId { get; set; }
        public Plan? Plan { get; set; }

        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }




    }
}
