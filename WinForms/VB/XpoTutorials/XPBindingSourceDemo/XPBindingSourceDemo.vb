Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace DevExpress.Xpo.Demos
    Partial Public Class XPBindingSourceDemo
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
            CreateConnectionString()
        End Sub

        Private Sub XPBindingSourceDemo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            cbDataSource.SelectedIndex = 0
        End Sub

        '<cbDataSource>
        Private Sub CreateConnectionString()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                session1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
            End If

            ' A session will not automatically create the database or update database schema.
            session1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None
        End Sub

        Private Sub cbDataSource_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDataSource.SelectedIndexChanged
            groupControl1.Text = cbDataSource.Text
            Select Case cbDataSource.SelectedIndex
                Case 0
                    xpBindingSource1.DataSource = xpCollection1
                Case 1
                    Dim listOfObjects As List(Of Customers) = session1.Query(Of Customers).ToList()
                    xpBindingSource1.DataSource = listOfObjects
                Case 2
                    Dim singleObject As Customers = session1.Query(Of Customers).First()
                    xpBindingSource1.DataSource = singleObject
                Case 3
                    xpBindingSource1.DataSource = Nothing
                    xpBindingSource1.ObjectClassInfo = session1.GetClassInfo(Of Customers)
            End Select
            gridView1.PopulateColumns()
            gridView1.BestFitColumns()
        End Sub
        '</cbDataSource>
    End Class
End Namespace
