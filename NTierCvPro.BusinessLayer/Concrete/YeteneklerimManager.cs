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
    public class YeteneklerimManager : IYeteneklerimService
    {
        private readonly IYeteneklerimDal _yeteneklerimDal;
        private readonly IUowDal _uowDal;

        public YeteneklerimManager(IYeteneklerimDal yeteneklerimDal, IUowDal uowDal)
        {
            _yeteneklerimDal = yeteneklerimDal;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<Yeteneklerim> t)
        {
            _yeteneklerimDal.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Yeteneklerim> t)
        {
            _yeteneklerimDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(Yeteneklerim t)
        {
            _yeteneklerimDal.Delete(t);
            _uowDal.Save();
        }

        public Yeteneklerim TFind(Expression<Func<Yeteneklerim, bool>> where)
        {
            return _yeteneklerimDal.Find(where);
        }

        public Yeteneklerim TGetById(int id)
        {
            return _yeteneklerimDal.GetById(id);
        }

        public List<Yeteneklerim> TGetList()
        {
            return _yeteneklerimDal.GetList();
        }

        public void TInsert(Yeteneklerim t)
        {
            _yeteneklerimDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Yeteneklerim t)
        {
            _yeteneklerimDal.Update(t);
            _uowDal.Save();
        }
    }
}
