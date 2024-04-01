using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using NTierCvPro.DataAccessLayer.Repositories;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.DataAccessLayer.EntityFremwork
{
    public class EfDeneyimlerimDal : GenericUowRepository<Deneyimlerim>, IDeneyimlerimDAl
    {
        public EfDeneyimlerimDal(NTierCvProContext context) : base(context)
        {
        }
    }
}
