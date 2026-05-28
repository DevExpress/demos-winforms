Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class WeatherItem
        Inherits XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Sity As String
            Get
                Return labelControl1.Text
            End Get

            Set(ByVal value As String)
                labelControl1.Text = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Temperature As String
            Get
                Return labelControl2.Text
            End Get

            Set(ByVal value As String)
                labelControl2.Text = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property SkyConditions As String
            Get
                Return labelControl3.Text
            End Get

            Set(ByVal value As String)
                labelControl3.Text = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property RelativeHumidity As String
            Get
                Return labelControl4.Text
            End Get

            Set(ByVal value As String)
                labelControl4.Text = value
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Image As Image
            Get
                Return windowsUIButtonPanel1.Buttons(0).Properties.Image
            End Get

            Set(ByVal value As Image)
                windowsUIButtonPanel1.Buttons(0).Properties.Image = value
            End Set
        End Property
    End Class
End Namespace
