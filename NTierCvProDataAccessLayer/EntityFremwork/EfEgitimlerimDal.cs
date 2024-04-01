using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using NTierCvPro.DataAccessLayer.Repositories;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.DataAccessLayer.EntityFremwork
{
    public class EfEgitimlerimDal : GenericUowRepository<Egitimlerim>, IEgitimlerimDal
    {
        public EfEgitimlerimDal(NTierCvProContext context) : base(context)
        {
        }
    }
}
