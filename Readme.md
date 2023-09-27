<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637723/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E415)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms TreeList - Move nodes between TreeList controls using drag-and-drop

Enable the [TreeList.OptionsDragAndDrop.AcceptOuterNodes](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsDragAndDrop.AcceptOuterNodes) option to allow the TreeList control to accept nodes being dragged from another TreeList control.

```csharp
public Form1() {
    InitializeComponent();
    treeList1.OptionsDragAndDrop.AcceptOuterNodes = true;
    treeList2.OptionsDragAndDrop.AcceptOuterNodes = true;

}
```


## Files to Review

* [Form1.cs](./CS/Q1824862_1/Form1.cs) (VB: [Form1.vb](./VB/Q1824862_1/Form1.vb))


## Documentation

* [Drag-and-Drop Tree List Nodes](https://docs.devexpress.com/WindowsForms/401949/controls-and-libraries/tree-list/feature-center/drag-and-drop)
* [How to: Drag XtraGrid rows to the XtraTreeList](https://docs.devexpress.com/WindowsForms/3021/controls-and-libraries/tree-list/feature-center/drag-and-drop/how-to-drag-xtragrid-rows-to-the-xtratreelist)


## See Also

* [DevExpress WinForms Cheat Sheet - Drag-and-Drop Within/Between Controls](https://go.devexpress.com/CheatSheets_WinForms_Examples_T949086.aspx)
