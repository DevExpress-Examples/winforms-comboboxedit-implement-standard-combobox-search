Namespace dxSample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.customComboBoxEdit1 = New dxSample.CustomComboBoxEdit()
			DirectCast(Me.customComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBox1
			' 
			Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "aaaaa", "bbbbb", "ccccc", "ddddd1", "ddddd2", "ddddd3", "eeeeee"})
			Me.comboBox1.Location = New System.Drawing.Point(114, 40)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(121, 21)
			Me.comboBox1.TabIndex = 3
			' 
			' customComboBoxEdit1
			' 
			Me.customComboBoxEdit1.LastFindIndex = -1
			Me.customComboBoxEdit1.Location = New System.Drawing.Point(126, 85)
			Me.customComboBoxEdit1.Name = "customComboBoxEdit1"
			Me.customComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.customComboBoxEdit1.Properties.Items.AddRange(New Object() { "aaaaa", "bbbbb", "ccccc", "ddddd1", "ddddd2", "ddddd3", "eeeeee"})
			Me.customComboBoxEdit1.Size = New System.Drawing.Size(100, 20)
			Me.customComboBoxEdit1.TabIndex = 2
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(367, 167)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.customComboBoxEdit1)
			Me.Name = "MainForm"
			Me.Text = "Form2"
			DirectCast(Me.customComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customComboBoxEdit1 As CustomComboBoxEdit
		Private comboBox1 As System.Windows.Forms.ComboBox
	End Class
End Namespace