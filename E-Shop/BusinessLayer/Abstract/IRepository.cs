﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRepository<T> where T:class,new()
    {
        List<T> List();
        void Insert(T p); //parametre aldı
        void Delete(T p);
        void Update(T p);
        T GetById(int id);

    }
}
