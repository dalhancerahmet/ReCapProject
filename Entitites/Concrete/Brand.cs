﻿using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.Concrete
{
    public class Brand:IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
