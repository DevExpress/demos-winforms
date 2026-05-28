## = Prerequisites =

Before you start designing an app, we recommend that you prepare your **Data layer**.
This gives you important information on you data objects and the API offered by parent classes.

This sample app includes a list of to-do items. Each item has an `ID`, a `Title`, a `Description` and a boolean `IsCompleted` property.
List items are represented by `TodoItem` class objects. Title, Description and IsCompleted are standard *public auto-implemented* properties.
The Id property is hidden via the `Display` attribute. 
The TodoItem class *constructor is private* – as such, it cannot initialize new instances directly.

The `IRepository` interface provides interaction between data items and application Views.
It exposes the methods to `Load`, `Reload`, `Save` and `Delete` Items. Additionally, it features a `Count` method that returns total item amount.
It also includes a `HasChanges` method that returns true when a target item was modified. 
Note: This application uses this interface as a **Service**. We have a [custom InMemoryRepository class](https://github.com/DevExpress-Examples/winforms-mvvm-todo-app/blob/20.2.4+/CS/Data/InMemory.cs) that implements this interface, 
and provides functionality to all interface methods.

All five modules in this section feature the same code for both the `TodoItem` class and the `IRepository` interface.
Snippets inside "Example Code" tabs illustrate how to use the aforementioned API to load, create, and save TodoItem entities from (to) a data source.

[Documentation - Services](https://docs.devexpress.com/WindowsForms/113971/build-an-application/winforms-mvvm/concepts/services)
[GitHub - A sample application powered by DevExpress WinForms MVVM](https://github.com/DevExpress-Examples/winforms-mvvm-todo-app)