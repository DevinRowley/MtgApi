namespace MtgApi.Data.Entities
{
    public class SetTranslations
    {
        public long Id { get; set; }
        public string Language { get; set; }
        public string SetCode { get; set; }
        public string Translation { get; set; }

        public virtual Sets SetCodeNavigation { get; set; }
    }
}
