Imports System.Drawing
Imports System.ComponentModel

Namespace DevExpress.XtraBars.Demos.BrowserDemo

    ''' <summary>
    ''' Summary description for frmAddFavorites.
    ''' </summary>
    Public Partial Class frmAddFavorites
        Inherits XtraEditors.XtraForm

        Public ReadOnly Property LocationName As String
            Get
                Return textBox1.Text
            End Get
        End Property

        Public ReadOnly Property LocationURL As String
            Get
                Return textBox2.Text
            End Get
        End Property

        Public Sub New(ByVal name As String, ByVal URL As String, ByVal img As Image)
            Me.New(name, URL, img, True)
        End Sub

        Public Sub New(ByVal name As String, ByVal URL As String, ByVal img As Image, ByVal isAdd As Boolean)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            label1.AutoSizeMode = XtraEditors.LabelAutoSizeMode.None
            textBox1.Text = name
            textBox2.Text = URL
            pictureBox1.Image = img
            If Not isAdd Then
                Text = "Edit Favorite Item"
                label1.Text = "Use the following edit fields to change this Favorite item description or the URL."
            End If
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub
#Region "Windows Form Designer generated code"
#End Region
    End Class
End Namespace
