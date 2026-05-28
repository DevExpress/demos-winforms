Imports System
Imports System.Reflection
Imports DevExpress.XtraTreeList

Namespace DevExpress.Demos

    Public Class ClassViewer

        Public Shared Sub AddClassInfo(ByVal tv As TreeList, ByVal type As Type, ByVal objects As Object())
            Dim s As String = type.Assembly.FullName
            s = s.Substring(0, s.IndexOf(", "))
            Dim aNode As Integer = tv.AppendNode((New Object() {s}), -1, -1, -1, 0).Id
            For Each obj As Object In objects
                s = obj.ToString()
                Call AddMetods(obj.GetType(), tv.AppendNode((New Object() {s}), aNode, -1, -1, 1).Id, tv)
            Next

            tv.ExpandAll()
        End Sub

        Private Shared Sub AddMetods(ByVal type As Type, ByVal node As Integer, ByVal tv As TreeList)
            Dim mii As MemberInfo() = type.GetMembers(BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.DeclaredOnly)
            For Each mi As MemberInfo In mii
                Dim ind As Integer = GetImageIndex(mi.MemberType)
                If ind <> -1 Then ind += GetAccessType(mi)
                tv.AppendNode(New Object() {mi.ToString()}, node, -1, -1, ind)
            Next
        End Sub

        Private Shared Function GetImageIndex(ByVal type As MemberTypes) As Integer
            Select Case type.ToString()
                Case "Field", "Property"
                    Return 2
                Case "Event"
                    Return 3
                Case "Method", "Constructor"
                    Return 4
                Case Else
                    Return -1
            End Select
        End Function

        Private Shared Function GetAccessType(ByVal m As MemberInfo) As Integer
            Dim x As Integer = 3
            Dim mi As MethodInfo = GetMethodInfo(m)
            Dim ret As Integer = x * 2
            If TypeOf m Is EventInfo Then mi = TryCast(m, EventInfo).GetAddMethod(True)
            If mi IsNot Nothing Then
                If mi.IsPublic Then ret = 0
                If mi.IsPrivate Then ret = x
            End If

            If TypeOf m Is FieldInfo Then
                If TryCast(m, FieldInfo).IsPublic Then ret = 0
                If TryCast(m, FieldInfo).IsPrivate Then ret = x
            End If

            If TypeOf m Is ConstructorInfo Then
                If TryCast(m, ConstructorInfo).IsPublic Then ret = 0
                If TryCast(m, ConstructorInfo).IsPrivate Then ret = x
            End If

            Return ret
        End Function

        Private Shared Function GetMethodInfo(ByVal m As MemberInfo) As MethodInfo
            If TypeOf m Is PropertyInfo Then
                Dim pi As PropertyInfo = TryCast(m, PropertyInfo)
                m = pi.GetGetMethod()
                If m Is Nothing Then m = pi.GetGetMethod(True)
            End If

            If TypeOf m Is MethodInfo Then Return TryCast(m, MethodInfo)
            Return Nothing
        End Function
    End Class
End Namespace
