using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using NTierCvPro.DataAccessLayer.Repositories;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.DataAccessLayer.EntityFremwork
{
    public class EfIletisimDal : GenericUowRepository<Iletisim>, IIletisimDal
    {
        public EfIletisimDal(NTierCvProContext context) : base(context)
        {
        }
    }
}
