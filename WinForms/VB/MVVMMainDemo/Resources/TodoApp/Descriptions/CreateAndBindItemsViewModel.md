## $CodeExampleName$

After the View is ready, proceed to the ViewModel. In this step, we add the following API:

- A *string* `Title` property bound (via the `SetBinding` method) to the titleLabel element.

- A *boolean* `ShowAllItems` property bound to the `toggleShowAll` element. 
This is a ***two-way*** binding: whenever a user clicks the toggle switch, the `ShowAllItem` property value changes accordingly. 
When a change occurs, the Framework ***automatically*** triggers the `OnShowAllItemsChanged` callback. 
This callback executes the `ReloadItems` method.

- A *IList<TodoItem>* `Items` property that stores all TodoItems. This property is bound to the Binding Source.
Much like the previous property, Items includes a `OnItemsChanged` callback. When this property value changes, 
the Framework calls `OnItemsChanged`. This callback sets the `SelectedItem` property.

- The `SelectedItem` property includes its own `OnSelectedItemChanged` callback that re-checks the `CanEdit` condition.
This is a **can execute** condition for the `Edit` **command**. It’s designed to navigate a user away from this screen 
and onto an Edit Screen (where they can modify the selected item). This property is also bound to the listBoxControl's `SelectedValue` property.

- The `Complete` method sets the TodoItem's `IsCompleted` property to `true`. The View code uses the **Event-To-Command Behavior** 
to bind this method to the [listBoxControl.ContextButtonClick](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.BaseListBoxControl.ContextButtonClick) event. Whenever a user presses the item context button, this event fires
and the Framework ***automatically*** runs the `Complete` command.

[Documentation - Commands](https://docs.devexpress.com/WindowsForms/113965/build-an-application/winforms-mvvm/concepts/commands)
[Documentation - Event-To-Command Behavior](https://docs.devexpress.com/WindowsForms/113975/build-an-application/winforms-mvvm/concepts/behaviors#eventcommand)