Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Specialized
Imports System.Text
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Module modFunctions

	Public Sub AppendAND(ByRef filter As String)
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(filter) Then
			filter = filter & " AND "
		End If
	End Sub

	Public Function AddToCollection(ByVal col As OrderedDictionary, ByVal Item As String) As Boolean
		Dim result As Boolean = False
		If Not Exists(col, Item) Then
			col.Add(Item, Item)
			result = True
		End If
		Return result
	End Function

	Public Function Exists(ByVal col As OrderedDictionary, ByVal Index As String) As Boolean
		Dim o As Object
		Try
			'UPGRADE_WARNING: (1068) col() of type Variant is being forced to Scalar. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1068
			o = col(Index)

		Catch
		End Try

		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		Return Not Object.Equals(o, Nothing)
	End Function


	Public Function DoubleValue(ByVal strValue As String) As Double
		If Strings.Len(strValue) <> 0 Then
			Return CDbl(strValue)
		Else
			Return 0
		End If
	End Function

	Public Function ValidateTextBoxDouble(ByVal txBox As TextBox, ByVal parentForm As Form) As Boolean
		Dim result As Boolean = False
		Try
			DoubleValue(txBox.Text)
			Return True

		Catch
			modMain.LogStatus("The value inserted is not valid", parentForm)
			txBox.Text = ""
			txBox.Focus()
			result = False
		End Try
		Return result
	End Function

	Public Function ValidateTextDouble(ByVal text As String, ByVal parentForm As Form) As Boolean
		Dim result As Boolean = False
		Try
			DoubleValue(text)
			Return True

		Catch
			modMain.LogStatus("The value inserted is not valid", parentForm)
			result = False
		End Try
		Return result
	End Function

	Public Sub SelectAll(ByVal txtBox As TextBox)
		txtBox.SelectionStart = 0
		txtBox.SelectionLength = Strings.Len(txtBox.Text)
	End Sub

	Public Function UpCase(ByVal KeyAscii As Integer) As Integer
		Return Strings.Asc(Strings.Chr(KeyAscii).ToString().ToUpper()(0))
	End Function


	''''''''''''''''''''''''''''''''''
	''' Combobox related functions '''
	''''''''''''''''''''''''''''''''''

	Public Sub LoadCombo(ByVal Table As String, ByVal combo As ComboBox, ByVal field As String, Optional ByVal valueField As String = "")
		ExecuteSql("Select * From " & Table)
		combo.Items.Clear()
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(valueField) Then
			While Not rs.EOF
				combo.AddItem(rs(field))
				combo.SetItemData(combo.GetNewIndex(), rs(valueField))
				rs.MoveNext()
			End While
		Else
			While Not rs.EOF
				combo.AddItem(rs(field))
				rs.MoveNext()
			End While
		End If
		'If strDefault <> Empty Then
		' combo = strDefault
		'End If
	End Sub


	Public Function ComboEmpty(ByVal combo As ComboBox, Optional ByVal strip As Object = Nothing, Optional ByVal Index As Integer = 0) As Boolean
		Dim result As Boolean = False
		If combo.SelectedIndex = -1 Then
			result = True
			MessageBox.Show("Please select an option from the list", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not Index.Equals(0) Then
				'strip.SelectedItem = strip.Tabs(Index)
			End If
			combo.Focus()
		Else
			result = False
		End If
		Return result
	End Function

	Public Function NoRecords(ByVal lstView As ListView, Optional ByVal Prompt As String = "") As Boolean
		If lstView.Items.Count = 0 Or lstView.FocusedItem Is Nothing Then
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not String.IsNullOrEmpty(Prompt) Then
				MessageBox.Show(Prompt, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			End If
			Return True
		Else
			Return False
		End If
	End Function

	Public Function RcrdId(ByVal Table As String, Optional ByVal Identifier As String = "", Optional ByVal FldNo As String = "") As String
		Dim RcrdNo As Integer
		ExecuteSql("Select * from " & Table & " order by " & FldNo & " ASC")
		If Not rs.EOF Then
			rs.MoveLast()
			RcrdNo = rs(FldNo) + 1
		Else
			RcrdNo = 1
		End If
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(Identifier) Then
			Return Identifier & CStr(RcrdNo) & DateTime.Today.ToString("MM")
		Else
			Return CStr(RcrdNo)
		End If
	End Function



	'''''''''''''''''''''''''''''''''''''''''
	Public Sub SearchShow(ByVal Table As String, ByVal fieldToSearch As String, ByVal itemToSearch As String)
		With frmSearch.DefInstance
			.Search(Table, fieldToSearch, itemToSearch)
			.ShowDialog()
		End With
	End Sub

	Public Function ValBox(ByVal Prompt As String, ByVal Icon As PictureBox, Optional ByVal Title As String = "", Optional ByVal Default_Renamed As Double = 0, Optional ByVal Header As String = "Value Box") As Double
		'With frmValue
		'    If Title <> Empty Then
		'       .Caption = Title
		'    Else
		'        .Caption = App.Title
		'    End If
		'    .lblHeader.Caption = StrConv(Header, vbUpperCase)
		'    .imgIcon.Picture = Icon.Picture
		'    .lblPrompt.Caption = Prompt
		'    .Default Val(Default)
		'    .Show vbModal
		'    ValBox = Val(.txtValue.Text)
		'    Unload frmValue
		'End With
	End Function


	Public Function TextBoxEmpty(ByVal stext As TextBox, Optional ByVal TabObject As Object = Nothing, Optional ByVal TabIndex As Integer = 0) As Boolean
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		Dim result As Boolean = False
		If String.IsNullOrEmpty(stext.Text.Trim()) Or stext.Text = "  /  /    " Then
			result = True
			MessageBox.Show("You need to fill in all required fields", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
			If Not TabIndex.Equals(0) Then
				'TabObject.SelectedItem = TabObject.Tabs(TabIndex)
			End If
			stext.Focus()
		Else
			result = False
		End If
		Return result
	End Function

	Public Function TextBoxNumberEmpty(ByVal textbox As TextBox) As Boolean
		'if the input is not a numeric then true
		Dim result As Boolean = False
		If Not Information.IsNumeric(textbox.Text) Then
			result = True
			MessageBox.Show("The field requires a numeric value.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			textbox.Focus()
			SelectAll(textbox)
		Else
			result = False
		End If
		Return result
	End Function



	'UPGRADE_NOTE: (7001) The following declaration (SaveDetection) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
	'Private Sub SaveDetection(ByVal Reference As String, ByVal Title As String, ByVal Description As String, ByVal Table As String)
		'ExecuteSql2("Select * from " & Table)
		'rs2.AddNew()
		'rs2("record_no") = Conversion.Val(RcrdId(Table, "", "record_no"))
		'rs2("Reference") = Reference
		'rs2("war_type") = Title
		'rs2("Description") = Description
		'rs2.Update()
	'End Sub



	Public Function ExecErr(ByVal Prompt As String, Optional ByVal PromptFld As String = "", Optional ByVal Table As String = "", Optional ByVal RcrdFld As String = "", Optional ByVal RcrdStr As String = "") As String
		Dim Rcrds As New StringBuilder()
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(Table) Then
			ExecuteSql("Select * from " & Table & " where " & RcrdFld & " = '" & RcrdStr & "'")
			While Not rs.EOF
				Rcrds.Append(rs(PromptFld) & "; ")
				rs.MoveNext()
			End While
			Return "Error: " & Prompt & Environment.NewLine & Environment.NewLine &  _
			"Related Records: " & Rcrds.ToString()
		Else
			Return Prompt
		End If
	End Function
End Module