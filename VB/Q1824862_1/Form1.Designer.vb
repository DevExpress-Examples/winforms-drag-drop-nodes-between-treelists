Namespace Q1824862_1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.colDepartment1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBudget1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colLastOrder1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.treeList2 = New DevExpress.XtraTreeList.TreeList()
            Me.colDepartment2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBudget2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeList2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colDepartment1, Me.colBudget1, Me.colLastOrder1})
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Top
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.BeginUnboundLoad()
            Me.treeList1.AppendNode(New Object() {"Corporate Headquarters", 1000000, New System.DateTime(2001, 12, 15, 0, 0, 0)}, -1)
            Me.treeList1.AppendNode(New Object() {"Engineering", 1100000, New System.DateTime(2001, 8, 12, 0, 0, 0)}, 0)
            Me.treeList1.AppendNode(New Object() {"Consumer Electronics Div", 1150000, New System.DateTime(2003, 5, 10, 0, 0, 0)}, 1)
            Me.treeList1.AppendNode(New Object() {"Software Development", 40000, New System.DateTime(2001, 8, 5, 0, 0, 0)}, 2)
            Me.treeList1.AppendNode(New Object() {"Software Products Div", 1200000, New System.DateTime(2001, 11, 11, 0, 0, 0)}, 1)
            Me.treeList1.AppendNode(New Object() {"Customer Services", 850000, New System.DateTime(2005, 5, 5, 0, 0, 0)}, 4)
            Me.treeList1.EndUnboundLoad()
            Me.treeList1.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.[Single]
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.Size = New System.Drawing.Size(681, 285)
            Me.treeList1.TabIndex = 0
            ' 
            ' colDepartment1
            ' 
            Me.colDepartment1.Caption = "Department"
            Me.colDepartment1.FieldName = "Department"
            Me.colDepartment1.MinWidth = 74
            Me.colDepartment1.Name = "colDepartment1"
            Me.colDepartment1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[String]
            Me.colDepartment1.Visible = True
            Me.colDepartment1.VisibleIndex = 0
            Me.colDepartment1.Width = 251
            ' 
            ' colBudget1
            ' 
            Me.colBudget1.Caption = "Budget"
            Me.colBudget1.FieldName = "Budget"
            Me.colBudget1.Format.FormatString = "c0"
            Me.colBudget1.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBudget1.Name = "colBudget1"
            Me.colBudget1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[Decimal]
            Me.colBudget1.Visible = True
            Me.colBudget1.VisibleIndex = 1
            Me.colBudget1.Width = 81
            ' 
            ' colLastOrder1
            ' 
            Me.colLastOrder1.Caption = "LastOrder"
            Me.colLastOrder1.FieldName = "LastOrder"
            Me.colLastOrder1.Name = "colLastOrder1"
            Me.colLastOrder1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.DateTime
            Me.colLastOrder1.Visible = True
            Me.colLastOrder1.VisibleIndex = 2
            Me.colLastOrder1.Width = 80
            ' 
            ' treeList2
            ' 
            Me.treeList2.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colDepartment2, Me.colBudget2})
            Me.treeList2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList2.Location = New System.Drawing.Point(0, 285)
            Me.treeList2.Name = "treeList2"
            Me.treeList2.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.[Single]
            Me.treeList2.OptionsBehavior.Editable = False
            Me.treeList2.Size = New System.Drawing.Size(681, 291)
            Me.treeList2.TabIndex = 0
            ' 
            ' colDepartment2
            ' 
            Me.colDepartment2.Caption = "Department"
            Me.colDepartment2.FieldName = "Department"
            Me.colDepartment2.Name = "colDepartment2"
            Me.colDepartment2.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[String]
            Me.colDepartment2.Visible = True
            Me.colDepartment2.VisibleIndex = 1
            Me.colDepartment2.Width = 295
            ' 
            ' colBudget2
            ' 
            Me.colBudget2.Caption = "Budget"
            Me.colBudget2.FieldName = "Budget"
            Me.colBudget2.Format.FormatString = "c0"
            Me.colBudget2.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBudget2.Name = "colBudget2"
            Me.colBudget2.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.[Decimal]
            Me.colBudget2.Visible = True
            Me.colBudget2.VisibleIndex = 0
            Me.colBudget2.Width = 117
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(681, 576)
            Me.Controls.Add(Me.treeList2)
            Me.Controls.Add(Me.treeList1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeList2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private treeList2 As DevExpress.XtraTreeList.TreeList

        Private colDepartment1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colBudget1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colLastOrder1 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colDepartment2 As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colBudget2 As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace
