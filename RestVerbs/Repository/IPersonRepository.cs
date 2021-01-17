using System.Collections.Generic;
using RestVerbs.Models;

namespace RestVerbs.Repository
{
  public interface IPersonRepository
  {
    Person Create(Person person);
    Person FindById(long id);
    List<Person> FindAll();
    Person Update(Person person);
    void Delete(long id);
  }
}