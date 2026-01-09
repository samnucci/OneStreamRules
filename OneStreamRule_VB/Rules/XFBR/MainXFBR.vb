Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Common
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports Microsoft.VisualBasic
Imports OneStream.Finance.Database
Imports OneStream.Finance.Engine
Imports OneStream.Shared.Common
Imports OneStream.Shared.Database
Imports OneStream.Shared.Engine
Imports OneStream.Shared.Wcf
Imports OneStream.Stage.Database
Imports OneStream.Stage.Engine

Namespace OneStream.BusinessRule.DashboardStringFunction.SiQ_ConsolHelper
	Public Class MainClass
		Public Function Main(ByVal si As SessionInfo, ByVal globals As BRGlobals, ByVal api As Object, ByVal args As DashboardStringFunctionArgs) As Object
			Try
#Region "Time Based Functions"
                If args.FunctionName.XFEqualsIgnoreCase("ReturnWCMonths") Then
                    Return ReturnWCMonths(si, globals, api, args)
                ElseIf args.FunctionName.XFEqualsIgnoreCase("ReturnWCMonths") Then
#End Region

				End If


			Catch ex As Exception

			End Try
		End Function

        Private Function ReturnWCMonths(ByVal si As SessionInfo, ByVal globals As BRGlobals, ByVal api As Object, ByVal args As DashboardStringFunctionArgs) As Object
            Try
                Dim strMonths As String = String.Empty
                Return strMonths
            Catch ex As Exception
                Throw
            End Try
        End Function
    End Class
End Namespace