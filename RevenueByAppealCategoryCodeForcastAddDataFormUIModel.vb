Imports Blackbaud.AppFx.Server
Imports Blackbaud.AppFx.UIModeling.Core

Public Class RevenueByAppealCategoryCodeForcastAddDataFormUIModel

    Private Sub RevenueByAppealCategoryCodeForcastAddDataFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Call LoadAppealCategoryCode()
        Me.FORECASTDETAILS.AllowColumnMove = False
        Me.FORECASTDETAILS.AllowDelete = False
        Me.FORECASTDETAILS.AllowAdd = False
        Me.FORECASTSTRING.Value = "Empty"
        FORECASTDETAILS.Caption = "Revenue forecast by appeal category code for " & Me.GLFISCALYEARID.GetCurrentLabel
    End Sub

    Private Sub LoadAppealCategoryCode()
        Dim CodeTableListRequest As New Blackbaud.AppFx.Server.CodeTableEntryGetListRequest
        CodeTableListRequest.CodeTableName = "APPEALCATEGORYCODE"
        CodeTableListRequest.ClientAppInfo = GetRequestContext.ClientAppInfo
        Dim CodeTableListReply = CodeTableEntryGetList(CodeTableListRequest, Me.GetRequestContext())

        For Each item In CodeTableListReply.Rows
            Dim _forcastdetail As New RevenueByAppealCategoryCodeForcastAddDataFormFORECASTDETAILSUIModel
            _forcastdetail.APPEALCATEGORYCODEID.Value = item.ID
            _forcastdetail.APPEALCATEGORYCODEDISPLAY.Value = item.Code
            _forcastdetail.APPEALCATEGORYCODEDISPLAY.Enabled = False
            Me.FORECASTDETAILS.Value.Add(_forcastdetail)
        Next
        Dim _totalrow As New RevenueByAppealCategoryCodeForcastAddDataFormFORECASTDETAILSUIModel
        _totalrow.APPEALCATEGORYCODEDISPLAY.Value = "Total"
        _totalrow.APPEALCATEGORYCODEDISPLAY.Enabled = False
        For Each dd In _totalrow.Fields
            dd.Enabled = False
        Next
        Me.FORECASTDETAILS.Value.Add(_totalrow)

        ' Disable last column 
        For i = 0 To FORECASTDETAILS.Value.Count - 1
            FORECASTDETAILS.Value(i).YEARTOTAL.Enabled = False
        Next





    End Sub
    Private Sub PrepareForecastSummary()
        Dim locsourceString As String = "<FORECASTDETAIL>"
        Dim i As Integer
        '        Dim j As Integer

        For i = 0 To FORECASTDETAILS.Value.Count - 2 ' Ignore the last row as it's total of the column values
            locsourceString &= "<ITEM>"
            locsourceString &= "<ID>" & FORECASTDETAILS.Value(i).APPEALCATEGORYCODEID.Value.ToString() & "</ID>"
            locsourceString &= "<JAN>" & FORECASTDETAILS.Value(i).MONTHJAN.Value.ToString() & "</JAN>"
            locsourceString &= "<FEB>" & FORECASTDETAILS.Value(i).MONTHFEB.Value.ToString() & "</FEB>"
            locsourceString &= "<MAR>" & FORECASTDETAILS.Value(i).MONTHMAR.Value.ToString() & "</MAR>"
            locsourceString &= "<APR>" & FORECASTDETAILS.Value(i).MONTHAPR.Value.ToString() & "</APR>"
            locsourceString &= "<MAY>" & FORECASTDETAILS.Value(i).MONTHMAY.Value.ToString() & "</MAY>"
            locsourceString &= "<JUN>" & FORECASTDETAILS.Value(i).MONTHJUN.Value.ToString() & "</JUN>"
            locsourceString &= "<JUL>" & FORECASTDETAILS.Value(i).MONTHJUL.Value.ToString() & "</JUL>"
            locsourceString &= "<AUG>" & FORECASTDETAILS.Value(i).MONTHAUG.Value.ToString() & "</AUG>"
            locsourceString &= "<SEP>" & FORECASTDETAILS.Value(i).MONTHSEP.Value.ToString() & "</SEP>"
            locsourceString &= "<OCT>" & FORECASTDETAILS.Value(i).MONTHOCT.Value.ToString() & "</OCT>"
            locsourceString &= "<NOV>" & FORECASTDETAILS.Value(i).MONTHNOV.Value.ToString() & "</NOV>"
            locsourceString &= "<DEC>" & FORECASTDETAILS.Value(i).MONTHDEC.Value.ToString() & "</DEC>"
            locsourceString &= "</ITEM>"
        Next
        locsourceString &= "</FORECASTDETAIL>"
        FORECASTSTRING.Value = locsourceString
    End Sub

    Private Sub RevenueByAppealCategoryCodeForcastAddDataFormUIModel_Validating(sender As Object, e As ValidatingEventArgs) Handles Me.Validating
        Call PrepareForecastSummary()
    End Sub


    Private Sub UpdateForcastValues()
        FORECASTSTRING.Value = "Yigermal"


        For i = 0 To FORECASTDETAILS.Value.Count - 1
            FORECASTDETAILS.Value(i).YEARTOTAL.Value = FORECASTDETAILS.Value(i).MONTHJAN.Value + FORECASTDETAILS.Value(i).MONTHFEB.Value + FORECASTDETAILS.Value(i).MONTHMAR.Value + FORECASTDETAILS.Value(i).MONTHAPR.Value + FORECASTDETAILS.Value(i).MONTHMAY.Value + FORECASTDETAILS.Value(i).MONTHJUN.Value + FORECASTDETAILS.Value(i).MONTHJUL.Value + FORECASTDETAILS.Value(i).MONTHAUG.Value + FORECASTDETAILS.Value(i).MONTHSEP.Value + FORECASTDETAILS.Value(i).MONTHOCT.Value + FORECASTDETAILS.Value(i).MONTHNOV.Value + FORECASTDETAILS.Value(i).MONTHDEC.Value
        Next
        Dim JanForecast As Decimal = 0
        Dim FebForecast As Decimal = 0
        Dim MarForecast As Decimal = 0
        Dim AprForecast As Decimal = 0
        Dim MayForecast As Decimal = 0
        Dim JunForecast As Decimal = 0
        Dim JulForecast As Decimal = 0
        Dim AugForecast As Decimal = 0
        Dim SepForecast As Decimal = 0
        Dim OctForecast As Decimal = 0
        Dim NovForecast As Decimal = 0
        Dim DecForecast As Decimal = 0

        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHJAN.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHFEB.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHMAR.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHAPR.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHMAY.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHJUN.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHJUL.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHAUG.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHSEP.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHOCT.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHNOV.Value = 0
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHDEC.Value = 0

        For Each itm In FORECASTDETAILS.Value
            JanForecast += itm.MONTHJAN.Value
            FebForecast += itm.MONTHFEB.Value
            MarForecast += itm.MONTHMAR.Value
            AprForecast += itm.MONTHAPR.Value
            MayForecast += itm.MONTHMAY.Value
            JunForecast += itm.MONTHJUN.Value
            JulForecast += itm.MONTHJUL.Value
            AugForecast += itm.MONTHAUG.Value
            SepForecast += itm.MONTHSEP.Value
            OctForecast += itm.MONTHOCT.Value
            NovForecast += itm.MONTHNOV.Value
            DecForecast += itm.MONTHDEC.Value
        Next
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHJAN.Value = JanForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHFEB.Value = FebForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHMAR.Value = MarForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHAPR.Value = AprForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHMAY.Value = MayForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHJUN.Value = JunForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHJUL.Value = JulForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHAUG.Value = AugForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHSEP.Value = SepForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHOCT.Value = OctForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHNOV.Value = NovForecast
        FORECASTDETAILS.Value(FORECASTDETAILS.Value.Count - 1).MONTHDEC.Value = DecForecast
    End Sub

    Private Sub _forecastdetails_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles _forecastdetails.SelectionChanged
        UpdateForcastValues()
    End Sub
End Class