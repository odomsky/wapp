﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace WApp.Exercises
{
    public class Exercise : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
