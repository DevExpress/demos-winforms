Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo.DB
Imports DevExpress.Utils

Namespace DevExpress.Xpo.Demos
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()

            XpoDefault.DataLayer = XpoDefault.GetDataLayer(InMemoryDataStore.GetConnectionString("XpoTutorials.xml"), AutoCreateOption.DatabaseAndSchema)
			
			Application.Run(New frmMain())
		End Sub
	End Class
End Namespace
