using Microsoft.EntityFrameworkCore;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using System.Linq.Expressions;

namespace NTierCvPro.DataAccessLayer.Repositories
{
    public class GenericUowRepository<T> : IGenericUowDal<T> where T : class
    {
        private readonly NTierCvProContext _context;
        public GenericUowRepository(NTierCvProContext context)
        {
            _context = context;
        }
        public void Delete(T t)
        {
            _context.Remove(t); //nesneyi siler.
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().AsNoTracking().FirstOrDefault(where);
            //berlitilen nesneyi where koşuluna göre döner
            //AsNoTracking izlemeyi engeller.
        }
        public T GetById(int id)
        {            
            return _context.Set<T>().Find(id); //belirtilen ID'ye sahip nesneyi alır.
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList(); // tüm datayı çekip liste olarak döner.
        }

        public void Insert(T t)
        {
            _context.Add(t); //nesneyi ekler
        }

        public void Update(T t)
        {
            _context.Update(t); // nesneyi günceller
        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t); //nesneyi toplu günceller.
        }
        public void MultiInsert(List<T> t)
        {
            _context.AddRange(t); // nesneyi toplu ekler.
        }
    }
}
