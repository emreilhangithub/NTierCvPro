using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using NTierCvPro.DataAccessLayer.Repositories;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.DataAccessLayer.EntityFremwork
{
    public class EfSertifikalarimDal : GenericUowRepository<Sertifikalarim>, ISertifikalarimDal
    {
        public EfSertifikalarimDal(NTierCvProContext context) : base(context)
        {
        }
    }
}
