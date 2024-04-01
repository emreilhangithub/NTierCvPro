using System.Linq.Expressions;

namespace NTierCvPro.DataAccessLayer.Abstract
{
    public interface IGenericUowDal<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
        T Find(Expression<Func<T, bool>> where);
        void MultiUpdate(List<T> t);
        void MultiInsert(List<T> t);
    }
}
