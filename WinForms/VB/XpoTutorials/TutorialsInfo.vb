Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Frames
Imports System.Collections.Generic
Imports System.Reflection
Imports System.IO

Namespace DevExpress.Xpo.Demos
	Public Class TutorialsInfo
		Inherits ModulesInfo
        Public Overloads Shared Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal manager As RibbonMenuManager)
            Dim item As ModuleInfo = TutorialsInfo.GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    If Instance.CurrentModuleBase.Name = name Then
                        Return
                    End If
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If
                Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
                tutorial.Bounds = group.DisplayRectangle
                Instance.CurrentModuleBase = item
                tutorial.Visible = False
                group.Controls.Add(tutorial)
                tutorial.Dock = DockStyle.Fill
                tutorial.RibbonMenuManager = manager
                tutorial.TutorialName = name
                tutorial.Visible = True
                Dim tc As TutorialControl = TryCast(item.TModule, TutorialControl)
                If tc IsNot Nothing AndAlso tc.SetNewWhatsThisPadding Then
                    manager.ShowReservGroup1(True)
                    tc.SetUpWhatsThis()
                Else
                    manager.ShowReservGroup1(False)
                End If
                item.WasShown = True
                If oldTutorial IsNot Nothing Then
                    oldTutorial.Visible = False
                End If
            Finally
                Cursor.Current = currentCursor
            End Try
            RaiseModuleChanged()
        End Sub
    End Class
End Namespace
