namespace Domain.Entities;

public class ExampleSentence : BaseEntity
{
    public string ClozeSentence { set; get; } = string.Empty; // phần cần điền sẽ cần lưu bằng 4 dấu gạc dưới(____)
    public string ExpectedAnswer { set; get; } = string.Empty; // đáp án điền vào
    public string? Hint { set; get; } // Gợi ý trả lời
    public string? VocabularyCardId { set; get; }
    public string? GrammarCardId { set; get; }

    public virtual VocabularyCard? VocabularyCard { set; get; }
    public virtual GrammarCard? GrammarCard { set; get; }
}   
