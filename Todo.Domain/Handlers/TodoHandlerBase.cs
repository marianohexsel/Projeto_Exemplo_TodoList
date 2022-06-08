using Flunt.Notifications;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandlerBase : Notifiable
    {
        protected readonly ITodoRepository _repository;

        public TodoHandlerBase(ITodoRepository repository)
        {
            _repository = repository;
        }
    }
}