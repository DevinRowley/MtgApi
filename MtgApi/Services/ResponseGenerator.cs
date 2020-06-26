using System;
using System.Collections.Generic;
using System.Linq;
using MtgApi.Data.Repository;
using MtgApi.Interfaces;
using MtgApi.ResponseTypes;

namespace MtgApi.Services
{
  public class ResponseGenerator : IResponseGenerator
  {
    private readonly IDataFetcherRepository _dataFetcher;

    public ResponseGenerator(IDataFetcherRepository dataFetcher)
    {
      _dataFetcher = dataFetcher ?? throw new ArgumentNullException(nameof(dataFetcher));
    }

    public CardResponse GetCardById(int id)
    {
      var cardFromDb = _dataFetcher.GetCardById(id);

      return new CardResponse
      {
        CardFullType = cardFromDb.Type, 
        CardSubType = cardFromDb.Subtypes,
        CardSuperType = cardFromDb.Supertypes,
        CardType = cardFromDb.Types,
        Cmc = cardFromDb.ConvertedManaCost.ToString(),
        FlavorText = cardFromDb.FlavorText,
        ManaCost = cardFromDb.ManaCost,
        Name = cardFromDb.Name,
        Power = cardFromDb.Power,
        Text = cardFromDb.Text,
        Toughness = cardFromDb.Toughness,
        Rarity = cardFromDb.Rarity,
        Loyalty = cardFromDb.Loyalty,
      };
    }

    public CardResponse GetRandomCard()
    {
      var random = new Random();

      var max = Convert.ToInt32(_dataFetcher.GetLargestId()) + 1;
      var randomId = random.Next(max);


      return GetCardById(randomId);
    }

    public CardResponse GetCardByName(string name)
    {
      var cardsFromDb = _dataFetcher.GetCardByName(name).ToList();

      var card = cardsFromDb.FirstOrDefault();

      if (card == null)
      {
        return new CardResponse();
      }

      return new CardResponse
      {
        CardFullType = card.Type,
        CardSubType = card.Subtypes,
        CardSuperType = card.Supertypes,
        CardType = card.Types,
        Cmc = card.ConvertedManaCost.ToString(),
        FlavorText = card.FlavorText,
        ManaCost = card.ManaCost,
        Name = card.Name,
        Power = card.Power,
        Text = card.Text,
        Toughness = card.Toughness,
        Rarity = card.Rarity,
        Loyalty = card.Loyalty,
      };
    }

    public IEnumerable<CardResponse> SearchCards(string query)
    {
      var cardsFromDb = _dataFetcher.SearchForCards(query).ToList();

      //if (cardsFromDb == null)
      //{
      //  return new List<CardResponse>();
      //}

      return cardsFromDb.Select(card => new CardResponse
        {
          CardFullType = card.Type,
          CardSubType = card.Subtypes,
          CardSuperType = card.Supertypes,
          CardType = card.Types,
          Cmc = card.ConvertedManaCost.ToString(),
          FlavorText = card.FlavorText,
          ManaCost = card.ManaCost,
          Name = card.Name,
          Power = card.Power,
          Text = card.Text,
          Toughness = card.Toughness,
          Rarity = card.Rarity,
          Loyalty = card.Loyalty,
      })
        .ToList();
    }
  }
}