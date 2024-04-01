using Microsoft.VisualBasic;
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
    public class DeneyimlerimManager : IDeneyimlerimService
    {
        private readonly IDeneyimlerimDAl _deneyimlerimDAl;
        private readonly IUowDal _uowDal;

        public DeneyimlerimManager(IDeneyimlerimDAl deneyimlerimDAl, IUowDal uowDal)
        {
            _deneyimlerimDAl = deneyimlerimDAl;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<Deneyimlerim> t)
        {
            _deneyimlerimDAl.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Deneyimlerim> t)
        {
            _deneyimlerimDAl.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(Deneyimlerim t)
        {
            _deneyimlerimDAl.Delete(t);
            _uowDal.Save();
        }

        public Deneyimlerim TFind(Expression<Func<Deneyimlerim, bool>> where)
        {
            return _deneyimlerimDAl.Find(where);
        }

        public Deneyimlerim TGetById(int id)
        {
            return _deneyimlerimDAl.GetById(id);
        }

        public List<Deneyimlerim> TGetList()
        {
            return _deneyimlerimDAl.GetList();
        }

        public void TInsert(Deneyimlerim t)
        {
            _deneyimlerimDAl.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Deneyimlerim t)
        {
            _deneyimlerimDAl.Update(t);
            _uowDal.Save();
        }
    }
}
