using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MtgApi.Data.Entities;
using MtgApi.Data.Services;

namespace MtgApi.Data.Repository
{
  public class DataFetcherRepository : IDataFetcherRepository
  {
    private readonly AllPrintingsContext _context;
    private readonly IAdvancedSearch _search;

    public DataFetcherRepository(AllPrintingsContext context, IAdvancedSearch search)
    {
      _context = context;
      _search = search;
    }

    public IEnumerable<Cards> GetCardByName(string cardName)
    {
      var result = from c in _context.Cards
        where EF.Functions.Like(c.Name, $"%{cardName}%")
        select c;
      
      return result;
    }

    public Cards GetCardById(int id)
    {
      var result = _context.Cards
        .Where(x => x.Id == id)
        .AsNoTracking()
        .FirstOrDefault();

      if (result == null)
      {
        return null;
      }

      result.Rulings = _context.Rulings.Where(x => x.Uuid == result.Uuid).Select(x => new Rulings
      {
        Date = x.Date,
        Id = x.Id,
        Text = x.Text,
        Uuid = x.Uuid
      }).AsNoTracking().ToList();

      return result;
    }

    public long GetLargestId()
    {
      var result = _context.Cards.Max(x => x.Id);
      return result;
    }

    public IEnumerable<Cards> SearchForCards(string query)
    {
      var result = _search.SearchCards(query);
      return result;
    }
  }
}
