Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.Xpo.Demos
    Partial Public Class Pagination
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Pagination_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            If xpBusinessObjects.Count = 0 Then
                CreateBusinessObjects(unitOfWork1, 100)
                xpBusinessObjects.Reload()
            End If
            UpdateEditors()
        End Sub

        '<simpleButton2>
        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton2.Click
            SelectPage(True)
        End Sub
        '</simpleButton2>

        '<simpleButton1>
        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
            SelectPage(False)
        End Sub

        '<simpleButton2>
        Private Sub SelectPage(ByVal forward As Boolean)
            If forward Then
                If xpPageSelector1.CurrentPage = xpPageSelector1.PageCount - 1 Then
                    Return
                End If
                xpPageSelector1.CurrentPage += 1
            Else
                If xpPageSelector1.CurrentPage = 0 Then
                    Return
                End If
                xpPageSelector1.CurrentPage -= 1
            End If
            UpdateEditors()
        End Sub
        '</simpleButton1>
        '</simpleButton2>

        Private Sub UpdateEditors()
            simpleButton1.Enabled = Not (xpPageSelector1.CurrentPage = 0)
            simpleButton2.Enabled = Not (xpPageSelector1.CurrentPage = xpPageSelector1.PageCount - 1)
            lCurrentPage.Text = "Current Page: " & xpPageSelector1.CurrentPage.ToString()
        End Sub

        Private Sub bSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bSave.Click
            SaveChanges(unitOfWork1)
        End Sub

        Public Overrides Sub ReloadData()
            xpPageSelector1.Collection.Reload()
        End Sub
    End Class
End Namespace
