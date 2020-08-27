﻿using System;
using System.Collections.Generic;
using System.Text;
using infrastructure;
using core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;
using Pos.Repositorie;

namespace core.Repositorie
{
    public class GenirecRepositorie<T> : IGenericRepository<T> where T : class
    {

        protected readonly DataContext _context;

        public GenirecRepositorie(DataContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            await _context.AddRangeAsync(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicte, params Expression<Func<T, object>>[] includes)
        {
            var query = _context.Set<T>().Where(predicte);
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }



        public async Task<T> FindOne(Expression<Func<T, bool>> predicte)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicte);
        }

       

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.RemoveRange(entities);
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

      


      

    }
}
