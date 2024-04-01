using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using NTierCvPro.DataAccessLayer.Repositories;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.DataAccessLayer.EntityFremwork
{
    public class EfHakkimdaDal : GenericUowRepository<Hakkimda>, IHakkimdaDal
    {
        public EfHakkimdaDal(NTierCvProContext context) : base(context)
        {
        }
    }
}
