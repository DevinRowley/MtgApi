using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MtgApi.Data.Entities;
using SQLitePCL;
using static System.Web.HttpUtility;

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
      //var parsedQuery2 = RunQuery(query);

      //var queryResult = _context.Cards.FromSqlRaw(parsedQuery);

      return parsedQuery;
      //return null;
    }

    //todo add checking to make sure the url is correct and we have error checking
    //todo add in parsing for the OR operator
    //Todo Somehow I need to sanitize the input after the = in a search parameter e.g. colors = 1';drop%20table%20set_translations;
    //Todo add back in the ParseQueryString
    private IEnumerable<Cards> ParseQuery(string query)
    {
      var parsedParamsCollection = new NameValueCollection();
      var andSplit = ParseQueryString(query);

      foreach (var operand in andSplit)
      {
        switch (operand)
        {
          case "name":
            parsedParamsCollection.Add("cards.name", $"{andSplit.Get("name")}");
            break;
          case "manacost":
            parsedParamsCollection.Add("cards.manacost", $"{andSplit.Get("manacost")}");
            break;
          case "colors":
            parsedParamsCollection.Add("cards.colors", $"{andSplit.Get("colors")}");
            break;
          case "rarity":
            parsedParamsCollection.Add("cards.rarity", $"{andSplit.Get("rarity")}");
            break;
          case "power":
            parsedParamsCollection.Add("cards.power", $"{andSplit.Get("power")}");
            break;
          case "toughness":
            parsedParamsCollection.Add("cards.toughness", $"{andSplit.Get("toughness")}");
            break;
          case "cmc":
            parsedParamsCollection.Add("cards.cmc", $"{andSplit.Get("cmc")}");
            break;
          case "text":
            parsedParamsCollection.Add("cards.text", $"{andSplit.Get("text")}");
            break;
          case "flavortext":
            parsedParamsCollection.Add("cards.flavortext", $"{andSplit.Get("flavortext")}");
            break;
          case "supertypes":
            parsedParamsCollection.Add("cards.supertypes", $"{andSplit.Get("supertypes")}");
            break;
          case "types":
            parsedParamsCollection.Add("cards.types", $"{andSplit.Get("types")}");
            break;
          case "subtypes":
            parsedParamsCollection.Add("cards.subtypes", $"{andSplit.Get("subtypes")}");
            break;
          default:
            //operandsSplitOnAnd[i] = "";
            break;
        }
      }


      var parsedParams = new string[parsedParamsCollection.Count];
      var sqlParameters = new List<SqliteParameter>();

      var sqlBuilder = new StringBuilder();
      sqlBuilder.Append("SELECT * FROM Cards");

      for (var i = 0; i < parsedParamsCollection.Count; i++)
      {
        var parameterValues = parsedParamsCollection.GetValues(i);

        if (parameterValues == null)
        {
          return new List<Cards>();
        }

        //we have an issue where if multiple colors are passed in they have the same key but the value is an string[] So we need to make a different parameter for each color
        //cards.color = red And Cards.color = blue
        if (parameterValues.Length > 1)
        {
          parsedParams[i] = $"@p{i}";
          sqlBuilder.Append(i == 0 ? $" WHERE {parsedParamsCollection.GetKey(i)} = {parsedParams[i]}" : $" AND {parsedParamsCollection.GetKey(i)} = {parsedParams[i]}");


          sqlParameters.Add(new SqliteParameter(parsedParams[i], parameterValues.FirstOrDefault()));
        }

        parsedParams[i] = $"@p{i}";
        sqlBuilder.Append(i == 0 ? $" WHERE {parsedParamsCollection.GetKey(i)} = {parsedParams[i]}" : $" AND {parsedParamsCollection.GetKey(i)} = {parsedParams[i]}");


        sqlParameters.Add(new SqliteParameter(parsedParams[i], parameterValues.FirstOrDefault()));
      }

      // ReSharper disable once CoVariantArrayConversion
      var resultingList = _context.Cards.FromSqlRaw(sqlBuilder.ToString(), sqlParameters.ToArray()).ToList();

      return resultingList;
    }
  }
}