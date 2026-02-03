using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ExampleSentenceConfiguration : IEntityTypeConfiguration<ExampleSentence>
{
    public void Configure(EntityTypeBuilder<ExampleSentence> builder)
    {
        builder.ToTable("ExampleSentences");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.ClozeSentence).IsRequired();
        builder.Property(x => x.ExpectedAnswer).IsRequired();
        builder.Property(x => x.Hint).HasMaxLength(500);

        builder.HasOne(e => e.VocabularyCard)
               .WithMany(v => v.ExampleSentences)
               .HasForeignKey(e => e.VocabularyCardId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.GrammarCard)
               .WithMany(g => g.ExampleSentences)
               .HasForeignKey(e => e.GrammarCardId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
