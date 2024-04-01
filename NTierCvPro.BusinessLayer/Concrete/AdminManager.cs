using NTierCvPro.BusinessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.UnitOfWork;
using NTierCvPro.EntityLayer.Concrete;
using System.Linq.Expressions;

namespace NTierCvPro.BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;
        private readonly IUowDal _uowDal;

        public AdminManager(IAdminDal adminDal, IUowDal uowDal)
        {
            _adminDal = adminDal;
            _uowDal = uowDal;
        }

        public void MultiInsert(List<Admin> t)
        {
            _adminDal.MultiInsert(t);
            _uowDal.Save();
        }

        public void MultiUpdate(List<Admin> t)
        {
            _adminDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TDelete(Admin t)
        {
            _adminDal.Delete(t);
            _uowDal.Save();
        }

        public Admin TFind(Expression<Func<Admin, bool>> where)
        {
            return _adminDal.Find(where);
        }

        public Admin TGetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> TGetList()
        {
            return _adminDal.GetList();
        }

        public void TInsert(Admin t)
        {
            _adminDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Admin t)
        {
            _adminDal.Update(t);
            _uowDal.Save();
        }
    }
}
