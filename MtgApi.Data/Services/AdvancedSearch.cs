using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using MtgApi.Data.Entities;

namespace MtgApi.Data.Services
{
  public class AdvancedSearch : IAdvancedSearch
  {
    private readonly AllPrintingsContext _context;

    public AdvancedSearch(AllPrintingsContext context)
    {
      _context = context;
    }

    public IEnumerable<Cards> SearchCards(string query)
    {
      var parsedQuery = ParseQuery(query);

      var queryResult = _context.Cards.FromSqlRaw(parsedQuery);
      
      return queryResult;
    }

    //todo add checking to make sure the url is correct and we have error checking
    //todo add in parsing for the OR operator
    private string ParseQuery(string query)
    {
      var operandsSplitOnAnd = query.Split("&");

      for (var i = 0; i < operandsSplitOnAnd.Length; i++)
      {
        var operand = operandsSplitOnAnd[i];


        if (operand.StartsWith("("))
        {

        }



        var splitOnEqual = operand.Split("=");

        switch (splitOnEqual.FirstOrDefault())
        {
          case "name":
            operandsSplitOnAnd[i] = $"cards.name = \'{splitOnEqual.Last()}\'";
            break;
          case "manacost":
            operandsSplitOnAnd[i] = $"cards.manacost = \'{splitOnEqual.Last()}\'";
            break;
          case "colors":
            operandsSplitOnAnd[i] = $"cards.colors = \'{splitOnEqual.Last()}\'";
            break;
          case "rarity":
            operandsSplitOnAnd[i] = $"cards.rarity = \'{splitOnEqual.Last()}\'";
            break;
          case "power":
            operandsSplitOnAnd[i] = $"cards.power = \'{splitOnEqual.Last()}\'";
            break;
          case "toughness":
            operandsSplitOnAnd[i] = $"cards.toughness = \'{splitOnEqual.Last()}\'";
            break;
          case "cmc":
            operandsSplitOnAnd[i] = $"cards.convertedmanacost = \'{splitOnEqual.Last()}.0\'";
            break;
          case "text":
            operandsSplitOnAnd[i] = $"cards.text = \'{splitOnEqual.Last()}\'";
            break;
          case "flavortext":
            operandsSplitOnAnd[i] = $"cards.flavortext = \'{splitOnEqual.Last()}\'";
            break;
          case "supertypes":
            operandsSplitOnAnd[i] = $"cards.supertypes = \'{splitOnEqual.Last()}\'";
            break;
          case "types":
            operandsSplitOnAnd[i] = $"cards.types = \'{splitOnEqual.Last()}\'";
            break;
          case "subtypes":
            operandsSplitOnAnd[i] = $"cards.subtypes = \'{splitOnEqual.Last()}\'";
            break;
          default:
            break;
        }
      }

      var sqlString = new StringBuilder();
      sqlString.Append("SELECT * FROM Cards WHERE ");

      for (var i = 0; i < operandsSplitOnAnd.Length; i++)
      {
        sqlString.Append(operandsSplitOnAnd[i]);
        
        if(i != operandsSplitOnAnd.Length - 1)
        {
          sqlString.Append(" AND ");
        }
      }

      return sqlString.ToString();
    }
  }
}