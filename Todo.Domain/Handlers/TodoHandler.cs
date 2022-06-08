using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public partial class TodoHandler : TodoHandlerBase
    // IHandler<MarkTodoAsUndoneCommand>
    {
        public TodoHandler(ITodoRepository repository) : base(repository)
        {
        }
    }
}