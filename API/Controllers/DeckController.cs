using Application.Common;
using Application.DTOs.Deck;
using Application.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/// <summary>
/// Quản lý decks cá nhân
/// </summary>
[ApiController]
[Route("decks")]
[Authorize]
public class DeckController : BaseController
{
    private readonly IDeckService _service;
    public DeckController(IDeckService service)
    {
        _service = service;
    }

    /// <summary>
    /// Tạo deck
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ApiResponse<bool>> Create(CreateDeckRequest request)
    {
        var result = await HandleException(_service.CreateDeckAsync(request, GetCurrentUserId()));

        return result;
    }
}
