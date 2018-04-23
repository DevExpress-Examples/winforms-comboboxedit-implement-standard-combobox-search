namespace dxSample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customComboBoxEdit1 = new dxSample.CustomComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.customComboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "aaaaa",
            "bbbbb",
            "ccccc",
            "ddddd1",
            "ddddd2",
            "ddddd3",
            "eeeeee"});
            this.comboBox1.Location = new System.Drawing.Point(114, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // customComboBoxEdit1
            // 
            this.customComboBoxEdit1.LastFindIndex = -1;
            this.customComboBoxEdit1.Location = new System.Drawing.Point(126, 85);
            this.customComboBoxEdit1.Name = "customComboBoxEdit1";
            this.customComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customComboBoxEdit1.Properties.Items.AddRange(new object[] {
            "aaaaa",
            "bbbbb",
            "ccccc",
            "ddddd1",
            "ddddd2",
            "ddddd3",
            "eeeeee"});
            this.customComboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.customComboBoxEdit1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 167);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.customComboBoxEdit1);
            this.Name = "MainForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.customComboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComboBoxEdit customComboBoxEdit1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}