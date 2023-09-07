Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList
Imports System.Collections
Imports DevExpress.XtraTreeList.Columns

Namespace Q1824862_1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Function GetDragNode(ByVal data As IDataObject) As TreeListNode
            Return CType(data.GetData(GetType(TreeListNode)), TreeListNode)
        End Function

        Private Overloads Sub OnDragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            Dim list As TreeList = CType(sender, TreeList)
            Dim node As TreeListNode = GetDragNode(e.Data)
            If node IsNot Nothing AndAlso node.TreeList IsNot list Then e.Effect = DragDropEffects.Copy
        End Sub

        Private Overloads Sub OnDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            Dim node As TreeListNode = GetDragNode(e.Data)
            If node Is Nothing Then Return
            Dim list As TreeList = CType(sender, TreeList)
            If list Is node.TreeList Then Return
            Dim info As TreeListHitInfo = list.CalcHitInfo(list.PointToClient(New Point(e.X, e.Y)))
            InsertBrunch(list, node, If(info.Node Is Nothing, -1, info.Node.Id))
        End Sub

        Private Sub InsertBrunch(ByVal list As TreeList, ByVal node As TreeListNode, ByVal parent As Integer)
            Dim data As ArrayList = New ArrayList()
            For Each column As TreeListColumn In node.TreeList.Columns
                data.Add(node(column))
            Next

            parent = list.AppendNode(data.ToArray(), parent).Id
            If node.HasChildren Then
                For Each n As TreeListNode In node.Nodes
                    InsertBrunch(list, n, parent)
                Next
            End If
        End Sub
    End Class
End Namespace
