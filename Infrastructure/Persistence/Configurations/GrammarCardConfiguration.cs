using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class GrammarCardConfiguration : IEntityTypeConfiguration<GrammarCard>
{
    public void Configure(EntityTypeBuilder<GrammarCard> builder)
    {
        builder.ToTable("GrammarCards");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Term).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Meaning).IsRequired().HasMaxLength(500);
        builder.Property(x => x.Structure).IsRequired();
        
        builder.HasOne(g => g.Deck)
               .WithMany(d => d.GrammarCards)
               .HasForeignKey(g => g.DeckId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
