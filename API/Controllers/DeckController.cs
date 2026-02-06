using Application.Common;
using Application.DTOs.Common;
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

    /// <summary>
    /// Cập nhật deck
    /// </summary>
    /// <param name="id"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public async Task<ApiResponse<bool>> Update([FromRoute] string id, [FromBody] UpdateDeckRequest request)
    {
        var result = await HandleException(_service.UpdateDeckAsync(request, GetCurrentUserId(), id));

        return result;
    }

    /// <summary>
    /// xóa deck
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public async Task<ApiResponse<bool>> Delete([FromRoute] string id)
    {
        var result = await HandleException(_service.DeleteDeckAsync(id, GetCurrentUserId()));

        return result;
    }

    /// <summary>
    /// Lấy tổng quan nội dung của các thẻ trong deck
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ApiResponse<DeckDTO>> GetDeckInfo(string id)
    {
        var result = await HandleException(_service.GetDeckSummaryContent(id));

        return result;
    }

    /// <summary>
    /// tìm kiếm deck của người dùng
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    [HttpGet]
    public async Task<ApiResponse<IEnumerable<DeckSummaryDTO>>> Search([FromQuery] SearchDeckQueryDTO query)
    {
        var model = new QueryDTO<SearchDeckQueryDTO>
        {
            Query = query
        };
        var result = await HandleException(_service.GetMyDeckByFilterAsync(model, GetCurrentUserId()));

        result.MetaData = new MetaData()
        {
            Total = model.Total,
            PageSize = query.PageSize,
            Page = query.Page
        };

        return result;
    }
}
