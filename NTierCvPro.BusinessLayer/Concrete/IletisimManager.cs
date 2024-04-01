using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.UnitOfWork;
using NTierCvPro.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace NTierCvPro.BusinessLayer.Concrete
{
    public class IletisimManager : IIletisimService
    {
        private readonly IIletisimDal _ıletisimDal;
        private readonly IUowDal _uowDal;

        public IletisimManager(IIletisimDal ıletisimDal, IUowDal uowDal)
        {
            _ıletisimDal = ıletisimDal;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<Iletisim> t)
        {
            _ıletisimDal.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Iletisim> t)
        {
            _ıletisimDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(Iletisim t)
        {
            _ıletisimDal.Delete(t);
            _uowDal.Save();
        }

        public Iletisim TFind(Expression<Func<Iletisim, bool>> where)
        {
            return _ıletisimDal.Find(where);
        }

        public Iletisim TGetById(int id)
        {
            return _ıletisimDal.GetById(id);
        }

        public List<Iletisim> TGetList()
        {
            return _ıletisimDal.GetList();
        }

        public void TInsert(Iletisim t)
        {
            _ıletisimDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Iletisim t)
        {
            _ıletisimDal.Update(t);
            _uowDal.Save();
        }
    }
}
