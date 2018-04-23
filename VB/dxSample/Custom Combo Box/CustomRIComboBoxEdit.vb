Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace dxSample
	Public Class CustomRIComboBox
		Inherits RepositoryItemComboBox

		Public Const EditorName As String = "CustomComboBoxEdit"
		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(CustomComboBoxEdit), GetType(CustomRIComboBox), GetType(DevExpress.XtraEditors.ViewInfo.ComboBoxViewInfo), New DevExpress.XtraEditors.Drawing.ButtonEditPainter(), True, EditImageIndexes.ComboBoxEdit))
		End Sub
		Public Sub New()
		End Sub
		Shared Sub New()
			Register()
		End Sub
        Public Overrides Property TextEditStyle As DevExpress.XtraEditors.Controls.TextEditStyles
            Get
                Return DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            End Get
            Set(value As DevExpress.XtraEditors.Controls.TextEditStyles)
                MyBase.TextEditStyle = value
            End Set
        End Property
	End Class
End Namespace
