Imports System.Reflection
Module OneStreamRule_VB_GetMemberList

	Public Function GetMemberList(ByVal si As SessionInfo, ByVal api As FinanceRulesApi, ByVal DimPK As DimPK, ByVal dimensionToken As String, ByVal topMember As String, ByVal memExpansion As String) As List(Of String)

		Dim objMemberInfoList As List(Of MemberInfo) = api.Members.GetMembersUsingFilter(DimPK, $"{dimensionToken}{topMember}.{memExpansion}", Nothing)
		Dim memberNames As New List(Of String)()

		For Each objMemberInfo As MemberInfo In objMemberInfoList
			Dim memName As String = objMemberInfo.Member.Name
			memberNames.Add(memName)
		Next

		Return memberNames

	End Function

End Module