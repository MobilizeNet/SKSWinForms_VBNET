Option Strict Off
Option Explicit On
Imports System
Imports System.Data.Common
Imports UpgradeHelpers.DB.ADO
Module modConnection

	Private _CurrentConnection As DbConnection = Nothing
	Public Property CurrentConnection() As DbConnection
		Get
			If _CurrentConnection Is Nothing Then
				_CurrentConnection = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection()
			End If
			Return _CurrentConnection
		End Get
		Set(ByVal Value As DbConnection)
			_CurrentConnection = Value
		End Set
	End Property
	Private _rs As ADORecordSetHelper = Nothing
	Public Property rs() As ADORecordSetHelper
		Get
			If _rs Is Nothing Then
				_rs = New ADORecordSetHelper("")
			End If
			Return _rs
		End Get
		Set(ByVal Value As ADORecordSetHelper)
			_rs = Value
		End Set
	End Property
	Private _rs2 As ADORecordSetHelper = Nothing
	Public Property rs2() As ADORecordSetHelper
		Get
			If _rs2 Is Nothing Then
				_rs2 = New ADORecordSetHelper("")
			End If
			Return _rs2
		End Get
		Set(ByVal Value As ADORecordSetHelper)
			_rs2 = Value
		End Set
	End Property

	Public Sub OpenConnection()
		CurrentConnection = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection()
		'UPGRADE_TODO: (7010) The connection string must be verified to fullfill the .NET data provider connection string requirements. More Information: https://www.mobilize.net/vbtonet/ewis/ewi7010
		CurrentConnection.ConnectionString = ConnectionString
		CurrentConnection.Open()
	End Sub

	Public Sub ExecuteSql(ByVal Statement As String)
		rs = New ADORecordSetHelper("")
		rs.Open(Statement, CurrentConnection, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic)
	End Sub

	Public Sub ExecuteSql2(ByVal Statement As String)
		rs2 = New ADORecordSetHelper("")
		rs2.Open(Statement, CurrentConnection, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic)
	End Sub
End Module