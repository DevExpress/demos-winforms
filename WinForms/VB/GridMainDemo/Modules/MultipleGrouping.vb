Imports System
Imports System.Drawing
Imports System.ComponentModel

Namespace DevExpress.XtraGrid.Demos

    ''' <summary>
    ''' Summary description for MultipleGrouping.
    ''' </summary>
    Public Partial Class MultipleGrouping
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"MultipleGrouping", "Tasks"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "MultipleGrouping"
            End Get
        End Property

        '<gridControl1>
        '<sbGroup>
        Private gc As GroupingControllerTasksWithCategories

        '</sbGroup>
        Private Sub MultipleGrouping_Load(ByVal sender As Object, ByVal e As EventArgs)
            gc = New GroupingControllerTasksWithCategories(gridControl1)
            AddHandler gc.AfterGrouping, New EventHandler(AddressOf gc_AfterGrouping)
            InitButtonCaption()
        End Sub

        '</gridControl1>
        Private Sub InitButtonCaption()
            sbGroup.Text = If(gc.IsCategoryGrouping, Properties.Resources.UngroupCategory, Properties.Resources.GroupCategory)
        End Sub

        '<sbGroup>
        Private Sub sbGroup_Click(ByVal sender As Object, ByVal e As EventArgs)
            If gc.CategoryColumn Is Nothing Then
                sbGroup.Enabled = False
                Return
            End If

            If gc.CategoryColumn.GroupIndex = -1 Then
                gc.CategoryColumn.Group()
            Else
                gc.CategoryColumn.UnGroup()
            End If
        End Sub

        '</sbGroup>
        Private Sub gc_AfterGrouping(ByVal sender As Object, ByVal e As EventArgs)
            InitButtonCaption()
        End Sub
    End Class
End Namespace
