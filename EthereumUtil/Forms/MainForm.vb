Imports Nethereum.Hex.HexTypes
Imports Nethereum.Web3
Imports Nethereum.Util
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports System.Numerics
Imports Nethereum.Contracts


Public Class MainForm
    Private Sub btnExec_Click(sender As Object, e As EventArgs) Handles btnStructUint.Click, btnTwoStructUint.Click, btnUintStruct.Click
        Dim testCase As Integer

        Select Case sender.name
            Case "btnStructUint"
                testCase = 1
            Case "btnUintStruct"
                testCase = 2
            Case "btnTwoStructUint"
                testCase = 3
        End Select

        Call testContract(testCase)
    End Sub

End Class