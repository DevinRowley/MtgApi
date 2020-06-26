namespace MtgApi.Data.Entities
{
    public class Rulings
    {
        public long Id { get; set; }
        public byte[] Date { get; set; }
        public string Text { get; set; }
        public string Uuid { get; set; }

        public virtual Cards Uu { get; set; }
    }
}
