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
    public class HakkimdaManager : IHakkimdaService
    {
        private readonly IHakkimdaDal _hakkimdaDal;
        private readonly IUowDal _uowDal;

        public HakkimdaManager(IHakkimdaDal hakkimdaDal, IUowDal uowDal)
        {
            _hakkimdaDal = hakkimdaDal;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<Hakkimda> t)
        {
            _hakkimdaDal.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Hakkimda> t)
        {
            _hakkimdaDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(Hakkimda t)
        {
            _hakkimdaDal.Delete(t);
            _uowDal.Save();
        }

        public Hakkimda TFind(Expression<Func<Hakkimda, bool>> where)
        {
            return _hakkimdaDal.Find(where);
        }

        public Hakkimda TGetById(int id)
        {
            return _hakkimdaDal.GetById(id);
        }

        public List<Hakkimda> TGetList()
        {
            return _hakkimdaDal.GetList();
        }

        public void TInsert(Hakkimda t)
        {
            _hakkimdaDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Hakkimda t)
        {
            _hakkimdaDal.Update(t);
            _uowDal.Save();
        }
    }
}
