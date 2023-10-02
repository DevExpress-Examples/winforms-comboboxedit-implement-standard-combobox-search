<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128618283/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T191192)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

#  WinForms ComboBoxEdit - Turn off incremental search and implement a standard ComboBox search

The [WinForms ComboBoxEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.ComboBoxEdit) uses incremental search to find items. This behavior is different from that of a [standard combobox](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.combobox?view=windowsdesktop-7.0&redirectedfrom=MSDN). This example demonstrates how to customize the DevExpress `ComboBoxEdit` control to behave like a standard combobox.

The example creates a custom ComboBoxEdit and overrides the `FindItem` method and `AutoSearchText` property. Note that the [RepositoryItemButtonEdit.TextEditStyle](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit.TextEditStyle) property should be set to `TextEditStyles.DisableTextEditor`.


## Files to Review

* [CustomComboBoxEdit.cs](./CS/dxSample/Custom%20Combo%20Box/CustomComboBoxEdit.cs) (VB: [CustomComboBoxEdit.vb](./VB/dxSample/Custom%20Combo%20Box/CustomComboBoxEdit.vb))
* [CustomRIComboBoxEdit.cs](./CS/dxSample/Custom%20Combo%20Box/CustomRIComboBoxEdit.cs) (VB: [CustomRIComboBoxEdit.vb](./VB/dxSample/Custom%20Combo%20Box/CustomRIComboBoxEdit.vb))
* [Form1.cs](./CS/dxSample/Form1.cs)
* [MainForm.cs](./CS/dxSample/MainForm.cs) (VB: [MainForm.vb](./VB/dxSample/MainForm.vb))


## Documentation

* [Custom Editors](https://docs.devexpress.com/WindowsForms/4716/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/custom-editors)
