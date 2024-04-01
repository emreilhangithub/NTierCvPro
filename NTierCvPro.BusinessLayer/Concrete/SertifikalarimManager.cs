using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.UnitOfWork;
using NTierCvPro.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace NTierCvPro.BusinessLayer.Concrete
{
    public class SertifikalarimManager : ISertifikalarimService
    {
        private readonly ISertifikalarimDal _sertifikalarımDal;
        private readonly IUowDal _uowDal;

        public SertifikalarimManager(ISertifikalarimDal sertifikalarımDal, IUowDal uowDal)
        {
            _sertifikalarımDal = sertifikalarımDal;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<Sertifikalarim> t)
        {
            _sertifikalarımDal.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Sertifikalarim> t)
        {
            _sertifikalarımDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(Sertifikalarim t)
        {
            _sertifikalarımDal.Delete(t);
            _uowDal.Save();
        }

        public Sertifikalarim TFind(Expression<Func<Sertifikalarim, bool>> where)
        {
            return _sertifikalarımDal.Find(where);
        }

        public Sertifikalarim TGetById(int id)
        {
            return _sertifikalarımDal.GetById(id);
        }

        public List<Sertifikalarim> TGetList()
        {
            return _sertifikalarımDal.GetList();
        }

        public void TInsert(Sertifikalarim t)
        {
            _sertifikalarımDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Sertifikalarim t)
        {
            _sertifikalarımDal.Update(t);
            _uowDal.Save();
        }
    }
}
