namespace Q1824862_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colDepartment1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBudget1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLastOrder1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.colDepartment2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBudget2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDepartment1,
            this.colBudget1,
            this.colLastOrder1});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "Corporate Headquarters",
            1000000,
            new System.DateTime(2001, 12, 15, 0, 0, 0)}, -1);
            this.treeList1.AppendNode(new object[] {
            "Engineering",
            1100000,
            new System.DateTime(2001, 8, 12, 0, 0, 0)}, 0);
            this.treeList1.AppendNode(new object[] {
            "Consumer Electronics Div",
            1150000,
            new System.DateTime(2003, 5, 10, 0, 0, 0)}, 1);
            this.treeList1.AppendNode(new object[] {
            "Software Development",
            40000,
            new System.DateTime(2001, 8, 5, 0, 0, 0)}, 2);
            this.treeList1.AppendNode(new object[] {
            "Software Products Div",
            1200000,
            new System.DateTime(2001, 11, 11, 0, 0, 0)}, 1);
            this.treeList1.AppendNode(new object[] {
            "Customer Services",
            850000,
            new System.DateTime(2005, 5, 5, 0, 0, 0)}, 4);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsBehavior.DragNodes = true;
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.Size = new System.Drawing.Size(681, 285);
            this.treeList1.TabIndex = 0;
            this.treeList1.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.treeList1.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // colDepartment1
            // 
            this.colDepartment1.Caption = "Department";
            this.colDepartment1.FieldName = "Department";
            this.colDepartment1.MinWidth = 74;
            this.colDepartment1.Name = "colDepartment1";
            this.colDepartment1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.colDepartment1.Visible = true;
            this.colDepartment1.VisibleIndex = 0;
            this.colDepartment1.Width = 251;
            // 
            // colBudget1
            // 
            this.colBudget1.Caption = "Budget";
            this.colBudget1.FieldName = "Budget";
            this.colBudget1.Format.FormatString = "c0";
            this.colBudget1.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBudget1.Name = "colBudget1";
            this.colBudget1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Decimal;
            this.colBudget1.Visible = true;
            this.colBudget1.VisibleIndex = 1;
            this.colBudget1.Width = 81;
            // 
            // colLastOrder1
            // 
            this.colLastOrder1.Caption = "LastOrder";
            this.colLastOrder1.FieldName = "LastOrder";
            this.colLastOrder1.Name = "colLastOrder1";
            this.colLastOrder1.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.DateTime;
            this.colLastOrder1.Visible = true;
            this.colLastOrder1.VisibleIndex = 2;
            this.colLastOrder1.Width = 80;
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDepartment2,
            this.colBudget2});
            this.treeList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList2.Location = new System.Drawing.Point(0, 285);
            this.treeList2.Name = "treeList2";
            this.treeList2.OptionsBehavior.DragNodes = true;
            this.treeList2.OptionsBehavior.Editable = false;
            this.treeList2.Size = new System.Drawing.Size(681, 291);
            this.treeList2.TabIndex = 0;
            this.treeList2.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDragDrop);
            this.treeList2.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            // 
            // colDepartment2
            // 
            this.colDepartment2.Caption = "Department";
            this.colDepartment2.FieldName = "Department";
            this.colDepartment2.Name = "colDepartment2";
            this.colDepartment2.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.colDepartment2.Visible = true;
            this.colDepartment2.VisibleIndex = 1;
            this.colDepartment2.Width = 295;
            // 
            // colBudget2
            // 
            this.colBudget2.Caption = "Budget";
            this.colBudget2.FieldName = "Budget";
            this.colBudget2.Format.FormatString = "c0";
            this.colBudget2.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBudget2.Name = "colBudget2";
            this.colBudget2.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Decimal;
            this.colBudget2.Visible = true;
            this.colBudget2.VisibleIndex = 0;
            this.colBudget2.Width = 117;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 576);
            this.Controls.Add(this.treeList2);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDepartment1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBudget1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLastOrder1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDepartment2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBudget2;
    }
}

