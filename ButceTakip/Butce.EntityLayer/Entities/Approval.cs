using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Approval
    {

        public int ApprovalID { get; set; }

        public  MainCode MainCode { get; set; }

        public string Companyname { get; set; }

        public string WorkName { get; set; }

        public string WorkType { get; set; }

        public int VAT { get; set; }

        public int ExcVAT { get; set; }

        public int InVAT { get; set; }

    }
}
