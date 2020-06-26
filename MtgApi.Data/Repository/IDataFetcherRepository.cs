using System.Collections.Generic;
using MtgApi.Data.Entities;

namespace MtgApi.Data.Repository
{
  public interface IDataFetcherRepository
  {
    IEnumerable<Cards> GetCardByName(string cardName);
    Cards GetCardById(int id);
    long GetLargestId();
    IEnumerable<Cards> SearchForCards(string query);
  }
}