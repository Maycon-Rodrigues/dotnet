using System.Collections.Generic;
using RestWithGenerics.Models;
using RestWithGenerics.Repository.Generic;

namespace RestWithGenerics.Business.Implementations
{
  public class BooksBusinessImplementation : IBooksBusiness
  {
    private readonly IRepository<Books> _repository;

    public BooksBusinessImplementation(IRepository<Books> repository)
    {
      _repository = repository;
    }

    public List<Books> FindAll()
    {
      return _repository.FindAll();
    }

    public Books FindById(long id)
    {
      return _repository.FindById(id);
    }

    public Books Create(Books books)
    {
      return _repository.Create(books);
    }

    public Books Update(Books books)
    {
      return _repository.Update(books);
    }

    public void Delete(long id)
    {
      _repository.Delete(id);
    }
  }
}