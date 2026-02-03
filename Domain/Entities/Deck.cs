using Domain.Enums;

namespace Domain.Entities;

public class Deck : BaseEntity
{
    public string Name { set; get; } = string.Empty;
    public string Description { set; get; } = string.Empty;
    public string CreatedBy { set; get; } = string.Empty;
    public DeckType Type { set; get; } 

    public virtual User? User { set; get; }
    public virtual ICollection<VocabularyCard> VocabularyCards { set; get; } = [];
    public virtual ICollection<GrammarCard> GrammarCards { set; get; } = [];
}
