Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.Xpo.Demos
    Partial Public Class XPViewDemo
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
            CreateConnectionString()
        End Sub

        Private Sub XPViewDemo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            cbViews.SelectedIndex = 0
        End Sub

        '<cbViews>
        Private Sub CreateConnectionString()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
            If DBFileName <> "" Then
                session1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
            End If

            ' A session will not automatically create the database or update database schema.
            session1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None
        End Sub

        Private Sub cbViews_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbViews.SelectedIndexChanged
            groupControl1.Text = cbViews.Text
            Select Case cbViews.SelectedIndex
                Case 0
                    gridControl1.DataSource = xpviewProducts
                Case 1
                    gridControl1.DataSource = xpviewSuppliersProduct
                Case 2
                    gridControl1.DataSource = xpviewOrders
            End Select
            gridView1.PopulateColumns()
            gridView1.BestFitColumns()
        End Sub
        '</cbViews>
    End Class
End Namespace
