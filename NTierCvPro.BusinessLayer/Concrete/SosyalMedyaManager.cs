using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.UnitOfWork;
using NTierCvPro.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace NTierCvPro.BusinessLayer.Concrete
{
    public class SosyalMedyaManager : ISosyalMedyaService
    {
        private readonly ISosyalMedyaDal _sosyalMedyaDal;
        private readonly IUowDal _uowDal;

        public SosyalMedyaManager(ISosyalMedyaDal sosyalMedyaDal, IUowDal uowDal)
        {
            _sosyalMedyaDal = sosyalMedyaDal;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<SosyalMedya> t)
        {
            _sosyalMedyaDal.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<SosyalMedya> t)
        {
            _sosyalMedyaDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(SosyalMedya t)
        {
            _sosyalMedyaDal.Delete(t);
            _uowDal.Save();
        }

        public SosyalMedya TFind(Expression<Func<SosyalMedya, bool>> where)
        {
            return _sosyalMedyaDal.Find(where);
        }

        public SosyalMedya TGetById(int id)
        {
            return _sosyalMedyaDal.GetById(id);
        }

        public List<SosyalMedya> TGetList()
        {
            return _sosyalMedyaDal.GetList();
        }

        public void TInsert(SosyalMedya t)
        {
            _sosyalMedyaDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(SosyalMedya t)
        {
            _sosyalMedyaDal.Update(t);
            _uowDal.Save();
        }
    }
}
