using System;
using System.Collections.Generic;

namespace USRUPTC1.Models
{
    public partial class PlanCanal
    {
        public int Id { get; set; }

        public int PlanId { get; set; }
        public Plan? Plan { get; set; }


        public int CanalId { get; set; }
        public Canal? Canal { get; set; }
    }
}
