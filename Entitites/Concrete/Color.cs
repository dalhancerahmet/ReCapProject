﻿using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.Concrete
{
    public class Color:IEntity
    {
        public int id { get; set; }
        public string ColorName { get; set; }
    }
}
