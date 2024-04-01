using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.UnitOfWork;
using NTierCvPro.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierCvPro.BusinessLayer.Concrete
{
    public class HobilerimManager : IHobilerimService
    {
        private readonly IHobilerimDal _hobilerimDal;
        private readonly IUowDal _uowDal;

        public HobilerimManager(IHobilerimDal hobilerimDal, IUowDal uowDal)
        {
            _hobilerimDal = hobilerimDal;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<Hobilerim> t)
        {
            _hobilerimDal.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Hobilerim> t)
        {
            _hobilerimDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(Hobilerim t)
        {
            _hobilerimDal.Delete(t);
            _uowDal.Save();
        }

        public Hobilerim TFind(Expression<Func<Hobilerim, bool>> where)
        {
            return _hobilerimDal.Find(where);
        }

        public Hobilerim TGetById(int id)
        {
            return _hobilerimDal.GetById(id);
        }

        public List<Hobilerim> TGetList()
        {
            return _hobilerimDal.GetList();
        }

        public void TInsert(Hobilerim t)
        {
            _hobilerimDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Hobilerim t)
        {
            _hobilerimDal.Update(t);
            _uowDal.Save();
        }
    }
}
