using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace dxSample {
    public class CustomRIComboBox : RepositoryItemComboBox {
        public const string EditorName = "CustomComboBoxEdit";
        public static void Register() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName,
                   typeof(CustomComboBoxEdit),
                      typeof(CustomRIComboBox),
                      typeof(DevExpress.XtraEditors.ViewInfo.ComboBoxViewInfo),
                      new DevExpress.XtraEditors.Drawing.ButtonEditPainter(),
                      true, EditImageIndexes.ComboBoxEdit));
        }
        public CustomRIComboBox() {
        }
        static CustomRIComboBox() {
            Register();
        }
        public override DevExpress.XtraEditors.Controls.TextEditStyles TextEditStyle {
            get {
                return DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            }
        }
    }
}
