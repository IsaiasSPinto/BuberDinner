using BuberDinner.Application.Menus.Commands.CreateMenu;
using BuberDinner.Contracts.Menus;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[Route("host/{hostId}/menus")]
public class MenusController : ApiController
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;
    public MenusController(ISender sender, IMapper mapper)
    {
        _mediator = sender;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> CreateMenu(CreateMenuRequest request, string hostId)
    {
        var command = _mapper.Map<CreateMenuCommand>((request, hostId));

        var result = await _mediator.Send(command);

        return result.Match(
            menu => Ok(_mapper.Map<MenuResponse>(menu)),
            errors => Problem(errors));
    }

    //[HttpGet("{menuId}")]
    //public async Task<IActionResult> GetMenu(string hostId, string menuId)
    //{
    //    var query = new GetMenuQuery(hostId, menuId);

    //    var result = await _mediator.Send(query);

    //    return result.Match(
    //        menu => Ok(_mapper.Map<MenuResponse>(menu)),
    //        errors => Problem(errors));
    //}
}
