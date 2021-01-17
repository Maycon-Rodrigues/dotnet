using System.Collections.Generic;
using RestWithGenerics.Models.Base;

namespace RestWithGenerics.Repository.Generic
{
    public interface IRepository<T>
    {
        T Create(T item);
        T FindById(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}