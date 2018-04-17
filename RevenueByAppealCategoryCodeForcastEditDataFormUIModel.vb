Imports Blackbaud.AppFx.Server
Imports Blackbaud.AppFx.UIModeling.Core

Public Class RevenueByAppealCategoryCodeForcastEditDataFormUIModel

    Private Sub RevenueByAppealCategoryCodeForcastEditDataFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded
        Call LoadAppealCategoryCode()
        Me.FORECASTDETAILS.AllowColumnMove = False
        Me.FORECASTDETAILS.AllowDelete = False
        Me.FORECASTDETAILS.AllowAdd = False
        Me.FORECASTSTRING.Value = "Empty"
        Call UpdateForcastValues()
    End Sub

    Private Sub LoadAppealCategoryCode()

        Dim _totalrow As New RevenueByAppealCategoryCodeForcastEditDataFormFORECASTDETAILSUIModel
        _totalrow.APPEALCATEGORYCODEDISPLAY.Value = "Total"
        _totalrow.APPEALCATEGORYCODEDISPLAY.Enabled = False
        For Each dd In _totalrow.Fields
            dd.Enabled = False
        Next
        Me.FORECASTDETAILS.Value.Add(_totalrow)

        ' Disable last column 
        For i = 0 To FORECASTDETAILS.Value.Count - 1
            FORECASTDETAILS.Value(i).YEARTOTAL.Enabled = False
            FORECASTDETAILS.Value(i).APPEALCATEGORYCODEDISPLAY.Enabled = False
        Next
    End Sub



    Private Sub UpdateForcastValues()



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
        Dim TotForecast As Decimal = 0

        Dim LastRowIndex As Integer = (FORECASTDETAILS.Value.Count - 1)

        For i = 0 To FORECASTDETAILS.Value.Count - 1
            FORECASTDETAILS.Value(LastRowIndex).MONTHJAN.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHFEB.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHMAR.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHAPR.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHMAY.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHJUN.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHJUL.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHAUG.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHSEP.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHOCT.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHNOV.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).MONTHDEC.Value = 0
            FORECASTDETAILS.Value(LastRowIndex).YEARTOTAL.Value = 0
        Next

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
            TotForecast += itm.YEARTOTAL.Value
        Next

        For i = 0 To FORECASTDETAILS.Value.Count - 1
            FORECASTDETAILS.Value(LastRowIndex).MONTHJAN.Value = JanForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHFEB.Value = FebForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHMAR.Value = MarForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHAPR.Value = AprForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHMAY.Value = MayForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHJUN.Value = JunForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHJUL.Value = JulForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHAUG.Value = AugForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHSEP.Value = SepForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHOCT.Value = OctForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHNOV.Value = NovForecast
            FORECASTDETAILS.Value(LastRowIndex).MONTHDEC.Value = DecForecast
            FORECASTDETAILS.Value(LastRowIndex).YEARTOTAL.Value = TotForecast
        Next

    End Sub

    Private Sub _forecastdetails_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles _forecastdetails.SelectionChanged
        UpdateForcastValues()
    End Sub
End Class