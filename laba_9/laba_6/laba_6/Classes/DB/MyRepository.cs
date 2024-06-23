﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    public class MyRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext context;
        private readonly DbSet<T> dbSet;

        public MyRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsNoTracking().ToList();
        }

        public T Get(int id)
        {
            return dbSet.Find(id)!;
        }

        public void Create(T item)
        {
            dbSet.Add(item);
            context.SaveChanges();
        }
        public void Add(T item)
        {
            dbSet.Add(item);
        }
        public void Update(T item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            T item = dbSet.Find(id)!;
            if (item != null)
                dbSet.Remove(item);
            context.SaveChanges();
        }

        public void Del(int id)
        {
            T item = dbSet.Find(id)!;
            if (item != null)
                dbSet.Remove(item);
        }
    }
}
