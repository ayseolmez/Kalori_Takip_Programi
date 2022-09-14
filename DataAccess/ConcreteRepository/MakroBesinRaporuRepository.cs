﻿using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConcreteRepository
{
    public class MakroBesinRaporuRepository : BaseRepository<MakroBesinRaporu>
    {
        public MakroBesinRaporuRepository(KaloriTakipDBContext kaloriTakipDBContext) : base(kaloriTakipDBContext)
        {
        }
    }
}
