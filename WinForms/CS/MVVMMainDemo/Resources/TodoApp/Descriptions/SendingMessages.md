## $CodeExampleName$

To enable ViewModel communication, use the DevExpress MVVM `Messenger`. The sender ViewModel calls the `Messenger.Default.Send` method
with an message object as a parameter. The recipient ViewModel calls the typed `Messenger.Default.Register` method. 
Method type must match the message type sent by the sender. With matched types, you can receive the sent object and perform actions as needed.
 
 This first module sends the **static** `All` property, and two static methods (`FromId` and `FromNew`) of the custom `ReloadRequired` class.
 These three APIs return different `ReloadRequired` object instances. These instances were designed to match appropriate usage scenarios 
 (related to how a message was sent). A global reload is required when a user deletes an existing item or adds a new item. 
 A specific item reload is executed when a user saves an existing item.

 [Documentation - Layer Communication. Messenger](https://docs.devexpress.com/WindowsForms/113982/build-an-application/winforms-mvvm/concepts/layer-communication-messenger)