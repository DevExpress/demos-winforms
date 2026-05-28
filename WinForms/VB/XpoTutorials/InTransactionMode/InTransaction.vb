Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering
Imports System.Globalization
Imports DevExpress.Xpo.DB.Helpers
Imports DevExpress.Xpo.Demos

Namespace DevExpress.Xpo.Demos
    Partial Public Class InTransactionMode
        Inherits TutorialControl
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding() = value
            End Set
        End Property
        Private inTransactionModeState As Boolean = False
        Public Sub New()
            InitializeComponent()
            PrepareDataLayer()
            PrepareViews()
            sbEmployees_Click(Me, EventArgs.Empty)
        End Sub

        Private session As UnitOfWork
        Private Sub PrepareDataLayer()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.xml")
            If (Not String.IsNullOrEmpty(DBFileName)) Then
                Dim inMemory As New InMemoryDataStore(AutoCreateOption.SchemaAlreadyExists)
                inMemory.ReadXml(DBFileName)
                Dim dataLayer As IDataLayer = New SimpleDataLayer(inMemory)
                session = New UnitOfWork(dataLayer)
            End If
        End Sub

        '<sbEmployees>
        Private viewEmployee As XPView
        Private Sub PrepareViews()
            viewEmployee = New XPView(session, GetType(Employees))
            viewEmployee.CriteriaString = "City='London'"
            viewEmployee.AddProperty("FirstName", "FirstName", False, True, SortDirection.Ascending)
            viewEmployee.AddProperty("LastName", "LastName", False, True, SortDirection.Ascending)
            viewEmployee.AddProperty("City", "City")
        End Sub
        Private Sub sbEmployees_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbEmployees.Click
            viewEmployee.Reload()
            If gclInTransactionModeMain.DataSource IsNot viewEmployee Then
                gclInTransactionModeMain.DataSource = viewEmployee
                gvlInTransactionMode.PopulateColumns()
                sbEmployees.Text = "Reload Employees"
            End If
        End Sub
        '</sbEmployees>

        '<sbChangeAnyEmployee>
        Private Sub changeAnyEmployee_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbChangeAnyEmployee.Click
            Dim employee As Employees = session.FindObject(Of Employees)(Nothing)
            If employee Is Nothing Then
                Return
            End If
            If employee.City = "London" Then
                employee.City = "Chicago"
            Else
                employee.City = "London"
            End If
            employee.Save()
            sbCommit.Enabled = True
        End Sub
        '</sbChangeAnyEmployee>
        '<sbCommit>
        Private Sub sbCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbCommit.Click
            session.CommitChanges()
            sbCommit.Enabled = False
        End Sub
        '</sbCommit>
        '<ceInTransactionMode>
        Private Sub ceInTransactionMode_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceInTransactionMode.CheckedChanged
            DevExpress.Xpo.Session.InTransactionMode = ceInTransactionMode.Checked
        End Sub
        '</ceInTransactionMode>

        Private Sub InTransactionMode_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.VisibleChanged
            If Visible Then
                DevExpress.Xpo.Session.InTransactionMode = inTransactionModeState
            Else
                DevExpress.Xpo.Session.InTransactionMode = False
            End If
        End Sub
        Private Sub ceInTransactionMode_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceInTransactionMode.CheckStateChanged
            inTransactionModeState = ceInTransactionMode.Checked
        End Sub
    End Class
End Namespace

