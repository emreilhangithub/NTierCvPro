using System.Linq.Expressions;

namespace NTierCvPro.BusinessLayer.Abstract
{
    public interface IGenericUowService<T> where T : class
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);
        T TFind(Expression<Func<T, bool>> where);
        void MultiInsert(List<T> t);
        void MultiUpdate(List<T> t);
    }
}
