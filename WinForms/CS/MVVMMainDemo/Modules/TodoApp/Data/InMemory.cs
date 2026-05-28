namespace TodoApp.Data {
    using System.Collections.Generic;
    using TodoApp.Model;

    sealed class InMemoryRepository : DevExpress.Tutorials.TodoApp.Data.InMemoryRepository<TodoItem>, IRepository {
        sealed class InMemoryTodoItem : TodoItem {
            public InMemoryTodoItem(int id)
                : base(id) {
            }
        }
        public InMemoryRepository()
            : base(AppModel.NewItemID, new KeyValuePair<int, TodoItem>[] {
                new KeyValuePair<int, TodoItem>(1, new InMemoryTodoItem(1) {
                    Title = "Create the MainView",
                    Description = "Create a Form with application icon and NavigationFrame control.",
                    IsCompleted = true
                }),
                new KeyValuePair<int, TodoItem>(2, new InMemoryTodoItem(2) {
                    Title = "Create the AppViewModel",
                    Description = "Create a class with the Title property.",
                    IsCompleted = true
                }),
                new KeyValuePair<int, TodoItem>(3, new InMemoryTodoItem(3) {
                    Title = "Bind the AppViewModel to the MainView.",
                    Description = "Bind the Title property to the Text. Register the NavigationFrame as a service.",
                    IsCompleted = true
                }),
                new KeyValuePair<int, TodoItem>(4, new InMemoryTodoItem(4) {
                    Title = "Create the ItemsView",
                    Description = "Create an UserControl with ListBoxControl and SearchBox."
                }),
                new KeyValuePair<int, TodoItem>(5, new InMemoryTodoItem(5) {
                    Title = "Create the ItemsViewModel",
                    Description = "Create a class with the Items property."
                }),
                new KeyValuePair<int, TodoItem>(6, new InMemoryTodoItem(6) {
                    Title = "Bind the ItemsViewModel to the ItemsView.",
                    Description = "Bind the Title property to the label. Bind the Items property to the bindingSource.",
                })}) {
        }
        protected override TodoItem Create(int id) {
            return new InMemoryTodoItem(id);
        }
        protected override int GetId(TodoItem item) {
            return item.Id;
        }
        protected override bool IsEmpty(TodoItem item) {
            return string.IsNullOrEmpty(item.Title) && string.IsNullOrEmpty(item.Description);
        }
        protected override TodoItem Copy(TodoItem source, int? id = null) {
            int actualId = id.GetValueOrDefault(source.Id);
            return new InMemoryTodoItem(actualId) {
                Title = source.Title,
                Description = source.Description,
                IsCompleted = source.IsCompleted
            };
        }
        protected override void Assign(TodoItem source, TodoItem target) {
            target.Title = source.Title;
            target.Description = source.Description;
            target.IsCompleted = source.IsCompleted;
        }
        protected override bool Equals(TodoItem source, TodoItem target) {
            return
                (source.Title == target.Title) &&
                (source.Description == target.Description) &&
                (source.IsCompleted == target.IsCompleted);
        }
    }
}
