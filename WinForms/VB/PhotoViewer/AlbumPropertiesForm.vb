Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace PhotoViewer

    Public Partial Class AlbumPropertiesForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(ByVal viewData As PhotoViewerData)
            Me.New()
            _viewData = viewData
        End Sub

        Private _viewData As PhotoViewerData

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property ViewData As PhotoViewerData
            Get
                Return _viewData
            End Get

            Set(ByVal value As PhotoViewerData)
                _viewData = value
            End Set
        End Property

        Private isEditExistingAlbumModeField As Boolean = False

        <DefaultValue(False)>
        Public Property IsEditExistingAlbumMode As Boolean
            Get
                Return isEditExistingAlbumModeField
            End Get

            Set(ByVal value As Boolean)
                isEditExistingAlbumModeField = value
            End Set
        End Property

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            If CheckAlbumProperties() Then
                DialogResult = DialogResult.OK
                Close()
            End If
        End Sub

        Protected Overridable Function CheckAlbumProperties() As Boolean
            Dim _albumName As String = albumNameEdit.Text.Trim()
            Dim messageCaption As String = If(IsEditExistingAlbumMode, "Edit Album", "New Album")
            If String.IsNullOrEmpty(_albumName) Then
                XtraMessageBox.Show(Me, "Error: please type album name.", messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            For Each album As AlbumData In ViewData.Albums
                If Equals(album.Name, _albumName) AndAlso Not IsEditExistingAlbumMode Then
                    XtraMessageBox.Show(Me, $"Error: album with the name '{albumNameEdit.Text}' already exists in albums collection. Please type another name.", messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Next

            Return True
        End Function

        Private Sub NewAlbumForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            _albumDate.DateTime = Date.Now
        End Sub

        <DefaultValue("")>
        Public Property AlbumName As String
            Get
                Return albumNameEdit.Text
            End Get

            Set(ByVal value As String)
                albumNameEdit.Text = value
            End Set
        End Property

        <System.ComponentModel.DefaultValue(CType(Nothing, Object))>
        Public Property AlbumDate As Date
            Get
                Return _albumDate.DateTime
            End Get

            Set(ByVal value As Date)
                _albumDate.DateTime = value
            End Set
        End Property

        <DefaultValue("")>
        Public Property AlbumDescription As String
            Get
                Return albumDescriptionCore.Text
            End Get

            Set(ByVal value As String)
                albumDescriptionCore.Text = value
            End Set
        End Property
    End Class
End Namespace
