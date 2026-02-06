using Application.DTOs.ExampleSentence;
using Application.Helpers;
using Domain.Entities;

namespace Application.Mappings;

public static class ExampleSentenceMappings
{
    public static ExampleSentenceDTO ToDTO(this ExampleSentence sentence)
    {
        return  new ExampleSentenceDTO()
        {
            Id = sentence.Id,
            ClozeSentence = sentence.ClozeSentence,
            ExpectedAnswer = sentence.ExpectedAnswer,
            Hint = sentence.Hint,
            FullSentence = TextHelpers.CombineFullExampleSentence(sentence.ClozeSentence, sentence.ExpectedAnswer)
        };
    }
}
