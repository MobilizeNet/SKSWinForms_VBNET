Option Strict Off
Option Explicit On
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.DB.ADO
Imports UpgradeHelpers.Gui
Partial Friend Class frmSearch
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try
					'For the start-up form, the first instance created is the default instance.
					If Not (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint Is Nothing) AndAlso System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.GetType() Then
						m_vb6FormDefInstance = Me
					End If

				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		ReLoadForm(False)
	End Sub


	Private Sub frmSearch_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Dim SearchTable As String = ""
	Private Sub cboSrchBy_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cboSrchBy.SelectedIndexChanged
		lblSrchBy.Text = cboSrchBy.Text
	End Sub

	Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub


	Public Sub Search(ByVal Table As String, ByVal fieldToSearch As String, ByVal itemToSearch As String)
		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(itemToSearch) Then
			Label20.Text = "Search for a " & itemToSearch
		End If
		SearchTable = Table
		ExecuteSql("Select * from " & Table & " limit 1;")
		For i = 0 To (rs.FieldsMetadata.Count - 1)
			cboSrchBy.AddItem(rs.GetField(i).FieldMetadata.ColumnName)
		Next i
		cboSrchBy.Text = fieldToSearch
	End Sub

	Private Sub cmdSearch_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSearch.Click
		If txtSrchStr.Text.Substring(Math.Max(txtSrchStr.Text.Length - 1, 0)) = "'" Then
			txtSrchStr.Text = ""
		End If
		Dim txtToSearch As String = ""

		'UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
		If Not String.IsNullOrEmpty(txtSrchStr.Text.Trim()) Then
			txtToSearch = txtSrchStr.Text
		Else
			txtToSearch = "%"
		End If
		If SearchTable = "Customers" Then
			SearchCriteriaCustomers(lblSrchBy.Text, txtToSearch)
		ElseIf SearchTable = "Products" Then 
			SearchCriteriaProducts(lblSrchBy.Text, txtToSearch)
		ElseIf SearchTable = "Providers" Then 
			SearchCriteriaProviders(lblSrchBy.Text, txtToSearch)
		End If
	End Sub

	'''
	Public Sub SearchCriteriaCustomers(ByVal field As String, ByVal value As String)
		ExecuteSql("Select * from Customers where " & field & " LIKE '" & value & "%'")
		If rs.RecordCount = 0 Then
			MessageBox.Show("There are no records with the selected criteria", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			LogStatus("There are " & rs.RecordCount & " that meet with the selected criteria")
			frmCustomers.DefInstance.dcCustomers.Recordset = rs
		End If
	End Sub

	Public Sub SearchCriteriaProducts(ByVal field As String, ByVal value As String)
		ExecuteSql("Select * from Products where " & field & " LIKE '" & value & "%'")
		If rs.RecordCount = 0 Then
			MessageBox.Show("There are no records with the selected criteria", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			frmProducts.DefInstance.dcProducts.Recordset = rs
		End If
	End Sub

	Public Sub SearchCriteriaProviders(ByVal field As String, ByVal value As String)
		ExecuteSql("Select * from Providers where " & field & " LIKE '" & value & "%'")
		If rs.RecordCount = 0 Then
			MessageBox.Show("There are no records with the selected criteria", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			LogStatus("There are " & rs.RecordCount & " that meet with the selected criteria")
			frmProviders.DefInstance.dcProviders.Recordset = rs
		End If
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class