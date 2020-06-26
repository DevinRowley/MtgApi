using System.Collections.Generic;

namespace MtgApi.Data.Entities
{
    public sealed class Sets
    {
        public Sets()
        {
            Cards = new HashSet<Cards>();
            SetTranslations = new HashSet<SetTranslations>();
            Tokens = new HashSet<Tokens>();
        }

        public long Id { get; set; }
        public long? BaseSetSize { get; set; }
        public string Block { get; set; }
        public string BoosterV3 { get; set; }
        public string Code { get; set; }
        public string CodeV3 { get; set; }
        public long IsFoilOnly { get; set; }
        public long IsForeignOnly { get; set; }
        public long IsOnlineOnly { get; set; }
        public long IsPartialPreview { get; set; }
        public string KeyruneCode { get; set; }
        public long? McmId { get; set; }
        public string McmName { get; set; }
        public string Meta { get; set; }
        public string MtgoCode { get; set; }
        public string Name { get; set; }
        public string ParentCode { get; set; }
        public byte[] ReleaseDate { get; set; }
        public long? TcgplayerGroupId { get; set; }
        public long? TotalSetSize { get; set; }
        public string Type { get; set; }

        public ICollection<Cards> Cards { get; set; }
        public ICollection<SetTranslations> SetTranslations { get; set; }
        public ICollection<Tokens> Tokens { get; set; }
    }
}
