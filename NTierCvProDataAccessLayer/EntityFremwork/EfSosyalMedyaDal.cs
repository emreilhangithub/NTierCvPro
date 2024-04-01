using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using NTierCvPro.DataAccessLayer.Repositories;
using NTierCvPro.EntityLayer.Concrete;

namespace NTierCvPro.DataAccessLayer.EntityFremwork
{
    public class EfSosyalMedyaDal : GenericUowRepository<SosyalMedya>, ISosyalMedyaDal
    {
        public EfSosyalMedyaDal(NTierCvProContext context) : base(context)
        {
        }
    }
}
