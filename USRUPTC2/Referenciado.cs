using System;
using System.Collections.Generic;

namespace USRUPTC1.Models
{
    public partial class Referenciado
    {
        public int Id { get; set; }


        public int ClienteId { get; set; }
        public  Cliente? Cliente { get; set; }

        public int Cliente1Id { get; set; }
        public  Cliente1? Cliente1 { get; set; } 
    }
}
