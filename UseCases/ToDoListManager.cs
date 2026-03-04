
using Entities;

namespace UseCases
{
    public class ToDoListManager
    {
        private readonly IToDoItemRepository repository;
        public ToDoListManager(IToDoItemRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<TodoItem> getTodoItems()
        {
            return repository.GetItems();
        }

        public void AddTodoItem(TodoItem item)
        {
            repository.Add(item);
        }

        public void MarkComplete(int id)
        {
            var item = repository.GetById(id);
            if (item != null)
            {
                item.IsCompleted = true;
                repository.Update(item);
            }
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}