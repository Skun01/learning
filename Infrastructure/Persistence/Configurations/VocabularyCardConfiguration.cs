using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class VocabularyCardConfiguration : IEntityTypeConfiguration<VocabularyCard>
{
    public void Configure(EntityTypeBuilder<VocabularyCard> builder)
    {
        builder.ToTable("VocabularyCards");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Term).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Meaning).IsRequired().HasMaxLength(500);

        builder.HasOne(v => v.Deck)
               .WithMany(d => d.VocabularyCards)
               .HasForeignKey(v => v.DeckId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
