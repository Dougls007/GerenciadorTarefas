using Gerenciador_Tarefas.Communication.Enums;

namespace Gerenciador_Tarefas.Communication.Requests;
public class RequestTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateOnly Date { get; set; }
    public Status Status { get; set; }
}
