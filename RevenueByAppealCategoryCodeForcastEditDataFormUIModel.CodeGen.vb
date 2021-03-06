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
''' Represents the UI model for the 'Revenue By Appeal Category Code Forcast Edit Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit, "58dfabb6-92c8-44f2-8e2e-ac48d831bcfd", "09341e13-57f0-4909-9eb2-57684711208d", "Revenue By Appeal Category Code Forcast")>
Partial Public Class [RevenueByAppealCategoryCodeForcastEditDataFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _forecaststring As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _forecastdetails As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of RevenueByAppealCategoryCodeForcastEditDataFormFORECASTDETAILSUIModel)

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public Sub New()
        MyBase.New()

        _forecaststring = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _forecastdetails = New Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of RevenueByAppealCategoryCodeForcastEditDataFormFORECASTDETAILSUIModel)

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.Edit
        MyBase.DataFormTemplateId = New System.Guid("58dfabb6-92c8-44f2-8e2e-ac48d831bcfd")
        MyBase.DataFormInstanceId = New System.Guid("09341e13-57f0-4909-9eb2-57684711208d")
        MyBase.RecordType = "Revenue By Appeal Category Code Forcast"
        MyBase.FORMHEADER.Value = "Edit a revenue by appeal category code forcast"
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/budgetvsactual/RevenueByAppealCategoryCodeForcastEditDataForm.html"

        '
        '_forecaststring
        '
        _forecaststring.Name = "FORECASTSTRING"
        _forecaststring.Caption = "Forcast string"
        _forecaststring.Required = True
        Me.Fields.Add(_forecaststring)
        '
        '_forecastdetails
        '
        _forecastdetails.Name = "FORECASTDETAILS"
        _forecastdetails.Caption = "Revenue forecast by appeal category code"
        _forecastdetails.Required = True
        Me.Fields.Add(_forecastdetails)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Forcast string
    ''' </summary>
    <System.ComponentModel.Description("Forcast string")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [FORECASTSTRING]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _forecaststring
        End Get
    End Property
    
    ''' <summary>
    ''' Revenue forecast by appeal category code
    ''' </summary>
    <System.ComponentModel.Description("Revenue forecast by appeal category code")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [FORECASTDETAILS]() As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of RevenueByAppealCategoryCodeForcastEditDataFormFORECASTDETAILSUIModel)
        Get
            Return _forecastdetails
        End Get
    End Property
    
End Class
