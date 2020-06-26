using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MtgApi.Interfaces;

namespace MtgApi.ResponseTypes
{
  public class CardResponse
  {
    public string Name { get; set; }
    public string ManaCost { get; set; }
    public string Cmc { get; set; }
    public string CardFullType { get; set; }
    public string Rarity { get; set; }
    public string Text { get; set; }
    public string Power { get; set; }
    public string Toughness { get; set; }
    public string Loyalty { get; set; }
    public string FlavorText { get; set; }
    public string CardSuperType { get; set; }
    public string CardType { get; set; }
    public string CardSubType { get; set; }
  }
}
