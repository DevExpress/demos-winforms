## $CodeExampleName$

The ViewModel related to the **Edit Item** screen includes a *boolean* `HasChanges` property. 
This property checks whether an entity was modified. If it was, "*" suffix is added to the main screen label.

The `BindCommand` methods bind View buttons to corresponding ViewModel commands. The `SetObjectDataSourceBinding` binds 
the `BindingSource` component to the `Item` property(stores the current data source entity). 
When the Item object changes, the `Update` method executes.

[Documentation - Data Binding](https://docs.devexpress.com/WindowsForms/113956/build-an-application/winforms-mvvm/concepts/data-bindings-and-notifications#data-binding)