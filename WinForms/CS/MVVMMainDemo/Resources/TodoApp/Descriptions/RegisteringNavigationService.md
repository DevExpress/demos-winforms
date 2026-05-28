## $CodeExampleName$

Drop a `NavigationFrame` onto the main View. We need to display the AppLogo View as an active NavigationFrame page when 
the application starts. Once the app starts, we switch to the MainView. To do this, use Services. 
Services allow you to manage DevExpress controls that reside on a View from the ViewModel.

To control the NavigationFrame, register the `NavigationService` and create a `OnShown` method that calls 
the `NavigationService.Navigate` method. This method activates a View as a NavigationFrame page.
To automatically execute this method, use the `EventToCommand` behavior to link a command 
(`OnShown` method is treated as a command by the MVVM Framework) with an event (the main form's `Shown` event in this case).

[Documentation - Navigation Frame](https://docs.devexpress.com/WindowsForms/114554/controls-and-libraries/navigation-controls/navigation-frame-and-tab-pane)
[Documentation - NavigationService](https://docs.devexpress.com/WindowsForms/114024/build-an-application/winforms-mvvm/design-time-support/control-based-services#navigationservice)