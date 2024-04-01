using NTierCvPro.DataAccessLayer.Context;

namespace NTierCvPro.DataAccessLayer.UnitOfWork
{
    public class UowDal : IUowDal
    {
        private readonly NTierCvProContext _context;

        public UowDal(NTierCvProContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
