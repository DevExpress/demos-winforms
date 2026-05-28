Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad

    ''' <summary>
    ''' Summary description for frmPad.
    ''' </summary>
    Public Partial Class frmPad
        Inherits XtraForm

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Icon = DevExpress.Utils.ResourceImageHelperCore.CreateIconFromResourcesEx("DevExpress.XtraBars.Demos.RibbonSimplePad.AppIcon.ico", GetType(frmMain).Assembly)
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Private modifiedCore As Boolean = False

        Private newDocumentCore As Boolean = True

        Private docNameCore As String = String.Empty

        Public ReadOnly Property RTBMain As RichTextBox
            Get
                Return richTextBox1
            End Get
        End Property

        <DefaultValue("")>
        Public Property DocName As String
            Get
                Return docNameCore
            End Get

            Set(ByVal value As String)
                docNameCore = value
                Text = DocName
            End Set
        End Property

        <DefaultValue(False)>
        Public Property Modified As Boolean
            Get
                Return modifiedCore
            End Get

            Set(ByVal value As Boolean)
                If value <> modifiedCore Then
                    modifiedCore = value
                    Text = DocName & If(Modified, "*", "")
                    If MdiParent IsNot Nothing Then CType(MdiParent, frmMain).UpdateText()
                End If
            End Set
        End Property

        Public ReadOnly Property NewDocument As Boolean
            Get
                Return newDocumentCore
            End Get
        End Property

        Public Sub LoadDocument(ByVal fileName As String)
            newDocumentCore = False
            Try
                RTBMain.LoadFile(fileName)
            Catch
                XtraMessageBox.Show("Sorry, this file cannot be opened.", "Ribbon Simple Pad")
            End Try

            DocName = fileName
        End Sub

        Public Function SaveAs(ByVal path As String) As String
            Dim dlg As SaveFileDialog = New SaveFileDialog()
            dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
            dlg.Title = "Save As"
            If Not Equals(path, String.Empty) Then dlg.InitialDirectory = path
            If dlg.ShowDialog(Me) = DialogResult.OK Then
                RTBMain.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText)
                DocName = dlg.FileName
                newDocumentCore = False
                Modified = False
                Return DocName
            End If

            Return String.Empty
        End Function

        Private Function SaveQuestion() As Boolean
            If Modified Then
                Select Case XtraMessageBox.Show("Do you want to save the changes you made to " & DocName & "?", "SimplePad Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    Case DialogResult.Cancel
                        Return False
                    Case DialogResult.Yes
                        SaveAs(String.Empty)
                End Select
            End If

            Return True
        End Function

        Private Sub frmPad_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            e.Cancel = Not SaveQuestion()
        End Sub

        Private Sub richTextBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If RTBMain.ClientRectangle.Contains(e.X, e.Y) Then
                If(e.Button And MouseButtons.Right) <> 0 Then
                    RaiseShowPopupMenu()
                ElseIf e.Button = MouseButtons.Left Then
                    RaiseShowMiniToolbar()
                End If
            End If
        End Sub

        Public Event ShowPopupMenu As EventHandler

        Public Event ShowMiniToolbar As EventHandler

        Private Sub RaiseShowPopupMenu()
            RaiseEvent ShowPopupMenu(RTBMain, EventArgs.Empty)
        End Sub

        Private Sub RaiseShowMiniToolbar()
            RaiseEvent ShowMiniToolbar(RTBMain, EventArgs.Empty)
        End Sub
    End Class
End Namespace
