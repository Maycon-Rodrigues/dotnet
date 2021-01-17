using System;
using System.Collections.Generic;
using System.Linq;
using RestWithGenerics.Models;
using RestWithGenerics.Models.Context;

namespace RestWithGenerics.Repository.Implementations
{
  public class BooksRepositoryImplementation : IBooksRepository
  {
    private MySQLContext _context;

    public BooksRepositoryImplementation(MySQLContext context)
    {
      _context = context;
    }

    public List<Books> FindAll()
    {
      return _context.Books.ToList();
    }

    public Books FindById(string id)
    {
      return _context.Books.SingleOrDefault(b => b.Id.Equals(id));
    }

    public Books Create(Books books)
    {
      try
      {
        _context.Add(books);
        _context.SaveChanges();
      }
      catch (Exception)
      {
        throw;
      }

      return books;
    }

    public Books Update(Books books)
    {
      var result = _context.Books.SingleOrDefault(b => b.Id.Equals(books.Id));
      if (result == null) return null;

      if (result != null)
      {
        try
        {
          _context.Entry(result).CurrentValues.SetValues(books);
          _context.SaveChanges();
        }
        catch (Exception)
        {
          throw;
        }
      }

      return books;
    }
    public void Delete(string id)
    {
      var result = _context.Books.SingleOrDefault(b => b.Id.Equals(id));
      if (result != null)
      {
        try
        {
          _context.Books.Remove(result);
          _context.SaveChanges();
        }
        catch (Exception)
        {
          throw;
        }
      }
    }
  }
}