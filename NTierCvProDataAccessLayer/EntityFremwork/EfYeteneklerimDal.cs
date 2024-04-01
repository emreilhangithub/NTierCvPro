using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using NTierCvPro.DataAccessLayer.Repositories;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.DataAccessLayer.EntityFremwork
{
    public class EfYeteneklerimDal : GenericUowRepository<Yeteneklerim>, IYeteneklerimDal
    {
        public EfYeteneklerimDal(NTierCvProContext context) : base(context)
        {
        }
    }
}
