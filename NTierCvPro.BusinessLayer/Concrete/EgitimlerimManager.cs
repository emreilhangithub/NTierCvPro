using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.UnitOfWork;
using NTierCvPro.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace NTierCvPro.BusinessLayer.Concrete
{
    public class EgitimlerimManager : IEgitimlerimService
    {
        private readonly IEgitimlerimDal _egitimlerimDal;
        private readonly IUowDal _uowDal;

        public EgitimlerimManager(IEgitimlerimDal egitimlerimDal, IUowDal uowDal)
        {
            _egitimlerimDal = egitimlerimDal;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<Egitimlerim> t)
        {
            _egitimlerimDal.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Egitimlerim> t)
        {
            _egitimlerimDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(Egitimlerim t)
        {
            _egitimlerimDal.Delete(t);
            _uowDal.Save();
        }

        public Egitimlerim TFind(Expression<Func<Egitimlerim, bool>> where)
        {
            return _egitimlerimDal.Find(where);
        }

        public Egitimlerim TGetById(int id)
        {
            return _egitimlerimDal.GetById(id);
        }

        public List<Egitimlerim> TGetList()
        {
            return _egitimlerimDal.GetList();
        }

        public void TInsert(Egitimlerim t)
        {
            _egitimlerimDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Egitimlerim t)
        {
            _egitimlerimDal.Update(t);
            _uowDal.Save();
        }

    }
}
