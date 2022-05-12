﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDonaMariana.Forms
{
    public abstract class EntidadeBase
    {

        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; protected set; }

    }
}
