//1. void Add(T item)
//2. void Remove(T item)
//3.Void Save()
//4.IEnumerable < T > GetAll()
//5.T GetById(int id)
using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment5Generics
{
    public interface IRepository<T> where T: BaseEntity
    {
        public void Add(T item);
        public void Remove(T item);
        public void Save(T item);
        public IEnumerable<T> GetAll();
        public T GetByID(int id);
    }
}

