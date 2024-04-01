using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierCvPro.DataAccessLayer.Abstract
{
    public interface IGenericUowDal<T> where T : class
    {
        bool Insert(T t);
        bool Delete(T t);
        bool Update(T t);
        List<T> GetList();
        T GetById(int id);
        T Find(Expression<Func<T, bool>> where);
    }
}
