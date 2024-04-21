﻿using Butce.DataAccessLayer.Abstract;
using Butce.DataAccessLayer.Concrete;
using Butce.DataAccessLayer.Repositories;
using Butce.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DataAccessLayer.EntityFramework
{
    public class EfAppControlDal : GenericRepository<AppControl>, IAppControlDal
    {
        public EfAppControlDal(ButceContext context) : base(context)
        {
        }
    }
}
