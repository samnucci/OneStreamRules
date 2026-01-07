Imports System.Data
Module fxRate
	Public Function GetConversionRate(ByVal si As SessionInfo, ByVal globals As BRGlobals, ByVal entityName As String, ByVal destCur As String, ByVal rateType As String) As Decimal
		Dim entCur As String = api.Entity.GetLocalCurrencyConsMember(Brapi.Finance.Members.GetMemberId(si, dimtype.Entity.Id, entityName)).Name

		If entCur = destCur Then
			Return 1D
		End If

		' Build FX key
		Dim fxKey As New FxRatePkUsingNames() With {
		.FxRateType = rateType,
		.Time = api.Pov.Time.Name,
		.SourceCurrency = entCur,
		.DestCurrency = destCur
	}

		' Retrieve FX rate
		Dim objFx As FxRateUsingNames = BRApi.Finance.Data.GetFxRate(si, fxKey)

		Return objFx.Amount
	End Function

End Module