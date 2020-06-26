namespace MtgApi.Data.Entities
{
    public class Legalities
    {
        public long Id { get; set; }
        public string Format { get; set; }
        public string Status { get; set; }
        public string Uuid { get; set; }

        public virtual Cards Uu { get; set; }
    }
}
