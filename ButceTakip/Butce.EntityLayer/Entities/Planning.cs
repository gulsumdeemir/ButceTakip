using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Planning
    {

        public int PlanID { get; set; }

        public MainCode MainCode { get; set; }

        public string Companyname { get; set; }

        public string WorkName { get; set; }

        public string WorkType { get; set; }

        public int VAT { get; set; }

        public int ExcVAT { get; set; }

        public int InVAT { get; set; }

        public bool PayStatus { get; set; }

        public float UsableBudget { get; set; }

         public float AvailableBudget { get; set; }

        public float RemaningBudget { get; set; }

        public float TotalExpenditure { get; set; }

       public int RowNumber { get; set; }

        public int Documents { get; set; }

        public string Image { get; set; }


    }
}

