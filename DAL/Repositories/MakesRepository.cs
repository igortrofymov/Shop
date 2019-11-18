using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class MakesRepository : IRepositiry<Make>
    {
        private ApplicationContext db;

        public MakesRepository(ApplicationContext db)
        {
            this.db = db;
        }
        public IQueryable<Make> GetAll()
        {
            return db.Makes.Include(m=>m.Products);
        }

        public Make Get(string id)
        {
            return db.Makes.Find(id);
        }

        public void Create(Make item)
        {
            db.Makes.Add(item);
            db.SaveChanges();
        }

        public void Update(Make item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            Make make = db.Makes.Find(id);
            if (make != null)
            {
                db.Makes.Remove(make);
                db.SaveChanges();
            }
        }
    }
}
