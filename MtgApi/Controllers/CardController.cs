using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.VisualBasic.FileIO;
using MtgApi.Data.Repository;
using MtgApi.Interfaces;
using MtgApi.ResponseTypes;

namespace MtgApi.Controllers
{
  [Route("cards/")]
  public class CardController : Controller
  {
    private readonly IResponseGenerator _responseGenerator;

    public CardController(IResponseGenerator responseGenerator)
    {
      _responseGenerator = responseGenerator;
    }

    [HttpGet("{id:int}")]
    public IActionResult CardById(int id)
    {
      var result = _responseGenerator.GetCardById(id);
      return Ok(result);
    }

    [HttpGet("name/{name}")]
    public IActionResult CardByName(string name)
    {
      var result = _responseGenerator.GetCardByName(name);
      return Ok(result);
    }

    [HttpGet("")]
    [HttpGet("random")]
    public IActionResult RandomCard()
    {
      var result = _responseGenerator.GetRandomCard();
      return Ok(result);
    }

    [HttpGet("search/{query}")]
    public IActionResult Search(string query)
    {
      var result = _responseGenerator.SearchCards(query);
      return Ok(result);
    }
  }
}