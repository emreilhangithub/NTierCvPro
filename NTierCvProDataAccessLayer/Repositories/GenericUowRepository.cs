﻿using Microsoft.EntityFrameworkCore;
using NTierCvPro.DataAccessLayer.Abstract;
using NTierCvPro.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
            _context.Remove(t);
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().AsNoTracking().FirstOrDefault(where);
        }

        public T GetById(int id)
        {
            //belirtilen ID'ye sahip nesneyi alır.
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
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
            _context.UpdateRange(t); //toplu güncelleme yapar.
        }
        public void MultiInsert(List<T> t)
        {
            _context.AddRange(t); // toplu ekleme yapar.
        }
    }
}
