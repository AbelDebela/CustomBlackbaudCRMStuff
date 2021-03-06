﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.167.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Revenue By Appeal Category Code Forcast View Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "7cd53815-3ca9-46cc-bc13-e43d9ef6469a", "db1ca5f9-f2e4-41fe-97d0-d2b0a6bfdee2", "Revenue By Appeal Category Code Forcast")>
Partial Public Class [RevenueByAppealCategoryCodeForcastViewDataFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _forecastdetails As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of RevenueByAppealCategoryCodeForcastViewDataFormFORECASTDETAILSUIModel)

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public Sub New()
        MyBase.New()

        _forecastdetails = New Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of RevenueByAppealCategoryCodeForcastViewDataFormFORECASTDETAILSUIModel)

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View
        MyBase.DataFormTemplateId = New System.Guid("7cd53815-3ca9-46cc-bc13-e43d9ef6469a")
        MyBase.DataFormInstanceId = New System.Guid("db1ca5f9-f2e4-41fe-97d0-d2b0a6bfdee2")
        MyBase.RecordType = "Revenue By Appeal Category Code Forcast"
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/customconfigurationsetting/RevenueByAppealCategoryCodeForcastViewDataForm.html"

        '
        '_forecastdetails
        '
        _forecastdetails.Name = "FORECASTDETAILS"
        _forecastdetails.Caption = "Revenue forecast by appeal category code"
        _forecastdetails.Required = True
        _forecastdetails.DBReadOnly = True
        Me.Fields.Add(_forecastdetails)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Revenue forecast by appeal category code
    ''' </summary>
    <System.ComponentModel.Description("Revenue forecast by appeal category code")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [FORECASTDETAILS]() As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of RevenueByAppealCategoryCodeForcastViewDataFormFORECASTDETAILSUIModel)
        Get
            Return _forecastdetails
        End Get
    End Property
    
End Class
