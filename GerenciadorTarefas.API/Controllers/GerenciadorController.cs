using Gerenciador_Tarefas.Application.UseCases.Task.Create;
using Gerenciador_Tarefas.Application.UseCases.Task.Delete;
using Gerenciador_Tarefas.Application.UseCases.Task.GetAll;
using Gerenciador_Tarefas.Application.UseCases.Task.GetById;
using Gerenciador_Tarefas.Application.UseCases.Task.Update;
using Gerenciador_Tarefas.Communication.Requests;
using Gerenciador_Tarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador_Tarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GerenciadorController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedTaskJson), StatusCodes.Status201Created)]
    public IActionResult CreatTask([FromBody] RequestTaskJson request)
    {
        var useCase = new CreateTaskUseCase();

        var response = useCase.Execute(request);

        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTasksUseCase();

        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var useCase = new GetTaskByIdUseCase();

        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseUpdatedTaskJson), StatusCodes.Status204NoContent)]
    public IActionResult UpdateTask([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();

        useCase.Execute(request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status204NoContent)]
    public IActionResult Execute([FromRoute] int id)
    {
        var useCase = new DeleteTaskByIdUseCase();

        useCase.Execute(id);

        return NoContent();
    }



}
