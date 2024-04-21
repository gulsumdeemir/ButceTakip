using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Realization
    {
        public int RealizationID { get; set; }
        public MainCode MainCode { get; set; }

        public string Subcode { get; set; }

        public string WorkName { get; set; }

        public bool PayStatus { get; set; }

        public float UsableBudget { get; set; }

        public float RemaningBudget { get; set; }

        public float TotalExpenditure { get; set; }

        public int TotalAmount { get; set; }

    }
}
