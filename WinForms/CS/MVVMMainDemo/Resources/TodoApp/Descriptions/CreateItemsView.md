## $CodeExampleName$

In this step, we create a screen that appears once the **AppLogo** screen is dismissed – the screen contains a list of ToDo items.
Like other application Views, this View has its own MvvmContext linked with the `ItemsViewModel` (described later). 

The following UI elements are used:

- `titleLabel` - displays the View caption;
- `searchControl` - allows users to search for tasks;
- `toggleShowAll` - a ToggleSwitch that allows users to only view incomplete tasks;
- `todoItemBindingSource` - a BindingSource that stores TodoItem objects;
- `listBoxControl` - displays all TodoItems loaded from BindingSource;
- two TablePanels to arrange all these elements across the View.

All listBoxControl items have *a context button* that appears when a user hover overs an item. To implement this behavior, 
we handle the [CustomizeContextItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.BaseListBoxControl.CustomizeContextItem) event that parses listBox items as TodoItem objects and checks associated IsCompleted fields.
If an item is marked completed, the button is hidden and a permanent checkmark SVG item is displayed instead (the [CustomizeItem](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.BaseListBoxControl.CustomizeItem) event).

This module helps demonstrate that MVVM apps do not restrict use of events. The goal of layer separation is to **avoid mixing business logic**
(ViewModel code) **with View settings**. Item images and context buttons solely depend on `IsCompleted` field values 
of related records – it is for this reason that they belong to the View.

[Documentation - Templated ListBox Controls](https://docs.devexpress.com/WindowsForms/119680/controls-and-libraries/editors-and-simple-controls/templated-listbox-items)