Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad

    Public Class PopupColor
        Inherits XtraUserControl
        Implements IPopupColorPickEdit

        Public Sub New(ByVal container As PopupControlContainer, ByVal parent As frmMain)
            _container = container
            builder = CreatePopupColorEditBuilder()
            container.Controls.Add(builder.TabControl)
            Dim _size As Size = builder.CalcContentSize()
            _container.Size = New Size(_size.Width + 3, _size.Height)
            main = parent
        End Sub

        Private _container As PopupControlContainer

        Private main As frmMain

        Protected Function CreatePopupColorEditBuilder() As PopupColorBuilderEx
            Return New DemoPopupColorBuilderEx(Me)
        End Function

        Private Sub IPopupColorEdit_ClosePopup() Implements IPopupColorEdit.ClosePopup
            _container.HidePopup()
        End Sub

        Private ReadOnly Property Color As Color Implements IPopupColorEdit.Color
            Get
                Return CType(PopupColorBuilder.ResultValue, Color)
            End Get
        End Property

        Private Function CreateColorListBox() As ColorListBox Implements IPopupColorEdit.CreateColorListBox
            Return New ColorListBox()
        End Function

        Private ReadOnly Property EditValue As Object Implements IPopupColorEdit.EditValue
            Get
                Return Nothing
            End Get
        End Property

        Private ReadOnly Property IsPopupOpen As Boolean Implements IPopupColorEdit.IsPopupOpen
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property IPopupColorEdit_LookAndFeel As LookAndFeel.UserLookAndFeel Implements IPopupColorEdit.LookAndFeel
            Get
                Return LookAndFeel
            End Get
        End Property

        Private Sub OnColorChanged() Implements IPopupColorEdit.OnColorChanged
            main.CurrentRichTextBox.SelectionColor = CType(PopupColorBuilder.ResultValue, Color)
        End Sub

        Private ReadOnly Property Properties As Repository.RepositoryItemColorEdit Implements IPopupColorEdit.Properties
            Get
                Return New Repository.RepositoryItemColorPickEdit()
            End Get
        End Property

        Private builder As PopupColorBuilderEx

        Public ReadOnly Property PopupColorBuilder As PopupColorBuilder
            Get
                Return TryCast(builder, PopupColorBuilder)
            End Get
        End Property

        Private Function CreateTabControl() As ColorEditTabControlBase Implements IPopupColorEdit.CreateTabControl
            Return TryCast(New PopupColorPickEditForm.ColorPickEditTabControl(Me), ColorEditTabControlBase)
        End Function

        Private ReadOnly Property OwnerWindow As IWin32Window Implements IPopupColorPickEdit.OwnerWindow
            Get
                Return Nothing
            End Get
        End Property

        Private Sub IPopupColorPickEdit_ClosePopup(ByVal mode As PopupCloseMode) Implements IPopupColorPickEdit.ClosePopup
            If _container IsNot Nothing Then _container.HidePopup()
        End Sub

        Private ReadOnly Property OwnerEdit As ColorPickEditBase Implements IPopupColorPickEdit.OwnerEdit
            Get
                Return Nothing
            End Get
        End Property

        Private Sub BeforeShowColorDialog() Implements IPopupColorPickEdit.BeforeShowColorDialog
        End Sub

        Private Sub AfterShowColorDialog() Implements IPopupColorPickEdit.AfterShowColorDialog
        End Sub

        Private Sub SetSelectedColorItem(ByVal item As ColorItem) Implements IPopupColorPickEdit.SetSelectedColorItem
        End Sub

        Private ReadOnly Property HasBorder As Boolean Implements IPopupColorPickEdit.HasBorder
            Get
                Return False
            End Get
        End Property
    End Class

    Public Class DemoPopupColorBuilderEx
        Inherits PopupColorBuilderEx

        Public Sub New(ByVal owner As IPopupColorPickEdit)
            MyBase.New(owner)
        End Sub

        Protected Overrides Function CreateTabControl() As ColorEditTabControlBase
            Dim tab As ColorEditTabControlBase = MyBase.CreateTabControl()
            tab.Dock = DockStyle.Fill
            Return tab
        End Function
    End Class
End Namespace
