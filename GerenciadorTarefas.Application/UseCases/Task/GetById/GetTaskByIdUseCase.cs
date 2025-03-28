using Gerenciador_Tarefas.Communication.Responses;

namespace Gerenciador_Tarefas.Application.UseCases.Task.GetById;
public class GetTaskByIdUseCase
{
    public ResponseGetTaskByIdJson Execute(int id)
    {
        return new ResponseGetTaskByIdJson
        { 
            Id = id,
            Name = "pipoca"
        };
    }
}

