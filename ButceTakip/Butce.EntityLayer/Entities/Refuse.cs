using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public  class Refuse
    {
        public int RefuseID  { get; set; }

        public string RefuseReason { get; set; }


        public MainCode MainCode { get; set; }
    }
}
