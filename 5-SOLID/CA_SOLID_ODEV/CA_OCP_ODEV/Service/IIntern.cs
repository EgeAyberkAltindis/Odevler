﻿using CA_OCP_ODEV.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP_ODEV.Service
{
    public interface IIntern
    {
        public int ThrowRandomId();

        public Intern GetID(int id);

        public void AddId(int id);
        

    }
}
