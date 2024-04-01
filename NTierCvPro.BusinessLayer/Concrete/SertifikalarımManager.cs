using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.UnitOfWork;
using NTierCvPro.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace NTierCvPro.BusinessLayer.Concrete
{
    public class SertifikalarımManager : ISertifikalarımService
    {
        private readonly ISertifikalarımDal _sertifikalarımDal;
        private readonly IUowDal _uowDal;

        public SertifikalarımManager(ISertifikalarımDal sertifikalarımDal, IUowDal uowDal)
        {
            _sertifikalarımDal = sertifikalarımDal;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<Sertifikalarım> t)
        {
            _sertifikalarımDal.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Sertifikalarım> t)
        {
            _sertifikalarımDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(Sertifikalarım t)
        {
            _sertifikalarımDal.Delete(t);
            _uowDal.Save();
        }

        public Sertifikalarım TFind(Expression<Func<Sertifikalarım, bool>> where)
        {
            return _sertifikalarımDal.Find(where);
        }

        public Sertifikalarım TGetById(int id)
        {
            return _sertifikalarımDal.GetById(id);
        }

        public List<Sertifikalarım> TGetList()
        {
            return _sertifikalarımDal.GetList();
        }

        public void TInsert(Sertifikalarım t)
        {
            _sertifikalarımDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Sertifikalarım t)
        {
            _sertifikalarımDal.Update(t);
            _uowDal.Save();
        }
    }
}
