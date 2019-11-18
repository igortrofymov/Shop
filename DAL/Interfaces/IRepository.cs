using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;

namespace DAL.Interfaces
{
    public interface IRepositiry<T> where T : class
    {
        IQueryable<Make> GetAll();
        T Get(string id);
        //IEnumerable<T> Find(Func<T, Boolean> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(string id);
    }
}
