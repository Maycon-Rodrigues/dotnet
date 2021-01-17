using System.Collections.Generic;
using RestWithGenerics.Models;

namespace RestWithGenerics.Business
{
  public interface IBooksBusiness
  {
    List<Books> FindAll();
    Books FindById(long id);
    Books Create(Books books);
    Books Update(Books books);
    void Delete(long id);
  }
}