## $CodeExampleName$

The `Register` method allows the main Item’s ViewModel to listen to messages sent by the `ItemViewModel`. 
When a message is received, the `ItemsViewModel` calls the `OnReloadRequired` method (to inspect the instance of `ReloadRequired`).
Based on its `Id` and `IsNew` property values, it reloads either one or multiple TodoItem records.

[Documentation - Layer Communication. Messenger](https://docs.devexpress.com/WindowsForms/113982/build-an-application/winforms-mvvm/concepts/layer-communication-messenger)