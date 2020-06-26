namespace MtgApi.Data.Entities
{
    public class Prices
    {
        public long Id { get; set; }
        public byte[] Date { get; set; }
        public double? Price { get; set; }
        public string Type { get; set; }
        public string Uuid { get; set; }

        public virtual Cards Uu { get; set; }
    }
}
