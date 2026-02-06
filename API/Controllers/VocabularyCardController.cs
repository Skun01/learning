using System.Threading.Tasks;
using Application.Common;
using Application.DTOs.VocabularyCard;
using Application.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("vocabularies")]
[Authorize]
public class VocabularyCardController : BaseController
{
    private IVocabularyCardService _service;
    public VocabularyCardController(IVocabularyCardService service)
    {
        _service = service;
    }

    /// <summary>
    /// Tạo một card cho một deck
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ApiResponse<bool>> Create([FromBody] CreateVocabularyRequest request)
    {
        var result = await HandleException(_service.CreateVocabularyCardAsync(request, GetCurrentUserId()));

        return result;
    }

    /// <summary>
    /// Lấy danh sách các card của một deck vocabulary
    /// </summary>
    /// <param name="deckId"></param>
    /// <returns></returns>
    [HttpGet("deck/{deckId}")]
    public async Task<ApiResponse<IEnumerable<VocabularyCardDTO>>> GetCardByDeckId([FromRoute] string deckId)
    {
        var result = await HandleException(_service.GetVocabularyListByDeckId(deckId));

        return result;
    }
}
