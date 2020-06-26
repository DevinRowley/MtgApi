using System.Collections.Generic;
using MtgApi.Data.Entities;

namespace MtgApi.Data.Services
{
  public interface IAdvancedSearch
  {
    IEnumerable<Cards> SearchCards(string query);
  }
}