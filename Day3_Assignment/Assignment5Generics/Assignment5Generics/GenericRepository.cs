//Implement a GenericRepository<T> class that implements IRepository<T> interface
//that will have common /CRUD/ operations so that it can work with any data source
//such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
//on T were it should be of reference type and can be of type Entity which has one
//property called Id. IRepository<T> should have following methods
//1. void Add(T item)
//2. void Remove(T item)
//3.Void Save()
//4.IEnumerable < T > GetAll()
//5.T GetById(int id)

using System;
using System.Collections.Generic;
namespace Assignment5Generics
{
    public class BaseEntity
    {
        public int ID { get; set; }
    }

    public class GenericRepository : IRepository<BaseEntity>
    {

        List<BaseEntity> Lst = new();
        public void Add(BaseEntity item)
        {
            Lst.Add(item);
        }

        public IEnumerable<BaseEntity> GetAll()
        {
            foreach(BaseEntity item in Lst)
            {
                return (IEnumerable<BaseEntity>)item;
            }
            return null;
        }

        public BaseEntity GetByID(int id)
        {
            foreach(BaseEntity i in Lst)
            {
                if (i.ID == id)
                {
                    return i;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        public void Remove(BaseEntity item)
        {
            Lst.Remove(item);
        }

        public void Save(BaseEntity item)
        {
            throw new NotImplementedException();
        }
    }
}

