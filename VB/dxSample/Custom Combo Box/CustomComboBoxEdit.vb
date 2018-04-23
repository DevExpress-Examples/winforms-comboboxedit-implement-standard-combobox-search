Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Globalization
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace dxSample
	<ToolboxItem(True)>
	Public Class CustomComboBoxEdit
		Inherits ComboBoxEdit

		Shared Sub New()
			CustomRIComboBox.Register()
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomRIComboBox.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public Shadows ReadOnly Property Properties() As CustomRIComboBox
			Get
				Return TryCast(MyBase.Properties, CustomRIComboBox)
			End Get
		End Property
		Public Sub New()
		End Sub
		Protected Overrides Function FindItem(ByVal text As String, ByVal autoComplete As Boolean, ByVal startIndex As Integer) As Integer
			Dim resText As String = text
			If Not Properties.CaseSensitiveSearch Then
				resText = resText.ToLower()
			End If
			Dim filterStr As Integer = FindStringEx(resText, startIndex)
			Return filterStr
		End Function
		Public Overrides Property AutoSearchText() As String
			Get
				Dim s As String = MyBase.AutoSearchText
				If String.IsNullOrWhiteSpace(s) OrElse String.IsNullOrEmpty(s) Then
					Return s
				End If
				Return s.Substring(s.Length - 1, 1)
			End Get
			Set(ByVal value As String)
				MyBase.AutoSearchText = value
			End Set
		End Property
		Public ReadOnly Property ItemCount() As Integer
			Get
				Return Properties.Items.Count
			End Get
		End Property
		Private Function FindStringEx(ByVal s As String, ByVal startIndex As Integer) As Integer
			If s Is Nothing Then
				Return -1
			End If
			Dim itemsCollection As ComboBoxItemCollection = Properties.Items
			If (itemsCollection Is Nothing) OrElse (itemsCollection.Count = 0) Then
				Return -1
			End If
			If (startIndex < -1) OrElse (startIndex >= itemsCollection.Count) Then
				Throw New ArgumentOutOfRangeException("startIndex")
			End If
			Return FindStringInternal(s, Properties.Items, startIndex, False)
		End Function
		Friend Function FindStringInternal(ByVal str As String, ByVal items As IList, ByVal startIndex As Integer, ByVal exact As Boolean) As Integer
			Return FindStringInternal(str, items, startIndex, exact, True)
		End Function
		Private _LastFindIndex As Integer = -1
		Public Property LastFindIndex() As Integer
			Get
				Return _LastFindIndex
			End Get
			Set(ByVal value As Integer)
				_LastFindIndex = value
			End Set
		End Property
		Friend Function FindStringInternal(ByVal str As String, ByVal items As IList, ByVal startIndex As Integer, ByVal exact As Boolean, ByVal ignorecase As Boolean) As Integer
			startIndex = GetStartIndex()
			If (str IsNot Nothing) AndAlso (items IsNot Nothing) Then
				If (startIndex < -1) OrElse (startIndex >= items.Count) Then
					Return -1
				End If
				Dim flag As Boolean = False
				Dim length As Integer = str.Length
				Dim num2 As Integer = 0
				Dim i As Integer = (startIndex + 1) Mod items.Count
				Do While num2 < items.Count
					num2 += 1
					Dim item As String = items(i).ToString()
					flag = String.Compare(str, 0, item, 0, length, ignorecase, CultureInfo.CurrentCulture) = 0
					If flag Then
						Return i
					End If
					i = (i + 1) Mod items.Count
				Loop
			End If
			Return -1
		End Function
		Private Function GetStartIndex() As Integer
			If IsPopupOpen Then
				Return PopupForm.SelectedItemIndex
			End If
			Return SelectedIndex
		End Function
	End Class
End Namespace
