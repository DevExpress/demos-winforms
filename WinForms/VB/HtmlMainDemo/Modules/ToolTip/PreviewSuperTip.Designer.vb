Namespace DevExpress.HTML.Demos

    Partial Class PreviewSuperTip

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.HTML.Demos.PreviewSuperTip))
            Me.htmlTemplateCollection1 = New DevExpress.Utils.Html.HtmlTemplateCollection()
            Me.htmlSimple = New DevExpress.Utils.Html.HtmlTemplate()
            Me.templateStandardSuperTip = New DevExpress.Utils.Html.HtmlTemplate()
            Me.SuspendLayout()
            ' 
            ' htmlTemplateCollection1
            ' 
            Me.htmlTemplateCollection1.AddRange(New DevExpress.Utils.Html.HtmlTemplate() {Me.htmlSimple, Me.templateStandardSuperTip})
            ' 
            ' htmlSimple
            ' 
            Me.htmlSimple.Name = "htmlSimple"
            Me.htmlSimple.PreviewType = GetType(DevExpress.Utils.ToolTipController)
            Me.htmlSimple.Styles = resources.GetString("htmlSimple.Styles")
            Me.htmlSimple.Tag = "Simple SuperTip"
            Me.htmlSimple.Template = resources.GetString("htmlSimple.Template")
            ' 
            ' templateStandardSuperTip
            ' 
            Me.templateStandardSuperTip.Name = "templateStandardSuperTip"
            Me.templateStandardSuperTip.PreviewType = GetType(DevExpress.Utils.ToolTipController)
            Me.templateStandardSuperTip.Styles = resources.GetString("templateStandardSuperTip.Styles")
            Me.templateStandardSuperTip.Tag = "Standard SuperTip Template"
            Me.templateStandardSuperTip.Template = resources.GetString("templateStandardSuperTip.Template")
            ' 
            ' PreviewSuperTip
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "PreviewSuperTip"
            Me.Size = New System.Drawing.Size(714, 497)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private htmlTemplateCollection1 As DevExpress.Utils.Html.HtmlTemplateCollection

        Private htmlSimple As DevExpress.Utils.Html.HtmlTemplate

        Private templateStandardSuperTip As DevExpress.Utils.Html.HtmlTemplate
    End Class
End Namespace
