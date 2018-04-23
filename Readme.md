#  ComboBoxEdit - How to turn off incremental search and implement a standard ComboBox search


By default, <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsComboBoxEdittopic">ComboBoxEdit </a>searches for an item by using the incremental search feature.<br />This searching mechanism is different from the one that is used by <a href="http://msdn.microsoft.com/en-us/library/system.windows.forms.combobox(v=vs.110).aspx">a standard Windows combo box control</a>. <br />The logic is similar to the one used by the standard ComboBox that is provided by <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsListBoxControltopic">ListBoxControl</a> out of the box.<br /><br />This example demonstrates how to implement this searching behavior for ComboBoxEdit. To do this, create a custom ComboBoxEdit (see <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument4716">Custom Editors</a> for more details on custom editor creation) and override methods that manage searching logic: the FindItem method and the AutoSearchText property. Note that the the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemButtonEdit_TextEditStyletopic.aspx">RepositoryItemButtonEdit.TextEditStyle</a> property should be set to <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraEditorsControlsTextEditStylesEnumtopic.aspx">TextEditStyles.DisableTextEditor</a>.

<br/>


