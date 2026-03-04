using Entities;
using Infratructure;
using UseCases;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void CreateTodoItem_And_Set_Completed_Test()
        {
            // Arrange
            var mockRepository = new InMemoryToDoItemRepository();
            var todoListManager = new ToDoListManager(mockRepository);

            var todoItem = new TodoItem { Id = 1, Text = "Test Item", IsCompleted = false };

            // Act
            todoListManager.AddTodoItem(todoItem);
            todoListManager.MarkComplete(1);

            // Assert
            Assert.True(todoListManager.getTodoItems().First().IsCompleted);
            Assert.Equal("Test Item", todoListManager.getTodoItems().First().Text);
        }
    }
}