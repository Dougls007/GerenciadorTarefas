using Gerenciador_Tarefas.Communication.Responses;

namespace Gerenciador_Tarefas.Application.UseCases.Task.GetAll;
public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                
            }
        };
    }
}
