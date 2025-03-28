using Gerenciador_Tarefas.Communication.Requests;
using Gerenciador_Tarefas.Communication.Responses;

namespace Gerenciador_Tarefas.Application.UseCases.Task.Update;
public class UpdateTaskUseCase
{
    public ResponseCreatedTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreatedTaskJson
        {
            Id = request.Id,
            Name = request.Name,
        };
    }
  
}
