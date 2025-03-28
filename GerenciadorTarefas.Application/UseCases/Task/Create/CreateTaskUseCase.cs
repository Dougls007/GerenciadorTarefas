using Gerenciador_Tarefas.Communication.Requests;
using Gerenciador_Tarefas.Communication.Responses;

namespace Gerenciador_Tarefas.Application.UseCases.Task.Create;
public class CreateTaskUseCase
{
    public ResponseCreatedTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreatedTaskJson
        {
            Priority = request.Priority,
            Id = request.Id,
            Name = request.Name,
        };
    }
}
