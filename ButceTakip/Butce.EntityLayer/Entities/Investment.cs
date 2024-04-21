using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Investment
    {

        public int ID { get; set; }

        public Budget Budget { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
