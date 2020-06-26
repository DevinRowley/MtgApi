namespace MtgApi.Data.Entities
{
    public class ForeignData
    {
        public long Id { get; set; }
        public string FlavorText { get; set; }
        public string Language { get; set; }
        public long? MultiverseId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public string Uuid { get; set; }

        public virtual Cards Uu { get; set; }
    }
}
