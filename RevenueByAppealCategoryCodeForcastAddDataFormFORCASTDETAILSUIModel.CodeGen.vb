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
''' Represents the UI model for the 'RevenueByAppealCategoryCodeForcastAddDataFormFORCASTDETAILS' data form
''' </summary>
Partial Public Class [RevenueByAppealCategoryCodeForcastAddDataFormFORCASTDETAILSUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.UIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _appealcategorycodeid As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
    Private WithEvents _appealcategorycodedisplay As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _monthjan As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthfeb As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthmar As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthapr As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthmay As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthjun As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthjul As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthaug As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthsep As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthoct As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthnov As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _monthdec As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
    Private WithEvents _yeartotal As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public Sub New()
        MyBase.New()

        _appealcategorycodeid = New Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        _appealcategorycodedisplay = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _monthjan = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthfeb = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthmar = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthapr = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthmay = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthjun = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthjul = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthaug = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthsep = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthoct = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthnov = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _monthdec = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        _yeartotal = New Global.Blackbaud.AppFx.UIModeling.Core.MoneyField

        '
        '_appealcategorycodeid
        '
        _appealcategorycodeid.Name = "APPEALCATEGORYCODEID"
        _appealcategorycodeid.Caption = "Appeal Category Code"
        _appealcategorycodeid.Visible = False
        _appealcategorycodeid.CodeTableName = "APPEALCATEGORYCODE"
        Me.Fields.Add(_appealcategorycodeid)
        '
        '_appealcategorycodedisplay
        '
        _appealcategorycodedisplay.Name = "APPEALCATEGORYCODEDISPLAY"
        _appealcategorycodedisplay.Caption = "Category code"
        _appealcategorycodedisplay.DBReadOnly = True
        Me.Fields.Add(_appealcategorycodedisplay)
        '
        '_monthjan
        '
        _monthjan.Name = "MONTHJAN"
        _monthjan.Caption = "Jan"
        Me.Fields.Add(_monthjan)
        '
        '_monthfeb
        '
        _monthfeb.Name = "MONTHFEB"
        _monthfeb.Caption = "Feb"
        Me.Fields.Add(_monthfeb)
        '
        '_monthmar
        '
        _monthmar.Name = "MONTHMAR"
        _monthmar.Caption = "Mar"
        Me.Fields.Add(_monthmar)
        '
        '_monthapr
        '
        _monthapr.Name = "MONTHAPR"
        _monthapr.Caption = "Apr"
        Me.Fields.Add(_monthapr)
        '
        '_monthmay
        '
        _monthmay.Name = "MONTHMAY"
        _monthmay.Caption = "May"
        Me.Fields.Add(_monthmay)
        '
        '_monthjun
        '
        _monthjun.Name = "MONTHJUN"
        _monthjun.Caption = "Jun"
        Me.Fields.Add(_monthjun)
        '
        '_monthjul
        '
        _monthjul.Name = "MONTHJUL"
        _monthjul.Caption = "Jul"
        Me.Fields.Add(_monthjul)
        '
        '_monthaug
        '
        _monthaug.Name = "MONTHAUG"
        _monthaug.Caption = "Aug"
        Me.Fields.Add(_monthaug)
        '
        '_monthsep
        '
        _monthsep.Name = "MONTHSEP"
        _monthsep.Caption = "Sep"
        Me.Fields.Add(_monthsep)
        '
        '_monthoct
        '
        _monthoct.Name = "MONTHOCT"
        _monthoct.Caption = "Oct"
        Me.Fields.Add(_monthoct)
        '
        '_monthnov
        '
        _monthnov.Name = "MONTHNOV"
        _monthnov.Caption = "Nov"
        Me.Fields.Add(_monthnov)
        '
        '_monthdec
        '
        _monthdec.Name = "MONTHDEC"
        _monthdec.Caption = "Dec"
        Me.Fields.Add(_monthdec)
        '
        '_yeartotal
        '
        _yeartotal.Name = "YEARTOTAL"
        _yeartotal.Caption = "Total"
        Me.Fields.Add(_yeartotal)

		OnCreated()

    End Sub
    
    ''' <summary>
    ''' Appeal Category Code
    ''' </summary>
    <System.ComponentModel.Description("Appeal Category Code")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [APPEALCATEGORYCODEID]() As Global.Blackbaud.AppFx.UIModeling.Core.CodeTableField
        Get
            Return _appealcategorycodeid
        End Get
    End Property
    
    ''' <summary>
    ''' Category code
    ''' </summary>
    <System.ComponentModel.Description("Category code")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [APPEALCATEGORYCODEDISPLAY]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _appealcategorycodedisplay
        End Get
    End Property
    
    ''' <summary>
    ''' Jan
    ''' </summary>
    <System.ComponentModel.Description("Jan")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHJAN]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthjan
        End Get
    End Property
    
    ''' <summary>
    ''' Feb
    ''' </summary>
    <System.ComponentModel.Description("Feb")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHFEB]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthfeb
        End Get
    End Property
    
    ''' <summary>
    ''' Mar
    ''' </summary>
    <System.ComponentModel.Description("Mar")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHMAR]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthmar
        End Get
    End Property
    
    ''' <summary>
    ''' Apr
    ''' </summary>
    <System.ComponentModel.Description("Apr")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHAPR]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthapr
        End Get
    End Property
    
    ''' <summary>
    ''' May
    ''' </summary>
    <System.ComponentModel.Description("May")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHMAY]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthmay
        End Get
    End Property
    
    ''' <summary>
    ''' Jun
    ''' </summary>
    <System.ComponentModel.Description("Jun")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHJUN]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthjun
        End Get
    End Property
    
    ''' <summary>
    ''' Jul
    ''' </summary>
    <System.ComponentModel.Description("Jul")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHJUL]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthjul
        End Get
    End Property
    
    ''' <summary>
    ''' Aug
    ''' </summary>
    <System.ComponentModel.Description("Aug")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHAUG]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthaug
        End Get
    End Property
    
    ''' <summary>
    ''' Sep
    ''' </summary>
    <System.ComponentModel.Description("Sep")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHSEP]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthsep
        End Get
    End Property
    
    ''' <summary>
    ''' Oct
    ''' </summary>
    <System.ComponentModel.Description("Oct")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHOCT]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthoct
        End Get
    End Property
    
    ''' <summary>
    ''' Nov
    ''' </summary>
    <System.ComponentModel.Description("Nov")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHNOV]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthnov
        End Get
    End Property
    
    ''' <summary>
    ''' Dec
    ''' </summary>
    <System.ComponentModel.Description("Dec")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [MONTHDEC]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _monthdec
        End Get
    End Property
    
    ''' <summary>
    ''' Total
    ''' </summary>
    <System.ComponentModel.Description("Total")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [YEARTOTAL]() As Global.Blackbaud.AppFx.UIModeling.Core.MoneyField
        Get
            Return _yeartotal
        End Get
    End Property
    
End Class
