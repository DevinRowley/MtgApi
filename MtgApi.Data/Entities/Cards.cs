using System.Collections.Generic;

namespace MtgApi.Data.Entities
{
    public sealed class Cards
    {
        public Cards()
        {
            ForeignData = new HashSet<ForeignData>();
            Legalities = new HashSet<Legalities>();
            Prices = new HashSet<Prices>();
            Rulings = new HashSet<Rulings>();
        }

        public long Id { get; set; }
        public string Artist { get; set; }
        public string AsciiName { get; set; }
        public string BorderColor { get; set; }
        public string ColorIdentity { get; set; }
        public string ColorIndicator { get; set; }
        public string Colors { get; set; }
        public double? ConvertedManaCost { get; set; }
        public string DuelDeck { get; set; }
        public long? EdhrecRank { get; set; }
        public double? FaceConvertedManaCost { get; set; }
        public string FlavorName { get; set; }
        public string FlavorText { get; set; }
        public string FrameEffect { get; set; }
        public string FrameEffects { get; set; }
        public string FrameVersion { get; set; }
        public string Hand { get; set; }
        public long HasFoil { get; set; }
        public long HasNoDeckLimit { get; set; }
        public long HasNonFoil { get; set; }
        public long IsAlternative { get; set; }
        public long IsArena { get; set; }
        public long IsBuyAbox { get; set; }
        public long IsDateStamped { get; set; }
        public long IsFullArt { get; set; }
        public long IsMtgo { get; set; }
        public long IsOnlineOnly { get; set; }
        public long IsOversized { get; set; }
        public long IsPaper { get; set; }
        public long IsPromo { get; set; }
        public long IsReprint { get; set; }
        public long IsReserved { get; set; }
        public long IsStarter { get; set; }
        public long IsStorySpotlight { get; set; }
        public long IsTextless { get; set; }
        public long IsTimeshifted { get; set; }
        public string Layout { get; set; }
        public string LeadershipSkills { get; set; }
        public string Life { get; set; }
        public string Loyalty { get; set; }
        public string ManaCost { get; set; }
        public long? McmId { get; set; }
        public long? McmMetaId { get; set; }
        public long? MtgArenaId { get; set; }
        public long? MtgoFoilId { get; set; }
        public long? MtgoId { get; set; }
        public long? MultiverseId { get; set; }
        public string Name { get; set; }
        public string Names { get; set; }
        public string Number { get; set; }
        public string OriginalText { get; set; }
        public string OriginalType { get; set; }
        public string OtherFaceIds { get; set; }
        public string Power { get; set; }
        public string Printings { get; set; }
        public string PurchaseUrls { get; set; }
        public string Rarity { get; set; }
        public string ScryfallId { get; set; }
        public string ScryfallIllustrationId { get; set; }
        public string ScryfallOracleId { get; set; }
        public string SetCode { get; set; }
        public string Side { get; set; }
        public string Subtypes { get; set; }
        public string Supertypes { get; set; }
        public long? TcgplayerProductId { get; set; }
        public string Text { get; set; }
        public string Toughness { get; set; }
        public string Type { get; set; }
        public string Types { get; set; }
        public string Uuid { get; set; }
        public string Variations { get; set; }
        public string Watermark { get; set; }

        public Sets SetCodeNavigation { get; set; }
        public ICollection<ForeignData> ForeignData { get; set; }
        public ICollection<Legalities> Legalities { get; set; }
        public ICollection<Prices> Prices { get; set; }
        public ICollection<Rulings> Rulings { get; set; }

        
    }
}
