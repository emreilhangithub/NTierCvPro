using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using NTierCvPro.DataAccessLayer.Repositories;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.DataAccessLayer.EntityFremwork
{
    public class EfHobilerimDal : GenericUowRepository<Hobilerim>, IHobilerimDal
    {
        public EfHobilerimDal(NTierCvProContext context) : base(context)
        {
        }
    }
}
