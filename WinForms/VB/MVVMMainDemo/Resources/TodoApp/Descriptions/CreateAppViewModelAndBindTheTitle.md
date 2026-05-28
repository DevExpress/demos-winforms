## $CodeExampleName$

In an MVVM application, **each View requires a ViewModel**. Invoke the MvvmContext smart tag menu and click "Add ViewModel".
In production apps, you may already have a ViewModel class. In such an instance, use the smart tag menu to select it.

In this application, the ViewModel class is called `AppViewModel`.

If you look closely at the `AppViewModel` class, you'll see a public property called `Title`.
This property stores the main View caption.
To pass this caption to the main View, call the `SetBinding` method in the View code.

[Documentation - Data and Property Bindings](https://docs.devexpress.com/WindowsForms/113956/build-an-application/winforms-mvvm/concepts/data-bindings-and-notifications)