using Microsoft.EntityFrameworkCore;
using MtgApi.Data.Entities;

namespace MtgApi.Data
{
    public partial class AllPrintingsContext : DbContext
    {
      public AllPrintingsContext()
        {
        }

        public AllPrintingsContext(DbContextOptions<AllPrintingsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cards> Cards { get; set; }
        public virtual DbSet<ForeignData> ForeignData { get; set; }
        public virtual DbSet<Legalities> Legalities { get; set; }
        public virtual DbSet<Prices> Prices { get; set; }
        public virtual DbSet<Rulings> Rulings { get; set; }
        public virtual DbSet<SetTranslations> SetTranslations { get; set; }
        public virtual DbSet<Sets> Sets { get; set; }
        public virtual DbSet<Tokens> Tokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source=C:\\src\\PersonalProject\\MtgApi\\AllPrintings.sqlite;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cards>(entity =>
            {
                entity.ToTable("cards");

                entity.HasIndex(x => x.Uuid)
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Artist).HasColumnName("artist");

                entity.Property(e => e.AsciiName).HasColumnName("asciiName");

                entity.Property(e => e.BorderColor).HasColumnName("borderColor");

                entity.Property(e => e.ColorIdentity).HasColumnName("colorIdentity");

                entity.Property(e => e.ColorIndicator).HasColumnName("colorIndicator");

                entity.Property(e => e.Colors).HasColumnName("colors");

                entity.Property(e => e.ConvertedManaCost)
                    .HasColumnName("convertedManaCost")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.DuelDeck).HasColumnName("duelDeck");

                entity.Property(e => e.EdhrecRank).HasColumnName("edhrecRank");

                entity.Property(e => e.FaceConvertedManaCost)
                    .HasColumnName("faceConvertedManaCost")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.FlavorName).HasColumnName("flavorName");

                entity.Property(e => e.FlavorText).HasColumnName("flavorText");

                entity.Property(e => e.FrameEffect).HasColumnName("frameEffect");

                entity.Property(e => e.FrameEffects).HasColumnName("frameEffects");

                entity.Property(e => e.FrameVersion).HasColumnName("frameVersion");

                entity.Property(e => e.Hand).HasColumnName("hand");

                entity.Property(e => e.HasFoil).HasColumnName("hasFoil");

                entity.Property(e => e.HasNoDeckLimit).HasColumnName("hasNoDeckLimit");

                entity.Property(e => e.HasNonFoil).HasColumnName("hasNonFoil");

                entity.Property(e => e.IsAlternative).HasColumnName("isAlternative");

                entity.Property(e => e.IsArena).HasColumnName("isArena");

                entity.Property(e => e.IsBuyAbox).HasColumnName("isBuyABox");

                entity.Property(e => e.IsDateStamped).HasColumnName("isDateStamped");

                entity.Property(e => e.IsFullArt).HasColumnName("isFullArt");

                entity.Property(e => e.IsMtgo).HasColumnName("isMtgo");

                entity.Property(e => e.IsOnlineOnly).HasColumnName("isOnlineOnly");

                entity.Property(e => e.IsOversized).HasColumnName("isOversized");

                entity.Property(e => e.IsPaper).HasColumnName("isPaper");

                entity.Property(e => e.IsPromo).HasColumnName("isPromo");

                entity.Property(e => e.IsReprint).HasColumnName("isReprint");

                entity.Property(e => e.IsReserved).HasColumnName("isReserved");

                entity.Property(e => e.IsStarter).HasColumnName("isStarter");

                entity.Property(e => e.IsStorySpotlight).HasColumnName("isStorySpotlight");

                entity.Property(e => e.IsTextless).HasColumnName("isTextless");

                entity.Property(e => e.IsTimeshifted).HasColumnName("isTimeshifted");

                entity.Property(e => e.Layout).HasColumnName("layout");

                entity.Property(e => e.LeadershipSkills).HasColumnName("leadershipSkills");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.Loyalty).HasColumnName("loyalty");

                entity.Property(e => e.ManaCost).HasColumnName("manaCost");

                entity.Property(e => e.McmId).HasColumnName("mcmId");

                entity.Property(e => e.McmMetaId).HasColumnName("mcmMetaId");

                entity.Property(e => e.MtgArenaId).HasColumnName("mtgArenaId");

                entity.Property(e => e.MtgoFoilId).HasColumnName("mtgoFoilId");

                entity.Property(e => e.MtgoId).HasColumnName("mtgoId");

