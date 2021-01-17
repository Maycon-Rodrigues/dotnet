using System.Collections.Generic;
using RestVerbs.Models;

namespace RestVerbs.Business
{
  public interface IBooksBusiness
  {
    List<Books> FindAll();
    Books FindById(string id);
    Books Create(Books books);
    Books Update(Books books);
    void Delete(string id);
  }
}