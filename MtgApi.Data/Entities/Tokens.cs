namespace MtgApi.Data.Entities
{
    public class Tokens
    {
        public long Id { get; set; }
        public string Artist { get; set; }
        public string BorderColor { get; set; }
        public string ColorIdentity { get; set; }
        public string Colors { get; set; }
        public long IsOnlineOnly { get; set; }
        public string Layout { get; set; }
        public string Name { get; set; }
        public string Names { get; set; }
        public string Number { get; set; }
        public string Power { get; set; }
        public string ReverseRelated { get; set; }
        public string ScryfallId { get; set; }
        public string ScryfallIllustrationId { get; set; }
        public string ScryfallOracleId { get; set; }
        public string SetCode { get; set; }
        public string Side { get; set; }
        public string Subtypes { get; set; }
        public string Supertypes { get; set; }
        public string Text { get; set; }
        public string Toughness { get; set; }
        public string Type { get; set; }
        public string Types { get; set; }
        public string Uuid { get; set; }
        public string Watermark { get; set; }

        public virtual Sets SetCodeNavigation { get; set; }
    }
}