                entity.Property(e => e.MultiverseId).HasColumnName("multiverseId");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Names).HasColumnName("names");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.OriginalText).HasColumnName("originalText");

                entity.Property(e => e.OriginalType).HasColumnName("originalType");

                entity.Property(e => e.OtherFaceIds).HasColumnName("otherFaceIds");

                entity.Property(e => e.Power).HasColumnName("power");

                entity.Property(e => e.Printings).HasColumnName("printings");

                entity.Property(e => e.PurchaseUrls).HasColumnName("purchaseUrls");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ScryfallId).HasColumnName("scryfallId");

                entity.Property(e => e.ScryfallIllustrationId).HasColumnName("scryfallIllustrationId");

                entity.Property(e => e.ScryfallOracleId).HasColumnName("scryfallOracleId");

                entity.Property(e => e.SetCode)
                    .HasColumnName("setCode")
                    .HasColumnType("TEXT(8)");

                entity.Property(e => e.Side).HasColumnName("side");

                entity.Property(e => e.Subtypes).HasColumnName("subtypes");

                entity.Property(e => e.Supertypes).HasColumnName("supertypes");

                entity.Property(e => e.TcgplayerProductId).HasColumnName("tcgplayerProductId");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Toughness).HasColumnName("toughness");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Types).HasColumnName("types");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("uuid")
                    .HasColumnType("TEXT(36)");

                entity.Property(e => e.Variations).HasColumnName("variations");

                entity.Property(e => e.Watermark).HasColumnName("watermark");

                entity.HasOne(d => d.SetCodeNavigation)
                    .WithMany(p => p.Cards)
                    .HasPrincipalKey(x => x.Code)
                    .HasForeignKey(x => x.SetCode)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<ForeignData>(entity =>
            {
                entity.ToTable("foreign_data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FlavorText).HasColumnName("flavorText");

                entity.Property(e => e.Language).HasColumnName("language");

                entity.Property(e => e.MultiverseId).HasColumnName("multiverseId");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("TEXT(36)");

                entity.HasOne(d => d.Uu)
                    .WithMany(p => p.ForeignData)
                    .HasPrincipalKey(x => x.Uuid)
                    .HasForeignKey(x => x.Uuid)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Legalities>(entity =>
            {
                entity.ToTable("legalities");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Format).HasColumnName("format");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("TEXT(36)");

                entity.HasOne(d => d.Uu)
                    .WithMany(p => p.Legalities)
                    .HasPrincipalKey(x => x.Uuid)
                    .HasForeignKey(x => x.Uuid)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Prices>(entity =>
            {
                entity.ToTable("prices");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("DATE");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("FLOAT");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("TEXT(36)");

                entity.HasOne(d => d.Uu)
                    .WithMany(p => p.Prices)
                    .HasPrincipalKey(x => x.Uuid)
                    .HasForeignKey(x => x.Uuid)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Rulings>(entity =>
            {
                entity.ToTable("rulings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("DATE");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasColumnType("TEXT(36)");

                entity.HasOne(d => d.Uu)
                    .WithMany(p => p.Rulings)
                    .HasPrincipalKey(x => x.Uuid)
                    .HasForeignKey(x => x.Uuid)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<SetTranslations>(entity =>
            {
                entity.ToTable("set_translations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Language).HasColumnName("language");

                entity.Property(e => e.SetCode)
                    .HasColumnName("setCode")
                    .HasColumnType("TEXT(8)");

                entity.Property(e => e.Translation).HasColumnName("translation");

                entity.HasOne(d => d.SetCodeNavigation)
                    .WithMany(p => p.SetTranslations)
                    .HasPrincipalKey(x => x.Code)
                    .HasForeignKey(x => x.SetCode)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Sets>(entity =>
            {
                entity.ToTable("sets");

                entity.HasIndex(x => x.Code)
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BaseSetSize).HasColumnName("baseSetSize");

                entity.Property(e => e.Block).HasColumnName("block");

                entity.Property(e => e.BoosterV3).HasColumnName("boosterV3");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("TEXT(8)");

                entity.Property(e => e.CodeV3).HasColumnName("codeV3");

                entity.Property(e => e.IsFoilOnly).HasColumnName("isFoilOnly");

                entity.Property(e => e.IsForeignOnly).HasColumnName("isForeignOnly");

                entity.Property(e => e.IsOnlineOnly).HasColumnName("isOnlineOnly");

                entity.Property(e => e.IsPartialPreview).HasColumnName("isPartialPreview");

                entity.Property(e => e.KeyruneCode).HasColumnName("keyruneCode");

                entity.Property(e => e.McmId).HasColumnName("mcmId");

                entity.Property(e => e.McmName).HasColumnName("mcmName");

                entity.Property(e => e.Meta).HasColumnName("meta");

                entity.Property(e => e.MtgoCode).HasColumnName("mtgoCode");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ParentCode).HasColumnName("parentCode");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("releaseDate")
                    .HasColumnType("DATE");

                entity.Property(e => e.TcgplayerGroupId).HasColumnName("tcgplayerGroupId");

                entity.Property(e => e.TotalSetSize).HasColumnName("totalSetSize");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Tokens>(entity =>
            {
                entity.ToTable("tokens");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Artist).HasColumnName("artist");

                entity.Property(e => e.BorderColor).HasColumnName("borderColor");

                entity.Property(e => e.ColorIdentity).HasColumnName("colorIdentity");

                entity.Property(e => e.Colors).HasColumnName("colors");

                entity.Property(e => e.IsOnlineOnly).HasColumnName("isOnlineOnly");

                entity.Property(e => e.Layout).HasColumnName("layout");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Names).HasColumnName("names");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Power).HasColumnName("power");

                entity.Property(e => e.ReverseRelated).HasColumnName("reverseRelated");

                entity.Property(e => e.ScryfallId).HasColumnName("scryfallId");

                entity.Property(e => e.ScryfallIllustrationId).HasColumnName("scryfallIllustrationId");

                entity.Property(e => e.ScryfallOracleId).HasColumnName("scryfallOracleId");

                entity.Property(e => e.SetCode)
                    .HasColumnName("setCode")
                    .HasColumnType("TEXT(8)");

                entity.Property(e => e.Side).HasColumnName("side");

                entity.Property(e => e.Subtypes).HasColumnName("subtypes");

                entity.Property(e => e.Supertypes).HasColumnName("supertypes");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Toughness).HasColumnName("toughness");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Types).HasColumnName("types");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("uuid")
                    .HasColumnType("TEXT(36)");

                entity.Property(e => e.Watermark).HasColumnName("watermark");

                entity.HasOne(d => d.SetCodeNavigation)
                    .WithMany(p => p.Tokens)
                    .HasPrincipalKey(x => x.Code)
                    .HasForeignKey(x => x.SetCode)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
