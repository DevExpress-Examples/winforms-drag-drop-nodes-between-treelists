using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using System.Collections;
using DevExpress.XtraTreeList.Columns;

namespace Q1824862_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeList2.OptionsDragAndDrop.AcceptOuterNodes = true;
        }
    }
}