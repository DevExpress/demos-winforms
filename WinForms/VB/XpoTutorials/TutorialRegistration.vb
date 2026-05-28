Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Frames
Imports System.Collections.Generic
Imports DevExpress.Tutorials

Namespace DevExpress.Xpo.Demos
	Friend Class TutorialRegistration
        Private Const languageDir As String = "VB\"
		Public Sub New(ByVal xmlFile As String, ByVal codeFile As String)
			Me.xmlFile = xmlFile
			Me.codeFile = codeFile
		End Sub
		Private xmlFile As String
		Private codeFile As String
		Public ReadOnly Property XmlInfoFile() As String
			Get
				Return xmlFile
			End Get
		End Property
		Public ReadOnly Property CodeInfoFile() As String
			Get
				Return languageDir & codeFile
			End Get
		End Property

		Private Shared modulesInfo As New Dictionary(Of String, TutorialRegistration)()
		Public Shared Sub AddInfo(ByVal moduleName As String, ByVal codeFile As String, ByVal xmlFile As String)
			If modulesInfo.ContainsKey(moduleName) Then
				modulesInfo(moduleName) = New TutorialRegistration(xmlFile, codeFile)
			Else
				modulesInfo.Add(moduleName, New TutorialRegistration(xmlFile, codeFile))
			End If
		End Sub
		Public Shared Function GetInfo(ByVal moduleName As String) As TutorialRegistration
			If modulesInfo.ContainsKey(moduleName) Then
				Return modulesInfo(moduleName)
			Else
				Return Nothing
			End If
		End Function

		Public Shared Sub Register()
            AddInfo("DeletingPersistentObjects", "XpoTutorials\DeletingPersistentObjects\DeletingPersistentObjects.vb", "Data\Tutorials\XPO\DeletingPersistentObjects.xml")
            AddInfo("Images", "XpoTutorials\Images\Cars.vb", "Data\Tutorials\XPO\Images.xml")
            AddInfo("NestedUnitsOfWork", "XpoTutorials\NestedUnitsOfWork\NestedUnitsOfWork.vb", "Data\Tutorials\XPO\NestedUnitsOfWork.xml")
            AddInfo("Pagination", "XpoTutorials\Pagination\Pagination.vb", "Data\Tutorials\XPO\Pagination.xml")
            AddInfo("QueryingData", "XpoTutorials\QueryingData\QueryingData.vb", "Data\Tutorials\XPO\QueryingData.xml")
            AddInfo("OneToManyRelations", "XpoTutorials\Customers.vb", "Data\Tutorials\XPO\OneToManyRelations.xml")
            AddInfo("SimpleDataAwareApplication", "XpoTutorials\Customers.vb", "Data\Tutorials\XPO\SimpleDataAwareApplication.xml")
            AddInfo("UnitsOfWork", "XpoTutorials\UnitsOfWork\UnitsOfWork.vb", "Data\Tutorials\XPO\UnitsOfWork.xml")
            AddInfo("MSSQLServer", "XpoTutorials\MSSQLServer\MSSQLServer.vb", "Data\Tutorials\XPO\MSSQLServer.xml")
            AddInfo("Validation", "XpoTutorials\Validation\Validation.vb;XpoTutorials\Validation\Contacts.cs;XpoTutorials\Validation\NewContactForm.vb", "Data\Tutorials\XPO\Validation.xml")
            AddInfo("XPViewDemo", "XpoTutorials\XPViewDemo\XPViewDemo.vb", "Data\Tutorials\XPO\XPViewDemo.xml")
            AddInfo("XPBindingSourceDemo", "XpoTutorials\XPBindingSourceDemo\XPBindingSourceDemo.vb", "Data\Tutorials\XPO\XPBindingSourceDemo.xml")
            AddInfo("Functions", "XpoTutorials\Function\Functions.vb", "Data\Tutorials\XPO\Functions.xml")
            AddInfo("AsyncLoading", "XpoTutorials\AsyncLoading\AsyncLoading.vb", "Data\Tutorials\XPO\AsyncLoading.xml")
            AddInfo("AsyncLoadingTaskBased", "XpoTutorials\AsyncLoading\AsyncLoading.vb", "Data\Tutorials\XPO\AsyncLoadingTaskBased.xml")
            AddInfo("FreeJoin", "XpoTutorials\FreeJoin\FreeJoin.vb", "Data\Tutorials\XPO\FreeJoin.xml")
            AddInfo("DataCaching", "XpoTutorials\DataCaching\DataCaching.vb", "Data\Tutorials\XPO\DataCaching.xml")
            AddInfo("DataServices", "XpoTutorials\DataStoreService\DataService.vb", "Data\Tutorials\XPO\DataServices.xml")
            AddInfo("ObjectLayerServices", "XpoTutorials\ObjectLayerService\ObjectLayerService.vb", "Data\Tutorials\XPO\ObjectLayerServices.xml")
            AddInfo("InTransactionMode", "XpoTutorials\InTransactionMode\InTransaction.vb", "Data\Tutorials\XPO\InTransactionMode.xml")
            AddInfo("SpecifiedTypeObject", "XpoTutorials\SpecifiedTypeObject\SpecifiedTypeObject.vb", "Data\Tutorials\XPO\SpecifiedTypeObject.xml")
            AddInfo("GridServerMode", "XpoTutorials\InstantFeedback\GridServerMode.vb", "Data\Tutorials\XPO\GridServerMode.xml")
            AddInfo("Single", "XpoTutorials\Single\Single.vb", "Data\Tutorials\XPO\Single.xml")
            AddInfo("ObjectsInAlias", "XpoTutorials\ObjectsInAlias\ObjectsInAlias.vb", "Data\Tutorials\XPO\ObjectsInAlias.xml")
            AddInfo("ModifiedProperties", "XpoTutorials\ModifiedProperties\ModifiedProperties.vb", "Data\Tutorials\XPO\ModifiedProperties.xml")
		End Sub
	End Class
End Namespace
