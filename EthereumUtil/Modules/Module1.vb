Imports Nethereum.Hex.HexTypes
Imports Nethereum.Web3
Imports Nethereum.Util
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports System.Numerics
Imports Nethereum.Contracts

Module Module1
    Public Async Function testContract(ByVal testCase As Integer) As Task

        ' from account - account we are transferring from
        Dim privateKey As New Nethereum.Signer.EthECKey("0000000000000000000000000000000000000000000000000000000000000001")
        Dim account = New Nethereum.Web3.Accounts.Account(privateKey)

        Dim iweb3 = New Web3(account, "https://ropsten.infura.io")
        Dim value As New HexBigInteger(0)

        ' deploy
        Dim gasPrice As New HexBigInteger(10000000000)
        Dim gas As New HexBigInteger(0)

        Dim contractAddress As String
        Select Case testCase
            Case 1
                ' code: https://gist.github.com/Enigmatic331/74cc6fe53817590d9348bd94e91b948b
                contractAddress = "0xc6cf0f044ba8ea402bfedf9e87b88bf1c008d162" ' struct array first, uint second
                Dim contract = iweb3.Eth.GetContractHandler(contractAddress)
                gas = Await contract.EstimateGasAsync(Of GetNestedStructFirstUintSecond)
                Dim getResult = Await contract.QueryDeserializingToObjectAsync(Of GetNestedStructFirstUintSecond, NestedStructFirstUintSecond)
                Console.WriteLine("Done GetNestedStructFirstUintSecond Example.")
            Case 2
                ' code: https://gist.github.com/Enigmatic331/9c44691b8391f151ea9a7dc648fde4cd
                contractAddress = "0x8242ad7e961000388324eb87271205a03f40096e" ' uint first, struct array second
                Dim contract = iweb3.Eth.GetContractHandler(contractAddress)
                gas = Await contract.EstimateGasAsync(Of GetUintFirstNestedStructSecond)
                Dim getResult = Await contract.QueryDeserializingToObjectAsync(Of GetUintFirstNestedStructSecond, UintFirstNestedStructSecond)
                Console.WriteLine("Done GetUintFirstNestedStructSecond Example.")
            Case 3
                ' code: https://gist.github.com/Enigmatic331/052357d06e684dc64f03dd2dea5a40cf
                contractAddress = "0x85cc65ce9a14c6c23abacf7a75e274e05e54347c" ' struct with two struct arrays and a uint256
                Dim contract = iweb3.Eth.GetContractHandler(contractAddress)
                gas = Await contract.EstimateGasAsync(Of GetTwoNestedStructAndUintLast)
                Dim getResult = Await contract.QueryDeserializingToObjectAsync(Of GetTwoNestedStructAndUintLast, TwoNestedStructAndUintLast)
                Console.WriteLine("Done GetTwoNestedStructAndUintLast Example.")
        End Select



    End Function


    <[Function]("returnStruct", GetType(UintFirstNestedStructSecond))>
    Public Class GetUintFirstNestedStructSecond
        Inherits FunctionMessage
    End Class

    <[Function]("returnStruct", GetType(NestedStructFirstUintSecond))>
    Public Class GetNestedStructFirstUintSecond
        Inherits FunctionMessage
    End Class

    <[Function]("returnStruct", GetType(TwoNestedStructAndUintLast))>
    Public Class GetTwoNestedStructAndUintLast
        Inherits FunctionMessage
    End Class


    <[FunctionOutput]>
    Public Class UintFirstNestedStructSecond
        Implements IFunctionOutputDTO

        <[Parameter]("uint256", "aRandomNumber", 1)>
        Public Overridable Property aRandomNumber As BigInteger
        <[Parameter]("tuple[]", "arrIntRP", 2)>
        Public Overridable Property arrIntRP As List(Of internalRiskParams)
    End Class

    <[FunctionOutput]>
    Public Class TwoNestedStructAndUintLast
        Implements IFunctionOutputDTO

        <[Parameter]("tuple[]", "arrIntRP", 1)>
        Public Overridable Property arrIntRP As List(Of internalRiskParams)
        <[Parameter]("tuple[]", "internalRiskParamsTwo", 2)>
        Public Overridable Property internalRiskParamsTwo As List(Of internalRiskParamsTwo)
        <[Parameter]("uint256", "aRandomNumber", 3)>
        Public Overridable Property aRandomNumber As BigInteger
    End Class


    <[FunctionOutput]>
    Public Class NestedStructFirstUintSecond
        Implements IFunctionOutputDTO

        <[Parameter]("tuple[]", "arrIntRP", 1)>
        Public Overridable Property arrIntRP As List(Of internalRiskParams)
        <[Parameter]("uint256", "aRandomNumber", 2)>
        Public Overridable Property aRandomNumber As BigInteger
    End Class

    Public Class internalRiskParamsTwo
        <[Parameter]("uint256", "NumberOne", 1)>
        Public Overridable Property NumberOne As BigInteger
        <[Parameter]("string", "NumberTwo", 2)>
        Public Overridable Property NumberTwo As String
    End Class

    Public Class internalRiskParams
        <[Parameter]("tuple", "marginRatio", 1)>
        Public Overridable Property [MarginRatio] As MarginRatio
        <[Parameter]("tuple", "liquidationSpread", 2)>
        Public Overridable Property [LiquidationSpread] As LiquidationSpread
        <[Parameter]("tuple", "earningsRate", 3)>
        Public Overridable Property [EarningsRate] As EarningsRate
        <[Parameter]("tuple", "minBorrowedValue", 4)>
        Public Overridable Property [MinBorrowedValue] As MinBorrowedValue
    End Class

    Public Class MarginRatio
        <[Parameter]("uint256", "value", 1)>
        Public Overridable Property [Value] As BigInteger
    End Class

    Public Class LiquidationSpread
        <[Parameter]("uint256", "value", 1)>
        Public Overridable Property [Value] As BigInteger
    End Class

    Public Class EarningsRate
        <[Parameter]("uint256", "value", 1)>
        Public Overridable Property [Value] As BigInteger
    End Class

    Public Class MinBorrowedValue
        <[Parameter]("uint256", "value", 1)>
        Public Overridable Property [Value] As BigInteger
    End Class
End Module
