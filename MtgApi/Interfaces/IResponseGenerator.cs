using System.Collections.Generic;
using MtgApi.ResponseTypes;

namespace MtgApi.Interfaces
{
  public interface IResponseGenerator
  {
    CardResponse GetCardById(int id);

    CardResponse GetRandomCard();

    CardResponse GetCardByName(string name);
    IEnumerable<CardResponse> SearchCards(string query);
  }
}