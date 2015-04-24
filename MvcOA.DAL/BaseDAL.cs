using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcOA.DAL
{
    class BaseDAL<T> where T:class,new ()
    {
        //T Add(T entity);
        //bool Update(T entity);
        //bool Delete(T entity);
        //bool Delete(params int[] ids);
        //IQueryable<T> GetEntities(Func<T, bool> whereLamada);
        //IQueryable<T> GetPagesEntities<S>(int pageIndex, int pageSize, out int totalPage, Func<T, bool> whereLamada, Func<S, T> orderByLamada, bool isAsc);
    }
}
