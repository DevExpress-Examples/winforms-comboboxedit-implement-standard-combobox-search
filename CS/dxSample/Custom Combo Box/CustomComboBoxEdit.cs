using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace dxSample {
    [ToolboxItem(true)]
    public class CustomComboBoxEdit : ComboBoxEdit {
        static CustomComboBoxEdit() {
            CustomRIComboBox.Register();
        }
        public override string EditorTypeName {
            get {
                return CustomRIComboBox.EditorName;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new CustomRIComboBox Properties {
            get {
                return base.Properties as CustomRIComboBox;
            }
        }
        public CustomComboBoxEdit() {
        }
        protected override int FindItem(string text, bool autoComplete, int startIndex) {
            string resText = text;
            if (!Properties.CaseSensitiveSearch) {
                resText = resText.ToLower();
            }
            int filterStr = FindStringEx(resText, startIndex);
            return filterStr;
        }
        public override string AutoSearchText {
            get {
                string s = base.AutoSearchText;
                if (String.IsNullOrWhiteSpace(s) || string.IsNullOrEmpty(s)) {
                    return s;
                }
                return s.Substring(s.Length - 1, 1);
            }
            set {
                base.AutoSearchText = value;
            }
        }
        public int ItemCount {
            get {
                return Properties.Items.Count;
            }
        }
        private int FindStringEx(string s, int startIndex) {
            if (s == null) {
                return -1;
            }
            ComboBoxItemCollection itemsCollection = Properties.Items;
            if ((itemsCollection == null) || (itemsCollection.Count == 0)) {
                return -1;
            }
            if ((startIndex < -1) || (startIndex >= itemsCollection.Count)) {
                throw new ArgumentOutOfRangeException("startIndex");
            }
            return FindStringInternal(s, Properties.Items, startIndex, false);
        }
        internal int FindStringInternal(string str, IList items, int startIndex, bool exact) {
            return FindStringInternal(str, items, startIndex, exact, true);
        }
        private int _LastFindIndex = -1;
        public int LastFindIndex {
            get {
                return _LastFindIndex;
            }
            set {
                _LastFindIndex = value;
            }
        }
        internal int FindStringInternal(string str, IList items, int startIndex, bool exact, bool ignorecase) {
            startIndex = GetStartIndex();
            if ((str != null) && (items != null)) {
                if ((startIndex < -1) || (startIndex >= items.Count)) {
                    return -1;
                }
                bool flag = false;
                int length = str.Length;
                int num2 = 0;
                for (int i = (startIndex + 1) % items.Count; num2 < items.Count; i = (i + 1) % items.Count) {
                    num2++;
                    string item = items[i].ToString();
                    flag = string.Compare(str, 0, item, 0, length, ignorecase, CultureInfo.CurrentCulture) == 0;
                    if (flag) {
                        return i;
                    }
                }
            }
            return -1;
        }
        private int GetStartIndex() {
            if (IsPopupOpen) {
                return  PopupForm.SelectedItemIndex;
            }
            return SelectedIndex;
        }
    }
}
